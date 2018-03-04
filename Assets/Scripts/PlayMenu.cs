using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayMenu : MonoBehaviour {

    public void PlayGame1()
    {
        SceneManager.LoadScene("Oui");
    }
    public void PlayGame2()
    {
        SceneManager.LoadScene("Non");
    }
}
