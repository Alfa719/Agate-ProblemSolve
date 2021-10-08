using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    void Update()
    {
        this.transform.Translate(Vector2.one * Time.timeScale * 0.1f);
    }
}
