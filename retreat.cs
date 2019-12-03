using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class retreat : MonoBehaviour
{
    public void noOneInside()
    {
        
        damageController.player_in_tokyo = 50;
        SceneManager.LoadScene("Game Board");
        
    }
}
