using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG;
using DG.Tweening;

public class Enemy05CPU : MonoBehaviour
{
    enum ActionStep
    {
        One, //移动到目标Y坐标
        Two, //攻击
        Three //逃跑
    }
    
    public float FireTime = 0.5f; //子弹发射时间密度，越小越多子弹
    public float MoveTargetY = 3f; //最终移动到的目标Y坐标
    public float MoveTime = 0.35f; //移动的时间，越小速度越快
    public float GoToEndTime = 8f; //停留的时间（秒），最终移动到的目标Y坐标后，这个时间到了就跑到画面边界执行销毁
    float NextFireTime = 0f;
    ActionStep CurrActionStep;

    Transform PlayerLayer;
    Transform BulletLayer;
    Transform HideLayer;

    Transform PlayerPlane;
	
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
            transform.DOLocalMoveY(MoveTargetY, MoveTargetY * MoveTime).SetEase(Ease.Linear).OnComplete(() =>
            {
                CurrActionStep = ActionStep.Two;
                StartCoroutine(GoToEndDelay());
            });
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

            //子弹部分
            if (Time.time > NextFireTime && CurrActionStep == ActionStep.Two)
            {
                Transform bullet = Instantiate(HideLayer.Find("Bullet04_0"));
                bullet.SetParent(BulletLayer);

                Vector3 bullet_pos = transform.localPosition;
                bullet.localPosition = bullet_pos;

                float target_y = 10f + (Camera.main.orthographicSize + bullet_pos.y);
                bullet.DOLocalMoveY(bullet_pos.y - target_y, 3.0f).SetEase(Ease.Linear);

                Bullet(3.5f);

                NextFireTime = Time.time + FireTime;
            }

        }
    }
	
	private void OnDestroy()
    {
        transform.DOKill(true);
    }

    IEnumerator GoToEndDelay()
    {
        yield return new WaitForSeconds(GoToEndTime);
        GoToEnd();
    }

    void GoToEnd()
    {
        CurrActionStep = ActionStep.Three;
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 0);

        transform.DOLocalMoveY(transform.localPosition.y - 20f, 12f * MoveTime).SetEase(Ease.Linear);
    }

    void Bullet(float target_x)
    {
        //==================================================================================
        //左边

        Transform bullet_left = Instantiate(HideLayer.Find("Bullet04_1"));
        bullet_left.SetParent(BulletLayer);

        Vector3 bullet_pos = transform.localPosition;
        bullet_left.localPosition = bullet_pos;

        float target_y = 10f + (Camera.main.orthographicSize + bullet_left.localPosition.y);
        Vector3 target_pos = bullet_pos;
        target_pos.x -= target_x;
        target_pos.y = -target_y;

        float r = FHUtility.Angle360(bullet_left.localPosition, target_pos);
        bullet_left.Rotate(0, 0, r + 90f);

        bullet_left.DOLocalMove(target_pos, 5.0f).SetEase(Ease.Linear);

        //==================================================================================
        //右边

        Transform bullet_right = Instantiate(HideLayer.Find("Bullet04_1"));
        bullet_right.SetParent(BulletLayer);

        bullet_right.localPosition = bullet_pos;

        target_pos.x += target_x * 2;

        r = FHUtility.Angle360(bullet_right.localPosition, target_pos);
        bullet_right.Rotate(0, 0, r + 90f);

        bullet_right.DOLocalMove(target_pos, 5.0f).SetEase(Ease.Linear);

    }

}
