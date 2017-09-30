using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public int id;
    public GameObject cardObj;



    public void Start()
    {
      
    }


    public void Flip()
    {
        //anim.Play(flipCard.name);

        ////if (!isStart)
        ////{
        ////    isStart = true;
        ////    anim.SetBool("isStart", isStart);
        ////}

        ////if (isFlippedBack)
        ////    isFlippedBack = false;
        ////else
        ////    isFlippedBack = true;

        ////anim.SetBool("isFlippedBack", isFlippedBack);

        ////Debug.Log("Flipped");
    }

    private void OnMouseDown()
    {
        Flip();
    }


}
