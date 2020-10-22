using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingManager : MonoBehaviour
{
    public GameObject SettingScreen;//设置UI界面
    public GameObject BackPackScreen;//背包UI界面

    // Start is called before the first frame update
    void Start()
    {
        SettingScreen.SetActive(false);
        BackPackScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    //打开设置UI界面
    public void OpenSetting()
    {
        SettingScreen.SetActive(true);
    }

    //关闭设置UI界面
    public void CloseSetting()
    {
        SettingScreen.SetActive(false);
    }
    //打开背包UI界面
    public void OpenBackPack()
    {
        BackPackScreen.SetActive(true);
    }
    //关闭背包UI界面
    public void CloseBackPack()
    {
        BackPackScreen.SetActive(false);
    }
    //返回开始场景
    public void ReturnStartScene()
    {
        SceneManager.LoadScene(1);
    }
}