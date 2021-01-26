using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG;
using DG.Tweening;

public class Enemy : MonoBehaviour
{
    public enum Status
    {
        Normal, //正常状态
        Force //无敌状态
    }

    public string BlastName = "Blast01";
    public int BlastMode = 0;
    public int Score = 100;
    public int HP = 1;
    public int EnemyLevel = 0;
    public Material EnemyVersionMat = null; //这个是在unity编辑器的，不需要在代码修改
    public Material EnemyHitMat = null; //同上
    Material EnemyTmpMat = null;
    bool DoHit = false;

    public Status StatusCurr;

    Animator EnemyAnim;
    IList<Collider2D> CollisionObjects = null; //确保一个Bullet Sprite对应一个爆炸Sprite

    SpriteRenderer EnemySpriteRenderer = null;

    // Start is called before the first frame update
    void Start()
    {
		Constant.ObjectIsPlayingSound(this);

        StatusCurr = Status.Normal;

        EnemyAnim = GetComponent<Animator>();
        CollisionObjects = new List<Collider2D>();

        if (EnemyAnim != null && transform.parent.name == "HideLayer")
        {
            EnemyAnim.speed = 0f;
        }

        EnemySpriteRenderer = GetComponent<SpriteRenderer>();
        if (EnemyVersionMat != null && transform.parent.name != "HideLayer")
        {
            EnemySpriteRenderer.material = EnemyVersionMat;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.parent.name == "HideLayer") return;

        if (Constant.GameIsPause)
        {
            if (EnemyAnim != null)
            {
                EnemyAnim.speed = 0f;
            }
            return;
        }
        if (EnemyAnim != null && EnemyAnim.speed == 0f)
        {
            EnemyAnim.speed = 1f;
        }

        //逃跑的敌机做销毁处理，-2f是为了缓冲一下位置
        if (transform.localPosition.y < -Camera.main.orthographicSize - 2f)
        {
            transform.localScale = Vector3.zero;
            transform.DOKill(true);
            Destroy(gameObject);
            return;
        }

        if (CollisionObjects.Count > 0)
        {
            //被打中的时候

            Transform hide_layer = transform.root.Find("HideLayer");
            if (StatusCurr == Status.Normal)
            {
                //正常状态

                HP -= 1;
                if (HP <= 0)
                {
                    //加分逻辑
                    StageCommon stage_common = Camera.main.GetComponent<StageCommon>();
                    int score_int = stage_common.GetScore();
                    score_int += Score;
                    stage_common.SetScore(score_int);

                    //爆炸效果对象相关
                    if (BlastMode == 1)
                    {
                        //用在中敌机的爆炸效果
                        Transform blast = Instantiate(hide_layer.Find(BlastName));
                        blast.SetParent(transform.parent);
                        blast.localPosition = transform.localPosition;
                        blast.localScale = new Vector3(3f, 3f, 3f);

                        Blast blast_s = blast.GetComponent<Blast>();
                        blast_s.Play();
                    }
                    else if (BlastMode == 2)
                    {
                        //用在boss级的爆炸效果
                        Transform blast = Instantiate(hide_layer.Find(BlastName));
                        blast.SetParent(transform.parent);
                        blast.localPosition = transform.localPosition;
                        blast.localScale = new Vector3(6f, 6f, 6f);

                        Blast blast_s = blast.GetComponent<Blast>();
                        blast_s.Play();

                        //打败boss后全部清理子弹
                        Transform bullet_layer = Camera.main.transform.Find("EnemyLayer/BulletLayer");
                        for (int i = 0; i < bullet_layer.childCount; i++)
                        {
                            Destroy(bullet_layer.GetChild(i).gameObject);
                        }

                        //camera震动效果
                        CameraShake.ShakeFor(0.8f, 0.1f);
                    }
                    else
                    {
                        //用在小敌机的爆炸效果
                        Transform blast = Instantiate(hide_layer.Find(BlastName));
                        blast.SetParent(transform.parent);
                        blast.localPosition = transform.localPosition;

                        Blast blast_s = blast.GetComponent<Blast>();
                        blast_s.Play();
                    }
                    //爆炸效果对象相关 end

                    transform.localPosition = new Vector3(5000f, 5000f, 5000f);
                    transform.localScale = Vector3.zero;
                    transform.DOKill(true);
                    PlayAudioCallback(GetComponent<AudioSource>(), OnAudioCallBack);

                }
                else
                {
                    //Bullet打中的效果
                    foreach (var item in CollisionObjects)
                    {
                        string name = item.gameObject.name.Replace("(Clone)", "") + "Effect";

                        Transform bullet_effect_src = hide_layer.Find(name);
                        if (bullet_effect_src != null)
                        {
                            Transform bullet_effect = Instantiate(bullet_effect_src);

                            bullet_effect.SetParent(transform);
                            bullet_effect.position = new Vector3(item.transform.localPosition.x, item.transform.localPosition.y + Camera.main.transform.position.y + 0.3f, -1f);
                            bullet_effect.GetComponent<BulletEffect>().Play();
                        }

                    }

                    //调用闪光shader
                    if (EnemyHitMat != null && !DoHit)
                    {
                        //Debug.Log("调用闪光shader");
                        if (EnemyTmpMat == null) EnemyTmpMat = EnemySpriteRenderer.material;
                        EnemySpriteRenderer.material = EnemyHitMat;
                        DoHit = true;

                        StartCoroutine(DelayRestoreDoHit());
                    }
                    
                }
            }
            else
            {
                //无敌状态
                //Bullet打中的效果
                foreach (var item in CollisionObjects)
                {
                    string name = item.gameObject.name.Replace("(Clone)", "") + "Effect";

                    Transform bullet_effect_src = hide_layer.Find(name);
                    if (bullet_effect_src != null)
                    {
                        Transform bullet_effect = Instantiate(bullet_effect_src);

                        bullet_effect.SetParent(transform);
                        bullet_effect.position = new Vector3(item.transform.localPosition.x, item.transform.localPosition.y + Camera.main.transform.position.y + 0.3f, -1f);
                        bullet_effect.GetComponent<BulletEffect>().Play();
                    }

                }
            }

            //销毁Bullet
            foreach (var item in CollisionObjects)
            {
                item.gameObject.transform.DOKill(true);
            }
            CollisionObjects.Clear();
        }
    }

    private void OnDestroy()
    {
        CollisionObjects.Clear();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //确保一个Bullet Sprite对应一个爆炸Sprite
        //判断1：碰撞体不是player
        //判断2：不是来自隐藏层的元素
        //判断3：不是已经存在的碰撞体
        if (collision.transform.name != "plane_center" && transform.parent.name != "HideLayer" && !CollisionObjects.Contains(collision))
        {
            CollisionObjects.Add(collision);
        }
        
    }

    IEnumerator DelayRestoreDoHit()
    {
        yield return new WaitForSeconds(0.5f);

        if (EnemyTmpMat != null && DoHit)
        {
            //Debug.Log("恢复原材质");
            EnemySpriteRenderer.material = EnemyTmpMat;
            EnemyTmpMat = null;
        }

        DoHit = false;
    }

    void OnAudioCallBack()
    {
        //销毁当前Enemy
        Destroy(gameObject);
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
