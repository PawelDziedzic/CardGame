using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManagerScript : MonoBehaviour
{
    public static TurnManagerScript turnManager;
    private bool isMyTurn;
    // Start is called before the first frame update
    void OnEnable()
    {
        turnManager = this;
    }



    // Update is called once per frame
    void Update()
    {

        
    }
}
