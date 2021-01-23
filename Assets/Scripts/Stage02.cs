using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage02 : MonoBehaviour
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
            "Name:Enemy07,InitX:-2.7",
        });
        EnemyData.Add(3.2f, new string[]
        {
            "Name:EnemyOther2,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
        });
        EnemyData.Add(3.3f, new string[]
        {
            "Name:Enemy06,InitX:2,MoveTime:2.5",
        });
        EnemyData.Add(3.5f, new string[]
        {
            "Name:Enemy09,InitX:1,MoveTargetY:1,MoveTime:1",
        });
        EnemyData.Add(3.7f, new string[]
        {
            "Name:Enemy09,InitX:0,MoveTargetY:2,MoveTime:0.7",
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
        EnemyData.Add(5.15f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
            "Name:Enemy02,InitX:-2",
        });
        EnemyData.Add(5.2f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
            "Name:Enemy02,InitX:-2",
        });
        EnemyData.Add(5.25f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
            "Name:Enemy02,InitX:-2",
        });
        EnemyData.Add(5.3f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
            "Name:Enemy02,InitX:-2",
            "Name:EnemyOther2,InitX:3,MoveTargetY:5",
        });
        EnemyData.Add(5.5f, new string[]
        {
            "Name:EnemyOther2,InitX:-1,MoveTargetY:4",
            "Name:EnemyOther2,InitX:-1.5,MoveTargetY:4",
            "Name:EnemyOther2,InitX:-2,MoveTargetY:4",
        });
        EnemyData.Add(6f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
        });
        EnemyData.Add(6.5f, new string[]
        {
            "Name:EnemyOther2,InitX:-1,MoveTargetY:4",
            "Name:EnemyOther2,InitX:-1.5,MoveTargetY:4",
            "Name:EnemyOther2,InitX:-2,MoveTargetY:4",
        });
        EnemyData.Add(7f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-0.5",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
        });
        EnemyData.Add(7.2f, new string[]
        {
            "Name:Enemy08,InitX:1,MoveTargetY:4.5",
        });
        EnemyData.Add(7.6f, new string[]
        {
            "Name:EnemyOther3,InitX:-3.2",
            "Name:EnemyOther4,InitX:3.2",
        });
        EnemyData.Add(7.65f, new string[]
        {
            "Name:EnemyOther3,InitX:-3.2",
            "Name:EnemyOther4,InitX:3.2",
        });
        EnemyData.Add(7.7f, new string[]
        {
            "Name:EnemyOther3,InitX:-3.2",
            "Name:EnemyOther4,InitX:3.2",
        });
        EnemyData.Add(7.75f, new string[]
        {
            "Name:EnemyOther3,InitX:-3.2",
            "Name:EnemyOther4,InitX:3.2",
            "Name:Enemy07,InitX:-2.7",
        });
        EnemyData.Add(7.8f, new string[]
        {
            "Name:EnemyOther3,InitX:-3.2",
            "Name:EnemyOther4,InitX:3.2",
        });
        EnemyData.Add(7.85f, new string[]
        {
            "Name:EnemyOther3,InitX:-3.2",
            "Name:EnemyOther4,InitX:3.2",
        });
        EnemyData.Add(7.9f, new string[]
        {
            "Name:EnemyOther3,InitX:-3.2",
            "Name:EnemyOther4,InitX:3.2",
        });
        EnemyData.Add(8.2f, new string[]
        {
            "Name:EnemyOther2,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
        });
        EnemyData.Add(8.5f, new string[]
        {
            "Name:Enemy09,InitX:2,MoveTargetY:1,MoveTime:1",
        });
        EnemyData.Add(8.7f, new string[]
        {
            "Name:Enemy09,InitX:0,MoveTargetY:2,MoveTime:0.7",
        });
        EnemyData.Add(9.3f, new string[]
        {
            "Name:Enemy07,InitX:1.2,MoveTargetY:3",
        });
        EnemyData.Add(9.5f, new string[]
        {
            "Name:EnemyOther3,InitX:-3.2",
            "Name:EnemyOther4,InitX:-3.15",
        });
        EnemyData.Add(9.55f, new string[]
        {
            "Name:EnemyOther3,InitX:-3.2",
            "Name:EnemyOther4,InitX:-3.15",
        });
        EnemyData.Add(9.6f, new string[]
        {
            "Name:EnemyOther3,InitX:-3.2",
            "Name:EnemyOther4,InitX:-3.15",
        });
        EnemyData.Add(9.65f, new string[]
        {
            "Name:EnemyOther3,InitX:-2.2",
            "Name:EnemyOther4,InitX:-2.15",
        });
        EnemyData.Add(9.7f, new string[]
        {
            "Name:EnemyOther3,InitX:-2.2",
            "Name:EnemyOther4,InitX:-2.15",
            "Name:EnemyOther2,InitX:1,MoveTargetY:5",
        });
        EnemyData.Add(9.75f, new string[]
        {
            "Name:EnemyOther3,InitX:-2.2",
            "Name:EnemyOther4,InitX:-2.15",
        });
        EnemyData.Add(9.9f, new string[]
        {
            "Name:Enemy07,InitX:2,MoveTargetY:4.5",
        });
        EnemyData.Add(10.15f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
            "Name:Enemy02,InitX:-2",
        });
        EnemyData.Add(10.2f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
            "Name:Enemy02,InitX:-2",
        });
        EnemyData.Add(10.25f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
            "Name:Enemy02,InitX:-2",
        });
        EnemyData.Add(10.3f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
            "Name:Enemy02,InitX:-2",
            "Name:EnemyOther2,InitX:3,MoveTargetY:5",
        });
        EnemyData.Add(10.5f, new string[]
        {
            "Name:EnemyOther2,InitX:-1,MoveTargetY:4.5",
            "Name:EnemyOther2,InitX:-1.5,MoveTargetY:4.5",
            "Name:EnemyOther2,InitX:-2,MoveTargetY:4.5",
        });
        EnemyData.Add(10.8f, new string[]
        {
            "Name:Enemy06,InitX:-3,MoveTime:2",
        });
        EnemyData.Add(11f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
        });
        EnemyData.Add(11.5f, new string[]
        {
            "Name:EnemyOther2,InitX:-1,MoveTargetY:4",
            "Name:EnemyOther2,InitX:-1.5,MoveTargetY:4",
            "Name:EnemyOther2,InitX:-2,MoveTargetY:4",
        });
        EnemyData.Add(12f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-0.5",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
        });
        EnemyData.Add(12.2f, new string[]
        {
            "Name:Enemy08,InitX:3,MoveTargetY:5",
        });
        EnemyData.Add(12.6f, new string[]
        {
            "Name:EnemyOther3,InitX:-3.2",
            "Name:EnemyOther4,InitX:3.2",
        });
        EnemyData.Add(12.65f, new string[]
        {
            "Name:EnemyOther3,InitX:-3.2",
            "Name:EnemyOther4,InitX:3.2",
        });
        EnemyData.Add(12.7f, new string[]
        {
            "Name:EnemyOther3,InitX:-3.2",
            "Name:EnemyOther4,InitX:3.2",
        });
        EnemyData.Add(12.75f, new string[]
        {
            "Name:EnemyOther3,InitX:-3.2",
            "Name:EnemyOther4,InitX:3.2",
            "Name:Enemy07,InitX:-2.7",
        });
        EnemyData.Add(12.8f, new string[]
        {
            "Name:EnemyOther3,InitX:-3.2",
            "Name:EnemyOther4,InitX:3.2",
        });
        EnemyData.Add(12.85f, new string[]
        {
            "Name:EnemyOther3,InitX:-3.2",
            "Name:EnemyOther4,InitX:3.2",
        });
        EnemyData.Add(12.9f, new string[]
        {
            "Name:EnemyOther3,InitX:-3.2",
            "Name:EnemyOther4,InitX:3.2",
        });
        EnemyData.Add(13.2f, new string[]
        {
            "Name:EnemyOther2,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
        });
        EnemyData.Add(13.3f, new string[]
        {
            "Name:Enemy06,InitX:2,MoveTime:2.5",
        });
        EnemyData.Add(13.5f, new string[]
        {
            "Name:Enemy09,InitX:1,MoveTargetY:1,MoveTime:1",
        });
        EnemyData.Add(13.7f, new string[]
        {
            "Name:Enemy09,InitX:-1,MoveTargetY:2,MoveTime:0.7",
        });
        EnemyData.Add(14.3f, new string[]
        {
            "Name:Enemy07,InitX:1.2,MoveTargetY:3",
        });
        EnemyData.Add(14.5f, new string[]
        {
            "Name:EnemyOther3,InitX:-3.2",
            "Name:EnemyOther4,InitX:-3.15",
        });
        EnemyData.Add(14.55f, new string[]
        {
            "Name:EnemyOther3,InitX:-3.2",
            "Name:EnemyOther4,InitX:-3.15",
        });
        EnemyData.Add(14.6f, new string[]
        {
            "Name:EnemyOther3,InitX:-3.2",
            "Name:EnemyOther4,InitX:-3.15",
        });
        EnemyData.Add(14.65f, new string[]
        {
            "Name:EnemyOther3,InitX:-2.2",
            "Name:EnemyOther4,InitX:-2.15",
        });
        EnemyData.Add(14.7f, new string[]
        {
            "Name:EnemyOther3,InitX:-2.2",
            "Name:EnemyOther4,InitX:-2.15",
            "Name:EnemyOther2,InitX:1,MoveTargetY:5",
        });
        EnemyData.Add(14.75f, new string[]
        {
            "Name:EnemyOther3,InitX:-2.2",
            "Name:EnemyOther4,InitX:-2.15",
        });
        EnemyData.Add(15.1f, new string[]
        {
            "Name:Enemy07,InitX:-0.5,MoveTargetY:4",
        });
        EnemyData.Add(15.15f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
            "Name:Enemy02,InitX:-2",
        });
        EnemyData.Add(15.2f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
            "Name:Enemy02,InitX:-2",
        });
        EnemyData.Add(15.25f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
            "Name:Enemy02,InitX:-2",
        });
        EnemyData.Add(15.3f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
            "Name:Enemy02,InitX:-2",
            "Name:EnemyOther2,InitX:3,MoveTargetY:5",
        });
        EnemyData.Add(15.5f, new string[]
        {
            "Name:EnemyOther2,InitX:-1,MoveTargetY:5",
            "Name:EnemyOther2,InitX:-1.5,MoveTargetY:5",
            "Name:EnemyOther2,InitX:-2,MoveTargetY:5",
        });
        EnemyData.Add(15.8f, new string[]
        {
            "Name:Enemy06,InitX:-3,MoveTime:2",
        });
        EnemyData.Add(16f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy06,InitX:-1.5,MoveTime:2.8",
        });
        EnemyData.Add(16.2f, new string[]
        {
            "Name:Enemy08,InitX:3,MoveTargetY:5",
        });
        EnemyData.Add(16.5f, new string[]
        {
            "Name:EnemyOther2,InitX:-1,MoveTargetY:4",
            "Name:EnemyOther2,InitX:-1.5,MoveTargetY:4",
            "Name:EnemyOther2,InitX:-2,MoveTargetY:4",
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
        EnemyData.Add(17.5f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-0.5",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
        });
        EnemyData.Add(18f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-0.5",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
        });
        EnemyData.Add(18.5f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-0.5",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
        });
        EnemyData.Add(19f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-0.5",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
        });
        EnemyData.Add(19.5f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-0.5",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
        });
        EnemyData.Add(20f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-0.5",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
        });
        EnemyData.Add(20.3f, new string[]
        {
            "Name:Enemy06,InitX:-3,MoveTime:2",
        });
        EnemyData.Add(20.4f, new string[]
        {
            "Name:Enemy09,InitX:-2,MoveTargetY:3",
            "Name:Enemy09,InitX:0,MoveTargetY:4",
            "Name:Enemy09,InitX:2,MoveTargetY:5",
        });
        EnemyData.Add(20.5f, new string[]
        {
            "Name:Enemy08,InitX:-2.5,MoveTargetY:4.5",
        });
        EnemyData.Add(24f, new string[] { "IsBoss:1" });
        EnemyData.Add(26f, new string[] { "Name:Enemy22,InitX:0" });
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
