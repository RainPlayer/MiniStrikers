using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG;
using DG.Tweening;
using System.Reflection;
using System.Text.RegularExpressions;

public class Enemy21CPU : MonoBehaviour
{

    enum Gun
    {
        BottomLeft = 0,
        BottomRight = 1,
        Left = 2,
        Right = 3
    }
    //boss的各个枪的位置
    Vector3 GunOffsetPosBottomLeft;
    Vector3 GunOffsetPosBottomRight;
    Vector3 GunOffsetPosLeft;
    Vector3 GunOffsetPosRight;

    //动态执行攻击方法
    int CurrAttackModeIndex = 0; //当前执行攻击的方法索引
    IList<MethodInfo> AttackModeMethods = null; //攻击方法组
    System.Type ThisType = null;
    float ChangeAttackModeTime = 10f; //切换攻击模式的时间

    public float FireTime = 0.05f; //子弹发射时间密度，越小越多子弹
    public float FireTime03 = 0.3f; //子弹发射时间密度，越小越多子弹，这里AttackMode03会用到
    float FireStartTime = 0.5f;
    float FireStopTime = 1f;
    float NextFireTime = 0f;
    float NextFireTime03 = 0f;
    bool DoChangeFireStatus = false; //是否正在执行ChangeFireStatus方法，确保ChangeFireStatus方法只执行一次
    bool DoFire = true;

    Transform PlayerLayer;
    Transform EnemyLayer;
    Transform HideLayer;
    Transform BulletLayer;

    Transform PlayerPlane;
    PlayerPlaneCenter PlayerPlaneCenterObject;
    Vector3 PlayerPlanePos;
    Enemy EnemyScriptObject;

    bool GameIsPause = false;

    // Start is called before the first frame update
    void Start()
    {
		Constant.ObjectIsPlayingSound(this);

        if (transform.parent.name != "HideLayer")
        {
            //动态加入攻击方法
            AttackModeMethods = new List<MethodInfo>();
            ThisType = GetType();
            foreach (var item in ThisType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance))
            {
                if (Regex.IsMatch(item.Name, @"^AttackMode(\d+)$"))
                {
                    MethodInfo m = ThisType.GetMethod(item.Name, BindingFlags.NonPublic | BindingFlags.Instance);
                    AttackModeMethods.Add(m);
                    //Debug.Log(item.Name);
                }
            }

            GunOffsetPosBottomLeft = new Vector3(-0.5f, -0.75f, 0);
            GunOffsetPosBottomRight = new Vector3(0.5f, -0.75f, 0);
            GunOffsetPosLeft = new Vector3(-0.88f, -0.1f, 0);
            GunOffsetPosRight = new Vector3(0.88f, -0.1f, 0);

            PlayerLayer = Camera.main.transform.Find("PlayerLayer");
            BulletLayer = transform.parent.Find("BulletLayer");
            HideLayer = Camera.main.transform.Find("HideLayer");

            PlayerPlane = PlayerLayer.Find(Constant.PlayerPlane);
            PlayerPlaneCenterObject = PlayerPlane.Find("plane_center").GetComponent<PlayerPlaneCenter>();
            EnemyScriptObject = transform.GetComponent<Enemy>();
            EnemyScriptObject.StatusCurr = Enemy.Status.Force;

            Vector3 target_pos = new Vector3(transform.localPosition.x, 4.6f, transform.localPosition.z);

            transform.DOLocalMove(target_pos, 3.0f).SetEase(Ease.Linear).OnComplete(() =>
            {
                EnemyScriptObject.StatusCurr = Enemy.Status.Normal;

                StartCoroutine(ChangeAttackMode());
                transform.DOLocalMoveX(-1.3f, 5.0f).SetEase(Ease.Linear).OnComplete(() => EnemyMove());
            });
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.parent.name != "HideLayer")
        {
            if (Constant.GameIsPause)
            {
                if (!GameIsPause)
                {
                    transform.DOPause();
                    GameIsPause = Constant.GameIsPause;
                }
                return;
            }
            else if (!Constant.GameIsPause && GameIsPause)
            {
                transform.DOPlay();
                GameIsPause = Constant.GameIsPause;
                return;
            }

            //子弹部分
            if (EnemyScriptObject.StatusCurr == Enemy.Status.Normal && CurrAttackModeIndex >= 0)
            {
                
                //var obj = AttackModeMethods[CurrAttackModeIndex].Invoke(this, null);
                AttackModeMethods[CurrAttackModeIndex].Invoke(this, null);

            }

        }
        
    }
	
	private void OnDestroy()
    {
        if (AttackModeMethods != null) AttackModeMethods.Clear();
        transform.DOKill(true);
    }

    //攻击模式1
    void AttackMode01()
    {
        if (Time.time > NextFireTime)
        {
            if (!DoChangeFireStatus)
            {
                StartCoroutine(ChangeFireStatus());
                DoChangeFireStatus = true;
            }

            if (DoFire)
            {
                Fire01(Gun.BottomLeft, 90);
                Fire01(Gun.BottomRight, 90);
                Fire01(Gun.Left, 80);
                Fire01(Gun.Left, 100);
                Fire01(Gun.Right, 80);
                Fire01(Gun.Right, 100);
            }

            NextFireTime = Time.time + FireTime;
        }
        
    }

    //攻击模式2
    void AttackMode02()
    {
        if (Time.time > NextFireTime)
        {
            if (!DoChangeFireStatus)
            {
                StartCoroutine(ChangeFireStatus());
                DoChangeFireStatus = true;
            }

            if (DoFire)
            {
                float angle = FHUtility.Angle360(transform.localPosition + GunOffsetPosBottomLeft, PlayerPlanePos);
                Fire01(Gun.BottomLeft, angle);

                angle = FHUtility.Angle360(transform.localPosition + GunOffsetPosBottomRight, PlayerPlanePos);
                Fire01(Gun.BottomRight, angle);
            }

            Fire02(Gun.Left, 60);
            Fire02(Gun.Left, 90);
            Fire02(Gun.Right, 120);
            Fire02(Gun.Right, 90);

            NextFireTime = Time.time + FireTime;
        }
    }

    //攻击模式3
    void AttackMode03()
    {
        float f = 60; //浮动角度

        if (Time.time > NextFireTime03)
        {
            float angle = Random.Range(90 - f, 90 + f);
            Fire02(Gun.BottomLeft, angle, 5);

            angle = Random.Range(90 - f, 90 + f);
            Fire02(Gun.BottomRight, angle, 5);

            angle = Random.Range(90 - f, 90 + f);
            Fire02(Gun.Left, angle, 8);

            angle = Random.Range(90 - f, 90 + f);
            Fire02(Gun.Right, angle, 8);

            NextFireTime03 = Time.time + FireTime03;
        }
    }

    //往指定角度直线攻击，使用随机子弹
    void Fire01(Gun gun, float angle)
    {
        Fire01(gun, angle, 2f);
    }
    //bullet_speed越少越速度快
    void Fire01(Gun gun, float angle, float bullet_speed)
    {
        string bullet_n = Constant.EnemyBullets01[Random.Range(0, Constant.EnemyBullets01.Length - 1)];
        Transform bullet = Instantiate(HideLayer.Find(bullet_n));
        bullet.SetParent(BulletLayer);

        Vector3 bullet_pos;
        if (gun == Gun.BottomLeft)
        {
            //左下发出
            bullet_pos = transform.localPosition + GunOffsetPosBottomLeft;
        }
        else if (gun == Gun.BottomRight)
        {
            //右下发出
            bullet_pos = transform.localPosition + GunOffsetPosBottomRight;
        }
        else if (gun == Gun.Left)
        {
            //左上发出
            bullet_pos = transform.localPosition + GunOffsetPosLeft;
        }
        //else if (gun == Gun.Right)
        else
        {
            //右上发出
            bullet_pos = transform.localPosition + GunOffsetPosRight;
        }

        bullet.localPosition = bullet_pos;
        bullet.eulerAngles = new Vector3(bullet.eulerAngles.x, bullet.eulerAngles.y, angle - 90f);

        Vector2 tmp = FHUtility.HypotenuseAngle2Position(20f, angle);
        Vector3 pos = new Vector3(tmp.x, tmp.y, 0);
        pos = bullet.localPosition - pos;
        bullet.DOLocalMove(pos, bullet_speed).SetEase(Ease.Linear).OnComplete(() =>
        {
            Destroy(bullet.gameObject);
        });
    }

    //往指定角度直线攻击，使用Bullet06
    void Fire02(Gun gun, float angle)
    {
        Fire02(gun, angle, 2f);
    }
    //bullet_speed越少越速度快
    void Fire02(Gun gun, float angle, float bullet_speed)
    {
        Transform bullet = Instantiate(HideLayer.Find("Bullet06"));
        bullet.SetParent(BulletLayer);

        Vector3 bullet_pos;
        if (gun == Gun.BottomLeft)
        {
            //左下发出
            bullet_pos = transform.localPosition + GunOffsetPosBottomLeft;
        }
        else if (gun == Gun.BottomRight)
        {
            //右下发出
            bullet_pos = transform.localPosition + GunOffsetPosBottomRight;
        }
        else if (gun == Gun.Left)
        {
            //左上发出
            bullet_pos = transform.localPosition + GunOffsetPosLeft;
        }
        //else if (gun == Gun.Right)
        else
        {
            //右上发出
            bullet_pos = transform.localPosition + GunOffsetPosRight;
        }

        bullet.localPosition = bullet_pos;

        Vector2 tmp = FHUtility.HypotenuseAngle2Position(20f, angle);
        Vector3 pos = new Vector3(tmp.x, tmp.y, 0);
        pos = bullet.localPosition - pos;
        bullet.DOLocalMove(pos, bullet_speed).SetEase(Ease.Linear).OnComplete(() =>
        {
            Destroy(bullet.gameObject);
        });
    }

    IEnumerator ChangeFireStatus()
    {
        if (DoFire)
        {
            //找到player的位置
            PlayerPlane = PlayerLayer.Find(Constant.PlayerPlane);
            PlayerPlaneCenterObject = PlayerPlane.Find("plane_center").GetComponent<PlayerPlaneCenter>();
            PlayerPlanePos = PlayerPlane != null && PlayerPlaneCenterObject.IsAlive ? PlayerPlane.localPosition : Constant.PlayerPlaneInitPosition;

            yield return new WaitForSeconds(FireStartTime);
            DoFire = false;
        }
        else
        {
            yield return new WaitForSeconds(FireStopTime);
            DoFire = true;
        }
        StartCoroutine(ChangeFireStatus());
    }

    IEnumerator ChangeAttackMode()
    {
        yield return new WaitForSeconds(ChangeAttackModeTime);
        StartCoroutine(PauseAttackMode());
    }
    IEnumerator PauseAttackMode()
    {
        int tmp = CurrAttackModeIndex;
        CurrAttackModeIndex = -1;

        //临时暂停攻击
        yield return new WaitForSeconds(2f);

        CurrAttackModeIndex = tmp;
        if (CurrAttackModeIndex + 1 < AttackModeMethods.Count)
        {
            CurrAttackModeIndex++;
        }
        else
        {
            CurrAttackModeIndex = 0;
        }
        StartCoroutine(ChangeAttackMode());
    }

    void EnemyMove()
    {
        if (transform.localPosition.x < 0)
        {
            //往右移动
            transform.DOLocalMoveX(1.3f, 10.0f).SetEase(Ease.Linear).OnComplete(() =>
            {
                EnemyMove();
            });
            return;
        }

        //往左移动
        transform.DOLocalMoveX(-1.3f, 10.0f).SetEase(Ease.Linear).OnComplete(() =>
        {
            EnemyMove();
        });
    }

}
