using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class attackInputField : MonoBehaviour
{
    public InputField WhoToAttack;
    public static string victim="";

    public void save()
    {
        victim = WhoToAttack.text;
        Debug.Log("victim chosen");
        PlayerPrefs.SetString("textTextKeyName", victim);
    }
}
