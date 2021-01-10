using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG;
using DG.Tweening;

public class Enemy22CPU : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Constant.ObjectIsPlayingSound(this);
		
		if (transform.parent.name != "HideLayer")
        {
            Vector3 target_pos = new Vector3(transform.localPosition.x, 4.6f, transform.localPosition.z);
            Sequence seq = DOTween.Sequence();
            seq.Append(transform.DOLocalMove(target_pos, 3.0f).SetEase(Ease.Linear));
            seq.Append(transform.DOLocalMoveX(-1.3f, 5.0f).SetEase(Ease.Linear).OnComplete(() =>
            {
                EnemyMove();
            }));
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.parent.name != "HideLayer")
        {
			
		}
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
