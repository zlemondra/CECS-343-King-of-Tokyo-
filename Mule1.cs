using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Choose Character button for Mule Monster Can
public class Mule1 : MonoBehaviour, MonsterInterface
{
    
    public string Name;
    assignedMonsters monsterList;
    
    
    public string GetName()
    {
        return Name;
    }

    public void SetName()
    {
        Name = "Mule";
    }

    public void setPlayerNumber()
    { Mule1 mule = new Mule1();
        assignedMonsters.monsterPlayers.Add(mule);
        if (assignedMonsters.monsterPlayers.Count == 6)
        {
            SceneManager.LoadScene("Game Board");
        }
    }
}
