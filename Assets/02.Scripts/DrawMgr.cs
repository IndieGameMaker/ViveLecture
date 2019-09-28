using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class DrawMgr : MonoBehaviour
{
    public SteamVR_Input_Sources rightHand = SteamVR_Input_Sources.RightHand;
    public SteamVR_Action_Boolean trigger  = SteamVR_Actions.default_InteractUI;
    public SteamVR_Action_Pose pose        = SteamVR_Actions.default_Pose;

    public Color lineColor = Color.white;
    public float lineWidth = 0.01f;
    private LineRenderer line;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //
        if (trigger.GetStateDown(rightHand))
        {
            CreateLineObject();
        }
        //
        if (trigger.GetState(rightHand))
        {
            Vector3 pos = pose.GetLocalPosition(rightHand);
            //라인의 노드 갯수 증가
            line.positionCount++;
            line.SetPosition(line.positionCount-1, pos);
        }

    }

    void CreateLineObject()
    {
        //빈 게임오브젝트 생성
        GameObject lineObject = new GameObject("Line");
        //lineObject.transform.position = transform.position + pose.GetLocalPosition(rightHand);

        //라인렌더러 컴포넌트를 추가
        line = lineObject.AddComponent<LineRenderer>();
        //머티리얼 생성 및 적용
        Material mt = new Material(Shader.Find("Unlit/Color"));
        mt.color = lineColor;
        line.material = mt;
        //라인렌더러의 속성 설정
        line.useWorldSpace = false; //로컬좌표 기준으로 생성
        line.numCapVertices = 20;
        //라인의 폭 설정
        line.widthMultiplier = 0.1f;
        line.startWidth = lineWidth;
        line.endWidth   = lineWidth;

        line.positionCount = 1;
        line.SetPosition(0, pose.GetLocalPosition(rightHand));
    }
}
