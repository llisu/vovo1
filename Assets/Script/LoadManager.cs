using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //引入命名空间
using UnityEngine.SceneManagement;//引入命名空间

public class LoadManager : MonoBehaviour
{
    public GameObject LoadScreen;
    public Slider slider;  //UI进度条
    public Text text;//文本框显示进度
    private AsyncOperation async;//UI应该达到的进度
    private int currProgress;
    //1. 获取滑动条
    //协同加载(异步加载 不断获取进度值 经过计算赋值给滑动条)
    // Use this for initialization
    void Start()
    {
        currProgress = 0;
        async = null;
        StartCoroutine("LoadScene");
    }

    // Update is called once per frame
    void Update()
    {
        //目的就是现实进度
        slider.value = currProgress / 100.0f;
        text.text = "资源正在加载:  " + slider.value * 100 + "%";
    }


    IEnumerator LoadScene()
    {

        LoadScreen.SetActive(true);
        //临时的进度
        int tmp;
        //异步加载
        async = SceneManager.LoadSceneAsync(1);  //

        //先不显示场景 等到进度为100%的时候显示场景 必须的!!!!
        async.allowSceneActivation = false;
        #region 优化进度的 
        while (async.progress < 0.9f)
        {
            //相当于滑动条应该到的位置
            tmp = (int)async.progress * 100;

            //当滑动条 < tmp 就意味着滑动条应该变化
            while (currProgress < tmp)
            {
                ++currProgress;
                yield return new WaitForEndOfFrame();
            }
        }//while end   进度为90%
        tmp = 100;
        while (currProgress < tmp)
        {

            ++currProgress;
            yield return new WaitForEndOfFrame();
        }
        #endregion


        //进度条完成 允许显示
        async.allowSceneActivation = true;

    }
}