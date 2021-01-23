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

        //合理InitX的设置应在-3.6到3.6之间

        //demo
        /*EnemyData.Add(1f, new string[] { "Name:Enemy01_0,InitX:-2,MoveTargetY:2.5", "Name:Enemy01_1,InitX:0,MoveTargetY:3.5" });
        EnemyData.Add(3.5f, new string[] { "Name:Enemy02,InitX:1" });
        EnemyData.Add(8f, new string[] { "IsBoss:1" });
        EnemyData.Add(10f, new string[] { "Name:Enemy21,InitX:0" });*/

        //========================================================================

        EnemyData.Add(2f, new string[]
        {
            "Name:Enemy01_0,InitX:0,MoveTargetY:1,MoveTime:1",
            "Name:Enemy01_1,InitX:1,MoveTargetY:1,MoveTime:1",
            "Name:Enemy01_1,InitX:2,MoveTargetY:1,MoveTime:1",
            "Name:Enemy01_0,InitX:3,MoveTargetY:1,MoveTime:1",
        });
        EnemyData.Add(2.2f, new string[]
        {
            "Name:Enemy01_0,InitX:0,MoveTargetY:2,MoveTime:0.7",
            "Name:Enemy01_0,InitX:-1,MoveTargetY:2,MoveTime:0.7",
            "Name:Enemy01_1,InitX:-2,MoveTargetY:2,MoveTime:0.7",
            "Name:Enemy01_1,InitX:-3,MoveTargetY:2,MoveTime:0.7",
        });
        EnemyData.Add(2.4f, new string[]
        {
            "Name:Enemy01_0,InitX:0,MoveTargetY:3",
            "Name:Enemy01_1,InitX:1,MoveTargetY:3",
            "Name:Enemy01_1,InitX:2,MoveTargetY:3",
            "Name:Enemy01_0,InitX:-1,MoveTargetY:3",
            "Name:Enemy01_1,InitX:-2,MoveTargetY:3",
        });
        EnemyData.Add(3f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:0.5",
            "Name:Enemy02,InitX:-2",
        });
        EnemyData.Add(3.4f, new string[]
        {
            "Name:Enemy05,InitX:-3,MoveTargetY:4",
        });
        EnemyData.Add(3.6f, new string[]
        {
            "Name:EnemyOther0,InitX:-3.5",
            "Name:EnemyOther0,InitX:3.5",
        });
        EnemyData.Add(3.7f, new string[]
        {
            "Name:EnemyOther1,InitX:-2.5",
            "Name:EnemyOther1,InitX:2.5",
        });
        EnemyData.Add(4.0f, new string[]
        {
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
        });
        EnemyData.Add(4.1f, new string[]
        {
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
        });
        EnemyData.Add(4.2f, new string[]
        {
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
        });
        EnemyData.Add(4.3f, new string[]
        {
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
        });
        EnemyData.Add(4.5f, new string[]
        {
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
        });
        EnemyData.Add(4.8f, new string[]
        {
            "Name:Enemy05,InitX:3,MoveTargetY:4",
        });
        EnemyData.Add(5.0f, new string[]
        {
            "Name:Enemy05,InitX:3,MoveTargetY:2,MoveTime:0.7",
        });
        EnemyData.Add(5.3f, new string[]
        {
            "Name:Enemy02,InitX:-3.3",
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:3.3",
        });
        EnemyData.Add(5.6f, new string[]
        {
            "Name:Enemy05,InitX:0",
            "Name:Enemy01_1,InitX:2.8,MoveTargetY:3",
            "Name:Enemy01_0,InitX:3.2,MoveTargetY:3",
        });
        EnemyData.Add(5.8f, new string[]
        {
            "Name:Enemy02,InitX:2.8",
            "Name:Enemy02,InitX:3.2",
        });
        EnemyData.Add(6f, new string[]
        {
            "Name:Enemy02,InitX:-2.8",
            "Name:Enemy02,InitX:-3.2",
        });
        EnemyData.Add(6.3f, new string[]
        {
            "Name:Enemy18,InitX:-2.6",
        });
        EnemyData.Add(6.8f, new string[]
        {
            "Name:Enemy05,InitX:-1,MoveTargetY:4",
            "Name:Enemy05,InitX:1,MoveTargetY:4",
        });
        EnemyData.Add(7.0f, new string[]
        {
            "Name:Enemy05,InitX:-1,MoveTargetY:2,MoveTime:0.7",
            "Name:Enemy05,InitX:1,MoveTargetY:2,MoveTime:0.7",
        });
        EnemyData.Add(7.3f, new string[]
        {
            "Name:Enemy01_0,InitX:0,MoveTargetY:3",
            "Name:Enemy01_0,InitX:-1,MoveTargetY:3",
            "Name:Enemy01_1,InitX:-2,MoveTargetY:3",
            "Name:Enemy01_1,InitX:-3,MoveTargetY:3",
        });
        EnemyData.Add(8.5f, new string[]
        {
            "Name:Enemy01_0,InitX:0,MoveTargetY:1,MoveTime:1",
            "Name:Enemy01_1,InitX:1,MoveTargetY:1,MoveTime:1",
            "Name:Enemy01_1,InitX:2,MoveTargetY:1,MoveTime:1",
            "Name:Enemy01_0,InitX:3,MoveTargetY:1,MoveTime:1",
        });
        EnemyData.Add(8.8f, new string[]
        {
            "Name:Enemy01_0,InitX:0,MoveTargetY:2,MoveTime:0.7",
            "Name:Enemy01_0,InitX:-1,MoveTargetY:2,MoveTime:0.7",
            "Name:Enemy01_1,InitX:-2,MoveTargetY:2,MoveTime:0.7",
            "Name:Enemy01_1,InitX:-3,MoveTargetY:2,MoveTime:0.7",
        });
        EnemyData.Add(9.1f, new string[]
        {
            "Name:Enemy01_0,InitX:0,MoveTargetY:3",
            "Name:Enemy01_1,InitX:1,MoveTargetY:3",
            "Name:Enemy01_1,InitX:2,MoveTargetY:3",
            "Name:Enemy01_0,InitX:-1,MoveTargetY:3",
            "Name:Enemy01_1,InitX:-2,MoveTargetY:3",
        });
        EnemyData.Add(9.7f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:0.5",
            "Name:Enemy02,InitX:-2",
        });
        EnemyData.Add(10.1f, new string[]
        {
            "Name:Enemy05,InitX:3,MoveTargetY:4",
        });
        EnemyData.Add(10.3f, new string[]
        {
            "Name:EnemyOther0,InitX:-3.5",
            "Name:EnemyOther0,InitX:3.5",
        });
        EnemyData.Add(10.4f, new string[]
        {
            "Name:EnemyOther1,InitX:-2.5",
            "Name:EnemyOther1,InitX:2.5",
        });
        EnemyData.Add(10.8f, new string[]
        {
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
        });
        EnemyData.Add(11f, new string[]
        {
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
        });
        EnemyData.Add(11.2f, new string[]
        {
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
        });
        EnemyData.Add(11.3f, new string[]
        {
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
        });
        EnemyData.Add(11.5f, new string[]
        {
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
        });
        EnemyData.Add(11.8f, new string[]
        {
            "Name:Enemy05,InitX:-3,MoveTargetY:4",
        });
        EnemyData.Add(12f, new string[]
        {
            "Name:Enemy05,InitX:3,MoveTargetY:2,MoveTime:0.7",
        });
        EnemyData.Add(12.3f, new string[]
        {
            "Name:Enemy02,InitX:-3.3",
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:3.3",
        });
        EnemyData.Add(12.6f, new string[]
        {
            "Name:Enemy05,InitX:0",
            "Name:Enemy01_1,InitX:2.8,MoveTargetY:3",
            "Name:Enemy01_0,InitX:3.2,MoveTargetY:3",
        });
        EnemyData.Add(12.8f, new string[]
        {
            "Name:Enemy02,InitX:2.8",
            "Name:Enemy02,InitX:3.2",
        });
        EnemyData.Add(13f, new string[]
        {
            "Name:Enemy02,InitX:-2.8",
            "Name:Enemy02,InitX:-3.2",
        });
        EnemyData.Add(13.3f, new string[]
        {
            "Name:Enemy18,InitX:-2.6",
        });
        EnemyData.Add(13.8f, new string[]
        {
            "Name:Enemy05,InitX:1,MoveTargetY:4",
        });
        EnemyData.Add(14.0f, new string[]
        {
            "Name:Enemy05,InitX:-1,MoveTargetY:2,MoveTime:0.7",
        });
        EnemyData.Add(14.3f, new string[]
        {
            "Name:Enemy01_0,InitX:0,MoveTargetY:3",
            "Name:Enemy01_0,InitX:-1,MoveTargetY:3",
            "Name:Enemy01_1,InitX:-2,MoveTargetY:3",
            "Name:Enemy01_1,InitX:-3,MoveTargetY:3",
        });
        EnemyData.Add(15f, new string[]
        {
            "Name:Enemy01_0,InitX:0,MoveTargetY:1,MoveTime:1",
            "Name:Enemy01_1,InitX:1,MoveTargetY:1,MoveTime:1",
            "Name:Enemy01_1,InitX:2,MoveTargetY:1,MoveTime:1",
            "Name:Enemy01_0,InitX:3,MoveTargetY:1,MoveTime:1",
        });
        EnemyData.Add(15.2f, new string[]
        {
            "Name:Enemy01_0,InitX:0,MoveTargetY:2,MoveTime:0.7",
            "Name:Enemy01_0,InitX:-1,MoveTargetY:2,MoveTime:0.7",
            "Name:Enemy01_1,InitX:-2,MoveTargetY:2,MoveTime:0.7",
            "Name:Enemy01_1,InitX:-3,MoveTargetY:2,MoveTime:0.7",
        });
        EnemyData.Add(15.4f, new string[]
        {
            "Name:Enemy01_0,InitX:0,MoveTargetY:3",
            "Name:Enemy01_1,InitX:1,MoveTargetY:3",
            "Name:Enemy01_1,InitX:2,MoveTargetY:3",
            "Name:Enemy01_0,InitX:-1,MoveTargetY:3",
            "Name:Enemy01_1,InitX:-2,MoveTargetY:3",
        });
        EnemyData.Add(16f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:0.5",
            "Name:Enemy02,InitX:-2",
        });
        EnemyData.Add(16.4f, new string[]
        {
            "Name:Enemy05,InitX:-3,MoveTargetY:4",
        });
        EnemyData.Add(16.6f, new string[]
        {
            "Name:EnemyOther0,InitX:-3.5",
            "Name:EnemyOther0,InitX:3.5",
        });
        EnemyData.Add(16.7f, new string[]
        {
            "Name:EnemyOther1,InitX:-2.5",
            "Name:EnemyOther1,InitX:2.5",
        });
        EnemyData.Add(17.0f, new string[]
        {
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
        });
        EnemyData.Add(17.1f, new string[]
        {
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
        });
        EnemyData.Add(17.2f, new string[]
        {
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
        });
        EnemyData.Add(17.3f, new string[]
        {
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
        });
        EnemyData.Add(17.5f, new string[]
        {
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
        });
        EnemyData.Add(17.8f, new string[]
        {
            "Name:Enemy05,InitX:3,MoveTargetY:4",
        });
        EnemyData.Add(18.0f, new string[]
        {
            "Name:Enemy05,InitX:-3,MoveTargetY:2,MoveTime:0.7",
        });
        EnemyData.Add(18.3f, new string[]
        {
            "Name:Enemy02,InitX:-3.3",
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:3.3",
        });
        EnemyData.Add(18.6f, new string[]
        {
            "Name:Enemy05,InitX:0",
            "Name:Enemy01_1,InitX:2.8,MoveTargetY:3",
            "Name:Enemy01_0,InitX:3.2,MoveTargetY:3",
        });
        EnemyData.Add(18.8f, new string[]
        {
            "Name:Enemy02,InitX:2.8",
            "Name:Enemy02,InitX:3.2",
        });
        EnemyData.Add(19f, new string[]
        {
            "Name:Enemy02,InitX:-2.8",
            "Name:Enemy02,InitX:-3.2",
        });
        EnemyData.Add(19.3f, new string[]
        {
            "Name:Enemy18,InitX:-2.6",
        });
        EnemyData.Add(19.8f, new string[]
        {
            "Name:Enemy05,InitX:1,MoveTargetY:4",
        });
        EnemyData.Add(20.0f, new string[]
        {
            "Name:Enemy05,InitX:-1,MoveTargetY:2,MoveTime:0.7",
        });
        EnemyData.Add(20.3f, new string[]
        {
            "Name:Enemy01_0,InitX:0,MoveTargetY:3",
            "Name:Enemy01_0,InitX:-1,MoveTargetY:3",
            "Name:Enemy01_1,InitX:-2,MoveTargetY:3",
            "Name:Enemy01_1,InitX:-3,MoveTargetY:3",
        });
        EnemyData.Add(24f, new string[] { "IsBoss:1" });
        EnemyData.Add(26f, new string[] { "Name:Enemy21,InitX:0" });

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
