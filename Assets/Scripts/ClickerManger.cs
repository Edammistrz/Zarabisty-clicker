using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickerMenager : MonoBehaviour
{
    [SerializeField] private ClickerUi clickerUi;
    [SerializeField] private Button clickerButton;

    private int pointsCounter = 0;

    private void Start()
    {
        clickerUi.UpdateUi(pointsCounter);
        clickerButton.onClick.AddListener(AddPoints);
    }

    private void AddPoints()
    {
        pointsCounter += 1;
        clickerUi.UpdateUi(pointsCounter);
    }
}
