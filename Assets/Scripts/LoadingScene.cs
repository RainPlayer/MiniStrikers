using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScene : MonoBehaviour
{
    private AsyncOperation async;
    private Transform LoadingIco;

    private float MaxY = 0;
    private float CurrProcess = 0;

    private IEnumerator LoadScene(int scene)
    {
        async = SceneManager.LoadSceneAsync(scene);
        async.allowSceneActivation = false;

        yield return async;
    }

    // Start is called before the first frame update
    void Start()
    {
		Constant.ObjectIsPlayingSound(this);
		
        LoadingIco = Camera.main.transform.Find("LoadingIco");
        SpriteRenderer loading_ico_sprite_renderer = LoadingIco.GetComponent<SpriteRenderer>();

        //loading的y坐标全长是-Camera.main.orthographicSize - (loading_ico_sprite_renderer.size.y * LoadingIco.localScale.y / 2f) 到 Camera.main.orthographicSize + (loading_ico_sprite_renderer.size.y * LoadingIco.localScale.y / 2f)

        float ico_size_y2 = loading_ico_sprite_renderer.size.y * LoadingIco.localScale.y / 2f;
        MaxY = (Camera.main.orthographicSize + ico_size_y2) * 2f;

        LoadingIco.localPosition = new Vector3(0f, -Camera.main.orthographicSize - ico_size_y2, 10f);

        int next_scene_index = PlayerPrefs.GetInt(Constant.NextSceneIndex, Constant.OpeningScene);
        StartCoroutine(LoadScene(next_scene_index));
    }

    // Update is called once per frame
    void Update()
    {
        //异步loading
        if (async == null)
        {
            return;
        }

        //坑爹的progress，最多到0.9f
        CurrProcess = async.progress * (1f / 0.9f);

        //显示部分
        if (LoadingIco.localPosition.y < MaxY / 2f)
        {
            LoadingIco.localPosition = new Vector3(0f, LoadingIco.localPosition.y + (CurrProcess * MaxY), 10f);
        }
        else
        {
            LoadingIco.localPosition = new Vector3(0f, MaxY, 10f);
        }
        //Debug.Log(LoadingIco.localPosition.y);

        if (CurrProcess == 1f) //async.isDone应该是在场景被激活时才为true
        {
            async.allowSceneActivation = true;
        }

        //异步loading end
    }
}
