
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("ButtonPressed");
        SceneManager.LoadScene(1);

    }
}

