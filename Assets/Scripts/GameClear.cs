using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameClear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		Constant.ObjectIsPlayingSound(this);
		
        StartCoroutine(AutoChangeScene());
    }

    // Update is called once per frame
    void Update()
    {
        //======================================
        //按了确认键
        if (Input.GetKey(KeyCode.L) || Input.GetButton("Fire2_JS"))
        {
            ChangeScene();
        }
        //按了确认键
        //======================================
    }
	
	IEnumerator AutoChangeScene()
    {
        yield return new WaitForSeconds(12f);
        ChangeScene();
    }

    void ChangeScene()
    {
        PlayerPrefs.SetInt(Constant.NextSceneIndex, Constant.OpeningScene);
        SceneManager.LoadScene(Constant.LoadingScene);
    }

}
