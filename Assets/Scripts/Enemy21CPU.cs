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
        EnemyLayer = Camera.main.transform.Find("EnemyLayer");
        HideLayer = Camera.main.transform.Find("HideLayer");
        BulletLayer = EnemyLayer.Find("BulletLayer");

        //test
        Bullet01();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Bullet01()
    {
        Transform bullet = Instantiate(HideLayer.Find("Bullet06"));
        bullet.SetParent(BulletLayer);

        Vector3 bullet_pos = transform.localPosition;
        bullet_pos.z = 11f;
        bullet.localPosition = bullet_pos;

        float target_y = -10f - (-Camera.main.orthographicSize + bullet.localPosition.y);
        Vector3 target_pos = bullet_pos;
        //target_pos.x -= 5f;
        target_pos.y = target_y;

        bullet.DOLocalMove(target_pos, 2.5f);

    }

    void Move01()
    {

    }

}
