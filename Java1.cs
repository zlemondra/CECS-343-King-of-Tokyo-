using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SceneManagement;

//Choose Character button for Java Can
public class Java1 : MonoBehaviour, MonsterInterface
{
    
    public string Name;
    assignedMonsters monsterList;

    public string GetName()
    {
        return Name;
    }

    public void SetName()
    {
        Name = "Java";
    }

    public void setPlayerNumber()
    {
        Java1 java = new Java1();
        assignedMonsters.monsterPlayers.Add(java);
        if (assignedMonsters.monsterPlayers.Count == 6)
        {
            SceneManager.LoadScene("Game Board");
        }
    }
}
