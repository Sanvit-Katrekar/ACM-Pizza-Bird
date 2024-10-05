using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMainGameScript : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("Main Game");
    }
}
