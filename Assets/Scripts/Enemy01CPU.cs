using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG;
using DG.Tweening;

public class Enemy01CPU : MonoBehaviour
{
    //public int EnemyCPUMode = 0;
    public float FireTime = 0.3f; //子弹发射时间密度
    public float MoveTargetY = 3f; //移动到的目标Y坐标
    public float MoveTime = 0.35f; //移动的时间
    float NextFireTime = 0f;
    bool IsMoveOver = false;

    Transform BulletLayer;
    Transform HideLayer;

    // Start is called before the first frame update
    void Start()
    {
        Constant.ObjectIsPlayingSound(this);
		
		if (transform.parent.name != "HideLayer")
        {
            BulletLayer = transform.parent.Find("BulletLayer");
            HideLayer = Camera.main.transform.Find("HideLayer");

            //float target_y = Random.Range(2f, 3f);
            float target_y = MoveTargetY;
            transform.DOLocalMoveY(target_y, target_y * MoveTime).SetEase(Ease.Linear).OnComplete(() => IsMoveOver = true);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.parent.name != "HideLayer")
        {
            float angle = FHUtility.Angle360(transform.localPosition, Vector3.zero);
            angle += 90f;
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, angle);

            if (Time.time > NextFireTime && IsMoveOver)
            {
                Transform bullet = Instantiate(HideLayer.Find("Bullet05_1"));
                bullet.SetParent(BulletLayer);

                Vector3 bullet_pos = transform.localPosition;
                bullet.eulerAngles = transform.eulerAngles;

                bullet.localPosition = bullet_pos;

                Vector2 tmp = FHUtility.HypotenuseAngle2Position(20f, angle + 90f);
                Vector3 pos = new Vector3(tmp.x, tmp.y, 0);
                pos = bullet.localPosition + pos;
                bullet.DOLocalMove(pos, 3.0f).SetEase(Ease.Linear);

                NextFireTime = Time.time + FireTime;
            }
        }
    }

}
