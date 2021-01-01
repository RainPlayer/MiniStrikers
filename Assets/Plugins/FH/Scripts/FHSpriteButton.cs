using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FHSpriteButton : MonoBehaviour
{
    public Sprite ButtonNormalSprite = null;
    public Sprite ButtonPressSprite = null;
    public Sprite ButtonDisableSprite = null;
    public bool ButtonEnabled = true;

    SpriteRenderer CurrSpriteRenderer = null;

    public delegate void MouseButtonDownCallBack();
    public delegate void MouseButtonUpCallBack();

    public MouseButtonDownCallBack OnMouseButtonDownCallBack = null;
    public MouseButtonUpCallBack OnMouseButtonUpCallBack = null;

    private void Awake()
    {
        if (ButtonNormalSprite == null)
        {
            Debug.Log("最少需要设置ButtonNormalSprite");
            return;
        }

        if (ButtonPressSprite == null)
        {
            ButtonPressSprite = ButtonNormalSprite;
        }

        CurrSpriteRenderer = GetComponent<SpriteRenderer>();
        CurrSpriteRenderer.sprite = ButtonNormalSprite;

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!ButtonEnabled)
        {
            //禁用按钮
            if (ButtonDisableSprite == null && CurrSpriteRenderer.sprite != ButtonNormalSprite)
            {
                //Debug.Log("禁用了按钮");
                CurrSpriteRenderer.sprite = ButtonNormalSprite;
            }
            else if (ButtonDisableSprite != null && CurrSpriteRenderer.sprite != ButtonDisableSprite)
            {
                //Debug.Log("禁用了按钮");
                CurrSpriteRenderer.sprite = ButtonDisableSprite;
            }

            return;
        }

#if UNITY_STANDALONE || UNITY_EDITOR
        if (Input.GetMouseButtonDown(0))
        {
            Rect sprite_rect = FHUtility.SpriteToWorldRect2D(CurrSpriteRenderer);
            if(FHUtility.ScreenPostionInWorldRect2D(Input.mousePosition, sprite_rect))
            {
                //按钮按下
                CurrSpriteRenderer.sprite = ButtonPressSprite;

                //触发点击事件
                if (OnMouseButtonDownCallBack != null)
                {
                    OnMouseButtonDownCallBack();
                }
            }
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Rect sprite_rect = FHUtility.SpriteToWorldRect2D(CurrSpriteRenderer);
            if (FHUtility.ScreenPostionInWorldRect2D(Input.mousePosition, sprite_rect))
            {
                //松开按钮
                CurrSpriteRenderer.sprite = ButtonNormalSprite;

                //触发点击事件
                if (OnMouseButtonUpCallBack != null)
                {
                    OnMouseButtonUpCallBack();
                }
            }
        }
#elif UNITY_ANDROID || UNITY_IPHONE
        Debug.Log("手游部分还未跟进...");

#endif
    }

}
