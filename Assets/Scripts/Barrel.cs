using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour, ITakeDamage
{
    /*interfaces have to implement the same methods 
      and react to the same contract
      but how they do it can vary*/

    public void TakeDamage(int damage)
    {
        Destroy(gameObject);
    }
}
