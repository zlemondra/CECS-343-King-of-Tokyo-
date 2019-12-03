using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthController : MonoBehaviour
{
    public int playerHealth;
    [SerializeField] private Text healthText;
    public int energy;
    [SerializeField] private Text energyText;
    public int victory_points;
    [SerializeField] private Text victoryText;

    public int playerHealth2;
    [SerializeField] private Text healthText2;
    public int energy2;
    [SerializeField] private Text energyText2;
    public int victory_points2;
    [SerializeField] private Text victoryText2;

    public int playerHealth3;
    [SerializeField] private Text healthText3;
    public int energy3;
    [SerializeField] private Text energyText3;
    public int victory_points3;
    [SerializeField] private Text victoryText3;

    public int playerHealth4;
    [SerializeField] private Text healthText4;
    public int energy4;
    [SerializeField] private Text energyText4;
    public int victory_points4;
    [SerializeField] private Text victoryText4;


    public int playerHealth5;
    [SerializeField] private Text healthText5;
    public int energy5;
    [SerializeField] private Text energyText5;
    public int victory_points5;
    [SerializeField] private Text victoryText5;


    public static int[] healthContainer = new int[5];
    

    private void Start()
    {
        healthContainer[0] = playerHealth;
        healthContainer[1] = playerHealth2;
        healthContainer[2] = playerHealth3;
        healthContainer[3] = playerHealth4;
        healthContainer[4] = playerHealth5;


        playerHealth = PlayerPrefs.GetInt("playerHealth1", 20);
        playerHealth2 = PlayerPrefs.GetInt("playerHealth2", 20);
        playerHealth3 = PlayerPrefs.GetInt("playerHealth3", 20);
        playerHealth4 = PlayerPrefs.GetInt("playerHealth4", 20);
        playerHealth5 = PlayerPrefs.GetInt("playerHealth5", 20);


        energy = PlayerPrefs.GetInt("energy", 0);
        energy2 = PlayerPrefs.GetInt("energy2", 0);
        energy3 = PlayerPrefs.GetInt("energy3", 0);
        energy4 = PlayerPrefs.GetInt("energy4", 0);
        energy5 = PlayerPrefs.GetInt("energy5", 0);

        victory_points = PlayerPrefs.GetInt("victory points", 0);
        victory_points2 = PlayerPrefs.GetInt("victory points2", 0);
        victory_points3 = PlayerPrefs.GetInt("victory points3", 0);
        victory_points4 = PlayerPrefs.GetInt("victory points4", 0);
        victory_points5 = PlayerPrefs.GetInt("victory points5", 0);




        UpdateStats();

    }

    





    public void UpdateStats()
    {

        healthText.text = playerHealth.ToString("0");
        energyText.text = energy.ToString("0");
        victoryText.text = victory_points.ToString("0");

        
        healthText2.text = playerHealth2.ToString("0");
        energyText2.text = energy2.ToString("0");
        victoryText2.text = victory_points2.ToString("0");
        
        healthText3.text = playerHealth3.ToString("0");
        energyText3.text = energy3.ToString("0");
        victoryText3.text = victory_points3.ToString("0");
        
        healthText4.text = playerHealth4.ToString("0");
        energyText4.text = energy4.ToString("0");
        victoryText4.text = victory_points4.ToString("0");

        healthText5.text = playerHealth5.ToString("0");
        energyText5.text = energy5.ToString("0");
        victoryText5.text = victory_points5.ToString("0");
        
        
    }
}
