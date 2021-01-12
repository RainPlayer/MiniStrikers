using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG;
using DG.Tweening;

public class Enemy06CPU : MonoBehaviour
{
    public float FireTime = 1f; //子弹发射时间密度，越小越多子弹
    public float MoveTime = 2f; //移动的时间，越小速度越快
    float NextFireTime = 0f;

    Transform PlayerLayer;
    Transform BulletLayer;
    Transform HideLayer;

    Transform PlayerPlane;
    PlayerPlaneCenter PlayerPlaneCenterObject;
    Vector3 PlayerPlanePos;

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
            PlayerPlaneCenterObject = PlayerPlane.Find("plane_center").GetComponent<PlayerPlaneCenter>();

            float target_y = 20f;
            transform.DOLocalMoveY(transform.localPosition.y - target_y, target_y * MoveTime).SetEase(Ease.Linear);
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

            //找到player的位置
            PlayerPlanePos = PlayerPlane != null && PlayerPlaneCenterObject.IsAlive ? PlayerPlane.localPosition : Constant.PlayerPlaneInitPosition;

            //子弹部分
            if (Time.time > NextFireTime)
            {
                //布局子弹
                //角度部分
                int c = 7; //必须是奇数
                float bullet_angle = 10f;
                float angle = FHUtility.Angle360(transform.localPosition, PlayerPlanePos);
                for (int i = 0; i < c; i++)
                {
                    float angle_s = (c - 1) / -2 * bullet_angle + (i * bullet_angle);
                    Fire(angle + angle_s);
                }

                NextFireTime = Time.time + FireTime;
            }
        }
    }

    private void OnDestroy()
    {
        transform.DOKill(true);
    }

    void Fire(float angle)
    {
        Transform bullet = Instantiate(HideLayer.Find("Bullet05_0"));
        bullet.SetParent(BulletLayer);

        Vector3 bullet_pos = transform.localPosition;

        bullet.localPosition = bullet_pos;
        bullet.eulerAngles = new Vector3(bullet.eulerAngles.x, bullet.eulerAngles.y, angle - 90f);

        Vector2 tmp = FHUtility.HypotenuseAngle2Position(20f, angle);
        Vector3 pos = new Vector3(tmp.x, tmp.y, 0);
        pos = bullet.localPosition - pos;
        bullet.DOLocalMove(pos, 8f).SetEase(Ease.Linear);
    }
}
