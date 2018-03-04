using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Finnish : MonoBehaviour
{
    public GameObject spr_horseSpriteSheet_5;
    public GameObject spr_horseSpriteSheet_9;
    public GameObject spr_horseSpriteSheet_13;
    public GameObject go;
    public GameObject number_1;
    public GameObject number_2;
    public GameObject number_3;

    IEnumerator MyCoroutine()
    {
    //This is a coroutine
        number_3.SetActive(true);//afficher 3 (setActive)
        yield return new WaitForSecondsRealtime(1);    //Wait one second
        number_2.SetActive(true);//enlever 3, afficher 2
        number_3.SetActive(false);
        yield return new WaitForSecondsRealtime(1);
        number_1.SetActive(true);
        number_2.SetActive(false);
        yield return new WaitForSecondsRealtime(1);
        go.SetActive(true);
        number_1.SetActive(false);
        yield return new WaitForSecondsRealtime(1);
        go.SetActive(false);
        spr_horseSpriteSheet_5.SetActive(true);
        spr_horseSpriteSheet_9.SetActive(true);
        spr_horseSpriteSheet_13.SetActive(true);
    }
    public void Quitter()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Rejouer()
    {
        SceneManager.LoadScene("Oui");
    }
    public void Jouer()
    {
        StartCoroutine(MyCoroutine());
    }
}
