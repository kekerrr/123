using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour

{
    private int price = 2;

    private void OnTriggerEnter(Collider other)

    {
        Plater player = other.GetComponent<player>();
        player.ChangeCoins(price);
        Destroy(gameObject);
    }
}
