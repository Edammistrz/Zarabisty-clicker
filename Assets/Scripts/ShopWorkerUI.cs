using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ShopWorkerUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private Button buyButton;
    [SerializeField] private TextMeshProUGUI powerText;
    [SerializeField] private TextMeshProUGUI priceText;

    public void UpdateUI(Worker worker)
    {
        nameText.text = worker.workerName;
        powerText.text = worker.power.ToString();
        priceText.text = worker.price.ToString();

        buyButton.onClick.AddListener(delegate { BuyButtonOnClick(worker.price, worker.power); });
    }

    private void BuyButtonOnClick(int price, int power)
    {
        ClickerMenager.OnItemBought?.Invoke(price, power);
    }
}
