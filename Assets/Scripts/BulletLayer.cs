using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG;
using DG.Tweening;

public class BulletLayer : MonoBehaviour
{
    Camera MainCamera;
    IList<Transform> DeleteBulletArr;

    bool GameIsPause;

    // Start is called before the first frame update
    void Start()
    {
        MainCamera = FindObjectOfType<Camera>();
        DeleteBulletArr = new List<Transform>();
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
                    bullet.DOPlay();
                }
            }
            GameIsPause = Constant.GameIsPause;
        }

        //子弹超出了屏幕就释放
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform bullet = transform.GetChild(i);
            SpriteRenderer bullet_sprite_renderer = bullet.GetComponent<SpriteRenderer>();

            //计算是否超出屏幕，以下是本地坐标的(y的范围是-6到6之间)，摄像机大小加上子弹的一半大小（子弹大小*子弹的放缩）
            if (bullet.localPosition.y > MainCamera.orthographicSize + (bullet.localScale.y * bullet_sprite_renderer.size.y / 2f))
            {
                //超出了就释放
                DeleteBulletArr.Add(bullet);
            }
        }

        //统一做释放处理
        foreach (var bullet in DeleteBulletArr)
        {
            bullet.DOKill(true);
            Destroy(bullet.gameObject);
        }
        DeleteBulletArr.Clear();

    }
}
