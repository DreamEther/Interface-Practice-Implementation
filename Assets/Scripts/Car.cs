using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour, ITakeDamage
{

    private int health = 10;

    //implementing our interface
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        Destroy(gameObject);
    }

}
