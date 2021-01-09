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

    void Move01()
    {

    }

}
