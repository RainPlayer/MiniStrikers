using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage01 : MonoBehaviour
{
    public IDictionary<float, string[]> EnemyData;

    private void Awake()
    {
        EnemyData = new Dictionary<float, string[]>();

        //格式：
        //key为敌机组出现的y坐标，camera跑到这个y坐标就会出现这组敌机
        //value为敌机组的数据，每个元素为1个敌机，Name:xxx,InitX:-2,IsBoss:1,参数a:参数a的值,参数b:参数b的值。Name和InitX是必须参数
        //Name为敌机对象名称，InitX为敌机出现的x坐标，Boss为把场景转换为boss状态（放这个参数，不需要其他参数了）

        //demo
        EnemyData.Add(1f, new string[] { "Name:Enemy01_0,InitX:-2,MoveTargetY:2.5", "Name:Enemy01_1,InitX:0,MoveTargetY:3.5" });
        EnemyData.Add(3.5f, new string[] { "Name:Enemy02,InitX:1" });
        EnemyData.Add(8f, new string[] { "IsBoss:1" });
        EnemyData.Add(10f, new string[] { "Name:Enemy21,InitX:0" });
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy()
    {
        EnemyData.Clear();
    }
}
