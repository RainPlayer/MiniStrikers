using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    bool IsDirectionUp = false;
    bool IsDirectionDown = false;

    int MenuSelectedIndex = 0;
    Transform Menu;
    Transform Items;
    Transform MenuCursor;
    int MenuLength = 0;

    // Start is called before the first frame update
    void Start()
    {
        Constant.ObjectIsPlayingSound(this);

        //恢复初始状态
        Constant.GameIsPause = false;
        Constant.PlayerPlane = "Plane0";
        Constant.PlayerLifeCurr = Constant.PlayerLife;
        Constant.ScoreCurr = 0;
        Constant.StageCurr = Constant.Stage01Scene;
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
        //恢复初始状态 end

        Menu = transform.Find("Canvas/Menu");
        Items = Menu.Find("Items");
        MenuCursor = Menu.Find("MenuCursor");
        MenuLength = Items.childCount;

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

                if (MenuSelectedIndex > 0)
                {
                    MenuSelectedIndex--;
                    GetComponents<AudioSource>()[1].Play();

                    Transform MenuSelectedItem = Items.GetChild(MenuSelectedIndex);
                    MenuCursor.localPosition = new Vector3(MenuCursor.localPosition.x, MenuSelectedItem.localPosition.y, MenuCursor.localPosition.z);
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

                if (MenuSelectedIndex + 1 < MenuLength)
                {
                    MenuSelectedIndex++;
                    GetComponents<AudioSource>()[1].Play();

                    Transform MenuSelectedItem = Items.GetChild(MenuSelectedIndex);
                    MenuCursor.localPosition = new Vector3(MenuCursor.localPosition.x, MenuSelectedItem.localPosition.y, MenuCursor.localPosition.z);
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
        //按了确认键
        if (Input.GetKey(KeyCode.L) || Input.GetButton("Fire2_JS"))
        {
            if (MenuSelectedIndex == 0)
            {
                //Start
                PlayerPrefs.SetInt(Constant.NextSceneIndex, Constant.PlayerSelectScene);
                SceneManager.LoadScene(Constant.LoadingScene);
            }
            else if (MenuSelectedIndex == 1)
            {
                //Option

                //加载资源少，用同步加载高效一点
                SceneManager.LoadScene(Constant.OptionScene);
            }
            else if (MenuSelectedIndex == 2)
            {
                //Exit
#if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
            }
        }
        //按了确认键
        //======================================

    }

}
