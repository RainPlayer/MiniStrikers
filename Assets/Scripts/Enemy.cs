using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG;
using DG.Tweening;

public class Enemy : MonoBehaviour
{
    public string BlastName = "Blast01";
    public uint BlastMode = 0;
    public uint Score = 100;
    public uint HP = 1;

    Animator EnemyAnim;
    IList<Collider2D> CollisionObjects = null; //确保一个Bullet Sprite对应一个爆炸Sprite

    // Start is called before the first frame update
    void Start()
    {
        EnemyAnim = GetComponent<Animator>();
        CollisionObjects = new List<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Constant.GameIsPause)
        {
            EnemyAnim.speed = 0f;
            return;
        }
        if (EnemyAnim.speed == 0f)
        {
            EnemyAnim.speed = 1f;
        }

        if (CollisionObjects.Count > 0)
        {
            HP -= 1;

            Transform hide_layer = transform.root.Find("HideLayer");
            if (HP <= 0)
            {
                //加分逻辑
                FHSpriteText score = transform.root.Find("PlayerInfo").Find("Score").GetComponent<FHSpriteText>();
                uint score_int = uint.Parse(score.StringContent);
                score_int += Score;
                score.SetStringContent(score_int.ToString());

                //爆炸效果对象相关
                Transform blast = Instantiate(hide_layer.Find(BlastName));
                blast.SetParent(transform.parent);
                blast.localPosition = transform.localPosition;

                Blast blast_s = blast.GetComponent<Blast>();
                blast_s.Play();

                transform.localPosition = new Vector3(-100f, transform.localPosition.y, transform.localPosition.z);
                transform.DOKill(true);
                PlayAudioCallback(GetComponent<AudioSource>(), OnAudioCallBack);

            }
            else
            {
                //Bullet打中的效果
                foreach (var item in CollisionObjects)
                {
                    string name = item.gameObject.name.Replace("(Clone)", "") + "Effect";
                    Transform bullet_effect = Instantiate(hide_layer.Find(name));

                    bullet_effect.SetParent(transform);
                    bullet_effect.localPosition = new Vector3(item.transform.localPosition.x, item.transform.localPosition.y + 0.5f, -1f);
                    bullet_effect.GetComponent<BulletEffect>().Play();
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //确保一个Bullet Sprite对应一个爆炸Sprite
        if (!CollisionObjects.Contains(collision))
        {
            CollisionObjects.Add(collision);
        }
        
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
