using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class PlayerPlaneCenter : MonoBehaviour
{
    Collider2D CollisionObject = null; //确保一个Bullet Sprite对应一个爆炸Sprite

    public float ForceTime = 0f; //无敌时间，大于0为无敌状态
    float NextForceTime = 0f;
    float ForceAnimIntervalTime = 0.15f; //无敌状态闪烁的时间间隔

    // Start is called before the first frame update
    void Start()
    {
        //无敌时间
        ForceTime = 0.25f;

    }

    // Update is called once per frame
    void Update()
    {
        //无敌状态的处理
        if (ForceTime > 0f && Time.time > NextForceTime)
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
            ForceTime -= Time.deltaTime;
        }
        else if(ForceTime <= 0f && transform.parent.localScale.x == 0f)
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
            CollisionObject = null;
        }
    }

    private void OnDestroy()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //确保一个Bullet Sprite对应一个爆炸Sprite
        //判断1：不是无敌状态下
        //判断2：碰撞体不是player本身
        //判断3：不是来自隐藏层的元素
        //判断4：player没有被碰撞过
        if (ForceTime <= 0f && collision.transform.name != "plane_center" && transform.parent.parent.name != "HideLayer" && CollisionObject == null)
        {
            CollisionObject = collision;
        }

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
