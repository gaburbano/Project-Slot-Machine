using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SpinButtonBehavior : MonoBehaviour
{
    private Button button;
    
    public Action ClickEvent;
    
    private void Start()
    {
        button = GetComponent<Button>();
    }
    
    public void OnPointerDown(PointerEventData eventData)
    {
        if (button && !button.interactable) return;
    }
    
    public void OnPointerUp(PointerEventData eventData)
    {
        ClickEvent?.Invoke();
    }
}
