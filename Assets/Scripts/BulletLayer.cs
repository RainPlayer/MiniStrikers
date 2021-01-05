using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG;
using DG.Tweening;

public class BulletLayer : MonoBehaviour
{
    bool GameIsPause;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //暂停的处理
        //如果全局已经暂停，BulletLayer::GameIsPause没有暂停，就把所有子弹先暂停，再把BulletLayer::GameIsPause改为暂停
        //如果全局已经不是暂停，BulletLayer::GameIsPause已经暂停，就把所有子弹的动画继续播放，再把BulletLayer::GameIsPause改为不暂停
        //以上逻辑确保动画的暂停和播放的方法只调用一次
        if (Constant.GameIsPause)
        {
            if (!GameIsPause)
            {
                for (int i = 0; i < transform.childCount; i++)
                {
                    Transform bullet = transform.GetChild(i);
                    Animator anim = bullet.gameObject.GetComponent<Animator>();
                    if (anim != null)
                    {
                        anim.speed = 0f;
                    }
                    bullet.DOPause();
                }
            }
            GameIsPause = Constant.GameIsPause;
        }
        else
        {
            if (GameIsPause)
            {
                for (int i = 0; i < transform.childCount; i++)
                {
                    Transform bullet = transform.GetChild(i);
                    Animator anim = bullet.gameObject.GetComponent<Animator>();
                    if (anim != null)
                    {
                        anim.speed = 1f;
                    }
                    bullet.DOPlay();
                }
            }
            GameIsPause = Constant.GameIsPause;
        }

    }
}
