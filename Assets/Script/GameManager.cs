using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    bool isStop;

    // Start is called before the first frame update
    void Start()
    {
        isStop = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    //进入游戏场景
    public void EnterScene()
    {
        SceneManager.LoadScene(2);
    }

    //退出游戏
    public void ExitScene()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    //暂停游戏
    public void stopGame()
    {
        if (isStop == false)
        {
            Time.timeScale = 0;
            Debug.Log(isStop);
            isStop = true;
            Debug.Log(isStop);
        }
        else if (isStop == true)
        {
            Debug.Log(isStop);
            Time.timeScale = 1;
            isStop = false;
            Debug.Log(isStop);
        }

    }
    }