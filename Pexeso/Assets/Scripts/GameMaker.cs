using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaker : MonoBehaviour {

    public GameObject card;
    public List<GameObject> cards = new List<GameObject>();
    public List<Material> materials = new List<Material>();

    //gameplay
    private int random;

    //graphics
    public float offset = 0.1f;

	
	void Start ()
    {
        GenerateCardField();
        GenerateCards();        
	}
	
	
	void Update ()
    {
		
	}

   


    private void GenerateCardField()
    {

        for (int y = 0; y < 8; y++)
        {
            for (int x = 0; x < 8; x++)
            {
                //TODO: Choose from list of cards
                Vector3 dir = new Vector3(x + offset*x, y + offset*y,0 );                
                cards.Add(Instantiate(card, dir, Quaternion.identity));
            }
        }


    }
    private void GenerateCards()
    {       
            for (int i = 0; i < 64; i++)
            {
                random = Random.Range(0, cards.Count+1);
                cards[random].GetComponent<Card>().id = i;
                
            }
        
    }

}
