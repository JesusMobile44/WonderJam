using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideScript : MonoBehaviour {

       bool loose = false;

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("spr_horseSpriteSheet_5") || other.gameObject.CompareTag("spr_horseSpriteSheet_9") || other.gameObject.CompareTag("spr_horseSpriteSheet_13"))
        {
            loose = true;
        }
    }

    public bool getLoose()
    {
        return loose;
    }
}
