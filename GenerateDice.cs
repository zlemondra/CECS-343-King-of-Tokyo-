using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class GenerateDice : MonoBehaviour
{

    
    public GameObject TextBox0;
    public GameObject TextBox1;
    public GameObject TextBox2;
    public GameObject TextBox3;
    public GameObject TextBox4;
    public GameObject TextBox5;
    public int n0;
    public int n1;
    public int n2;
    public int n3;
    public int n4;
    public int n5;
    public int count = 0;
    public string choices;
    public GameObject[] textboxes = new GameObject[6];
    public int kept;
    public static int[] rolls_container = new int[6];

    
    public void assignRolls()
    {
        
        rolls_container[0] = n0;
        rolls_container[1] = n1;
        rolls_container[2] = n2;
        rolls_container[3] = n3;
        rolls_container[4] = n4;
        rolls_container[5] = n5;
        
        /*
        rolls_container[0] = 1;
        rolls_container[1] = 2;
        rolls_container[2] = 2;
        rolls_container[3] = 3;
        rolls_container[4] = 1;
        rolls_container[5] = 6;

        */

    }

    public void displayResult()
    {
        for (int i = 0; i < rolls_container.Length; i++)
        {
            Debug.Log(rolls_container[i]);
        }
    }

    public void Roll()
    {
        choices = GetInput.text;
        //Debug.Log(choices);
        //Debug.Log(choices.Length);
        //Debug.Log(count);
        char[] charArr = choices.ToCharArray();
        int[] status = Array.ConvertAll(charArr, c => (int)Char.GetNumericValue(c));
        textboxes[0] = TextBox0;
        textboxes[1] = TextBox1;
        textboxes[2] = TextBox2;
        textboxes[3] = TextBox3;
        textboxes[4] = TextBox4;
        textboxes[5] = TextBox5;

        // the player is out of re rolls
        if (count == 3)
        {
            Debug.Log("you have used all of your re rolls, dice resolved");
            assignRolls();
            
           
        }

        // if the player still has re rolls left
        else
        {
            
            if (choices.Length > 0) // if status has any contents then they chose items to re roll
            {
                kept = 1;
            }

            if (kept == 1) // if they chose to re roll 
            {
                for (int i = 0; i < choices.Length; i++)
                {
                    int number = Random.Range(1, 7);
                    //Debug.Log(choices[i]);
                    //Debug.Log(textboxes.Length);
                    //Debug.Log(textboxes[choices[i]]);
                    textboxes[status[i]].GetComponent<Text>().text = "" + number;
                    
                }
                count++;
                kept = 0;
                assignRolls();

            }

            else
            {
                n0 = Random.Range(1, 7);
                n1 = Random.Range(1, 7);
                n2 = Random.Range(1, 7);
                n3 = Random.Range(1, 7);
                n4 = Random.Range(1, 7);
                n5 = Random.Range(1, 7);
                TextBox0.GetComponent<Text>().text = "" + n0;
                TextBox1.GetComponent<Text>().text = "" + n1;
                TextBox2.GetComponent<Text>().text = "" + n2;
                TextBox3.GetComponent<Text>().text = "" + n3;
                TextBox4.GetComponent<Text>().text = "" + n4;
                TextBox5.GetComponent<Text>().text = "" + n5;
                count += 1;
                assignRolls();
            }

        }

    }


}
