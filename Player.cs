using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int coins = 0;
    public AudioSource audiosource;
    public 
    public void ChangeCoins(int count_coins)
    {
        coins += count_coins;
        print("Кол-во монеток:" + coins);
    }
}
