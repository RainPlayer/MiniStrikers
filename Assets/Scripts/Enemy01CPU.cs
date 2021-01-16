using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG;
using DG.Tweening;

public class Enemy01CPU : MonoBehaviour
{
    enum ActionStep
    {
        One, //移动到目标Y坐标
        Two, //瞄准player攻击
        Three //逃跑
    }

    //public int EnemyCPUMode = 0;
    public float FireTime = 0.3f; //子弹发射时间密度，越小越多子弹
    public float MoveTargetY = 3f; //最终移动到的目标Y坐标
    public float MoveTime = 0.35f; //移动的时间，越小速度越快
    public float GoToEndTime = 5f; //停留的时间（秒），最终移动到的目标Y坐标后，这个时间到了就跑到画面边界执行销毁
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
            
            if (CurrActionStep != ActionStep.Three)
            {
                if (PlayerPlane == null || PlayerPlane.localPosition.x <= -500)
                {
                    StopCoroutine(GoToEndDelay());
                    GoToEnd();
                    return;
                }

                //角度
                float angle = FHUtility.Angle360(transform.localPosition, PlayerPlane.localPosition);
                angle -= 90f;
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, angle);

                //子弹部分
                if (Time.time > NextFireTime && CurrActionStep == ActionStep.Two)
                {
                    Transform bullet = Instantiate(HideLayer.Find("Bullet05_1"));
                    bullet.SetParent(BulletLayer);

                    Vector3 bullet_pos = transform.localPosition;
                    bullet.eulerAngles = transform.eulerAngles;

                    bullet.localPosition = bullet_pos;

                    Vector2 tmp = FHUtility.HypotenuseAngle2Position(20f, angle - 90f);
                    Vector3 pos = new Vector3(tmp.x, tmp.y, 0);
                    pos = bullet.localPosition + pos;
                    bullet.DOLocalMove(pos, 3.0f).SetEase(Ease.Linear);

                    NextFireTime = Time.time + FireTime;
                }
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

}
