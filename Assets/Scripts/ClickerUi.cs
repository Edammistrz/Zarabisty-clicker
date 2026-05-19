using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClickerUi : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI couterText;

    public void UpdateUi (int amount)
    {
        couterText.text = $"Point: {amount}";
    }
}
