using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
		Constant.ObjectIsPlayingSound(this);
		
        Transform bullet = transform.Find("Bullet03");

        float r = FHUtility.Angle360(Vector2.zero, new Vector2(-100, 0));

        bullet.Rotate(0, 0, r + 90f);

    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
