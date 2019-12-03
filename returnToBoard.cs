using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class returnToBoard : MonoBehaviour
{

    public void BackToGameBoard()
    {
        SceneManager.LoadScene("Game Board");
    }
}
