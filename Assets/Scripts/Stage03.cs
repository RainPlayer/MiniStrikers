using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage03 : MonoBehaviour
{
    public IDictionary<float, string[]> EnemyData;

    private void Awake()
    {
        EnemyData = new Dictionary<float, string[]>();

        EnemyData.Add(2f, new string[]
        {
            "Name:Enemy14,InitX:0",
            "Name:Enemy15,InitX:1",
        });
        EnemyData.Add(2.05f, new string[]
        {
            "Name:Enemy14,InitX:2",
            "Name:Enemy15,InitX:2.5",
        });
        EnemyData.Add(2.1f, new string[]
        {
            "Name:Enemy14,InitX:-1.5",
            "Name:Enemy15,InitX:-2",
        });
        EnemyData.Add(2.12f, new string[]
        {
            "Name:Enemy01_0,InitX:0,MoveTargetY:5,MoveTime:0.2",
            "Name:Enemy01_0,InitX:1,MoveTargetY:5,MoveTime:0.2",
            "Name:Enemy01_0,InitX:2,MoveTargetY:5,MoveTime:0.2",
            "Name:Enemy01_1,InitX:1,MoveTargetY:4.5,MoveTime:0.2",
            "Name:Enemy01_1,InitX:2,MoveTargetY:4.5,MoveTime:0.2",
            "Name:Enemy01_1,InitX:3,MoveTargetY:5,MoveTime:0.2",
        });
        EnemyData.Add(2.2f, new string[]
        {
            "Name:Enemy17,InitX:-2.5,MoveTargetY:5",
        });
        EnemyData.Add(3.0f, new string[]
        {
            "Name:Enemy16,InitX:-2.5",
            "Name:Enemy16,InitX:-3",
            "Name:Enemy16,InitX:-0.2",
            "Name:Enemy16,InitX:-1.2",
        });
        EnemyData.Add(3.8f, new string[]
        {
            "Name:EnemyOther5,InitX:0",
            "Name:EnemyOther5,InitX:-1.8",
            "Name:Enemy12,InitX:1",
        });
        EnemyData.Add(3.85f, new string[]
        {
            "Name:EnemyOther5,InitX:0",
            "Name:EnemyOther5,InitX:-1.8",
        });
        EnemyData.Add(3.9f, new string[]
        {
            "Name:EnemyOther5,InitX:0",
            "Name:EnemyOther5,InitX:-1.8",
        });
        EnemyData.Add(4.1f, new string[]
        {
            "Name:EnemyOther5,InitX:0",
            "Name:EnemyOther5,InitX:-1.8",
        });
        EnemyData.Add(4.3f, new string[]
        {
            "Name:EnemyOther5,InitX:0",
            "Name:EnemyOther5,InitX:-1.8",
            "Name:Enemy01_1,InitX:2.5,MoveTargetY:5,MoveTime:0.3",
        });
        EnemyData.Add(4.5f, new string[]
        {
            "Name:EnemyOther5,InitX:0",
            "Name:EnemyOther5,InitX:-1.8",
            "Name:Enemy01_0,InitX:2,MoveTargetY:5,MoveTime:0.3",
        });
        EnemyData.Add(4.7f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:-1.8",
        });
        EnemyData.Add(4.9f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:-1.8",
        });
        EnemyData.Add(5f, new string[]
        {
            "Name:Enemy14,InitX:3",
            "Name:Enemy15,InitX:-3",
        });
        EnemyData.Add(5.05f, new string[]
        {
            "Name:Enemy14,InitX:2",
            "Name:Enemy15,InitX:2.5",
        });
        EnemyData.Add(5.1f, new string[]
        {
            "Name:Enemy14,InitX:-1.5",
            "Name:Enemy15,InitX:-2",
        });
        EnemyData.Add(5.2f, new string[]
        {
            "Name:Enemy12,InitX:0.5",
            "Name:Enemy17,InitX:-0.5,MoveTargetY:5",
        });
        EnemyData.Add(5.3f, new string[]
        {
            "Name:Enemy16,InitX:0",
        });
        EnemyData.Add(5.4f, new string[]
        {
            "Name:Enemy16,InitX:0",
        });
        EnemyData.Add(5.5f, new string[]
        {
            "Name:Enemy16,InitX:0",
            "Name:EnemyOther6,InitX:3.1,MoveTargetY:4",
        });
        EnemyData.Add(5.7f, new string[]
        {
            "Name:EnemyOther6,InitX:-2.5,MoveTargetY:3",
        });
        EnemyData.Add(5.8f, new string[]
        {
            "Name:EnemyOther5,InitX:-0.5",
            "Name:EnemyOther5,InitX:0.5",
        });
        EnemyData.Add(5.85f, new string[]
        {
            "Name:EnemyOther5,InitX:-0.5",
            "Name:EnemyOther5,InitX:0.5",
        });
        EnemyData.Add(6f, new string[]
        {
            "Name:Enemy12,InitX:-3.1",
        });
        EnemyData.Add(6.4f, new string[]
        {
            "Name:Enemy12,InitX:3,MoveTargetY:5",
            "Name:Enemy12,InitX:-2,MoveTargetY:5",
        });
        EnemyData.Add(6.7f, new string[]
        {
            "Name:Enemy17,InitX:1,MoveTargetY:5",
            "Name:Enemy17,InitX:-1,MoveTargetY:5",
        });
        EnemyData.Add(7f, new string[]
        {
            "Name:Enemy14,InitX:0",
            "Name:Enemy15,InitX:1",
        });
        EnemyData.Add(7.05f, new string[]
        {
            "Name:Enemy14,InitX:2",
            "Name:Enemy15,InitX:2.5",
        });
        EnemyData.Add(7.1f, new string[]
        {
            "Name:Enemy14,InitX:-1.5",
            "Name:Enemy15,InitX:-2",
        });
        EnemyData.Add(7.12f, new string[]
        {
            "Name:Enemy01_0,InitX:0,MoveTargetY:5,MoveTime:0.2",
            "Name:Enemy01_0,InitX:1,MoveTargetY:5,MoveTime:0.2",
            "Name:Enemy01_0,InitX:2,MoveTargetY:5,MoveTime:0.2",
            "Name:Enemy01_1,InitX:1,MoveTargetY:4.5,MoveTime:0.2",
            "Name:Enemy01_1,InitX:2,MoveTargetY:4.5,MoveTime:0.2",
            "Name:Enemy01_1,InitX:3,MoveTargetY:5,MoveTime:0.2",
        });
        EnemyData.Add(7.2f, new string[]
        {
            "Name:Enemy17,InitX:-2.5,MoveTargetY:5",
        });
        EnemyData.Add(8.0f, new string[]
        {
            "Name:Enemy16,InitX:-2.5",
            "Name:Enemy16,InitX:-3",
            "Name:Enemy16,InitX:-0.2",
            "Name:Enemy16,InitX:-1.2",
        });
        EnemyData.Add(8.8f, new string[]
        {
            "Name:EnemyOther5,InitX:0",
            "Name:EnemyOther5,InitX:-1.8",
            "Name:Enemy12,InitX:1",
        });
        EnemyData.Add(8.85f, new string[]
        {
            "Name:EnemyOther5,InitX:0",
            "Name:EnemyOther5,InitX:-1.8",
        });
        EnemyData.Add(8.9f, new string[]
        {
            "Name:EnemyOther5,InitX:0",
            "Name:EnemyOther5,InitX:-1.8",
        });
        EnemyData.Add(9.1f, new string[]
        {
            "Name:EnemyOther5,InitX:0",
            "Name:EnemyOther5,InitX:-1.8",
        });
        EnemyData.Add(9.3f, new string[]
        {
            "Name:EnemyOther5,InitX:0",
            "Name:EnemyOther5,InitX:-1.8",
            "Name:Enemy01_1,InitX:2.5,MoveTargetY:5,MoveTime:0.3",
        });
        EnemyData.Add(9.5f, new string[]
        {
            "Name:EnemyOther5,InitX:0",
            "Name:EnemyOther5,InitX:-1.8",
            "Name:Enemy01_0,InitX:2,MoveTargetY:5,MoveTime:0.3",
        });
        EnemyData.Add(9.7f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:-1.8",
        });
        EnemyData.Add(9.9f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:-1.8",
        });
        EnemyData.Add(10f, new string[]
        {
            "Name:Enemy14,InitX:3",
            "Name:Enemy15,InitX:-3",
        });
        EnemyData.Add(10.05f, new string[]
        {
            "Name:Enemy14,InitX:2",
            "Name:Enemy15,InitX:2.5",
        });
        EnemyData.Add(10.1f, new string[]
        {
            "Name:Enemy14,InitX:-1.5",
            "Name:Enemy15,InitX:-2",
        });
        EnemyData.Add(10.2f, new string[]
        {
            "Name:Enemy12,InitX:0.5",
            "Name:Enemy17,InitX:-0.5,MoveTargetY:5",
        });
        EnemyData.Add(10.3f, new string[]
        {
            "Name:Enemy16,InitX:0",
        });
        EnemyData.Add(10.4f, new string[]
        {
            "Name:Enemy16,InitX:0",
        });
        EnemyData.Add(10.5f, new string[]
        {
            "Name:Enemy16,InitX:0",
            "Name:EnemyOther6,InitX:3.1,MoveTargetY:4",
        });
        EnemyData.Add(10.7f, new string[]
        {
            "Name:EnemyOther6,InitX:-2.5,MoveTargetY:3",
        });
        EnemyData.Add(10.8f, new string[]
        {
            "Name:EnemyOther5,InitX:-0.5",
            "Name:EnemyOther5,InitX:0.5",
        });
        EnemyData.Add(10.85f, new string[]
        {
            "Name:EnemyOther5,InitX:-0.5",
            "Name:EnemyOther5,InitX:0.5",
        });
        EnemyData.Add(11f, new string[]
        {
            "Name:Enemy12,InitX:-3.1",
        });
        EnemyData.Add(11.4f, new string[]
        {
            "Name:Enemy12,InitX:3,MoveTargetY:5",
            "Name:Enemy12,InitX:-2,MoveTargetY:5",
        });
        EnemyData.Add(11.7f, new string[]
        {
            "Name:Enemy17,InitX:1,MoveTargetY:5",
            "Name:Enemy17,InitX:-1,MoveTargetY:5",
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
            "Name:Enemy01_0,InitX:0,MoveTargetY:5,MoveTime:0.2",
            "Name:Enemy01_0,InitX:1,MoveTargetY:5,MoveTime:0.2",
            "Name:Enemy01_0,InitX:2,MoveTargetY:5,MoveTime:0.2",
            "Name:Enemy01_1,InitX:1,MoveTargetY:4.5,MoveTime:0.2",
            "Name:Enemy01_1,InitX:2,MoveTargetY:4.5,MoveTime:0.2",
            "Name:Enemy01_1,InitX:3,MoveTargetY:5,MoveTime:0.2",
        });
        EnemyData.Add(17.2f, new string[]
        {
            "Name:Enemy17,InitX:-2.5,MoveTargetY:5",
        });
        EnemyData.Add(18.0f, new string[]
        {
            "Name:Enemy16,InitX:-2.5",
            "Name:Enemy16,InitX:-3",
            "Name:Enemy16,InitX:-0.2",
            "Name:Enemy16,InitX:-1.2",
        });
        EnemyData.Add(18.5f, new string[]
        {
            "Name:Enemy14,InitX:0",
            "Name:Enemy15,InitX:1",
        });
        EnemyData.Add(18.55f, new string[]
        {
            "Name:Enemy14,InitX:2",
            "Name:Enemy15,InitX:2.5",
        });
        EnemyData.Add(18.6f, new string[]
        {
            "Name:Enemy14,InitX:-1.5",
            "Name:Enemy15,InitX:-2",
        });
        EnemyData.Add(19.2f, new string[]
        {
            "Name:Enemy17,InitX:-2.5,MoveTargetY:4",
        });
        EnemyData.Add(19.5f, new string[]
        {
            "Name:Enemy16,InitX:-2.5",
            "Name:Enemy16,InitX:-3",
            "Name:Enemy16,InitX:-0.2",
            "Name:Enemy16,InitX:-1.2",
        });
        EnemyData.Add(19.8f, new string[]
        {
            "Name:Enemy12,InitX:1",
        });
        EnemyData.Add(19.9f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:-1.8",
        });
        EnemyData.Add(23f, new string[] { "IsBoss:1" });
        EnemyData.Add(25f, new string[] { "Name:Enemy23,InitX:0" });
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
