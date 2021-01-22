using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage07 : MonoBehaviour
{
    public IDictionary<float, string[]> EnemyData;

    private void Awake()
    {
        EnemyData = new Dictionary<float, string[]>();

        EnemyData.Add(8f, new string[] { "IsBoss:1" });
        //EnemyData.Add(10f, new string[] { "Name:Enemy22,InitX:0" });
        EnemyData.Add(10f, new string[] { "Name:Enemy02,InitX:1" });
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
