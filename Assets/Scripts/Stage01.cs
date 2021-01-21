using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage01 : MonoBehaviour
{
    public IDictionary<float, string[]> EnemyData;

    private void Awake()
    {
        EnemyData = new Dictionary<float, string[]>();
        EnemyData.Add(1f, new string[] { "Name:Enemy01_0,InitX:-2,MoveTargetY:2.5", "Name:Enemy01_1,InitX:0,MoveTargetY:3.5" });
        EnemyData.Add(3.5f, new string[] { "Name:Enemy02,InitX:1" });
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
