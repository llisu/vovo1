using HTC.UnityPlugin.Vive;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (ViveInput.GetPressDownEx(HandRole.RightHand, ControllerButton.Trigger))
        {
            Debug.Log("HandRole.RightHand");
        }
        //获取扳机轴
        Debug.Log(ViveInput.GetAxisEx(HandRole.RightHand, ControllerAxis.Trigger));
    }
}
