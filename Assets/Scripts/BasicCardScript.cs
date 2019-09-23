using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Assets.Scripts.Glossary;

public class BasicCardScript : MonoBehaviour
{
    enum zone : short
    {
        Hand, Life, Ether, Source, Field, Yard
    };

    private zone currentZone;


    void OnEnable()
    {
        currentZone = zone.Hand;
        SetInZone();
    }

    void SetInZone()
    {
        Vector3 position = transform.position;
        position[2] = (int)currentZone*10;
        transform.position = position;
    }


}
