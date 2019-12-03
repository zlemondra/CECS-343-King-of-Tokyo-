using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Choose Character button for OG Monster Can
public class OG1 : MonoBehaviour, MonsterInterface
{
 
    public string Name;
    assignedMonsters monsterList;

    public string GetName()
    {
        return Name;
    }

    public void SetName()
    {
        Name = "OG";
    }

    public void setPlayerNumber()
    {
        OG1 og = new OG1();
        assignedMonsters.monsterPlayers.Add(og);
        if (assignedMonsters.monsterPlayers.Count == 6)
        {
            SceneManager.LoadScene("Game Board");
        }
    }
}
