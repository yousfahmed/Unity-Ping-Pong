using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPlay : MonoBehaviour {

    public void PlayGame()
    {
        Debug.Log("play game now!");
        SceneManager.LoadScene("Game");
    }
}
