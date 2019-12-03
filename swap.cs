using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class swap : MonoBehaviour
{

    public void swapPlayers()
    {
        string a = TokyoInput.swapper;
        Debug.Log("swapper: " + a);
        int ia = Int32.Parse(a);
        damageController.player_in_tokyo = ia;
        SceneManager.LoadScene("Game Board");
    }
}
