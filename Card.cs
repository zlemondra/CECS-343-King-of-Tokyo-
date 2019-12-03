using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card:MonoBehaviour
{
    public int id;
    public string cardName;
    public int cost;
    public string type;
    public string effect;


    public Card()
    {
        id = 0;
        cardName = "Name";
        cost = 0;
        type = "Type";
        effect = "Effect";
    }

    public Card(int Id, string CardName, int Cost, string Type, string Effect)
    {
        id = Id;
        cardName = CardName;
        cost = Cost;
        type = Type;
        effect = Effect;
    }
}