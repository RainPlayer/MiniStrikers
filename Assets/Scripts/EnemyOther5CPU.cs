using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG;
using DG.Tweening;

public class EnemyOther5CPU : MonoBehaviour
{
    enum ActionStep
    {
        One, //追着player攻击
        Two, //逃跑
    }

    public float FireTime = 0.2f; //子弹发射时间密度，越小越多子弹
    float NextFireTime = 0f;

    Transform PlayerLayer;
    Transform BulletLayer;
    Transform HideLayer;

    Transform PlayerPlane;
    ActionStep CurrActionStep;

    bool GameIsPause = false;

    // Start is called before the first frame update
    void Start()
    {
        Constant.ObjectIsPlayingSound(this);
		
		if (transform.parent.name != "HideLayer")
        {
			PlayerLayer = Camera.main.transform.Find("PlayerLayer");
            BulletLayer = transform.parent.Find("BulletLayer");
            HideLayer = Camera.main.transform.Find("HideLayer");

            PlayerPlane = PlayerLayer.Find(Constant.PlayerPlane);
            CurrActionStep = ActionStep.One;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.parent.name != "HideLayer")
        {
            if (Constant.GameIsPause)
            {
                if (!GameIsPause)
                {
                    transform.DOPause();
                    GameIsPause = Constant.GameIsPause;
                }
                return;
            }
            else if (!Constant.GameIsPause && GameIsPause)
            {
                transform.DOPlay();
                GameIsPause = Constant.GameIsPause;
                return;
            }

            //找不到player的处理
            if (PlayerPlane == null)
            {
                Vector2 tmp = FHUtility.HypotenuseAngle2Position(20f, transform.eulerAngles.z - 90f);
                Vector3 pos = new Vector3(tmp.x, tmp.y, 0);
                pos = transform.localPosition + pos;
                transform.DOLocalMove(pos, 8f).SetEase(Ease.Linear);
                return;
            }

            if (CurrActionStep == ActionStep.One)
            {
                //角度部分
                float angle = FHUtility.Angle360(transform.localPosition, PlayerPlane.localPosition);
                angle -= 90f;
                //控制在一个范围值，确保不会死死缠着player不放
                float angle_range = 20f;
                if (angle < -angle_range) angle = -angle_range;
                if (angle > angle_range) angle = angle_range;
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, angle);

                //平移部分
                Vector2 target_pos = FHUtility.HypotenuseAngle2Position(20f, angle - 90f);
                float move_speed = 3.5f; //平移速度，越小越快
                transform.Translate(target_pos.x / move_speed * Time.deltaTime, target_pos.y / move_speed * Time.deltaTime, 0);

                //子弹部分
                if (Time.time > NextFireTime && transform.localPosition.y > PlayerPlane.localPosition.y)
                {
                    string[] bullet_arr = new string[] { "Bullet04_0", "Bullet04_1", "Bullet05_0", "Bullet05_1" };
                    string bullet_n = bullet_arr[Random.Range(0, bullet_arr.Length - 1)];
                    Transform bullet = Instantiate(HideLayer.Find(bullet_n));
                    bullet.SetParent(BulletLayer);

                    Vector3 bullet_pos = transform.localPosition;
                    bullet.eulerAngles = transform.eulerAngles;

                    bullet.localPosition = bullet_pos;

                    float f = 5f; //子弹发出的角度浮动
                    angle -= 90f;
                    Vector2 tmp = FHUtility.HypotenuseAngle2Position(20f, Random.Range(angle - f, angle + f));
                    Vector3 pos = new Vector3(tmp.x, tmp.y, 0);
                    pos = bullet.localPosition + pos;
                    bullet.DOLocalMove(pos, 2.5f).SetEase(Ease.Linear);

                    NextFireTime = Time.time + FireTime;
                }
                else if (transform.localPosition.y <= PlayerPlane.localPosition.y)
                {
                    CurrActionStep = ActionStep.Two;
                }
            }
            else if (CurrActionStep == ActionStep.Two)
            {
                Vector2 target_pos = FHUtility.HypotenuseAngle2Position(20f, transform.eulerAngles.z - 90f);
                float move_speed = 3.5f; //平移速度，越小越快
                transform.Translate(target_pos.x / move_speed * Time.deltaTime, target_pos.y / move_speed * Time.deltaTime, 0);

            }
        }
    }
	
	private void OnDestroy()
    {
        transform.DOKill(true);
    }
	
}
