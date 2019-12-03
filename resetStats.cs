using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetStats : MonoBehaviour
{

    [SerializeField] private healthController healthControl;
    public void delete()
    {


        PlayerPrefs.SetInt("playerHealth1", 20);
        PlayerPrefs.SetInt("playerHealth2", 20);
        PlayerPrefs.SetInt("playerHealth3", 20);
        PlayerPrefs.SetInt("playerHealth4", 20);
        PlayerPrefs.SetInt("playerHealth5", 20);


        PlayerPrefs.SetInt("energy", 0);
        PlayerPrefs.SetInt("energy2", 0);
        PlayerPrefs.SetInt("energy3", 0);
        PlayerPrefs.SetInt("energy4", 0);
        PlayerPrefs.SetInt("energy5", 0);

        PlayerPrefs.SetInt("victory points", 0);
        PlayerPrefs.SetInt("victory points2", 0);
        PlayerPrefs.SetInt("victory points3", 0);
        PlayerPrefs.SetInt("victory points4", 0);
        PlayerPrefs.SetInt("victory points5", 0);

        PlayerPrefs.SetInt("turn count", 0);


        damageController.turn_count = PlayerPrefs.GetInt("turn count", 0);

        healthControl.playerHealth = PlayerPrefs.GetInt("playerHealth1", 20);
        healthControl.playerHealth2 = PlayerPrefs.GetInt("playerHealth2", 20);
        healthControl.playerHealth3 = PlayerPrefs.GetInt("playerHealth3", 20);
        healthControl.playerHealth4 = PlayerPrefs.GetInt("playerHealth4", 20);
        healthControl.playerHealth5 = PlayerPrefs.GetInt("playerHealth5", 20);


        healthControl.energy = PlayerPrefs.GetInt("energy", 0);
        healthControl.energy2 = PlayerPrefs.GetInt("energy2", 0);
        healthControl.energy3 = PlayerPrefs.GetInt("energy3", 0);
        healthControl.energy4 = PlayerPrefs.GetInt("energy4", 0);
        healthControl.energy5 = PlayerPrefs.GetInt("energy5", 0);

        healthControl.victory_points = PlayerPrefs.GetInt("victory points", 0);
        healthControl.victory_points2 = PlayerPrefs.GetInt("victory points2", 0);
        healthControl.victory_points3 = PlayerPrefs.GetInt("victory points3", 0);
        healthControl.victory_points4 = PlayerPrefs.GetInt("victory points4", 0);
        healthControl.victory_points5 = PlayerPrefs.GetInt("victory points5", 0);
    }
}
