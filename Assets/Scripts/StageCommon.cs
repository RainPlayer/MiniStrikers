using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageCommon : MonoBehaviour
{
    FHSpriteText Score;
    FHSpriteText PlayerLife;

    Transform PlayerLayer;
    Transform HideLayer;

    // Start is called before the first frame update
    void Start()
    {
        Constant.ObjectIsPlayingSound(this);

        PlayerLayer = transform.root.Find("PlayerLayer");
        HideLayer = transform.root.Find("HideLayer");
        Transform player_info = transform.Find("PlayerInfo");
        Transform player_layer = transform.Find("PlayerLayer");
        Transform player_life_ico = player_info.Find("PlayerLifeIco");

        Score = player_info.Find("Score").GetComponent<FHSpriteText>();
        PlayerLife = player_life_ico.Find("PlayerLife").GetComponent<FHSpriteText>();

        Constant.PlayerLifeCurr = Constant.PlayerLife;

        SetScore(Constant.ScoreCurr);
        SetPlayerLife(Constant.PlayerLifeCurr);
        PlayerPlaneGo();

        //右上角的icon
        Transform plane = player_layer.Find(Constant.PlayerPlane);
        player_life_ico.GetComponent<SpriteRenderer>().sprite = plane.Find(Constant.PlayerPlane.ToLower()).GetComponent<SpriteRenderer>().sprite;

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
            GetComponents<AudioSource>()[2].Play();

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

    public int GetPlayerLife()
    {
        return int.Parse(PlayerLife.StringContent);
    }

    public void SetPlayerLife(int player_life)
    {
        PlayerLife.SetStringContent(player_life.ToString());
        Constant.PlayerLifeCurr = player_life;
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
        if (PlayerLayer.Find("Constant.PlayerPlane") == null)
        {
            Transform PlayerPlane = Instantiate(HideLayer.Find(Constant.PlayerPlane));
            PlayerPlane.name = Constant.PlayerPlane;
            PlayerPlane.SetParent(PlayerLayer);
            PlayerPlane.localPosition = new Vector3(0, -4.5f, 12f);
        }
    }

}
