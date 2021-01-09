using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG;
using DG.Tweening;

public class Test : MonoBehaviour
{

    //Transform TmpEnemy;
    //float TmpR;

    // Start is called before the first frame update
    void Start()
    {
        Constant.ObjectIsPlayingSound(this);

        /*Transform bullet = transform.Find("Bullet03");
        float r = FHUtility.Angle360(Vector2.zero, new Vector2(-100, 0));
        bullet.Rotate(0, 0, r + 90f);

        TmpEnemy = null;
        TmpR = 0;

        Transform enemy = InitEnemy("Enemy05", 1.5f);
        Vector3 target_pos = new Vector3(-2, 2, enemy.localPosition.z);
        float r2 = FHUtility.Angle360(enemy.localPosition, target_pos) - 90f;
        enemy.Rotate(0, 0, r2);
        enemy.DOMove(target_pos, 2.0f).OnComplete(() => {
            TmpEnemy = enemy;
            TmpR = FHUtility.Angle360(enemy.localPosition, transform.Find("Enemy05").localPosition) - 90f;

            Debug.Log(enemy.localRotation);
            Debug.Log(r2);
            Debug.Log(TmpR);
        });
        */

        Camera.main.transform.Find("EnemyLayer").GetComponent<EnemyLayer>().InitEnemy("Enemy10", 0f);

    }

    // Update is called once per frame
    void Update()
    {

        /*if (TmpEnemy != null && TmpEnemy.localRotation.z != TmpR)
        {
            TmpEnemy. = new 
        }*/

    }
}
