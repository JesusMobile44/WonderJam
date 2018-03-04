using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainPersoScript : MonoBehaviour {

    private string testChaine = "";
    private string[] tabChaine = { "il me juge digne de ce travail car je le fais minutieusement", "quand midi sonna les cowboys sortirent leurs revolvers noirs", "programmer avec unity est une activite qui est tres amusante", "je regarde les constellations dans le ciel pour me retrouver", "cette chaine de caractere est beaucoup trop longue pour rien", "ce cactus a pris vraiment beaucoup trop de temps a modeliser", "ingurgiter trop de rockstar peut etre une tres mauvaise idee", "de la surface lunaire on peut apercevoir de loin notre terre", "il est plus difficile que vous pensez de trouver des phrases", "les tutoriels youtube nous ont bien franchement sauve la vie" };
    public GameObject temp;
    private Sprite[] spritesLetters;
    private Sprite[] spritesNumbers;
    private int position = 0;
    private string chaineModifie;
    private float deplacement = (float)-6.59;
    public GameObject UI_fin;
    public GameObject image;
    /*public GameObject cheval1;
    public GameObject cheval2;
    public GameObject cheval3;*/

    // Use this for initialization
    void Start ()
    {
        int randomNumber = Random.Range(0, 11);
        testChaine = tabChaine[randomNumber];
        for (int i = 0; i < testChaine.Length; i++)
        {
            if (testChaine[i]==' ')
            {
                chaineModifie += ((char)32).ToString();
            }
            else if (testChaine[i] > 96)
            {
                chaineModifie += (testChaine[i] - 96).ToString();
            }
            else
            {
                chaineModifie += ((char)(testChaine[i] + 48)).ToString();
            }
        }
        print(chaineModifie);

        spritesLetters = Resources.LoadAll<Sprite>("Letters");
        spritesNumbers = Resources.LoadAll<Sprite>("Numbers");

        for (int i=0; i<testChaine.Length; i++)
        {
            if (testChaine[i] == ' ')
            {
                GameObject go = GameObject.Instantiate(temp) as GameObject;
                go.GetComponent<SpriteRenderer>().sprite = spritesLetters[26];
                go.transform.position = new Vector2(deplacement, (float)0.39898);
                deplacement++;
            }
            else if (testChaine[i] < 97)
            {
                GameObject go = GameObject.Instantiate(temp) as GameObject;
                go.GetComponent<SpriteRenderer>().sprite = spritesLetters[(int)(chaineModifie[i] - 97)];
                go.transform.position = new Vector2(deplacement, (float)0.39898);
                deplacement++;
            }
            else if (testChaine[i] > 96)
            {
                GameObject go = GameObject.Instantiate(temp) as GameObject;
                go.GetComponent<SpriteRenderer>().sprite = spritesNumbers[(int)(testChaine[i] - 96)];
                go.transform.position = new Vector2(deplacement, (float)0.39898);
                deplacement++;
            }
        }
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
        if (Input.GetKeyDown("0"))
        {
            testEntree('0');
        }
        if (Input.GetKeyDown("1"))
        {
            testEntree('1');
        }
        if (Input.GetKeyDown("2"))
        {
            testEntree('2');
        }
        if (Input.GetKeyDown("3"))
        {
            testEntree('3');
        }
        if (Input.GetKeyDown("4"))
        {
            testEntree('4');
        }
        if (Input.GetKeyDown("5"))
        {
            testEntree('5');
        }
        if (Input.GetKeyDown("6"))
        {
            testEntree('6');
        }
        if (Input.GetKeyDown("7"))
        {
            testEntree('7');
        }
        if (Input.GetKeyDown("8"))
        {
            testEntree('8');
        }
        if (Input.GetKeyDown("9"))
        {
            testEntree('9');
        }
    }

    void testEntree(char entree) //Méthode pour tester l'entrée, valide -> true, invalide -> false
    {
        char[] texte = testChaine.ToCharArray();

        if (position < testChaine.Length)
        {
            if (entree == texte[position])
            {
                position++;
                print(entree + " est entré\n");
                print(position + "\n");
                gameObject.transform.position = new Vector2(gameObject.transform.position.x + 1, gameObject.transform.position.y);
                if (position == texte.Length)
                {
                    if (image.activeSelf == false)
                    {
                        UI_fin.gameObject.SetActive(true);
                        print("Victoire!");
                        print(gameObject.transform.position.x);
                    }
                }
            }
            else if (entree != texte[position]) print("mauvaise entrée\n");
        }
        //else if (position >= testChaine.Length && GameObject.Find("Cheval1") > Vector2(54f,0f)
    }
}