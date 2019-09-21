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

    }

    void PointerOut(GameObject button)
    {
        
    }

}
