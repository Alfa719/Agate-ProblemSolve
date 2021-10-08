using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTriangle : MonoBehaviour
{
    public GameObject Triangle;

    float randVert, randHoriz, randTotal;
    void Start()
    {
        randTotal = Random.Range(5, 20);
        for (int i = 0; i < randTotal; i++)
        {
            randVert = Random.Range(3.37f, -3.37f);
            randHoriz = Random.Range(6.32f, -6.32f);
            Instantiate(Triangle, new Vector2(randHoriz, randVert), Quaternion.identity);
        }
    }
}
