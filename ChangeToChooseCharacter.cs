using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    Button start = null;
    void Start()
    {
        start.onClick.AddListener(() => { SceneManager.LoadScene("CharacterScene"); });
        SceneManager.LoadScene("CharacterScene");
    }

    // Update is called once per frame
    void Update()
    {

    }

}
