using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBallon : MonoBehaviour
{
    void OnTriggerEnter2D (Collider2D collider)
    {
        GameControlScript.health += 1;
        Destroy(gameObject);
    }
}
