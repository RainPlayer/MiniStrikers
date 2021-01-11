using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    bool IsDirectionUp = false;
    bool IsDirectionDown = false;

    int MenuSelectedIndex = 0;
    Transform Items;
    Transform MenuCursor;
    int MenuLength = 0;

    // Start is called before the first frame update
    void Start()
    {
		Constant.ObjectIsPlayingSound(this);
		
        Items = transform.Find("Items");
        MenuCursor = transform.Find("MenuCursor");
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
        //按了确认键
        if (Input.GetKey(KeyCode.L) || Input.GetButton("Fire2_JS"))
        {
            if (MenuSelectedIndex == 0)
            {
                //Continue，初始化
                Constant.GameIsPause = false;
                Constant.PlayerLifeCurr = Constant.PlayerLife;
                Constant.ScoreCurr = 0;

                PlayerPrefs.SetInt(Constant.NextSceneIndex, Constant.StageSurr);
                SceneManager.LoadScene(Constant.LoadingScene);
            }
            else if (MenuSelectedIndex == 1)
            {
                //End
                PlayerPrefs.SetInt(Constant.NextSceneIndex, Constant.OpeningScene);
                SceneManager.LoadScene(Constant.LoadingScene);
            }

        }
        //按了确认键
        //======================================

    }

}
