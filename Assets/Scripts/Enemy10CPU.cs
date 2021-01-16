using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG;
using DG.Tweening;

public class Enemy10CPU : MonoBehaviour
{
    public float FireTime = 0.05f; //子弹发射时间密度，越小越多子弹
    float FireStartTime = 0.5f;
    float FireStopTime = 1f;
    float NextFireTime = 0f;
    bool DoChangeFireStatus = false; //是否正在执行ChangeFireStatus方法，确保ChangeFireStatus方法只执行一次
    bool DoFire = true;

    Transform PlayerLayer;
    Transform BulletLayer;
    Transform HideLayer;

    Transform PlayerPlane;
    Vector3 BulletEulerAngles;

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
			
            Vector3 target_pos = new Vector3(transform.localPosition.x, 4.6f, transform.localPosition.z);

            //用DOTween.Sequence会报错，不知道是什么问题
            transform.DOLocalMove(target_pos, 3.0f).SetEase(Ease.Linear).OnComplete(() =>
            {
                transform.DOLocalMoveX(-1.3f, 5.0f).SetEase(Ease.Linear).OnComplete(() => EnemyMove());
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

            if (PlayerPlane == null || PlayerPlane.localPosition.x <= -500)
            {
                return;
            }
            Fire01(1);
        }
    }

	private void OnDestroy()
    {
        transform.DOKill(true);
    }

    void Fire01(float angle)
    {
        string bullet_n = Constant.EnemyBullets01[Random.Range(0, Constant.EnemyBullets01.Length - 1)];
        Transform bullet = Instantiate(HideLayer.Find(bullet_n));
        bullet.SetParent(BulletLayer);

        Vector3 bullet_pos = transform.localPosition;

        bullet.localPosition = bullet_pos;

        Vector3 pos = new Vector3(bullet_pos.x, bullet_pos.y - 20f, bullet_pos.z);
        bullet.DOLocalMove(pos, 2f).SetEase(Ease.Linear);
    }

    void EnemyMove()
    {
        if (transform.localPosition.x < 0)
        {
            //往右移动
            transform.DOLocalMoveX(1.3f, 10.0f).SetEase(Ease.Linear).OnComplete(() =>
            {
                EnemyMove();
            });
            return;
        }

        //往左移动
        transform.DOLocalMoveX(-1.3f, 10.0f).SetEase(Ease.Linear).OnComplete(() =>
        {
            EnemyMove();
        });
    }

}
