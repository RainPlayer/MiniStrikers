using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG;
using DG.Tweening;

public class Enemy21CPU : MonoBehaviour
{
    Transform EnemyLayer;
    Transform HideLayer;
    Transform BulletLayer;

    // Start is called before the first frame update
    void Start()
    {
		Constant.ObjectIsPlayingSound(this);
		
		if (transform.parent.name != "HideLayer")
        {
            Vector3 target_pos = new Vector3(transform.localPosition.x, 4.6f, transform.localPosition.z);

            //用DOTween.Sequence会报错，不知道是什么问题
            transform.DOLocalMove(target_pos, 3.0f).SetEase(Ease.Linear).OnComplete(() =>
            {
                transform.DOLocalMoveX(-1.3f, 5.0f).SetEase(Ease.Linear).OnComplete(() => EnemyMove());
            });
            
        }
		
        //EnemyLayer = Camera.main.transform.Find("EnemyLayer");
        //HideLayer = Camera.main.transform.Find("HideLayer");
        //BulletLayer = EnemyLayer.Find("BulletLayer");

        //test
        //float target_y = transform.localPosition.y + (Camera.main.orthographicSize * -2f) - 10f;
        //Bullet(new Vector2(0f, target_y), 8f);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.parent.name != "HideLayer")
        {
			
		}
    }

    void Bullet(Vector2 pos, float time)
    {
        Transform bullet = Instantiate(HideLayer.Find("Bullet06"));
        bullet.SetParent(BulletLayer);

        Vector3 bullet_pos = transform.localPosition;
        bullet_pos.z = 11f;
        bullet.localPosition = bullet_pos;

        
        Vector3 target_pos = bullet_pos;
        target_pos.x = pos.x;
        target_pos.y = pos.y;

        bullet.DOLocalMove(target_pos, time);
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
