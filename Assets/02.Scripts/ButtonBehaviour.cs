using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonBehaviour : MonoBehaviour
{
    void OnEnable()
    {
        LaserPointer.OnPointerIn  += this.PointerIn;
        LaserPointer.OnPointerOut += this.PointerOut;
    }

    void OnDisable()
    {
        LaserPointer.OnPointerIn  -= this.PointerIn;
        LaserPointer.OnPointerOut -= this.PointerOut;
    }    

    void PointerIn(GameObject button)
    {
        if (button == this.gameObject)
        {
            ExecuteEvents.Execute(this.gameObject
                                , new PointerEventData(EventSystem.current)
                                , ExecuteEvents.pointerEnterHandler);
        }
    }

    void PointerOut(GameObject button)
    {
        if (button == this.gameObject)
        {
            ExecuteEvents.Execute(this.gameObject
                                , new PointerEventData(EventSystem.current)
                                , ExecuteEvents.pointerExitHandler);
        }       
    }

}
