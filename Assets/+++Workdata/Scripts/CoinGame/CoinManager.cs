using System;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] public int counterInt = 0;
    [SerializeField] private UI_Manager uiManager;

    private void Start()
    {
        counterInt = 0;
        uiManager.UpdateCounter(counterInt);
    }

    public void AddCoin()
    {
        counterInt++;
        uiManager.UpdateCounter(counterInt);
    }
}
