using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class LaserPointer : MonoBehaviour
{
    private SteamVR_Behaviour_Pose pose;
    [SerializeField]
    private SteamVR_Input_Sources hand;
    public SteamVR_Action_Boolean trigger = SteamVR_Actions.default_InteractUI;

    //라인렌더러의 속성
    private LineRenderer line;
    public float maxDistance = 10.0f;           //광선의 최대거리
    public Color defaultColor = Color.white;    //광선의 기본 색상
    public Color clickedColor = Color.green;    //클릭했을 때의 색상

    void Start()
    {
        pose = GetComponent<SteamVR_Behaviour_Pose>();
        hand = pose.inputSource;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
