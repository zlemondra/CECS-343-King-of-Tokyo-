using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ThisCard : MonoBehaviour
{
    public List<Card> thisCard = new List<Card>();
    public int thisId;

    public int id;
    public string cardName;
    public int cost;
    public string type;
    public string effect;
    public int size;
  
    public Text cardNameText;
    public Text costText;
    public Text typeText;
    public Text effectText;

    // Start is called before the first frame update
    void Start()
    {

        thisCard[0] = CardDataBase.cardList[thisId];
    }

    // Update is called once per frame
    void Update()
    {
        id = CardDataBase.cardList[thisId].id;
        size = CardDataBase.cardList.Count;
        //id = thisCard[0].id;
        cardName = thisCard[0].cardName;
        cost = thisCard[0].cost;
        type = thisCard[0].type;
        effect = thisCard[0].effect;

        cardNameText.text = "" + cardName;
        costText.text = "" + cost.ToString();
        typeText.text = "" + type;
        effectText.text = "" + effect;

    }
}
