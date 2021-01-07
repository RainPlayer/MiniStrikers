using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG;
using DG.Tweening;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Constant.ObjectIsPlayingSound(this);
		
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.parent.name != "HideLayer")
        {
            SpriteRenderer bullet_sprite_renderer = GetComponent<SpriteRenderer>();

            //计算是否超出屏幕，以下是本地坐标的(y的范围是-6到6之间)，摄像机大小加上子弹的一半大小（子弹大小*子弹的放缩）
            if ((transform.localPosition.y > Camera.main.orthographicSize + (transform.localScale.y * bullet_sprite_renderer.size.y / 2f)) //超出上面
                || (transform.localPosition.y < -Camera.main.orthographicSize + (-transform.localScale.y * bullet_sprite_renderer.size.y / 2f)) //超出下面
                )
            {
                //超出了就释放
                transform.DOKill(true);
                Destroy(gameObject);
            }
        }
    }
}
