using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSelect : MonoBehaviour
{
    Transform PlayerLayer;
    bool IsDirectionLeft = false;
    bool IsDirectionRight = false;
    int PlayerSelectedIndex = 0;

    bool IsGameGo = false;
    float NextFlashTime = 0f;
    float FlashAnimIntervalTime = 0.08f;

    // Start is called before the first frame update
    void Start()
    {
        Constant.ObjectIsPlayingSound(this);

        PlayerLayer = transform.Find("PlayerLayer");
        for (int i = 0; i < PlayerLayer.childCount; i++)
        {
            Transform plane = PlayerLayer.GetChild(i);
            SpriteRenderer plane_sprite_renderer = plane.GetComponent<SpriteRenderer>();

            float a = 0.4f;
            if (Constant.PlayerPlane == plane.name)
            {
                a = 1f;
                PlayerSelectedIndex = i;
            }
            plane_sprite_renderer.color = new Color(plane_sprite_renderer.color.r, plane_sprite_renderer.color.g, plane_sprite_renderer.color.b, a);
        }
    }

    // Update is called once per frame
    void Update()
    {
        FlashPlane();

        if (IsGameGo)
        {
            return;
        }

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

                if (PlayerSelectedIndex > 0)
                {
                    GetComponents<AudioSource>()[1].Play();
                    PlayerSelectedIndex--;
                    SelectedPlane();
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

                if (PlayerSelectedIndex + 1 < PlayerLayer.childCount)
                {
                    GetComponents<AudioSource>()[1].Play();
                    PlayerSelectedIndex++;
                    SelectedPlane();
                }
            }
        }
        //方向右
        //======================================

        //======================================
        //按了取消键
        if (Input.GetKey(KeyCode.K) || Input.GetButton("Fire1_JS"))
        {
            PlayerPrefs.SetInt(Constant.NextSceneIndex, Constant.OpeningScene);
            SceneManager.LoadScene(Constant.LoadingScene);
        }
        //按了取消键
        //======================================

        //======================================
        //按了确认键
        if (Input.GetKey(KeyCode.L) || Input.GetButton("Fire2_JS"))
        {
            GetComponents<AudioSource>()[2].Play();
            IsGameGo = true;
            StartCoroutine(GameGo());
        }
        //按了确认键
        //======================================

    }

    void SelectedPlane()
    {
        for (int i = 0; i < PlayerLayer.childCount; i++)
        {
            Transform plane = PlayerLayer.GetChild(i);
            SpriteRenderer plane_sprite_renderer = plane.GetComponent<SpriteRenderer>();

            float a = PlayerSelectedIndex == i ? 1f : 0.4f;
            plane_sprite_renderer.color = new Color(plane_sprite_renderer.color.r, plane_sprite_renderer.color.g, plane_sprite_renderer.color.b, a);
        }

        Constant.PlayerPlane = PlayerLayer.GetChild(PlayerSelectedIndex).name;
    }

    void FlashPlane()
    {
        Transform plane = PlayerLayer.GetChild(PlayerSelectedIndex);
        if (IsGameGo && Time.time > NextFlashTime)
        {
            if (plane.localScale.x != 0f)
            {
                plane.localScale = new Vector3(0f, 0f, 1f);
            }
            else
            {
                plane.localScale = Vector3.one;
            }

            NextFlashTime = Time.time + FlashAnimIntervalTime;
        }
    }

    IEnumerator GameGo()
    {
        yield return new WaitForSeconds(3.0f);

        PlayerPrefs.SetInt(Constant.NextSceneIndex, Constant.Stage01Scene);
        SceneManager.LoadScene(Constant.LoadingScene);
    }

}
