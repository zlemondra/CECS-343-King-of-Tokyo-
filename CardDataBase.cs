using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDataBase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    void Awake()
    {
        cardList.Add(new Card(0,"Acid Attack", 6, "Keep", "Deal 1 extra damage eavch turn (even when you don't attack)."));
        cardList.Add(new Card(1,"Alien Metabolism", 3, "Keep", "Buying cards costs you 1 less energy."));
        cardList.Add(new Card(2,"Alpha Monster", 5, "Keep", "Gain 1 star when you attack."));
        cardList.Add(new Card(3,"Apartment", 5, "Discard", "+3 star"));
        cardList.Add(new Card(4,"Armor Plating", 4, "Keep", "Ignore damage of 1"));
        cardList.Add(new Card(5,"Background", 4, "Keep", "You can always reroll any 3 you have."));
        cardList.Add(new Card(6, "Burrowing", 5, "Keep", "Deal 1 extra damage eavch turn (even when you don't attack)."));
        cardList.Add(new Card(7, "Camouflage", 3, "Keep", "If you take damage roll a die for each damage point. On a heart you do not take that damage."));
        cardList.Add(new Card(8, "Commuter Train", 4, "Discard", "+2 star"));
        cardList.Add(new Card(9, "Complete Destruction", 3, "Keep", "If you roll 1, 2, 3, heart, attack, energy, gain 9 stars in addition to the regular result."));
        cardList.Add(new Card(10, "Drop Altitude", 5, "Discard", "+1 star."));
        cardList.Add(new Card(11, "Eater of Dead", 4, "Keep", "Gain 3 stars every time a monster's heart goes to 0."));
        cardList.Add(new Card(12, "Energize", 8, "Discard", "+9 energy."));
        cardList.Add(new Card(13, "Energy Hoarder", 3, "Keep", "You gain 1 star for every 6 energy you have at the end of your turn."));
        cardList.Add(new Card(14, "Evacuation Orders", 7, "Discard", "All other monsters lose 5 stars"));
        cardList.Add(new Card(15, "Even Bigger", 4, "Keep", "Your maximum heart is increased by 2. Gain 2 hearts when you het this card."));
        cardList.Add(new Card(16, "Extra Head", 7, "Keep", "You get 1 extra die."));
        cardList.Add(new Card(17, "Fire Blast", 3, "Discard", "Deal 2 damage to all other monsters."));
        cardList.Add(new Card(18, "Fire Breathing", 4, "Keep", "Your neighbors take 1 extra damage when you deal damage."));
        cardList.Add(new Card(19, "Freeze Time", 5, "Keep", "On a turn when you score 1, 1, 1, you can take another turn with one less die."));
        cardList.Add(new Card(20, "Frenzy", 7, "Discard", "When you purchase this card, take another turn immediately after this one."));
        cardList.Add(new Card(21, "Friend of Children", 3, "Keep", "When you gain any energy hain 1 extra energy."));
        cardList.Add(new Card(22, "Gas Refinery", 6, "Discard", "+2 stars and dael 3 damage to all other monsters."));
        cardList.Add(new Card(23, "Giant Brain", 5, "Keep", "You have one extra reroll each turn."));
        cardList.Add(new Card(24, "Gourmet", 4, "Keep", "When scoring 1, 1, 1, gain 2 extra star."));
        cardList.Add(new Card(25, "Heal", 3, "Discard", "Heal 2 damage."));
        cardList.Add(new Card(26, "Healing Ray", 4, "Keep", "You can heal other monsters with your heart reuslts. They pay you 2 energy for each damage you heal."));
        cardList.Add(new Card(27, "Herbivore", 5, "Keep", "Gain 1 star on your turn if you don't damage anyone."));
        cardList.Add(new Card(28, "Herd Culler", 3, "Keep", "You can change oe of your dice to a 1 each turn."));
        cardList.Add(new Card(29, "High Altitude", 4, "Discard", "All monsters (including you) take 3 damage."));
        cardList.Add(new Card(30, "It Has a Child", 7, "Keep", "If you are eliminated, discard all your cards and reset all player stats."));
        cardList.Add(new Card(31, "Jet Fighter", 5, "Discard", "+5 stars and take 4 damage."));
        cardList.Add(new Card(32, "Jets", 5, "Keep", "You suffer no damage when you yield Tokyo."));
        cardList.Add(new Card(33, "Made in a Lab", 2, "Keep", "When purchaseing cards you can peek at and purchase the top card of the deck."));
        cardList.Add(new Card(34, "Metamorpgh", 3, "Keep", "At the end of your trun, you can disable any keep cards you have received for energy they were purchased for."));
        cardList.Add(new Card(35, "Mimic", 8, "Keep", "Choose a card any monster has in play and put a mimic counter on it."));
    }

}
