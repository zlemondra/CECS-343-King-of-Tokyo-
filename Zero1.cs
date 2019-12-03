using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Choose Character button for Zero Can
public class Zero1 : MonoBehaviour, MonsterInterface
{
    
    public string Name;
    assignedMonsters monsterList;

    public string GetName()
    {
        return Name;
    }

    public void SetName()
    {
        Name = "Zero";
    }

    public void setPlayerNumber()
    {
        Zero1 zero = new Zero1();
        assignedMonsters.monsterPlayers.Add(zero);
        if (assignedMonsters.monsterPlayers.Count == 6)
        {
            SceneManager.LoadScene("Game Board");
        }
    }
}
