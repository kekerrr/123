aaausing System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Fireball")
        {
            Destroy("Fireball"), Destroy("Enemy");
        }

        // Update is called once per frame
        void Update()
    {
        transform.position +=
       transform.forward *
       speed * Time.deltaTime;
      
    }
        void Start()
    {
        Destroy("Fireball", 3);
    }

}
