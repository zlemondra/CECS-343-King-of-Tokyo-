using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public int lives = 10;
    public int energy = 0;
    public int vp = 0;
    public bool inTokyo = false;

    private void Start()
    {
        lives = PlayerPrefs.GetInt("lives", 10);
        energy = PlayerPrefs.GetInt("energy", 0);
        vp = PlayerPrefs.GetInt("vp", 0);
    }


    private void OnDestroy()
    {
        PlayerPrefs.SetInt("lives", lives);
        PlayerPrefs.SetInt("energy", energy);
        PlayerPrefs.SetInt("vp", vp);
    }

}
