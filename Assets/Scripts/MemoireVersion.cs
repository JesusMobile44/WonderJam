using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoireVersion : MonoBehaviour {

    public string testChaine = "";
    public GameObject temp;
    private int isitok;
    private float Range;
    private Sprite[] spritesLetters;
    private Sprite[] spritesNumbers;
    private int position = 0;
    private string chaineModifie;
    private float deplacement = (float)-6.59;
    public GameObject UI_fin;
    private char[] lettres= {'a','a','a','a'};
    private bool[] done= {false,false,false,false};
    private string chaineFinale = "";
    private string subChaine = "";

    // Use this for initialization
    void Start()
    {
        print(testChaine + "\n");
        print(position + "\n");

        randomizer();
    }

    // Update is called once per frame
    void Update()
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
                    UI_fin.gameObject.SetActive(true);
                    print("Victoire!");
                    print(gameObject.transform.position.x);
                }
            }
            else if (entree != texte[position]) print("mauvaise entrée\n");
        }
    }

    void randomizer()
    {
        for (int h = 0; h < 4; h++)
        {
            if (h < 1) {
            subChaine = testChaine.Substring(0, 15);
            }
            else
            {
                subChaine = testChaine.Substring(15*h, 15);
            }
            lettres[0] = (char)Random.Range(97, 122);
            for (int i = 1; i < 4; i++)
            {
                while (!done[i])
                {
                    isitok = 0;
                    if (!done[i])
                    {
                        lettres[i] = (char)Random.Range(97, 122);

                    }
                    for (int j = 0; j < 4; j++)
                    {
                        if (lettres[i] == lettres[j])
                        {
                            isitok++;
                        }
                        if (isitok == 1)
                        {
                            done[i] = true;
                        }
                        isitok = 0;
                    }
                }
                done[i] = false;
                print(lettres[i]);
            }


            for (int i = 0; i < subChaine.Length; i++)
            {
                if (subChaine[i] == lettres[0])
                {
                    chaineModifie += lettres[1].ToString();
                }
                else if (subChaine[i] == lettres[2])
                {
                    chaineModifie += lettres[3].ToString();
                }
                else
                {
                    chaineModifie += subChaine[i].ToString();
                }
            }
            print(chaineModifie);

            spritesLetters = Resources.LoadAll<Sprite>("Letters");
            spritesNumbers = Resources.LoadAll<Sprite>("Numbers");

            for (int i = 0; i < subChaine.Length; i++)
            {
                if (chaineModifie[i] == ' ')
                {
                    GameObject go = GameObject.Instantiate(temp) as GameObject;
                    go.GetComponent<SpriteRenderer>().sprite = spritesLetters[26];
                    go.transform.position = new Vector2(deplacement, (float)0.39898);
                    deplacement++;
                }
                else if (chaineModifie[i] > 96)
                {
                    GameObject go = GameObject.Instantiate(temp) as GameObject;
                    go.GetComponent<SpriteRenderer>().sprite = spritesLetters[(int)(chaineModifie[i] - 97)];
                    go.transform.position = new Vector2(deplacement, (float)0.39898);
                    deplacement++;
                }
                else
                {
                    GameObject go = GameObject.Instantiate(temp) as GameObject;
                    go.GetComponent<SpriteRenderer>().sprite = spritesNumbers[(int)(chaineModifie[i] - 48)];
                    go.transform.position = new Vector2(deplacement, (float)0.39898);
                    deplacement++;
                }
            }
            chaineFinale += chaineModifie;
            chaineModifie = "";
        }
    }
}
