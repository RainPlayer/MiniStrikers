using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageCommon : MonoBehaviour
{
    FHSpriteText Score;
    FHSpriteText PlayerNum;

    // Start is called before the first frame update
    void Start()
    {
        //临时数据
        uint player_num = 2;
        uint score = 0;
        string plane_name = "Plane0";

        Transform player_info = transform.Find("PlayerInfo");
        Transform player_layer = transform.Find("PlayerLayer");
        Transform player_num_ico = player_info.Find("PlayerNumIco");

        Score = player_info.Find("Score").GetComponent<FHSpriteText>();
        Score.SetStringContent(score.ToString());

        PlayerNum = player_num_ico.Find("PlayerNum").GetComponent<FHSpriteText>();
        PlayerNum.SetStringContent(player_num.ToString());

        Transform plane = player_layer.Find(plane_name);
        player_num_ico.GetComponent<SpriteRenderer>().sprite = plane.Find(plane_name.ToLower()).GetComponent<SpriteRenderer>().sprite;

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
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Start"))
        {
            //按了暂停游戏
            GetComponents<AudioSource>()[1].Play();

            if (Constant.GameIsPause)
            {
                //暂停游戏的情况下继续游戏
                GetComponents<AudioSource>()[0].Play();
                Constant.GameIsPause = false;
            }
            else
            {
                //正常游戏的情况下暂停游戏
                GetComponents<AudioSource>()[0].Pause();
                Constant.GameIsPause = true;
            }
            
        }

    }

}
