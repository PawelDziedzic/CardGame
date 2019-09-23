using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManagerScript : MonoBehaviour
{
    public static CardManagerScript ManagerOfCards;
    public List<BasicCardScript> CardsInPlay;
    // Start is called before the first frame update
    void OnEnable()
    {
        ManagerOfCards = this;
    }


}
