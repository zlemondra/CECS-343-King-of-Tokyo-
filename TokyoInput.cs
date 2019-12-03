using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TokyoInput : MonoBehaviour
{
    public InputField WhoToSwap;
    public static string swapper = "";

    public void save()
    {
        swapper = WhoToSwap.text;       
        PlayerPrefs.SetString("sname", swapper);
    }
}
