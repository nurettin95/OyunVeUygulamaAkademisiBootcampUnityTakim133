using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneLoader : MonoBehaviour
{
    public void SahneDegistir (int sahne_id)
    {
        SceneManager.LoadScene(sahne_id);
    }
    public void NextScene()
    {
        int next_idx = SceneManager.GetActiveScene().buildIndex+1;
        SceneManager.LoadScene(next_idx);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
