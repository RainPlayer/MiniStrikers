using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG;
using DG.Tweening;

public class EnemyLayer : MonoBehaviour
{
    Transform HideLayer;

    // Start is called before the first frame update
    void Start()
    {
        Constant.ObjectIsPlayingSound(this);

        HideLayer = Camera.main.transform.Find("HideLayer");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Transform InitEnemy(string enemy_name, float init_x)
    {
        //transform是来源对象的parent层
        Transform enemy = Instantiate(HideLayer.Find(enemy_name));

        //定位初始位置
        SpriteRenderer enemy_sprite_renderer = enemy.GetComponent<SpriteRenderer>();
        float init_y = enemy_sprite_renderer.size.y * enemy.localScale.y / 2f;
        init_y += Camera.main.orthographicSize;
        enemy.localPosition = new Vector3(init_x, init_y + Camera.main.transform.localPosition.y, enemy.localPosition.z);

        //Camera.main.transform是目标对象的parent层
        enemy.SetParent(transform);

        return enemy;
    }

}
