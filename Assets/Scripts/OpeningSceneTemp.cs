using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpeningSceneTemp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //这个是临时文件
		Constant.ObjectIsPlayingSound(this);
		
    }

    // Update is called once per frame
    void Update()
    {
        //======================================
        //按了确认键
        if (Input.GetKey(KeyCode.L) || Input.GetButton("Fire2_JS"))
        {
            PlayerPrefs.SetInt(Constant.NextSceneIndex, Constant.Stage01Scene);
            SceneManager.LoadScene(Constant.LoadingScene);
        }
        //按了确认键
        //======================================
    }
}
