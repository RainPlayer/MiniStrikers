using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage05 : MonoBehaviour
{
    public IDictionary<float, string[]> EnemyData;

    private void Awake()
    {
        EnemyData = new Dictionary<float, string[]>();

        EnemyData.Add(2f, new string[]
        {
            "Name:Enemy01_0,InitX:0,MoveTargetY:1,MoveTime:1",
            "Name:Enemy01_1,InitX:1,MoveTargetY:1,MoveTime:1",
            "Name:Enemy01_1,InitX:2,MoveTargetY:1,MoveTime:1",
            "Name:Enemy01_0,InitX:3,MoveTargetY:1,MoveTime:1",
            "Name:Enemy01_0,InitX:-1,MoveTargetY:1,MoveTime:1",
            "Name:Enemy01_1,InitX:-2,MoveTargetY:1,MoveTime:1",
            "Name:Enemy01_1,InitX:-3,MoveTargetY:1,MoveTime:1",
        });
        EnemyData.Add(2.2f, new string[]
        {
            "Name:Enemy01_0,InitX:0,MoveTargetY:2,MoveTime:0.7",
            "Name:Enemy01_1,InitX:1,MoveTargetY:2,MoveTime:0.7",
            "Name:Enemy01_1,InitX:2,MoveTargetY:2,MoveTime:0.7",
            "Name:Enemy01_0,InitX:3,MoveTargetY:2,MoveTime:0.7",
            "Name:Enemy01_0,InitX:-1,MoveTargetY:2,MoveTime:0.7",
            "Name:Enemy01_1,InitX:-2,MoveTargetY:2,MoveTime:0.7",
            "Name:Enemy01_1,InitX:-3,MoveTargetY:2,MoveTime:0.7",
        });
        EnemyData.Add(2.4f, new string[]
        {
            "Name:Enemy01_0,InitX:0,MoveTargetY:3",
            "Name:Enemy01_1,InitX:1,MoveTargetY:3",
            "Name:Enemy01_1,InitX:2,MoveTargetY:3",
            "Name:Enemy01_0,InitX:3,MoveTargetY:3",
            "Name:Enemy01_0,InitX:-1,MoveTargetY:3",
            "Name:Enemy01_1,InitX:-2,MoveTargetY:3",
            "Name:Enemy01_1,InitX:-3,MoveTargetY:3",
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
            "Name:EnemyOther7,InitX:-1,MoveTargetY:2,MoveTime:0.7",
        });
        EnemyData.Add(7.3f, new string[]
        {
            "Name:Enemy01_0,InitX:0,MoveTargetY:3",
            "Name:Enemy01_0,InitX:-1,MoveTargetY:3",
            "Name:Enemy01_1,InitX:-2,MoveTargetY:3",
            "Name:Enemy01_1,InitX:-3,MoveTargetY:3",
        });
        EnemyData.Add(8f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-0.5",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
        });
        EnemyData.Add(8.2f, new string[]
        {
            "Name:Enemy08,InitX:1,MoveTargetY:4.5",
        });
        EnemyData.Add(8.6f, new string[]
        {
            "Name:EnemyOther3,InitX:-3.2",
            "Name:EnemyOther4,InitX:3.2",
        });
        EnemyData.Add(8.65f, new string[]
        {
            "Name:EnemyOther3,InitX:-3.2",
            "Name:EnemyOther4,InitX:3.2",
        });
        EnemyData.Add(8.7f, new string[]
        {
            "Name:EnemyOther3,InitX:-3.2",
            "Name:EnemyOther4,InitX:3.2",
        });
        EnemyData.Add(8.75f, new string[]
        {
            "Name:EnemyOther3,InitX:-3.2",
            "Name:EnemyOther4,InitX:3.2",
            "Name:Enemy07,InitX:-2.7",
        });
        EnemyData.Add(8.8f, new string[]
        {
            "Name:EnemyOther3,InitX:-3.2",
            "Name:EnemyOther4,InitX:3.2",
        });
        EnemyData.Add(8.85f, new string[]
        {
            "Name:EnemyOther3,InitX:-3.2",
            "Name:EnemyOther4,InitX:3.2",
        });
        EnemyData.Add(8.9f, new string[]
        {
            "Name:EnemyOther3,InitX:-3.2",
            "Name:EnemyOther4,InitX:3.2",
        });
        EnemyData.Add(10f, new string[]
        {
            "Name:Enemy06,InitX:3",
        });
        EnemyData.Add(10.2f, new string[]
        {
            "Name:EnemyOther2,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
        });
        EnemyData.Add(10.3f, new string[]
        {
            "Name:Enemy06,InitX:2,MoveTime:2.5",
        });
        EnemyData.Add(10.5f, new string[]
        {
            "Name:Enemy09,InitX:1,MoveTargetY:1,MoveTime:1",
            "Name:Enemy09,InitX:2,MoveTargetY:1,MoveTime:1",
        });
        EnemyData.Add(10.7f, new string[]
        {
            "Name:Enemy09,InitX:0,MoveTargetY:2,MoveTime:0.7",
            "Name:Enemy09,InitX:-1,MoveTargetY:2,MoveTime:0.7",
        });
        EnemyData.Add(10.9f, new string[]
        {
            "Name:Enemy09,InitX:-2,MoveTargetY:3",
            "Name:Enemy09,InitX:-3,MoveTargetY:3",
        });
        EnemyData.Add(11.3f, new string[]
        {
            "Name:Enemy07,InitX:1.2,MoveTargetY:3",
        });
        EnemyData.Add(11.5f, new string[]
        {
            "Name:EnemyOther3,InitX:-3.2",
            "Name:EnemyOther4,InitX:-3.15",
        });
        EnemyData.Add(11.55f, new string[]
        {
            "Name:EnemyOther3,InitX:-3.2",
            "Name:EnemyOther4,InitX:-3.15",
        });
        EnemyData.Add(11.6f, new string[]
        {
            "Name:EnemyOther3,InitX:-3.2",
            "Name:EnemyOther4,InitX:-3.15",
        });
        EnemyData.Add(11.65f, new string[]
        {
            "Name:EnemyOther3,InitX:-2.2",
            "Name:EnemyOther4,InitX:-2.15",
        });
        EnemyData.Add(11.7f, new string[]
        {
            "Name:EnemyOther3,InitX:-2.2",
            "Name:EnemyOther4,InitX:-2.15",
            "Name:EnemyOther2,InitX:1,MoveTargetY:5",
        });
        EnemyData.Add(11.75f, new string[]
        {
            "Name:EnemyOther3,InitX:-2.2",
            "Name:EnemyOther4,InitX:-2.15",
        });
        EnemyData.Add(11.9f, new string[]
        {
            "Name:Enemy07,InitX:-0.5,MoveTargetY:4",
        });
        EnemyData.Add(12f, new string[]
        {
            "Name:Enemy14,InitX:0",
            "Name:Enemy15,InitX:1",
        });
        EnemyData.Add(12.05f, new string[]
        {
            "Name:Enemy14,InitX:2",
            "Name:Enemy15,InitX:2.5",
        });
        EnemyData.Add(12.1f, new string[]
        {
            "Name:Enemy14,InitX:-1.5",
            "Name:Enemy15,InitX:-2",
        });
        EnemyData.Add(12.12f, new string[]
        {
            "Name:Enemy01_0,InitX:0,MoveTargetY:5,MoveTime:0.2",
            "Name:Enemy01_0,InitX:1,MoveTargetY:5,MoveTime:0.2",
            "Name:Enemy01_0,InitX:2,MoveTargetY:5,MoveTime:0.2",
            "Name:Enemy01_1,InitX:1,MoveTargetY:4.5,MoveTime:0.2",
            "Name:Enemy01_1,InitX:2,MoveTargetY:4.5,MoveTime:0.2",
            "Name:Enemy01_1,InitX:3,MoveTargetY:5,MoveTime:0.2",
        });
        EnemyData.Add(12.2f, new string[]
        {
            "Name:Enemy17,InitX:-2.5,MoveTargetY:5",
        });
        EnemyData.Add(13.0f, new string[]
        {
            "Name:Enemy16,InitX:-2.5",
            "Name:Enemy16,InitX:-3",
            "Name:Enemy16,InitX:-0.2",
            "Name:Enemy16,InitX:-1.2",
        });
        EnemyData.Add(13.8f, new string[]
        {
            "Name:EnemyOther5,InitX:0",
            "Name:EnemyOther5,InitX:-1.8",
            "Name:Enemy12,InitX:1",
        });
        EnemyData.Add(13.85f, new string[]
        {
            "Name:EnemyOther5,InitX:0",
            "Name:EnemyOther5,InitX:-1.8",
        });
        EnemyData.Add(13.9f, new string[]
        {
            "Name:EnemyOther5,InitX:0",
            "Name:EnemyOther5,InitX:-1.8",
        });
        EnemyData.Add(14.1f, new string[]
        {
            "Name:EnemyOther5,InitX:0",
            "Name:EnemyOther5,InitX:-1.8",
        });
        EnemyData.Add(14.3f, new string[]
        {
            "Name:EnemyOther5,InitX:0",
            "Name:EnemyOther5,InitX:-1.8",
            "Name:Enemy01_1,InitX:2.5,MoveTargetY:5,MoveTime:0.3",
        });
        EnemyData.Add(14.5f, new string[]
        {
            "Name:EnemyOther5,InitX:0",
            "Name:EnemyOther5,InitX:-1.8",
            "Name:Enemy01_0,InitX:2,MoveTargetY:5,MoveTime:0.3",
        });
        EnemyData.Add(14.7f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:-1.8",
        });
        EnemyData.Add(14.9f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:-1.8",
        });
        EnemyData.Add(15f, new string[]
        {
            "Name:Enemy14,InitX:3",
            "Name:Enemy15,InitX:-3",
        });
        EnemyData.Add(15.05f, new string[]
        {
            "Name:Enemy14,InitX:2",
            "Name:Enemy15,InitX:2.5",
        });
        EnemyData.Add(15.1f, new string[]
        {
            "Name:Enemy14,InitX:-1.5",
            "Name:Enemy15,InitX:-2",
        });
        EnemyData.Add(15.2f, new string[]
        {
            "Name:Enemy12,InitX:0.5",
            "Name:Enemy17,InitX:-0.5,MoveTargetY:5",
        });
        EnemyData.Add(15.3f, new string[]
        {
            "Name:Enemy16,InitX:0",
        });
        EnemyData.Add(15.4f, new string[]
        {
            "Name:Enemy16,InitX:0",
        });
        EnemyData.Add(15.5f, new string[]
        {
            "Name:Enemy16,InitX:0",
            "Name:EnemyOther6,InitX:3.1,MoveTargetY:4",
        });
        EnemyData.Add(15.7f, new string[]
        {
            "Name:EnemyOther6,InitX:-2.5,MoveTargetY:3",
        });
        EnemyData.Add(15.8f, new string[]
        {
            "Name:EnemyOther5,InitX:-0.5",
            "Name:EnemyOther5,InitX:0.5",
        });
        EnemyData.Add(15.85f, new string[]
        {
            "Name:EnemyOther5,InitX:-0.5",
            "Name:EnemyOther5,InitX:0.5",
        });
        EnemyData.Add(16f, new string[]
        {
            "Name:Enemy12,InitX:-3.1",
        });
        EnemyData.Add(16.4f, new string[]
        {
            "Name:Enemy12,InitX:3,MoveTargetY:5",
            "Name:Enemy12,InitX:-2,MoveTargetY:5",
        });
        EnemyData.Add(16.7f, new string[]
        {
            "Name:Enemy17,InitX:1,MoveTargetY:5",
            "Name:Enemy17,InitX:-1,MoveTargetY:5",
        });





        EnemyData.Add(17f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-0.5",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
        });
        EnemyData.Add(17.2f, new string[]
        {
            "Name:Enemy01_0,InitX:-1,MoveTargetY:4.5",
            "Name:Enemy01_0,InitX:0,MoveTargetY:4.5",
            "Name:Enemy01_1,InitX:1,MoveTargetY:4.5",
            "Name:Enemy01_1,InitX:2,MoveTargetY:4.5",
        });
        EnemyData.Add(17.6f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy03,InitX:3.2",
        });
        EnemyData.Add(17.65f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy03,InitX:3.2",
        });
        EnemyData.Add(17.7f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy03,InitX:3.2",
        });
        EnemyData.Add(17.75f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy03,InitX:3.2",
            "Name:Enemy09,InitX:-2.7",
        });
        EnemyData.Add(17.8f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy03,InitX:3.2",
        });
        EnemyData.Add(17.85f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy03,InitX:3.2",
        });
        EnemyData.Add(18f, new string[]
        {
            "Name:Enemy06,InitX:3",
        });
        EnemyData.Add(18.2f, new string[]
        {
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
        });
        EnemyData.Add(18.3f, new string[]
        {
            "Name:Enemy05,InitX:-3,MoveTargetY:4",
        });
        EnemyData.Add(18.5f, new string[]
        {
            "Name:Enemy16,InitX:1",
            "Name:Enemy16,InitX:0",
        });
        EnemyData.Add(18.7f, new string[]
        {
            "Name:Enemy09,InitX:-1,MoveTargetY:2,MoveTime:0.7",
            "Name:Enemy16,InitX:0",
        });
        EnemyData.Add(18.95f, new string[]
        {
            "Name:Enemy14,InitX:2",
            "Name:Enemy15,InitX:2.5",
        });
        EnemyData.Add(19f, new string[]
        {
            "Name:Enemy14,InitX:0",
            "Name:Enemy15,InitX:1",
        });
        EnemyData.Add(19.1f, new string[]
        {
            "Name:Enemy14,InitX:-1.5",
            "Name:Enemy15,InitX:-2",
        });
        EnemyData.Add(19.5f, new string[]
        {
            "Name:Enemy16,InitX:3.15",
            "Name:Enemy04,InitX:-3.15,MoveTargetY:5.5",
        });
        EnemyData.Add(19.7f, new string[]
        {
            "Name:Enemy06,InitX:2.5,MoveTime:2",
        });
        EnemyData.Add(19.75f, new string[]
        {
            "Name:EnemyOther7,InitX:-2.15,MoveTargetY:5",
        });
        EnemyData.Add(19.9f, new string[]
        {
            "Name:Enemy05,InitX:2,MoveTargetY:4.5",
        });
        EnemyData.Add(20f, new string[]
        {
            "Name:Enemy14,InitX:-1.5",
            "Name:Enemy15,InitX:-2",
        });
        EnemyData.Add(20.05f, new string[]
        {
            "Name:Enemy14,InitX:2",
            "Name:Enemy15,InitX:2.5",
        });
        EnemyData.Add(20.1f, new string[]
        {
            "Name:Enemy14,InitX:0",
            "Name:Enemy15,InitX:1",
        });
        EnemyData.Add(23f, new string[] { "IsBoss:1" });
        EnemyData.Add(25f, new string[] { "Name:Enemy25,InitX:0" });
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
