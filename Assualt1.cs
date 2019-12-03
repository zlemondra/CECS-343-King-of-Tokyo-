using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Choose Character button for Assualt Monster Can
public class Assualt1 : MonoBehaviour, MonsterInterface
{
    
    public string Name;
    assignedMonsters monsterList;

    public string GetName()
    {
        return Name;
    }

    public void SetName()
    {
        Name = "Assault";
    }

    public void setPlayerNumber()
    {
        Assualt1 assualt = new Assualt1();
        assignedMonsters.monsterPlayers.Add(assualt);
        if(assignedMonsters.monsterPlayers.Count == 6)
        {
            SceneManager.LoadScene("Game Board");
        }
    }
}
