using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    [SerializeField] private PlayerStats stats;
    public List<Card> deck = new List<Card>();
    public List<Card> container = new List<Card>();
    public int deckSize;
    // Start is called before the first frame update
    void Start()
    {
        deckSize = CardDataBase.cardList.Count;
        for (int i = 0; i < deckSize; i++) {
            deck[i] = CardDataBase.cardList[i];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shuffle() {
        for(int i=0; i<deckSize; i++)
        {
            container[0] = deck[i];
            int randomIndex = Random.Range(i, deckSize);
            deck[i] = deck[randomIndex];
            deck[randomIndex] = container[0];
        }
    }

    public void Sweep() {
        if (stats.energy >= 3) {
            Shuffle();
        }
      
    }
}
