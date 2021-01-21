using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;
using System.Reflection;

public class StageCommon : MonoBehaviour
{
    //游戏进行到什么状态
    public enum GameProgress
    {
        Normal = 0,
        Boss = 1 //boss战
    };

    public string StageCurr = "Stage01";

    FHSpriteText Score;
    FHSpriteText PlayerLife;

    Transform PlayerLayer;
    Transform HideLayer;
    EnemyLayer EnemyLayerScript;

    //敌机的数据
    IDictionary<float, string[]> EnemyData = null;

    GameProgress CurrGameProgress = GameProgress.Normal;

    // Start is called before the first frame update
    void Start()
    {
        Constant.ObjectIsPlayingSound(this);

        PlayerLayer = transform.root.Find("PlayerLayer");
        HideLayer = transform.root.Find("HideLayer");
        Transform enemy_layer = transform.Find("EnemyLayer");
        EnemyLayerScript = enemy_layer.GetComponent<EnemyLayer>();

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

        //获取当前场景的敌机数据
        Component stage_script = GetComponent(System.Type.GetType(StageCurr));
        System.Type stage_script_type = stage_script.GetType();
        EnemyData = (IDictionary<float, string[]>)stage_script_type.GetField("EnemyData").GetValue(stage_script);

    }

    // Update is called once per frame
    void Update()
    {
        //敌机数据解析
        IList<KeyValuePair<float, string[]>> curr_enemys_data = EnemyData.Where(t => t.Key <= transform.localPosition.y).ToList();
        while (curr_enemys_data.Count > 0)
        {
            //1条敌机数据结构：显示y坐标,敌机组
            KeyValuePair<float, string[]> enemys = curr_enemys_data[0];

            //遍历敌机组
            foreach (var enemy in enemys.Value)
            {
                string[] data = enemy.Split(',');

                string enemy_name = ""; //敌机对象名称
                float init_x = -1000f; //敌机出现的x坐标
                IDictionary<string, object> enemy_params = new Dictionary<string, object>(); //需要设置的参数
                foreach (var item in data)
                {
                    //如果是敌机对象名称或敌机出现的x坐标，则设置变量
                    //除此之外均视为参数，然后加入参数组
                    string[] tmp = item.Split(':');
                    if (tmp[0] == "Name") enemy_name = tmp[1];
                    else if (tmp[0] == "InitX") init_x = float.Parse(tmp[1]);
                    else enemy_params.Add(tmp[0], tmp[1]);

                }

                //获取数据后，进行敌机初始化处理
                if (enemy_name != "" && init_x > -1000f)
                {
                    Transform enemy_obj = EnemyLayerScript.InitEnemy(enemy_name, init_x);
                    string enemy_script_name = enemy_obj.name.Replace("(Clone)", "").Split('_')[0] + "CPU";
                    Component enemy_script = enemy_obj.GetComponent(System.Type.GetType(enemy_script_name));
                    System.Type enemy_script_type = enemy_script.GetType();
                    foreach (var enemy_param in enemy_params)
                    {
                        FieldInfo field = enemy_script_type.GetField(enemy_param.Key);
                        field.SetValue(enemy_script, float.Parse(enemy_param.Value.ToString()));
                    }

                }
            }

            //已经使用过的敌机数据就删除
            curr_enemys_data.Remove(enemys);
            EnemyData.Remove(enemys);
        }
        //敌机数据解析 end

#if UNITY_STANDALONE || UNITY_EDITOR
        UpdatePC();
#endif

    }

    private void OnDestroy()
    {
        if (EnemyData != null)
        {
            EnemyData.Clear();
        }

    }

    void UpdatePC()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Start"))
        {
            AudioSource[] audios = GetComponents<AudioSource>();

            //按了暂停游戏
            audios[2].Play();

            if (Constant.GameIsPause)
            {
                //暂停游戏的情况下继续游戏
                audios[(int)CurrGameProgress].Play();
                Time.timeScale = 1;
                Constant.GameIsPause = false;
            }
            else
            {
                //正常游戏的情况下暂停游戏
                audios[(int)CurrGameProgress].Pause();
                Time.timeScale = 0;
                Constant.GameIsPause = true;
            }
            
        }
        if (Input.GetKeyDown(KeyCode.Escape) && Constant.GameIsPause)
        {
            //暂停游戏的时候按ESC键就退出游戏
            PlayerPrefs.SetInt(Constant.NextSceneIndex, Constant.MainScene);
            SceneManager.LoadScene(Constant.LoadingScene);
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
        Transform player_plane = PlayerLayer.Find(Constant.PlayerPlane);
        if (player_plane != null)
        {
            Destroy(player_plane);
        }

        Transform PlayerPlane = Instantiate(HideLayer.Find(Constant.PlayerPlane));
        PlayerPlane.name = Constant.PlayerPlane;
        PlayerPlane.SetParent(PlayerLayer);
        PlayerPlane.localPosition = Constant.PlayerPlaneInitPosition;
    }

    public void ChnageGameProgress(GameProgress game_progress)
    {
        CurrGameProgress = game_progress;

        //切换BGM
        AudioSource[] audios = GetComponents<AudioSource>();
        if (CurrGameProgress == GameProgress.Normal)
        {
            audios[1].Stop();
            audios[0].Play();
            return;
        }

        //boss
        audios[0].Stop();
        audios[1].Play();
    }

}
