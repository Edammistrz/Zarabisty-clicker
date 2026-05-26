using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Clicker/New Worker")]
public class Worker : ScriptableObject
{
    [Header("General")]
    public string workerName;
    public int power;

    public int price;
}
