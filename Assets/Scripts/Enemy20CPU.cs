using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG;
using DG.Tweening;

public class Enemy20CPU : MonoBehaviour
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

            //找不到player的处理
            if (PlayerPlane == null)
            {
                Vector2 tmp = FHUtility.HypotenuseAngle2Position(20f, transform.eulerAngles.z - 90f);
                Vector3 pos = new Vector3(tmp.x, tmp.y, 0);
                pos = transform.localPosition + pos;
                transform.DOLocalMove(pos, 8f).SetEase(Ease.Linear);
                return;
            }

            //角度部分
            float angle = FHUtility.Angle360(transform.localPosition, PlayerPlane.localPosition);
            angle -= 90f;
            //控制在一个范围值，确保不会死死缠着player不放
            float angle_range = 30f;
            if (angle < -angle_range) angle = -angle_range;
            if (angle > angle_range) angle = angle_range;
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, angle);

            //平移部分
            Vector2 target_pos = FHUtility.HypotenuseAngle2Position(20f, angle - 90f);
            float move_speed = 3.5f; //平移速度，越小越快
            transform.Translate(target_pos.x / move_speed * Time.deltaTime, target_pos.y / move_speed * Time.deltaTime, 0);

        }
    }
	
	private void OnDestroy()
    {
        transform.DOKill(true);
    }
	
}
