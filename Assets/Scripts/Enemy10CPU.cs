using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG;
using DG.Tweening;

public class Enemy10CPU : MonoBehaviour
{

    bool GameIsPause = false;

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
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.parent.name != "HideLayer")
        {
            if (Constant.GameIsPause && !GameIsPause)
            {
                transform.DOPause();
                GameIsPause = Constant.GameIsPause;
                return;
            }
            else if (!Constant.GameIsPause && GameIsPause)
            {
                transform.DOPlay();
                GameIsPause = Constant.GameIsPause;
                return;
            }

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
