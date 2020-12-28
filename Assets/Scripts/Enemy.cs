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
    GameObject TriggerObject = null; //确保一个Bullet Sprite对应一个爆炸Sprite

    // Start is called before the first frame update
    void Start()
    {
        EnemyAnim = GetComponent<Animator>();
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

        if (TriggerObject != null)
        {
            HP -= 1;

            Transform hide_layer = transform.root.Find("HideLayer");
            if (HP <= 0)
            {
                //加分逻辑
                SpriteString score = transform.root.Find("PlayerInfo").Find("Score").GetComponent<SpriteString>();
                uint score_int = uint.Parse(score.StringContent);
                score_int += Score;
                score.SetStringContent(score_int.ToString());

                //爆炸效果对象相关
                Transform blast = Instantiate(hide_layer.Find(BlastName));
                blast.SetParent(transform.parent);
                blast.localPosition = transform.localPosition;

                Blast blast_s = blast.GetComponent<Blast>();
                blast_s.Play();

                //销毁当前Enemy
                transform.DOKill(true);
                Destroy(gameObject);
            }
            else
            {
                //Bullet打中的效果
                Transform bullet_hit_effect = Instantiate(hide_layer.Find("BulletHitEffect"));
                ParticleSystem bullet_hit_effect_s = bullet_hit_effect.gameObject.GetComponent<ParticleSystem>();
                bullet_hit_effect.SetParent(transform.parent);
                bullet_hit_effect.localPosition = transform.localPosition;
                bullet_hit_effect_s.Play();
            }


            //销毁Bullet
            TriggerObject.transform.DOKill(true);
            Destroy(TriggerObject);
            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        TriggerObject = collision.gameObject;

    }

}
