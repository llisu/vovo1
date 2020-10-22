using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{
    public AudioClip music;
    private AudioSource back;
    //public Slider slider;
    void Start()
    {
        back = this.GetComponent<AudioSource>();
        back.loop = false; //设置循环播放  
        back.volume = 0.8f;//设置音量最大，区间在0-1之间
        back.clip = music;
        back.Play(); //播放背景音乐
    }

    void Update()
    {
        //back.volume = slider.value;

    }
    public void OnMusicOpen()
    {
        back.Play(); //播放背景音乐
    }
    public void OnMusicOff()
    {
        back.Stop(); //播放背景音乐
    }

}
