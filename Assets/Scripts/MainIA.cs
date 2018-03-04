﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainIA : MonoBehaviour
{

    public float chance;

    private static System.Random rnd = new System.Random();
    private Vector2 movement = new Vector2(0.0001f, 0);


    private void Update()
    {
        float randomFloat = (float) rnd.NextDouble() * (0.01f - 0.0001f) + 0.0001f;
        movement = new Vector2(randomFloat, 0);
        gameObject.transform.Translate(movement);
    }
}