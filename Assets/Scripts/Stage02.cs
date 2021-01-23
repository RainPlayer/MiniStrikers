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
        });
        EnemyData.Add(2.2f, new string[]
        {
            "Name:Enemy08,InitX:3,MoveTargetY:5",
            "Name:Enemy08,InitX:-2.5,MoveTargetY:4.5",
            "Name:Enemy08,InitX:1,MoveTargetY:4.5",
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
