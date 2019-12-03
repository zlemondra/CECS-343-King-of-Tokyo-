using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class assignedMonsters : MonoBehaviour
{
    //List to keep track of monster players
    public static ArrayList monsterPlayers = new ArrayList();
    
    // adds Monster Can to list in order clicked on
    public void addPlayer(MonsterInterface player)
    {
        capAt6Players();
        monsterPlayers.Add(player);
        
    }
    
    //Returns order of monster Cans/Players
    public ArrayList returnPlayerList()
    {
        return monsterPlayers;
    }

    public int getLength()
    {
        return monsterPlayers.Count;
    }
    
    private void capAt6Players()
    {
        if(monsterPlayers.Count == 6)
        {
            SceneManager.LoadScene("DecideWhoIsFirst");
        }
    }

   

}
