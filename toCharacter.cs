using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class toCharacter : MonoBehaviour
{
    // Start is called before the first frame update
    Button start = null;
    public void ToCharacter()
    {
        start.onClick.AddListener(() => { SceneManager.LoadScene("CharacterScene"); });
    }
    public void Character()
    {
        SceneManager.LoadScene("Character");
    }
}
