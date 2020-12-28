using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG;
using DG.Tweening;

public class PlayerPlane : MonoBehaviour
{
    enum SpeedMode
    {
        Normal,
        Slow,
    }

    public string PlaneName = "Plane0";
    public float PlaneSpeed = 0f;

    bool IsDirectionUp = false;
    bool IsDirectionDown = false;
    bool IsDirectionLeft = false;
    bool IsDirectionRight = false;

    Camera MainCamera;
    Animator PlaneAnimator;
    Animator PlaneCenterAnimator;
    Vector2 PlaneCenterSize;

    Transform PlayerLayer;
    Transform BulletLayer;
    Transform EnemyLayer;
    Transform HideLayer;
    
    float PxUnit;
    float WidthUnit;

    public float FireATime = 0f;
    float NextFireATime = 0f;

    public float FireBTime = 0f;
    float NextFireBTime = 0f;
    float NextFireBTime2 = 0f;

    bool DoBulletA = false; //防止子弹AB的冲突

    SpeedMode PlaneSpeedMode = SpeedMode.Normal;

    // Start is called before the first frame update
    void Start()
    {
        MainCamera = FindObjectOfType<Camera>();
        PlaneAnimator = transform.Find(PlaneName.ToLower()).GetComponent<Animator>();
        PlaneCenterAnimator = transform.Find("plane_center").GetComponent<Animator>();

        SpriteRenderer plane_center = transform.Find("plane_center").GetComponent<SpriteRenderer>();
        PlaneCenterSize = plane_center.size * plane_center.gameObject.transform.localScale;

        PlayerLayer = transform.root.Find("PlayerLayer");
        BulletLayer = PlayerLayer.Find("BulletLayer");
        EnemyLayer = transform.root.Find("EnemyLayer");
        HideLayer = transform.root.Find("HideLayer");
        
        PxUnit = MainCamera.orthographicSize * 2f / Screen.height;
        WidthUnit = PxUnit * Screen.width;
    }

    // Update is called once per frame
    void Update()
    {
        if (Constant.GameIsPause)
        {
            PlaneAnimator.speed = 0f;
            PlaneCenterAnimator.speed = 0f;

            for (int i = 0; i < BulletLayer.childCount; i++)
            {
                Transform bullet = BulletLayer.GetChild(i);
                Animator anim = bullet.gameObject.GetComponent<Animator>();
                if (anim != null)
                {
                    anim.speed = 0f;
                }
            }

            return;
        }

        //为0时是游戏在暂停情况下开始了游戏的时候
        if (PlaneAnimator.speed == 0f)
        {
            PlaneAnimator.speed = 1f;
        }
        if (PlaneCenterAnimator.speed == 0f)
        {
            PlaneCenterAnimator.speed = 1f;

            for (int i = 0; i < BulletLayer.childCount; i++)
            {
                Transform bullet = BulletLayer.GetChild(i);
                Animator anim = bullet.gameObject.GetComponent<Animator>();
                if (anim != null)
                {
                    anim.speed = 1f;
                }
            }
        }

#if UNITY_STANDALONE || UNITY_EDITOR
        UpdatePC();
#endif

    }

    void UpdatePC()
    {
        //======================================
        //方向上
        if (Input.GetKey(KeyCode.W) || Input.GetAxis("Vertical") < -0.5f)
        {
            if (!IsDirectionUp)
            {
                IsDirectionUp = true;
            }
            else
            {
                if (transform.localPosition.y <= MainCamera.orthographicSize - (PlaneCenterSize.y / 2f))
                {
                    transform.Translate(new Vector3(0, PlaneSpeed * Time.deltaTime, 0));
                }
            }
        }
        else
        {
            if (IsDirectionUp)
            {
                IsDirectionUp = false;
            }
        }
        //方向上
        //======================================

        //======================================
        //方向下
        if (Input.GetKey(KeyCode.S) || Input.GetAxis("Vertical") > 0.5f)
        {
            if (!IsDirectionDown)
            {
                IsDirectionDown = true;
            }
            else
            {
                if (transform.localPosition.y >= -MainCamera.orthographicSize + (PlaneCenterSize.y / 2f))
                {
                    transform.Translate(new Vector3(0, -PlaneSpeed * Time.deltaTime, 0));
                }
            }
        }
        else
        {
            if (IsDirectionDown)
            {
                IsDirectionDown = false;
            }
        }
        //方向下
        //======================================

        //======================================
        //方向左
        if (Input.GetKey(KeyCode.A) || Input.GetAxis("Horizontal") < -0.5f)
        {
            if (!IsDirectionLeft)
            {
                PlaneAnimator.Play(PlaneName + "_Left");
                IsDirectionLeft = true;
            }
            else
            {
                if (transform.localPosition.x >= -(WidthUnit / 2f) + (PlaneCenterSize.x / 2f))
                {
                    transform.Translate(new Vector3(-PlaneSpeed * Time.deltaTime, 0, 0));
                }
            }
        }
        else
        {
            if (IsDirectionLeft)
            {
                PlaneAnimator.Play(PlaneName + "_Normal");
                IsDirectionLeft = false;
            }
        }
        //方向左
        //======================================

        //======================================
        //方向右
        if (Input.GetKey(KeyCode.D) || Input.GetAxis("Horizontal") > 0.5f)
        {
            if (!IsDirectionRight)
            {
                PlaneAnimator.Play(PlaneName + "_Right");
                IsDirectionRight = true;
            }
            else
            {
                if (transform.localPosition.x <= (WidthUnit / 2f) - (PlaneCenterSize.x / 2f))
                {
                    transform.Translate(new Vector3(PlaneSpeed * Time.deltaTime, 0, 0));
                }
            }
        }
        else
        {
            if (IsDirectionRight)
            {
                PlaneAnimator.Play(PlaneName + "_Normal");
                IsDirectionRight = false;
            }
        }
        //方向右
        //======================================

        //======================================
        //子弹A
        if ((Input.GetKey(KeyCode.K) || Input.GetButton("Fire1_JS")) && Time.time > NextFireATime)
        {
            if (PlaneName == "Plane0")
            {
                //布局子弹A
                int bullet_count = 4;

                for (int i = 0; i < bullet_count; i++)
                {
                    Transform bullet = Instantiate(HideLayer.Find("Bullet01"));
                    SpriteRenderer bullet_sprite_renderer = bullet.GetComponent<SpriteRenderer>();
                    bullet.SetParent(BulletLayer);

                    Vector3 bullet_pos = transform.localPosition;
                    float size_x = bullet.localScale.x * bullet_sprite_renderer.size.x; //子弹的sprite的宽度
                    float start_step = (bullet_count - 1) * 0.5f;
                    bullet_pos.x = transform.localPosition.x - (size_x * start_step); //计算初始位置
                    bullet_pos.x += size_x * i;
                    bullet.localPosition = bullet_pos;

                    //子弹A在当前位置往上移动10，这样才能保证看到的发射效果是匀速的
                    //把当前子弹y坐标的转换为原点为最下面的形式
                    //float target_y = 10f + (-MainCamera.orthographicSize + (MainCamera.orthographicSize * 2f) + bullet.localPosition.y);
                    float target_y = 10f + (MainCamera.orthographicSize + bullet.localPosition.y); //上面的简化版本
                    /*bullet.DOLocalMoveY(target_y, 1.2f).OnKill(() => {
                        Debug.Log("OnKill");
                    }).OnComplete(() => {
                        Debug.Log("OnComplete");
                    });*/
                    bullet.DOLocalMoveY(target_y, 1.2f);

                    DoBulletA = true;
                }
            }

            NextFireATime = Time.time + FireATime;
        }
        if (Input.GetKeyUp(KeyCode.K) || Input.GetButtonUp("Fire1_JS"))
        {
            DoBulletA = false;
        }

        //子弹A
        //======================================

        //======================================
        //子弹B
        if (!DoBulletA && (Input.GetKey(KeyCode.L) || Input.GetButton("Fire2_JS")))
        {
            if (Time.time > NextFireBTime)
            {
                if (PlaneName == "Plane0")
                {
                    //布局子弹B
                    int bullet_count = 3;
                    for (int i = 0; i < bullet_count; i++)
                    {
                        Transform bullet = Instantiate(HideLayer.Find("Bullet02"));
                        SpriteRenderer bullet_sprite_renderer = bullet.GetComponent<SpriteRenderer>();
                        bullet.SetParent(BulletLayer);
                        
                        Vector3 bullet_pos = transform.localPosition;
                        float size_x = bullet.localScale.x * bullet_sprite_renderer.size.x; //子弹的sprite的宽度
                        float start_step = (bullet_count - 1) * 0.5f;
                        bullet_pos.x = transform.localPosition.x - (size_x * start_step); //计算初始位置
                        bullet_pos.x += size_x * i;
                        bullet.localPosition = bullet_pos;

                        //子弹B在当前位置往上移动10，这样才能保证看到的发射效果是匀速的
                        //把当前子弹y坐标的转换为原点为最下面的形式
                        float target_y = 10f + (MainCamera.orthographicSize + bullet.localPosition.y); //上面的简化版本
                        bullet.DOLocalMoveY(target_y, 1.2f);
                    }


                }

                NextFireBTime = Time.time + FireBTime;
            }

            if (Time.time > NextFireBTime2)
            {
                if (PlaneName == "Plane0")
                {
                    //布局子弹B(2)

                    //==================================================================================
                    //左边

                    Transform bullet_left = Instantiate(HideLayer.Find("Bullet03"));
                    bullet_left.SetParent(BulletLayer);

                    Vector3 bullet_pos = transform.localPosition;
                    bullet_left.localPosition = bullet_pos;

                    float target_y = 10f + (MainCamera.orthographicSize + bullet_left.localPosition.y);
                    Vector3 target_pos = bullet_pos;
                    target_pos.x -= 5f;
                    target_pos.y = target_y;

                    float r = Constant.Angle360(bullet_left.localPosition, target_pos);
                    bullet_left.Rotate(0, 0, r + 90f);

                    bullet_left.DOLocalMove(target_pos, 1.2f);

                    //==================================================================================
                    //右边

                    Transform bullet_right = Instantiate(HideLayer.Find("Bullet03"));
                    bullet_right.SetParent(BulletLayer);

                    bullet_right.localPosition = bullet_pos;

                    target_pos.x += 10f;

                    r = Constant.Angle360(bullet_right.localPosition, target_pos);
                    bullet_right.Rotate(0, 0, r + 90f);

                    bullet_right.DOLocalMove(target_pos, 1.2f);
                }

                NextFireBTime2 = Time.time + (FireBTime * 2.5f);
            }

            //子弹B使用慢速移动模式
            if (PlaneSpeedMode == SpeedMode.Normal)
            {
                PlaneSpeed /= 2.5f;
                PlaneSpeedMode = SpeedMode.Slow;
            }
        }
        else
        {
            //没有使用子弹B的时候回到正常速度
            if (PlaneSpeedMode == SpeedMode.Slow)
            {
                PlaneSpeed *= 2.5f;
                PlaneSpeedMode = SpeedMode.Normal;
            }
        }
        //子弹B
        //======================================

    }

}
