using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetInput : MonoBehaviour
{
    public InputField inputText;
    public static string text ="";

    

    public void save()
    {
        text = inputText.text;
        PlayerPrefs.SetString("textTextKeyName", text);
    }
}
