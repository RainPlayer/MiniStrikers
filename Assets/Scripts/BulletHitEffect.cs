using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHitEffect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ParticleSystem bullet_hit_effect_s = GetComponent<ParticleSystem>();
        if (Constant.GameIsPause)
        {
            if(bullet_hit_effect_s.isPlaying)
            {
                bullet_hit_effect_s.Pause();
            }
            
            return;
        }

        if (bullet_hit_effect_s.isPaused)
        {
            bullet_hit_effect_s.Play();
        }

    }
}
