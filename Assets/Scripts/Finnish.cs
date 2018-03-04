using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Finnish : MonoBehaviour
{
    public GameObject UI_Debut;
    public GameObject spr_horseSpriteSheet_5;
    public GameObject spr_horseSpriteSheet_9;
    public GameObject spr_horseSpriteSheet_13;

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
        
        
    }
}
