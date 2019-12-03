using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class WhoGoesFirst : MonoBehaviour
{

    public GameObject window;

    public int n0;
    public int n1;
    public int n2;
    public int n3;
    public int n4;
    public int n5;
    public static int[] player1 = new int[6];
    public static int[] player2 = new int[6];
    public static int[] player3 = new int[6];
    public static int[] player4 = new int[6];
    public static int[] player5 = new int[6];

    public int p1_count;
    public int p2_count;
    public int p3_count;
    public int p4_count;
    public int p5_count;
    public static int maxIndex;
    public static int[] count_container = new int[5];
    

    public int[][] player_container = new int[5][];


    public int num_players;


    public void choose()
    {

        player_container[0] = player1;
        player_container[1] = player2;
        player_container[2] = player3;
        player_container[3] = player4;
        player_container[4] = player5;

        num_players = PlayerPrefs.GetInt("player count");
        Debug.Log("number of players: " + num_players);
        for (int i = 0; i < num_players; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                int number = Random.Range(0, 7);
                player_container[i][j] = number;
                 
                
            }
        }
    }

    public void calculate_winner()
    {
        choose();
        count_container[0] = p1_count;
        count_container[1] = p2_count;
        count_container[2] = p3_count;
        count_container[3] = p4_count;
        count_container[4] = p5_count;

        for (int i = 0; i < num_players; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                if (player_container[i][j] == 6)
                {
                    count_container[i]++;
                }

            }
        }
        Debug.Log("player 1 claws: " + count_container[0]);
        Debug.Log("player 2 claws: " + count_container[1]);
        int maxValue = count_container.Max();
        maxIndex = count_container.ToList().IndexOf(maxValue);
        window.GetComponent<Text>().text = "Player: " + maxIndex + " will go first and has entered Tokyo! Good Luck";

    }
}
