using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SelectedCounterVisual : MonoBehaviour
{
    [SerializeField] private BaseCounter baseCounter;
    [SerializeField] private GameObject[] visualGameObjectArray;

    private void Start()
    {
        Player.Instance.OnSelectedCounterChanged += Player_OnSelectedCounterChanged;
    }

    private void Player_OnSelectedCounterChanged(object sender, EventArgs e)
    {
        if (e is Player.OnSelectedCounterChangedEventArgs args)
        {
            if (args.selectedCounter == baseCounter)
            {
                Show();
            }
            else
            {
                Hide();
            }
        }
    }

    private void Show()
    {
        foreach (GameObject visualGameObject in visualGameObjectArray) { visualGameObject.SetActive(true); }
    }

    private void Hide()
    {
        foreach (GameObject visualGameObject in visualGameObjectArray) { visualGameObject.SetActive(false); }
    }
}
