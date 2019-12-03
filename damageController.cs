using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class damageController : MonoBehaviour
{
   
    public int damage = 0;
    public int energyAdded = 0;
    public int vp_earned = 0;
    public int damage_dealt;
    public static int turn_count = WhoGoesFirst.maxIndex;
    // this will be the initial variable for who won the dice roll, they enter tokyo upon winning
    public static int player_in_tokyo = WhoGoesFirst.maxIndex;
    [SerializeField] private healthController healthControl;


    void OnDestroy()
    {
        
        PlayerPrefs.SetInt("playerHealth1", healthControl.playerHealth);
        PlayerPrefs.SetInt("playerHealth2", healthControl.playerHealth2);
        PlayerPrefs.SetInt("playerHealth3", healthControl.playerHealth3);
        PlayerPrefs.SetInt("playerHealth4", healthControl.playerHealth4);
        PlayerPrefs.SetInt("playerHealth5", healthControl.playerHealth5);

        PlayerPrefs.SetInt("energy", healthControl.energy);
        PlayerPrefs.SetInt("energy2", healthControl.energy2);
        PlayerPrefs.SetInt("energy3", healthControl.energy3);
        PlayerPrefs.SetInt("energy4", healthControl.energy4);
        PlayerPrefs.SetInt("energy5", healthControl.energy5);

        PlayerPrefs.SetInt("victory points", healthControl.victory_points);
        PlayerPrefs.SetInt("victory points2", healthControl.victory_points2);
        PlayerPrefs.SetInt("victory points3", healthControl.victory_points3);
        PlayerPrefs.SetInt("victory points4", healthControl.victory_points4);
        PlayerPrefs.SetInt("victory points5", healthControl.victory_points5);

        


        PlayerPrefs.SetInt("turn count", turn_count);



    }
    public void applyRoll()
    {
        //turn_count = PlayerPrefs.GetInt("turn count", turn_count);
        //Debug.Log("turn count: " + turn_count);
        //Debug.Log("player count: " + PlayerPrefs.GetInt("player count"));
        Debug.Log("player in tokyo: " + player_in_tokyo);
        Debug.Log("player turn: " + turn_count);
        
        if (turn_count >= PlayerPrefs.GetInt("player count"))
        {
            turn_count = 0;
        }

        calculate();
        string victim = attackInputField.victim;
        // manage how to deal damage to other players, does not let player attack themself
        if (damage_dealt > 0)
        {
            int vic = Int32.Parse(victim);

            // if player in tokyo is being attacked
            if ((player_in_tokyo == 0 && turn_count != 0)||
                (player_in_tokyo == 1 && turn_count != 1)||
                (player_in_tokyo == 2 && turn_count != 2)||
                (player_in_tokyo == 3 && turn_count != 3)||
                (player_in_tokyo == 4 && turn_count != 4)||
                (player_in_tokyo == 5 && turn_count != 5))
            {
                if (player_in_tokyo == 0)
                {
                    healthControl.playerHealth = healthControl.playerHealth - damage_dealt;
                    healthControl.victory_points = healthControl.victory_points + 1;
                }

                if (player_in_tokyo == 1)
                {
                    healthControl.playerHealth2 = healthControl.playerHealth2 - damage_dealt;
                    healthControl.victory_points2 = healthControl.victory_points2 + 1;
                }

                if (player_in_tokyo == 2)
                {
                    healthControl.playerHealth3 = healthControl.playerHealth3 - damage_dealt;
                    healthControl.victory_points3 = healthControl.victory_points3 + 1;
                }

                if (player_in_tokyo == 4)
                {
                    healthControl.playerHealth4 = healthControl.playerHealth4 - damage_dealt;
                    healthControl.victory_points4 = healthControl.victory_points4 + 1;
                }

                if (player_in_tokyo == 5)
                {
                    healthControl.playerHealth5 = healthControl.playerHealth5 - damage_dealt;
                    healthControl.victory_points5 = healthControl.victory_points5 + 1;
                }
            }

            // if attacking player is in tokyo
            else if (player_in_tokyo == turn_count)
            {
                // if the player is in tokyo attack everyone
                if (turn_count == 0 && player_in_tokyo == 0)
                {
                    healthControl.victory_points = healthControl.victory_points + 1;
                    healthControl.playerHealth2 = healthControl.playerHealth2 - damage_dealt;
                    healthControl.playerHealth3 = healthControl.playerHealth3 - damage_dealt;
                    healthControl.playerHealth4 = healthControl.playerHealth4 - damage_dealt;
                    healthControl.playerHealth5 = healthControl.playerHealth5 - damage_dealt;
                }

                if (turn_count == 1 && player_in_tokyo == 1)
                {
                    healthControl.victory_points2 = healthControl.victory_points2 + 1;
                    healthControl.playerHealth = healthControl.playerHealth - damage_dealt;
                    healthControl.playerHealth3 = healthControl.playerHealth3 - damage_dealt;
                    healthControl.playerHealth4 = healthControl.playerHealth4 - damage_dealt;
                    healthControl.playerHealth5 = healthControl.playerHealth5 - damage_dealt;
                }

                if (turn_count == 2 && player_in_tokyo == 2)
                {
                    healthControl.victory_points3 = healthControl.victory_points3 + 1;
                    healthControl.playerHealth = healthControl.playerHealth - damage_dealt;
                    healthControl.playerHealth2 = healthControl.playerHealth2 - damage_dealt;
                    healthControl.playerHealth4 = healthControl.playerHealth4 - damage_dealt;
                    healthControl.playerHealth5 = healthControl.playerHealth5 - damage_dealt;
                }

                if (turn_count == 3 && player_in_tokyo == 3)
                {
                    healthControl.victory_points4 = healthControl.victory_points4 + 1;
                    healthControl.playerHealth = healthControl.playerHealth - damage_dealt;
                    healthControl.playerHealth2 = healthControl.playerHealth3 - damage_dealt;
                    healthControl.playerHealth3 = healthControl.playerHealth3 - damage_dealt;
                    healthControl.playerHealth5 = healthControl.playerHealth5 - damage_dealt;
                }

                if (turn_count == 4 && player_in_tokyo == 4)
                {
                    healthControl.victory_points5 = healthControl.victory_points5 + 1;
                    healthControl.playerHealth = healthControl.playerHealth - damage_dealt;
                    healthControl.playerHealth2 = healthControl.playerHealth3 - damage_dealt;
                    healthControl.playerHealth3 = healthControl.playerHealth4 - damage_dealt;
                    healthControl.playerHealth4 = healthControl.playerHealth4 - damage_dealt;
                }

            }

            // no one is inside tokyo, turn proceeds as usual
            else
            {
                if (vic == 0 && (turn_count != 0))
                {
                    healthControl.playerHealth = healthControl.playerHealth - damage_dealt;
                    Debug.Log("hit");
                    if (player_in_tokyo == 0)
                    {
                        SceneManager.LoadScene("TokyoChoice");
                    }
                }
                if (vic == 1 && (turn_count != 1))
                {
                    healthControl.playerHealth2 = healthControl.playerHealth2 - damage_dealt;
                    if (player_in_tokyo == 1)
                    {
                        SceneManager.LoadScene("TokyoChoice");
                    }
                }
                if (vic == 2 && (turn_count != 2))
                {
                    healthControl.playerHealth3 = healthControl.playerHealth3 - damage_dealt;
                    if (player_in_tokyo == 2)
                    {
                        SceneManager.LoadScene("TokyoChoice");
                    }
                }
                if (vic == 3 && (turn_count != 3))
                {
                    healthControl.playerHealth4 = healthControl.playerHealth4 - damage_dealt;
                    if (player_in_tokyo == 3)
                    {
                        SceneManager.LoadScene("TokyoChoice");
                    }
                }
                if (vic == 4 && (turn_count != 4))
                {
                    healthControl.playerHealth5 = healthControl.playerHealth5 - damage_dealt;
                    if (player_in_tokyo == 4)
                    {
                        SceneManager.LoadScene("TokyoChoice");
                    }
                }
            }
        }
        // if it is the first players turn
        if (turn_count == 0)
        {
            // adds life to players health
            healthControl.playerHealth = healthControl.playerHealth + damage;
            // adds amount of energy from roll
            healthControl.energy = healthControl.energy + energyAdded;
            // adds to victory points
            healthControl.victory_points = healthControl.victory_points + vp_earned;
        }
        // if it is the second players turn
        if (turn_count == 1)
        {
            // adds life to players health
            healthControl.playerHealth2 = healthControl.playerHealth2 + damage;
            // adds amount of energy from roll
            healthControl.energy2 = healthControl.energy2 + energyAdded;
            // adds to victory points
            healthControl.victory_points2 = healthControl.victory_points2 + vp_earned;
        }

        if (turn_count == 2)
        {
            // adds life to players health
            healthControl.playerHealth3 = healthControl.playerHealth3 + damage;
            // adds amount of energy from roll
            healthControl.energy3 = healthControl.energy3 + energyAdded;
            // adds to victory points
            healthControl.victory_points3 = healthControl.victory_points3 + vp_earned;
        }
        
        if (turn_count == 3)
        {
            // adds life to players health
            healthControl.playerHealth4 = healthControl.playerHealth4 + damage;
            // adds amount of energy from roll
            healthControl.energy4 = healthControl.energy4 + energyAdded;
            // adds to victory points
            healthControl.victory_points4 = healthControl.victory_points4 + vp_earned;
        }

        if (turn_count == 4)
        {
            // adds life to players health
            healthControl.playerHealth5 = healthControl.playerHealth5 + damage;
            // adds amount of energy from roll
            healthControl.energy5 = healthControl.energy5 + energyAdded;
            // adds to victory points
            healthControl.victory_points5 = healthControl.victory_points5 + vp_earned;
        }

         
         
      


        // check if any of the players have reached maximum victory points
        if (healthControl.victory_points >= 20)
        {
            SceneManager.LoadScene("GameOver");
        }

        if (healthControl.victory_points2 >= 20)
        {
            SceneManager.LoadScene("GameOver");
        }

        if (healthControl.victory_points3 >= 20)
        {
            SceneManager.LoadScene("GameOver");
        }

        if (healthControl.victory_points4 >= 20)
        {
            SceneManager.LoadScene("GameOver");
        }

        if (healthControl.victory_points5 >= 20)
        {
            SceneManager.LoadScene("GameOver");
        }

        turn_count++;

    }

    public void calculate()
    {
        int one_count = 0;
        int two_count = 0;
        int three_count = 0;

        for (int i = 0; i < GenerateDice.rolls_container.Length; i++)
        {

            // if the player rolled a one
            if (GenerateDice.rolls_container[i] == 1)
            {
                one_count++;
                if (one_count == 3)
                {
                    vp_earned++;
                    one_count = 0;
                }
            }

            // if the player rolled a two
            if (GenerateDice.rolls_container[i] == 2)
            {
                two_count++;
                if (two_count == 3)
                {
                    vp_earned++;
                    two_count = 0;
                }
            }

            // if the player rolled a three
            if (GenerateDice.rolls_container[i] == 3)
            {
                three_count++;
                if (three_count == 3)
                {
                    vp_earned++;
                    three_count = 0;
                }
            }

            // if the player rolled a heart
            if (GenerateDice.rolls_container[i] == 4)
            {
                damage++;
            }

            // if the player rolled an energy cube
            if (GenerateDice.rolls_container[i] == 5)
            {
                energyAdded++;
            }

            // if the player rolled an claw
            if (GenerateDice.rolls_container[i] == 6)
            {
                damage_dealt++;
            }
        }

        
        
    }

}
