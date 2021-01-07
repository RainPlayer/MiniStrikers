using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blast : MonoBehaviour
{
    enum BlastStatus
    {
        Init,
        Playing,
        Pause,
    }

    Animator BlastAnim;
    BlastStatus Status;

    private void Awake()
    {
        BlastAnim = GetComponent<Animator>();
        BlastAnim.speed = 0f;
        
        Status = BlastStatus.Init;
    }

    // Start is called before the first frame update
    void Start()
    {
        Constant.ObjectIsPlayingSound(this);
		
    }

    // Update is called once per frame
    void Update()
    {
        if (Constant.GameIsPause)
        {
            if (transform.parent.name != "HideLayer")
            {
                BlastAnim.speed = 0f;
                Status = BlastStatus.Pause;
            }

            return;
        }

        if (BlastAnim.speed == 0f && Status == BlastStatus.Pause)
        {
            BlastAnim.speed = 1f;
            Status = BlastStatus.Playing;
        }
        
    }

    public void OnBlastFinish()
    {
        Destroy(gameObject);
    }

    public void Play()
    {
        BlastAnim.speed = 1f;
        Status = BlastStatus.Playing;

    }

}
