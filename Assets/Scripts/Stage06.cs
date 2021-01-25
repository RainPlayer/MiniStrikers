using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage06 : MonoBehaviour
{
    public IDictionary<float, string[]> EnemyData;

    private void Awake()
    {
        EnemyData = new Dictionary<float, string[]>();

        EnemyData.Add(2f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-0.5",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
        });
        EnemyData.Add(2.2f, new string[]
        {
            "Name:Enemy08,InitX:1,MoveTargetY:4.5",
        });
        EnemyData.Add(2.6f, new string[]
        {
            "Name:EnemyOther3,InitX:-3.2",
            "Name:EnemyOther4,InitX:3.2",
        });
        EnemyData.Add(2.65f, new string[]
        {
            "Name:EnemyOther3,InitX:-3.2",
            "Name:EnemyOther4,InitX:3.2",
        });
        EnemyData.Add(2.7f, new string[]
        {
            "Name:EnemyOther3,InitX:-3.2",
            "Name:EnemyOther4,InitX:3.2",
        });
        EnemyData.Add(2.75f, new string[]
        {
            "Name:EnemyOther3,InitX:-3.2",
            "Name:EnemyOther4,InitX:3.2",
            "Name:Enemy07,InitX:-2.7",
        });
        EnemyData.Add(2.8f, new string[]
        {
            "Name:EnemyOther3,InitX:-3.2",
            "Name:EnemyOther4,InitX:3.2",
        });
        EnemyData.Add(2.85f, new string[]
        {
            "Name:EnemyOther3,InitX:-3.2",
            "Name:EnemyOther4,InitX:3.2",
        });
        EnemyData.Add(2.9f, new string[]
        {
            "Name:EnemyOther3,InitX:-3.2",
            "Name:EnemyOther4,InitX:3.2",
        });
        EnemyData.Add(3f, new string[]
        {
            "Name:Enemy06,InitX:3",
        });
        EnemyData.Add(3.2f, new string[]
        {
            "Name:EnemyOther2,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
        });
        EnemyData.Add(3.5f, new string[]
        {
            "Name:Enemy09,InitX:1,MoveTargetY:1,MoveTime:1",
        });
        EnemyData.Add(3.7f, new string[]
        {
            "Name:Enemy09,InitX:-1,MoveTargetY:2,MoveTime:0.7",
        });
        EnemyData.Add(3.9f, new string[]
        {
            "Name:Enemy09,InitX:-2,MoveTargetY:3",
        });
        EnemyData.Add(4.3f, new string[]
        {
            "Name:Enemy07,InitX:1.2,MoveTargetY:3",
        });
        EnemyData.Add(4.5f, new string[]
        {
            "Name:EnemyOther3,InitX:-3.2",
            "Name:EnemyOther4,InitX:-3.15",
        });
        EnemyData.Add(4.55f, new string[]
        {
            "Name:EnemyOther3,InitX:-3.2",
            "Name:EnemyOther4,InitX:-3.15",
        });
        EnemyData.Add(4.6f, new string[]
        {
            "Name:EnemyOther3,InitX:-3.2",
            "Name:EnemyOther4,InitX:-3.15",
        });
        EnemyData.Add(4.65f, new string[]
        {
            "Name:EnemyOther3,InitX:-2.2",
            "Name:EnemyOther4,InitX:-2.15",
        });
        EnemyData.Add(4.7f, new string[]
        {
            "Name:EnemyOther3,InitX:-2.2",
            "Name:EnemyOther4,InitX:-2.15",
            "Name:EnemyOther2,InitX:1,MoveTargetY:5",
        });
        EnemyData.Add(4.75f, new string[]
        {
            "Name:EnemyOther3,InitX:-2.2",
            "Name:EnemyOther4,InitX:-2.15",
        });
        EnemyData.Add(4.9f, new string[]
        {
            "Name:Enemy07,InitX:2,MoveTargetY:4.5",
        });
        EnemyData.Add(5.1f, new string[]
        {
            "Name:Enemy07,InitX:-0.5,MoveTargetY:4",
        });




        EnemyData.Add(6f, new string[]
        {
            "Name:Enemy14,InitX:0",
            "Name:Enemy15,InitX:1",
        });
        EnemyData.Add(6.05f, new string[]
        {
            "Name:Enemy14,InitX:2",
            "Name:Enemy15,InitX:2.5",
        });
        EnemyData.Add(6.1f, new string[]
        {
            "Name:Enemy14,InitX:-1.5",
            "Name:Enemy15,InitX:-2",
        });
        EnemyData.Add(6.12f, new string[]
        {
            "Name:Enemy01_0,InitX:0,MoveTargetY:5,MoveTime:0.2",
            "Name:Enemy01_0,InitX:1,MoveTargetY:5,MoveTime:0.2",
            "Name:Enemy01_0,InitX:2,MoveTargetY:5,MoveTime:0.2",
            "Name:Enemy01_1,InitX:1,MoveTargetY:4.5,MoveTime:0.2",
            "Name:Enemy01_1,InitX:2,MoveTargetY:4.5,MoveTime:0.2",
            "Name:Enemy01_1,InitX:3,MoveTargetY:5,MoveTime:0.2",
        });
        EnemyData.Add(6.2f, new string[]
        {
            "Name:Enemy17,InitX:-2.5,MoveTargetY:5",
        });
        EnemyData.Add(7.0f, new string[]
        {
            "Name:Enemy16,InitX:-2.5",
            "Name:Enemy16,InitX:-3",
            "Name:Enemy16,InitX:-0.2",
            "Name:Enemy16,InitX:-1.2",
        });
        EnemyData.Add(7.8f, new string[]
        {
            "Name:EnemyOther5,InitX:0",
            "Name:EnemyOther5,InitX:-1.8",
            "Name:Enemy12,InitX:1",
        });
        EnemyData.Add(7.85f, new string[]
        {
            "Name:EnemyOther5,InitX:0",
            "Name:EnemyOther5,InitX:-1.8",
        });
        EnemyData.Add(7.9f, new string[]
        {
            "Name:EnemyOther5,InitX:0",
            "Name:EnemyOther5,InitX:-1.8",
        });
        EnemyData.Add(8.1f, new string[]
        {
            "Name:EnemyOther5,InitX:0",
            "Name:EnemyOther5,InitX:-1.8",
        });
        EnemyData.Add(8.3f, new string[]
        {
            "Name:EnemyOther5,InitX:0",
            "Name:EnemyOther5,InitX:-1.8",
            "Name:Enemy01_1,InitX:2.5,MoveTargetY:5,MoveTime:0.3",
        });
        EnemyData.Add(8.5f, new string[]
        {
            "Name:EnemyOther5,InitX:0",
            "Name:EnemyOther5,InitX:-1.8",
            "Name:Enemy01_0,InitX:2,MoveTargetY:5,MoveTime:0.3",
        });
        EnemyData.Add(8.7f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:-1.8",
        });
        EnemyData.Add(8.9f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:-1.8",
        });
        EnemyData.Add(9f, new string[]
        {
            "Name:Enemy14,InitX:3",
            "Name:Enemy15,InitX:-3",
        });
        EnemyData.Add(9.05f, new string[]
        {
            "Name:Enemy14,InitX:2",
            "Name:Enemy15,InitX:2.5",
        });
        EnemyData.Add(9.1f, new string[]
        {
            "Name:Enemy14,InitX:-1.5",
            "Name:Enemy15,InitX:-2",
        });
        EnemyData.Add(9.2f, new string[]
        {
            "Name:Enemy12,InitX:0.5",
            "Name:Enemy17,InitX:-0.5,MoveTargetY:5",
        });
        EnemyData.Add(9.3f, new string[]
        {
            "Name:Enemy16,InitX:0",
        });
        EnemyData.Add(9.4f, new string[]
        {
            "Name:Enemy16,InitX:0",
        });
        EnemyData.Add(9.5f, new string[]
        {
            "Name:Enemy16,InitX:0",
            "Name:EnemyOther6,InitX:3.1,MoveTargetY:4",
        });
        EnemyData.Add(9.7f, new string[]
        {
            "Name:EnemyOther6,InitX:-2.5,MoveTargetY:3",
        });
        EnemyData.Add(9.8f, new string[]
        {
            "Name:EnemyOther5,InitX:-0.5",
            "Name:EnemyOther5,InitX:0.5",
        });
        EnemyData.Add(9.85f, new string[]
        {
            "Name:EnemyOther5,InitX:-0.5",
            "Name:EnemyOther5,InitX:0.5",
        });
        EnemyData.Add(10f, new string[]
        {
            "Name:Enemy12,InitX:-3.1",
        });
        EnemyData.Add(10.4f, new string[]
        {
            "Name:Enemy12,InitX:3,MoveTargetY:5",
            "Name:Enemy12,InitX:-2,MoveTargetY:5",
        });
        EnemyData.Add(10.7f, new string[]
        {
            "Name:Enemy17,InitX:1,MoveTargetY:5",
            "Name:Enemy17,InitX:-1,MoveTargetY:5",
        });






        EnemyData.Add(11f, new string[]
        {
            "Name:Enemy01_0,InitX:0,MoveTargetY:1,MoveTime:1",
            "Name:Enemy01_1,InitX:1,MoveTargetY:1,MoveTime:1",
            "Name:Enemy01_1,InitX:2,MoveTargetY:1,MoveTime:1",
            "Name:Enemy01_0,InitX:3,MoveTargetY:1,MoveTime:1",
        });
        EnemyData.Add(11.2f, new string[]
        {
            "Name:Enemy01_0,InitX:0,MoveTargetY:2,MoveTime:0.7",
            "Name:Enemy01_0,InitX:-1,MoveTargetY:2,MoveTime:0.7",
            "Name:Enemy01_1,InitX:-2,MoveTargetY:2,MoveTime:0.7",
            "Name:Enemy01_1,InitX:-3,MoveTargetY:2,MoveTime:0.7",
        });
        EnemyData.Add(11.4f, new string[]
        {
            "Name:Enemy01_0,InitX:0,MoveTargetY:3",
            "Name:Enemy01_1,InitX:1,MoveTargetY:3",
            "Name:Enemy01_1,InitX:2,MoveTargetY:3",
            "Name:Enemy01_0,InitX:-1,MoveTargetY:3",
            "Name:Enemy01_1,InitX:-2,MoveTargetY:3",
        });
        EnemyData.Add(12f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:0.5",
            "Name:Enemy02,InitX:-2",
        });
        EnemyData.Add(12.4f, new string[]
        {
            "Name:Enemy05,InitX:-3,MoveTargetY:4",
        });
        EnemyData.Add(12.6f, new string[]
        {
            "Name:EnemyOther0,InitX:-3.5",
            "Name:EnemyOther0,InitX:3.5",
        });
        EnemyData.Add(12.7f, new string[]
        {
            "Name:EnemyOther1,InitX:-2.5",
            "Name:EnemyOther1,InitX:2.5",
        });
        EnemyData.Add(13.0f, new string[]
        {
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
        });
        EnemyData.Add(13.1f, new string[]
        {
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
        });
        EnemyData.Add(13.2f, new string[]
        {
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
        });
        EnemyData.Add(13.3f, new string[]
        {
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
        });
        EnemyData.Add(13.5f, new string[]
        {
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
        });
        EnemyData.Add(13.8f, new string[]
        {
            "Name:Enemy05,InitX:3,MoveTargetY:4",
        });
        EnemyData.Add(14.0f, new string[]
        {
            "Name:Enemy05,InitX:3,MoveTargetY:2,MoveTime:0.7",
        });
        EnemyData.Add(14.3f, new string[]
        {
            "Name:Enemy02,InitX:-3.3",
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:3.3",
        });
        EnemyData.Add(14.6f, new string[]
        {
            "Name:Enemy05,InitX:0",
            "Name:Enemy01_1,InitX:2.8,MoveTargetY:3",
            "Name:Enemy01_0,InitX:3.2,MoveTargetY:3",
        });
        EnemyData.Add(14.8f, new string[]
        {
            "Name:Enemy02,InitX:2.8",
            "Name:Enemy02,InitX:3.2",
        });
        EnemyData.Add(15f, new string[]
        {
            "Name:Enemy02,InitX:-2.8",
            "Name:Enemy02,InitX:-3.2",
        });
        EnemyData.Add(15.3f, new string[]
        {
            "Name:Enemy18,InitX:-2.6",
        });
        EnemyData.Add(15.8f, new string[]
        {
            "Name:Enemy05,InitX:-1,MoveTargetY:4",
            "Name:Enemy05,InitX:1,MoveTargetY:4",
        });
        EnemyData.Add(16.0f, new string[]
        {
            "Name:Enemy05,InitX:-1,MoveTargetY:2,MoveTime:0.7",
            "Name:Enemy05,InitX:1,MoveTargetY:2,MoveTime:0.7",
        });




        EnemyData.Add(16.5f, new string[]
        {
            "Name:EnemyOther3,InitX:-3.2",
            "Name:EnemyOther4,InitX:-3.15",
        });
        EnemyData.Add(16.55f, new string[]
        {
            "Name:EnemyOther3,InitX:-3.2",
            "Name:EnemyOther4,InitX:-3.15",
        });
        EnemyData.Add(16.6f, new string[]
        {
            "Name:EnemyOther3,InitX:-3.2",
            "Name:EnemyOther4,InitX:-3.15",
        });
        EnemyData.Add(16.65f, new string[]
        {
            "Name:EnemyOther3,InitX:-2.2",
            "Name:EnemyOther4,InitX:-2.15",
        });
        EnemyData.Add(16.7f, new string[]
        {
            "Name:EnemyOther3,InitX:-2.2",
            "Name:EnemyOther4,InitX:-2.15",
            "Name:EnemyOther2,InitX:1,MoveTargetY:5",
        });
        EnemyData.Add(16.75f, new string[]
        {
            "Name:EnemyOther3,InitX:-2.2",
            "Name:EnemyOther4,InitX:-2.15",
        });
        EnemyData.Add(16.9f, new string[]
        {
            "Name:Enemy07,InitX:-0.5,MoveTargetY:4",
        });
        EnemyData.Add(17f, new string[]
        {
            "Name:Enemy14,InitX:0",
            "Name:Enemy15,InitX:1",
        });
        EnemyData.Add(17.05f, new string[]
        {
            "Name:Enemy14,InitX:2",
            "Name:Enemy15,InitX:2.5",
        });
        EnemyData.Add(17.1f, new string[]
        {
            "Name:Enemy14,InitX:-1.5",
            "Name:Enemy15,InitX:-2",
        });
        EnemyData.Add(17.12f, new string[]
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
        EnemyData.Add(18.8f, new string[]
        {
            "Name:EnemyOther5,InitX:0",
            "Name:EnemyOther5,InitX:-1.8",
            "Name:Enemy12,InitX:1",
        });
        EnemyData.Add(18.85f, new string[]
        {
            "Name:EnemyOther5,InitX:0",
            "Name:EnemyOther5,InitX:-1.8",
        });
        EnemyData.Add(18.9f, new string[]
        {
            "Name:EnemyOther5,InitX:0",
            "Name:EnemyOther5,InitX:-1.8",
        });
        EnemyData.Add(19.1f, new string[]
        {
            "Name:EnemyOther5,InitX:0",
            "Name:EnemyOther5,InitX:-1.8",
        });
        EnemyData.Add(19.3f, new string[]
        {
            "Name:EnemyOther5,InitX:0",
            "Name:EnemyOther5,InitX:-1.8",
            "Name:Enemy01_1,InitX:2.5,MoveTargetY:5,MoveTime:0.3",
        });
        EnemyData.Add(19.5f, new string[]
        {
            "Name:EnemyOther5,InitX:0",
            "Name:EnemyOther5,InitX:-1.8",
            "Name:Enemy01_0,InitX:2,MoveTargetY:5,MoveTime:0.3",
        });
        EnemyData.Add(19.7f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:-1.8",
        });
        EnemyData.Add(19.9f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:-1.8",
        });
        EnemyData.Add(20f, new string[]
        {
            "Name:Enemy14,InitX:3",
            "Name:Enemy15,InitX:-3",
        });
        EnemyData.Add(20.05f, new string[]
        {
            "Name:Enemy14,InitX:2",
            "Name:Enemy15,InitX:2.5",
        });
        EnemyData.Add(20.1f, new string[]
        {
            "Name:Enemy14,InitX:-1.5",
            "Name:Enemy15,InitX:-2",
        });
        EnemyData.Add(20.2f, new string[]
        {
            "Name:Enemy12,InitX:0.5",
            "Name:Enemy17,InitX:-0.5,MoveTargetY:5",
        });
        EnemyData.Add(20.3f, new string[]
        {
            "Name:Enemy16,InitX:0",
        });
        EnemyData.Add(20.4f, new string[]
        {
            "Name:Enemy16,InitX:0",
        });
        EnemyData.Add(20.5f, new string[]
        {
            "Name:Enemy16,InitX:0",
            "Name:EnemyOther6,InitX:3.1,MoveTargetY:4",
        });
        EnemyData.Add(20.7f, new string[]
        {
            "Name:EnemyOther6,InitX:-2.5,MoveTargetY:3",
        });
        EnemyData.Add(20.8f, new string[]
        {
            "Name:EnemyOther5,InitX:-0.5",
            "Name:EnemyOther5,InitX:0.5",
        });
        EnemyData.Add(20.85f, new string[]
        {
            "Name:EnemyOther5,InitX:-0.5",
            "Name:EnemyOther5,InitX:0.5",
        });
        EnemyData.Add(21f, new string[]
        {
            "Name:Enemy12,InitX:-3.1",
        });
        EnemyData.Add(24f, new string[] { "IsBoss:1" });
        EnemyData.Add(26f, new string[] { "Name:Enemy10,InitX:0" });
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
