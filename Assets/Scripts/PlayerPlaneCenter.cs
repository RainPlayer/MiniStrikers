using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class PlayerPlaneCenter : MonoBehaviour
{
    Collider2D CollisionObject = null; //确保一个Bullet Sprite对应一个爆炸Sprite

    public bool IsAlive = true; //是否活着
    public bool IsForce = false; //无敌状态
    float ForceTime = 3f; //无敌时间，秒
    bool PrevIsForce = false; //上一帧是否为无敌状态
    float NextForceTime = 0f;
    float ForceAnimIntervalTime = 0.15f; //无敌状态闪烁的时间间隔

    Animator PlaneCenterAnimator;

    private void Awake()
    {
        //DOTween.Init(true, true, LogBehaviour.Verbose).SetCapacity(200, 10);
    }

    // Start is called before the first frame update
    void Start()
    {
		Constant.ObjectIsPlayingSound(this);
        
        PlaneCenterAnimator = GetComponent<Animator>();

        if (transform.parent.parent.name == "HideLayer")
        {
            PlaneCenterAnimator.speed = 0f;
            return;
        }

        //出场的时候进入一下无敌状态
        IsForce = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.parent.parent.name == "HideLayer") return;

        if (Constant.GameIsPause)
        {
            PlaneCenterAnimator.speed = 0f;
            return;
        }

        if (PlaneCenterAnimator.speed == 0f)
        {
            PlaneCenterAnimator.speed = 1f;
        }

        //无敌状态的处理
        if (IsForce)
        {
            if (!PrevIsForce)
            {
                StartCoroutine(ForceDisable());
                PrevIsForce = true;
            }

            if (Time.time > NextForceTime)
            {
                if (transform.parent.localScale.x != 0f)
                {
                    transform.parent.localScale = new Vector3(0f, 0f, 1f);
                }
                else
                {
                    transform.parent.localScale = Vector3.one;
                }

                NextForceTime = Time.time + ForceAnimIntervalTime;
            }
        }
        else if(!IsForce && transform.parent.localScale.x == 0f)
        {
            transform.parent.localScale = Vector3.one;
        }
        //无敌状态的处理 end

        if (CollisionObject != null)
        {
            //爆炸效果对象相关
            Transform hide_layer = Camera.main.transform.Find("HideLayer");

            Transform blast = Instantiate(hide_layer.Find("Blast06"));
            blast.SetParent(transform.parent.parent);
            blast.localPosition = transform.parent.localPosition;

            Blast blast_s = blast.GetComponent<Blast>();
            blast_s.Play();

            transform.parent.localPosition = new Vector3(-500f, 500f, transform.parent.localPosition.z);
            PlayAudioCallback(GetComponent<AudioSource>(), OnAudioCallBack);

            //如果是跟子弹碰撞就把子弹也一起销毁，敌机就不做销毁处理
            if (CollisionObject.gameObject.name.Contains("Bullet"))
            {
                CollisionObject.gameObject.transform.DOKill(true);
            }

            IsAlive = false; //挂了!
            CollisionObject = null;
        }
    }

    private void OnDestroy()
    {
        //Debug.Log("PlayerPlaneCenter::OnDestroy");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //确保一个Bullet Sprite对应一个爆炸Sprite
        //判断1：不是无敌状态下
        //判断2：碰撞体不是player本身
        //判断3：不是来自隐藏层的元素
        //判断4：player没有被碰撞过
        if (!IsForce && collision.transform.name != "plane_center" && transform.parent.parent.name != "HideLayer" && CollisionObject == null)
        {
            CollisionObject = collision;
        }

    }

    IEnumerator ForceDisable()
    {
        //Debug.Log("等待无敌时间取消");
        yield return new WaitForSeconds(ForceTime);
        IsForce = false;
        //Debug.Log("已取消无敌时间");
    }

    void OnAudioCallBack()
    {
        //销毁当前Enemy
        Destroy(transform.parent.gameObject);

        //减命逻辑
        StageCommon stage_common = Camera.main.GetComponent<StageCommon>();
        int player_life_int = Constant.PlayerLifeCurr;
        if (player_life_int > 0)
        {
            //复活
            player_life_int--;
            stage_common.SetPlayerLife(player_life_int);
            stage_common.PlayerPlaneGo();
        }
        else
        {
            //game over
            //PlayerPrefs.SetInt(Constant.NextSceneIndex, Constant.GameOverScene);
            //SceneManager.LoadScene(Constant.LoadingScene);

            //加载资源少，用同步加载高效一点
            SceneManager.LoadScene(Constant.GameOverScene);
        }

    }

    //声音播放的回调
    delegate void AudioCallBack();
    void PlayAudioCallback(AudioSource audio, AudioCallBack callback)
    {
        audio.Play();
        StartCoroutine(DelayedCallback(audio.clip.length, callback));
    }
    IEnumerator DelayedCallback(float time, AudioCallBack callback)
    {
        yield return new WaitForSeconds(time);
        callback();
    }
    //声音播放的回调 end

}
