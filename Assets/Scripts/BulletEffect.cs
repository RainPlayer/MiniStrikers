using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEffect : MonoBehaviour
{
    enum BulletEffectStatus
    {
        Init,
        Playing,
        Pause,
    }

    Animator BulletEffectAnim;
    BulletEffectStatus Status;

    private void Awake()
    {
        BulletEffectAnim = GetComponent<Animator>();
        BulletEffectAnim.speed = 0f;
        
        Status = BulletEffectStatus.Init;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Constant.GameIsPause)
        {
            if (transform.parent.name != "HideLayer")
            {
                BulletEffectAnim.speed = 0f;
                Status = BulletEffectStatus.Pause;
            }

            return;
        }

        if (BulletEffectAnim.speed == 0f && Status == BulletEffectStatus.Pause)
        {
            BulletEffectAnim.speed = 1f;
            Status = BulletEffectStatus.Playing;
        }
        
    }

    public void OnBulletEffectFinish()
    {
        Destroy(gameObject);
    }

    public void Play()
    {
        BulletEffectAnim.speed = 1f;
        Status = BulletEffectStatus.Playing;

    }

}
