using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndTrigger : MonoBehaviour {

    public GameObject image;
    public GameObject woopwoop;


    public void OnTriggerEnter2D(Collider other)
    {
        if(woopwoop.activeSelf == false)
        image.SetActive(true);
    }
}
