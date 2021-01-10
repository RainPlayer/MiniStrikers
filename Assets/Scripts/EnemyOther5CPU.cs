using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG;
using DG.Tweening;

public class EnemyOther5CPU : MonoBehaviour
{

    bool GameIsPause = false;

    // Start is called before the first frame update
    void Start()
    {
        Constant.ObjectIsPlayingSound(this);
		
		if (transform.parent.name != "HideLayer")
        {
			
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
}
