using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResolveDice : MonoBehaviour
{
    public int damage = 0;
    public int lifeAdded = 0;
    public int energyAdded = 0;
    public int vp_earned = 0;
   [SerializeField] private PlayerStats stats;


    public void applyRoll()
    {
        calculate();
        // adds life points to player health if they have less than 10 lives and aren't in tokyo
        if (stats.lives < 10 && stats.inTokyo == false)
        {
            stats.lives = stats.lives + lifeAdded;
            //if the amount of lives added takes the player over 10 lives, the life count is set to 10
            if (stats.lives > 10)
            {
                stats.lives = 10;
            }
        }
        // adds amount of energy from roll
        stats.energy = stats.energy + energyAdded;
        // adds to victory points
        stats.vp = stats.vp + vp_earned;

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
            }

            // if the player rolled a two
            else if (GenerateDice.rolls_container[i] == 2)
            {
                two_count++;
            }

            // if the player rolled a three
            else if (GenerateDice.rolls_container[i] == 3)
            {
                three_count++;
            }

            // if the player rolled a heart
            else if (GenerateDice.rolls_container[i] == 4)
            {
                lifeAdded++;
            }

            // if the player rolled an energy cube
            else if (GenerateDice.rolls_container[i] == 5)
            {
                energyAdded++;
            }
            // if the player rolled a claw
            else if (GenerateDice.rolls_container[i] == 6)
            {
                damage++;
            }
        }

        // roll three of one you get one point
        if (one_count == 3)
        {
            vp_earned++;
        }
        // roll three of two you get two points
        else if (two_count == 3)
        {
            vp_earned += 2;
        }
        // roll three of three you get three points
        else if (three_count == 3)
        {
            vp_earned += 3;
        }
        // roll four of one you get two points
        else if (one_count == 4)
        {
            vp_earned += 2;
        }
        // roll four of two you get three points
        else if (two_count == 4)
        {
            vp_earned += 3;
        }
        // roll four of three you get four points
        else if (three_count == 4)
        {
            vp_earned += 4;
        }

        if (stats.inTokyo == true)
        {
            vp_earned += 2;
        }
        
    }
}
