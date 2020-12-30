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
    Collider2D CollisionObject = null; //确保一个Bullet Sprite对应一个爆炸Sprite

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

        if (CollisionObject != null)
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

                GetComponent<AudioSource>().Play();

                //销毁当前Enemy
                transform.localPosition = new Vector3(-100f, transform.localPosition.y, transform.localPosition.z);
                transform.DOKill(true);
                Destroy(gameObject, 0.8f);

            }
            else
            {
                //Bullet打中的效果
                string name = CollisionObject.gameObject.name.Replace("(Clone)", "") + "Effect";
                Transform bullet_effect = Instantiate(hide_layer.Find(name));
                bullet_effect.SetParent(transform);
                bullet_effect.localPosition = new Vector3(CollisionObject.transform.localPosition.x, CollisionObject.transform.localPosition.y + 0.5f, -1f);
                bullet_effect.GetComponent<BulletEffect>().Play();
            }

            //销毁Bullet
            CollisionObject.gameObject.transform.DOKill(true);
            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);
        CollisionObject = collision;
        
    }

}
