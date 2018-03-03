using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Finnish : MonoBehaviour
{

    public void Quitter()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Rejouer()
    {
        SceneManager.LoadScene("Oui");
    }
}
