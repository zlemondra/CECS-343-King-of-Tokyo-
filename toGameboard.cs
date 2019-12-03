using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class toGameboard : MonoBehaviour
{

    public void changeToGameBoard()
    {
        Debug.Log(assignedMonsters.monsterPlayers.Count);
        PlayerPrefs.SetInt("player count", assignedMonsters.monsterPlayers.Count);
        SceneManager.LoadScene("DecideWhoIsFirst");
    }
}
