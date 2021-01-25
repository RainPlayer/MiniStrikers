using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage04 : MonoBehaviour
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
            "Name:Enemy01_0,InitX:-1,MoveTargetY:4.5",
            "Name:Enemy01_0,InitX:0,MoveTargetY:4.5",
            "Name:Enemy01_1,InitX:1,MoveTargetY:4.5",
            "Name:Enemy01_1,InitX:2,MoveTargetY:4.5",
        });
        EnemyData.Add(2.6f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy03,InitX:3.2",
        });
        EnemyData.Add(2.65f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy03,InitX:3.2",
        });
        EnemyData.Add(2.7f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy03,InitX:3.2",
        });
        EnemyData.Add(2.75f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy03,InitX:3.2",
            "Name:Enemy09,InitX:-2.7",
        });
        EnemyData.Add(2.8f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy03,InitX:3.2",
        });
        EnemyData.Add(2.85f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy03,InitX:3.2",
        });
        EnemyData.Add(3f, new string[]
        {
            "Name:Enemy06,InitX:3",
        });
        EnemyData.Add(3.2f, new string[]
        {
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
        });
        EnemyData.Add(3.3f, new string[]
        {
            "Name:Enemy05,InitX:-3,MoveTargetY:4",
            "Name:Enemy06,InitX:2,MoveTime:2.5",
        });
        EnemyData.Add(3.5f, new string[]
        {
            "Name:Enemy09,InitX:1,MoveTargetY:1,MoveTime:1",
            "Name:Enemy09,InitX:2,MoveTargetY:1,MoveTime:1",
        });
        EnemyData.Add(3.7f, new string[]
        {
            "Name:Enemy09,InitX:0,MoveTargetY:2,MoveTime:0.7",
            "Name:Enemy09,InitX:-1,MoveTargetY:2,MoveTime:0.7",
        });
        EnemyData.Add(3.9f, new string[]
        {
            "Name:Enemy09,InitX:-2,MoveTargetY:3",
            "Name:Enemy09,InitX:-3,MoveTargetY:3",
        });
        EnemyData.Add(3.95f, new string[]
        {
            "Name:Enemy14,InitX:2",
            "Name:Enemy15,InitX:2.5",
        });
        EnemyData.Add(4f, new string[]
        {
            "Name:Enemy14,InitX:0",
            "Name:Enemy15,InitX:1",
        });
        EnemyData.Add(4.1f, new string[]
        {
            "Name:Enemy14,InitX:-1.5",
            "Name:Enemy15,InitX:-2",
        });
        EnemyData.Add(4.5f, new string[]
        {
            "Name:Enemy04,InitX:-3.2,MoveTargetY:4",
            "Name:Enemy04,InitX:-3.15,MoveTargetY:4",
        });
        EnemyData.Add(4.55f, new string[]
        {
            "Name:Enemy04,InitX:-3.2,MoveTargetY:3",
            "Name:Enemy04,InitX:-3.15,MoveTargetY:3",
        });
        EnemyData.Add(4.7f, new string[]
        {
            "Name:Enemy06,InitX:-1,MoveTime:2",
        });
        EnemyData.Add(4.75f, new string[]
        {
            "Name:EnemyOther7,InitX:-2.15,MoveTargetY:5",
        });
        EnemyData.Add(4.9f, new string[]
        {
            "Name:Enemy05,InitX:2,MoveTargetY:4.5",
        });
        EnemyData.Add(4.95f, new string[]
        {
            "Name:Enemy06,InitX:-3,MoveTime:2",
        });
        EnemyData.Add(5f, new string[]
        {
            "Name:Enemy14,InitX:-1.5",
            "Name:Enemy15,InitX:-2",
            
        });
        EnemyData.Add(5.05f, new string[]
        {
            "Name:Enemy14,InitX:2",
            "Name:Enemy15,InitX:2.5",
        });
        EnemyData.Add(5.1f, new string[]
        {
            "Name:Enemy14,InitX:0",
            "Name:Enemy15,InitX:1",
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
            "Name:EnemyOther7,InitX:3,MoveTargetY:5",
        });
        EnemyData.Add(5.5f, new string[]
        {
            "Name:Enemy09,InitX:-1,MoveTargetY:4",
            "Name:Enemy09,InitX:1,MoveTargetY:4",
        });
        EnemyData.Add(5.8f, new string[]
        {
            "Name:Enemy06,InitX:-3,MoveTime:2",
        });
        EnemyData.Add(6f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy06,InitX:-1.5,MoveTime:2.8",
        });
        EnemyData.Add(6.2f, new string[]
        {
            "Name:Enemy09,InitX:-2.5,MoveTargetY:4.5",
        });
        EnemyData.Add(6.5f, new string[]
        {
            "Name:Enemy01_0,InitX:-1,MoveTargetY:4",
            "Name:Enemy01_1,InitX:-1.5,MoveTargetY:4",
            "Name:Enemy01_0,InitX:-2,MoveTargetY:4",
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
            "Name:Enemy09,InitX:1,MoveTargetY:4.5",
        });
        EnemyData.Add(7.6f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy04,InitX:3.2",
        });
        EnemyData.Add(7.65f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy04,InitX:3.2",
        });
        EnemyData.Add(7.7f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy04,InitX:3.2",
        });
        EnemyData.Add(7.75f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy04,InitX:3.2",
            "Name:Enemy05,InitX:-2.7,MoveTargetY:5.2",
        });
        EnemyData.Add(7.8f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy04,InitX:3.2",
        });
        EnemyData.Add(7.85f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy04,InitX:3.2",
        });
        EnemyData.Add(7.9f, new string[]
        {
            "Name:Enemy03,InitX:-3.2",
            "Name:Enemy04,InitX:3.2",
        });
        EnemyData.Add(8f, new string[]
        {
            "Name:Enemy06,InitX:3",
        });
        EnemyData.Add(8.1f, new string[]
        {
            "Name:Enemy14,InitX:0",
            "Name:Enemy15,InitX:1",
        });
        EnemyData.Add(8.15f, new string[]
        {
            "Name:Enemy14,InitX:2",
            "Name:Enemy15,InitX:2.5",
        });
        EnemyData.Add(8.2f, new string[]
        {
            "Name:Enemy14,InitX:-1.5",
            "Name:Enemy15,InitX:-2",
        });
        EnemyData.Add(8.5f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-0.5",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
        });
        EnemyData.Add(8.55f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-0.5",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
        });
        EnemyData.Add(8.6f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-0.5",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
        });
        EnemyData.Add(8.65f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-0.5",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
        });
        EnemyData.Add(8.7f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-0.5",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
        });
        EnemyData.Add(8.75f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-0.5",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
        });
        EnemyData.Add(8.8f, new string[]
        {
            "Name:Enemy02,InitX:0",
            "Name:Enemy02,InitX:1",
            "Name:Enemy02,InitX:2",
            "Name:Enemy02,InitX:-0.5",
            "Name:Enemy02,InitX:-1",
            "Name:Enemy02,InitX:-1.5",
        });
        EnemyData.Add(23f, new string[] { "IsBoss:1" });
        EnemyData.Add(25f, new string[] { "Name:Enemy24,InitX:0" });
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
