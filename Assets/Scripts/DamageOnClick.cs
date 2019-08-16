using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnClick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            /* Unity's raycast function does exactly that. It shoots a ray, 
             * of a given length, in a given direction, and tells you about what it did
             * (or didn't) hit. Note that raycasting is calling a function. 
             * The raycast does not tell you anything apart from a book saying whether you hit 
             * something */

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo)) // a bool essentially. creating an origin point, and checking to see if it hits any colliders.
            {
                ITakeDamage damageable = hitInfo.collider.GetComponent<ITakeDamage>();
                if (damageable != null)
                {
                    damageable.TakeDamage(1);
                }
                    
            }
        }
    }
}
