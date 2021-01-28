using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScene : MonoBehaviour
{
    private AsyncOperation Async;
    private Transform LoadingIco;

    private float MaxY = 0;
    private float CurrProcess = 0;

    private IEnumerator LoadScene(int scene)
    {
        Async = SceneManager.LoadSceneAsync(scene);
        Async.allowSceneActivation = false;

        yield return Async;
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

        int next_scene_index = PlayerPrefs.GetInt(Constant.NextSceneIndex, Constant.MainScene);
        StartCoroutine(LoadScene(next_scene_index));
    }

    // Update is called once per frame
    void Update()
    {
        //异步loading
        if (Async != null)
        {
            //坑爹的progress，最多到0.9f
            CurrProcess = Async.progress * (1f / 0.9f);

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
                Async.allowSceneActivation = true;
            }
        }
        //异步loading end
    }
}
