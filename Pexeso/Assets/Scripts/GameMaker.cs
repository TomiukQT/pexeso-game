using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaker : MonoBehaviour {

    public GameObject card;
    public List<GameObject> cards = new List<GameObject>();
    public List<Material> _materials = new List<Material>();
    //[SerializeField]private Material[] _materialsArray;
    //gameplay
    private int random;
    int lenghtMat = 0;
    //graphics
    public float offset = 0.1f;

	
	void Start ()
    {
        GenerateMaterialList();
        GenerateCardField();
        GenerateCards();
    }
	
	
	void Update ()
    {
		
	}


    private void GenerateMaterialList()
    {
        //    _materialsArray = new Material[32];

        //    _materialsArray = Resources.LoadAll<Material>("Materials");
        //foreach (Material mat in _materialsArray)
        //{
        //    //_materials.Add(mat);
        //}
        lenghtMat = _materials.Count;
        for (int i = 0; i < lenghtMat ; i++)
        {
            _materials.Add(_materials[i]);
        }

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
        for (int i = 0; i <= 64; i ++)
        {
            int randomCard = Random.Range(0, cards.Count );
            int randomMaterial = Random.Range(0, _materials.Count);
            GameObject card = cards[randomCard];
            Material mat = _materials[randomMaterial];

            Transform fore = card.transform.Find("Fore");
            fore.GetComponent<Renderer>().material = mat;

            cards.RemoveAt(randomCard);
            _materials.RemoveAt(randomMaterial);
        }
        
    }

}
