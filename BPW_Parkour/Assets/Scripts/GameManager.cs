using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameEnd = false;
   public void EndGame()
    {
       if (gameEnd == false)
        {
            gameEnd = true;
            Debug.Log("YOU DIED");
            SceneManager.LoadScene(2);
            Debug.Log("Buttonpressed");
        }
        
    }
}
   