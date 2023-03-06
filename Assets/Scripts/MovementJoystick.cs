using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MovementJoystick : MonoBehaviour
{
    public GameObject joystick;
    public GameObject joystickBg;
    public Vector2 joystickVec;
    private Vector2 joystickTouchPos;
    private Vector2 joystickOriginalPos;
    private float joystickRadius;

    public float radius = 4;



    void Start()
    {
        joystickOriginalPos = joystickBg.transform.position;
        //joystickRadius = joystickBg.GetComponent<RectTransform>().sizeDelta.y / 4;
        joystickRadius = joystickBg.GetComponent<RectTransform>().sizeDelta.y / radius;
    }

    /*public void PointerDown()
    {
        int i = Input.touches.Length;

        if (i == 1)
        {
            joystick.transform.position = Input.mousePosition;
            joystickBg.transform.position = Input.mousePosition;
            joystickTouchPos = Input.mousePosition;
        }

        else
        {
            int id = SortArray();
            joystick.transform.position = Input.touches[id].position;
            joystickBg.transform.position = Input.touches[id].position;
            joystickTouchPos = Input.touches[id].position;
        }
        
    }*/

    public void PointerDown()
    {
        joystick.transform.position = Input.mousePosition;
        joystickBg.transform.position = Input.mousePosition;
        joystickTouchPos = Input.mousePosition;
    }


    /*private int SortArray()
    {
        Touch[] inputlist = Input.touches;
        float[] listpositioninputX = new float[inputlist.Length];
        int id = 0;
        for (int i = 0; i < inputlist.Length; i++)
        {
            listpositioninputX[i] = inputlist[i].position.x;
        }
        Comparison<float> compare = new Comparison<float>((numero1, numero2) => numero1.CompareTo(numero2));
        Array.Sort<float>(listpositioninputX, compare);

        for (int i = 0; i < inputlist.Length; i++)
        {
            if (listpositioninputX[0] == inputlist[i].position.x)
            {
                return id = inputlist[i].fingerId;
            }
        }
        return id;

    }*/


    public void Drag(BaseEventData baseEventData)
    {
        PointerEventData pointerEventData = baseEventData as PointerEventData;
        Vector2 dragPos = pointerEventData.position;
        joystickVec = (dragPos - joystickTouchPos).normalized;

        float joystickDist = Vector2.Distance(dragPos, joystickTouchPos);

        if (joystickDist < joystickRadius)
        {
            joystick.transform.position = joystickTouchPos + joystickVec * joystickDist;
        }

        else
        {
            joystick.transform.position = joystickTouchPos + joystickVec * joystickRadius;
        }
    }

    public void PointerUp()
    {
        joystickVec = Vector2.zero;
        joystick.transform.position = joystickOriginalPos;
        joystickBg.transform.position = joystickOriginalPos;
    }
    
}
