using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainPersoScript2 : MonoBehaviour {
    public string testChaine = "je suis un test";
    private int position = 0;
    public Text WinText;
    public GameObject UI_fin;

	// Use this for initialization
	void Start ()
    {
     
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            
            testEntree('a');
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            
            testEntree('b');
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            
            testEntree('c');
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            
            testEntree('d');
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            
            testEntree('e');
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            
            testEntree('f');
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
           
            testEntree('g');
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            
            testEntree('h');
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            
            testEntree('i');
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            
            testEntree('j');
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            
            testEntree('k');
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            
            testEntree('l');
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            
            testEntree('m');
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            
            testEntree('n');
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
           
            testEntree('o');
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            
            testEntree('p');
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            
            testEntree('q');
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            
            testEntree('r');
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            
            testEntree('s');
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            
            testEntree('t');
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            
            testEntree('u');
        }
        if (Input.GetKeyDown(KeyCode.V))
        { 
           
            testEntree('v');
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            
            testEntree('w');
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            
            testEntree('x');
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            
            testEntree('y');
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            
            testEntree('z');
        }
        if (Input.GetKeyDown("space"))
        {
            testEntree(' ');
        }

    }

    void testEntree(char entree) //Méthode pour tester l'entrée, valide -> true, invalide -> false
    {
        char[] texte = testChaine.ToCharArray();

        if (position < testChaine.Length - 1)
        {
            if (entree == texte[position])
            {
                position++;
                gameObject.transform.position = new Vector2(gameObject.transform.position.x + 0.5f, gameObject.transform.position.y);
            }
            //else if (entree != texte[position])
        }
        else if (position == texte.Length - 1)
        {
            UI_fin.gameObject.SetActive(true);
        }
    }
}