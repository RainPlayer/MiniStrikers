using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG;
using DG.Tweening;

public class Enemy01CPU : MonoBehaviour
{
    float FireTime = 0.5f;
    float NextFireTime = 0f;

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

            Vector3 target_pos = new Vector3(transform.localPosition.x, 2f, transform.localPosition.z);
            transform.DOLocalMove(target_pos, 2.0f).SetEase(Ease.Linear);
            
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

            if (Time.time > NextFireTime)
            {
                Transform bullet = Instantiate(HideLayer.Find("Bullet05_1"));
                SpriteRenderer bullet_sprite_renderer = bullet.GetComponent<SpriteRenderer>();
                bullet.SetParent(BulletLayer);

                Vector3 bullet_pos = transform.localPosition;
                bullet.eulerAngles = transform.eulerAngles;
                bullet.localPosition = bullet_pos;

                NextFireTime = Time.time + FireTime;
            }
        }
    }
}
