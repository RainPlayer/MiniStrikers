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

        PlayAudioCallback(GetComponent<AudioSource>(), ChangeScene);
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

    void ChangeScene()
    {
        PlayerPrefs.SetInt(Constant.NextSceneIndex, Constant.MainScene);
        SceneManager.LoadScene(Constant.LoadingScene);
    }

    //声音播放的回调
    delegate void AudioCallBack();
    void PlayAudioCallback(AudioSource audio, AudioCallBack callback)
    {
        audio.Play();
        StartCoroutine(DelayedCallback(audio.clip.length, callback));
    }
    IEnumerator DelayedCallback(float time, AudioCallBack callback)
    {
        yield return new WaitForSeconds(time);
        callback();
    }
    //声音播放的回调 end

}
