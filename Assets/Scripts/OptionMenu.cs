using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionMenu : MonoBehaviour
{
    bool IsDirectionUp = false;
    bool IsDirectionDown = false;
    bool IsDirectionLeft = false;
    bool IsDirectionRight = false;

    int MenuSelectedIndex = 0;
    Transform Items;
    Transform ItemPlayerLifeText;
    Transform ItemSoundText;
    Transform MenuCursor;
    int MenuLength = 0;

    // Start is called before the first frame update
    void Start()
    {
		Constant.ObjectIsPlayingSound(this);
		
        Items = transform.Find("Items");
        MenuCursor = transform.Find("MenuCursor");
        MenuLength = Items.childCount;

        Transform item_player_life = Items.Find("Item_PlayerLife");
        Transform item_sound = Items.Find("Item_Sound");

        ItemPlayerLifeText = item_player_life.Find("Text");
        ItemSoundText = item_sound.Find("Text");

        ItemPlayerLifeText.GetComponent<Text>().text = Constant.PlayerLife.ToString();
        ItemSoundText.GetComponent<Text>().text = Constant.GameIsPlayingSound ? "On" : "Off";

        //移动端不显示光标
#if UNITY_ANDROID || UNITY_IPHONE
        MenuCursor.localScale = Vector3.zero;
#endif
    }

    // Update is called once per frame
    void Update()
    {

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
        }
        else
        {
            if (IsDirectionUp)
            {
                IsDirectionUp = false;

                if (MenuSelectedIndex > 0)
                {
                    MenuSelectedIndex--;
                    GetComponent<AudioSource>().Play();

                    Transform MenuSelectedItem = Items.GetChild(MenuSelectedIndex);
                    MenuCursor.localPosition = new Vector3(MenuCursor.localPosition.x, MenuSelectedItem.localPosition.y, MenuCursor.localPosition.z);
                }
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
        }
        else
        {
            if (IsDirectionDown)
            {
                IsDirectionDown = false;

                if (MenuSelectedIndex + 1 < MenuLength)
                {
                    MenuSelectedIndex++;
                    GetComponent<AudioSource>().Play();

                    Transform MenuSelectedItem = Items.GetChild(MenuSelectedIndex);
                    MenuCursor.localPosition = new Vector3(MenuCursor.localPosition.x, MenuSelectedItem.localPosition.y, MenuCursor.localPosition.z);
                }
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
                IsDirectionLeft = true;
            }
        }
        else
        {
            if (IsDirectionLeft)
            {
                IsDirectionLeft = false;

                if (MenuSelectedIndex == 0)
                {
                    if (Constant.PlayerLife > 0)
                    {
                        Constant.PlayerLife--;
                    }
                    ItemPlayerLifeText.GetComponent<Text>().text = Constant.PlayerLife.ToString();
                }
                else if (MenuSelectedIndex == 1)
                {
                    Constant.GameIsPlayingSound = !Constant.GameIsPlayingSound;
                    ItemSoundText.GetComponent<Text>().text = Constant.GameIsPlayingSound ? "On" : "Off";
                }
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
                IsDirectionRight = true;
            }
        }
        else
        {
            if (IsDirectionRight)
            {
                IsDirectionRight = false;

                if (MenuSelectedIndex == 0)
                {
                    if (Constant.PlayerLife < 5)
                    {
                        Constant.PlayerLife++;
                    }
                    ItemPlayerLifeText.GetComponent<Text>().text = Constant.PlayerLife.ToString();
                }
                else if (MenuSelectedIndex == 1)
                {
                    Constant.GameIsPlayingSound = !Constant.GameIsPlayingSound;
                    ItemSoundText.GetComponent<Text>().text = Constant.GameIsPlayingSound ? "On" : "Off";
                }
            }
        }
        //方向右
        //======================================

        //======================================
        //按了确认键
        if (Input.GetKey(KeyCode.L) || Input.GetButton("Fire2_JS"))
        {
            if (MenuSelectedIndex == 2)
            {
                //Exit
                PlayerPrefs.SetInt(Constant.NextSceneIndex, Constant.OpeningScene);
                SceneManager.LoadScene(Constant.LoadingScene);
            }
        }
        //按了确认键
        //======================================

    }

}
