using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class ViveController : MonoBehaviour
{
    public SteamVR_Input_Sources leftHand = SteamVR_Input_Sources.LeftHand;
    public SteamVR_Input_Sources rightHand = SteamVR_Input_Sources.RightHand;
    public SteamVR_Input_Sources any = SteamVR_Input_Sources.Any;

    //트리거 버튼
    public SteamVR_Action_Boolean trigger = SteamVR_Actions.default_InteractUI;
    //트랙패드 터치
    public SteamVR_Action_Boolean trackPadTouch = SteamVR_Actions.default_TrackpadTouch;
    //트랙패드의 위치(Vector2)
    public SteamVR_Action_Vector2 trackPadPosition = SteamVR_Actions.default_TrackpadPosition;
    //그랩버튼
    public SteamVR_Action_Boolean grabGrip = SteamVR_Actions.default_GrabGrip;
    //헵틱
    public SteamVR_Action_Vibration haptic = SteamVR_Actions.default_Haptic;

    void Update()
    {
        if (trigger.GetStateDown(any))
        {
            Debug.Log("Left Trigger Clicked");
        }

        if (trackPadTouch.GetState(rightHand))
        {
            Vector2 pos = trackPadPosition.GetAxis(rightHand);
            Debug.LogFormat("x={0}, y={1}" , pos.x, pos.y);
        }

        if (grabGrip.GetState(any))
        {
            Debug.Log("Grab Grip");
            haptic.Execute(0.3f, 0.2f, 200.0f, 0.5f, leftHand);
        }
    }

    public void OnClickButton(string msg)
    {
        Debug.Log("Click " + msg);
    }
}
