using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Choose Character button for Low Carb Monster Can
public class LowCarb1 : MonoBehaviour, MonsterInterface
{
    
    public string Name;
    assignedMonsters monsterList;

    public string GetName()
    {
        return Name;
    }

    public void SetName()
    {
        Name = "Low Carb";
    }

    public void setPlayerNumber()
    {
        LowCarb1 lw = new LowCarb1();
        assignedMonsters.monsterPlayers.Add(lw);
        if (assignedMonsters.monsterPlayers.Count == 6)
        {
            SceneManager.LoadScene("Game Board");
        }
    }
}
