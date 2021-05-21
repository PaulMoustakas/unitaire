using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barricade_Animation : MonoBehaviour
{
    public float healthPool = 100;
    public float currentCollisionCount = 0;
    private float attackMultiplier = 0;

    private void OnCollisionEnter(Collision collision)
    {

        currentCollisionCount++;
        attackMultiplier += 0.01f;
    }

    private void OnCollisionStay(Collision collision)
    {

        healthPool = healthPool - attackMultiplier;
        if (healthPool <= 0)

        {
            Destroy(GameObject.FindWithTag("Barricade"));
        }

    }
}



