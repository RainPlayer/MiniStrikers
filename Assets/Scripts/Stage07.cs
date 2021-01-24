using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage07 : MonoBehaviour
{

    Transform EnemyLayer;
    Queue<string> BossData;
    bool IsBossGo = false;

    // Start is called before the first frame update
    void Start()
    {
        EnemyLayer = Camera.main.transform.Find("EnemyLayer");
        BossData = new Queue<string>();
        BossData.Enqueue("Enemy21");
        BossData.Enqueue("Enemy22");
        BossData.Enqueue("Enemy23");
        BossData.Enqueue("Enemy24");
        BossData.Enqueue("Enemy25");
        BossData.Enqueue("Enemy10");

        StartCoroutine(ChangeBossBattle());
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyLayer.childCount <= 1 && IsBossGo)
        {
            StartCoroutine(BossGo());
        }
    }

    private void OnDestroy()
    {

    }

    IEnumerator ChangeBossBattle()
    {
        yield return new WaitForSeconds(3f);

        Camera.main.transform.GetComponent<StageCommon>().ChnageGameProgress(StageCommon.GameProgress.Boss);
        StartCoroutine(BossGo());
    }
    
    IEnumerator BossGo()
    {
        if (!IsBossGo)
        {
            IsBossGo = true;
        }

        yield return new WaitForSeconds(3f);
        EnemyLayer.GetComponent<EnemyLayer>().InitEnemy(BossData.Dequeue(), 0f);
    }
}
