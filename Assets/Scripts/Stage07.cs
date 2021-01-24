using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage07 : MonoBehaviour
{

    Transform EnemyLayer;
    Queue<string> BossData;
    bool IsBossGo = false;

    // Start is called before the first frame update
    void Start()
    {
        EnemyLayer = Camera.main.transform.Find("EnemyLayer");

        //最后1关连续跟之前的boss打1次
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
            IsBossGo = false;
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
        yield return new WaitForSeconds(3f);
        if (BossData.Count > 0)
        {
            if (!IsBossGo)
            {
                IsBossGo = true;
            }
            EnemyLayer.GetComponent<EnemyLayer>().InitEnemy(BossData.Dequeue(), 0f);
        }
        else
        {
            //爆机了
            //过了最后1关，则进入爆机场景
            //加载资源少，用同步加载高效一点
            SceneManager.LoadScene(Constant.GameClearScene);
        }
    }
}
