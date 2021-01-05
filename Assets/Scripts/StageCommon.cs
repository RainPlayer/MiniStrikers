using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageCommon : MonoBehaviour
{
    FHSpriteText Score;
    FHSpriteText PlayerNum;

    Transform PlayerLayer;
    Transform HideLayer;

    // Start is called before the first frame update
    void Start()
    {
        PlayerLayer = transform.root.Find("PlayerLayer");
        HideLayer = transform.root.Find("HideLayer");
        Transform player_info = transform.Find("PlayerInfo");
        Transform player_layer = transform.Find("PlayerLayer");
        Transform player_num_ico = player_info.Find("PlayerNumIco");

        Score = player_info.Find("Score").GetComponent<FHSpriteText>();
        PlayerNum = player_num_ico.Find("PlayerNum").GetComponent<FHSpriteText>();

        SetScore(Constant.ScoreCurr);
        SetPlayerNum(Constant.PlayerNumCurr);
        PlayerPlaneGo();

        //右上角的icon
        Transform plane = player_layer.Find(Constant.PlayerPlane);
        player_num_ico.GetComponent<SpriteRenderer>().sprite = plane.Find(Constant.PlayerPlane.ToLower()).GetComponent<SpriteRenderer>().sprite;

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

    public int GetPlayerNum()
    {
        return int.Parse(PlayerNum.StringContent);
    }

    public void SetPlayerNum(int player_num)
    {
        PlayerNum.SetStringContent(player_num.ToString());
        Constant.PlayerNumCurr = player_num;
    }

    public int GetScore()
    {
        return int.Parse(Score.StringContent);
    }

    public void SetScore(int score)
    {
        Score.SetStringContent(score.ToString());
        Constant.ScoreCurr = score;
    }

    public void PlayerPlaneGo()
    {
        Transform PlayerPlane = Instantiate(HideLayer.Find(Constant.PlayerPlane));
        PlayerPlane.name = Constant.PlayerPlane;
        PlayerPlane.SetParent(PlayerLayer);
        PlayerPlane.localPosition = new Vector3(0, -4.5f, 12f);

    }

}
