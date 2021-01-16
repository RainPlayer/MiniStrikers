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

        Camera.main.transform.GetComponent<StageCommon>().ChnageGameProgress(StageCommon.GameProgress.Boss);

        Transform EnemyLayer = Camera.main.transform.Find("EnemyLayer");
        //EnemyLayer.GetComponent<EnemyLayer>().InitEnemy("Enemy01_0", -2f); //!!!
        //EnemyLayer.GetComponent<EnemyLayer>().InitEnemy("Enemy01_1", 2.5f); //!!!
        //EnemyLayer.GetComponent<EnemyLayer>().InitEnemy("Enemy02", -2f); //!!!
        //EnemyLayer.GetComponent<EnemyLayer>().InitEnemy("Enemy03", 2.5f); //!!!
        //EnemyLayer.GetComponent<EnemyLayer>().InitEnemy("Enemy04", -0.5f); //!!!
        //EnemyLayer.GetComponent<EnemyLayer>().InitEnemy("Enemy05", 1f); //!!!
        //EnemyLayer.GetComponent<EnemyLayer>().InitEnemy("Enemy06", 2.5f); //!!!
        //EnemyLayer.GetComponent<EnemyLayer>().InitEnemy("Enemy07", 1f); //!!!
        //EnemyLayer.GetComponent<EnemyLayer>().InitEnemy("Enemy08", 0f); //!!!
        //EnemyLayer.GetComponent<EnemyLayer>().InitEnemy("Enemy09", -1f); //!!!
        //EnemyLayer.GetComponent<EnemyLayer>().InitEnemy("Enemy10", 0f);
        //EnemyLayer.GetComponent<EnemyLayer>().InitEnemy("Enemy11", -1f); //!!!
        //EnemyLayer.GetComponent<EnemyLayer>().InitEnemy("Enemy12", 0f); //!!!
        //EnemyLayer.GetComponent<EnemyLayer>().InitEnemy("Enemy13", 1f); //!!!
        //EnemyLayer.GetComponent<EnemyLayer>().InitEnemy("Enemy14", -2f); //!!!
        //EnemyLayer.GetComponent<EnemyLayer>().InitEnemy("Enemy15", 1f); //!!!
        //EnemyLayer.GetComponent<EnemyLayer>().InitEnemy("Enemy16", 1f); //!!!
        //EnemyLayer.GetComponent<EnemyLayer>().InitEnemy("Enemy17", -1f); //!!!
        //EnemyLayer.GetComponent<EnemyLayer>().InitEnemy("Enemy18", -1f); //!!!
        //EnemyLayer.GetComponent<EnemyLayer>().InitEnemy("Enemy19", 0); //!!!
        //EnemyLayer.GetComponent<EnemyLayer>().InitEnemy("Enemy20", -1f); //!!!
        EnemyLayer.GetComponent<EnemyLayer>().InitEnemy("Enemy21", 0f);
        //EnemyLayer.GetComponent<EnemyLayer>().InitEnemy("Enemy22", 0f);
        //EnemyLayer.GetComponent<EnemyLayer>().InitEnemy("Enemy23", 0f);
        //EnemyLayer.GetComponent<EnemyLayer>().InitEnemy("Enemy24", 0f);
        //EnemyLayer.GetComponent<EnemyLayer>().InitEnemy("Enemy25", 0f);
        //EnemyLayer.GetComponent<EnemyLayer>().InitEnemy("EnemyOther0", 2.5f); //!!!
        //EnemyLayer.GetComponent<EnemyLayer>().InitEnemy("EnemyOther1", 2.5f); //!!!
        //EnemyLayer.GetComponent<EnemyLayer>().InitEnemy("EnemyOther2", 2.5f); //!!!
        //EnemyLayer.GetComponent<EnemyLayer>().InitEnemy("EnemyOther3", 2.5f); //!!!
        //EnemyLayer.GetComponent<EnemyLayer>().InitEnemy("EnemyOther4", 2.5f); //!!!
        //EnemyLayer.GetComponent<EnemyLayer>().InitEnemy("EnemyOther5", 2.5f); //!!!
        //EnemyLayer.GetComponent<EnemyLayer>().InitEnemy("EnemyOther6", 2.5f); //!!!
        //EnemyLayer.GetComponent<EnemyLayer>().InitEnemy("EnemyOther7", 2.5f); //!!!
    }

    // Update is called once per frame
    void Update()
    {


    }
}
