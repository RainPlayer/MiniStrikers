using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG;
using DG.Tweening;

public class Enemy12CPU : MonoBehaviour
{
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

        }
    }
	
	private void OnDestroy()
    {
        transform.DOKill(true);
    }

    void Move01()
    {
    
    }

}
