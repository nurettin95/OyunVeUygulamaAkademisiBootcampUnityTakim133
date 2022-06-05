using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneLoader : MonoBehaviour
{

    public void NewGame (int sahne_id)
    {
        SceneManager.LoadScene(sahne_id);
        PlayerPrefs.SetInt ("CurrentPlayerScore", 0);
    }

    public void NextScene()
    {
        PlayerPrefs.SetInt ("CurrentPlayerScore", ItemCollector.puan);
        int next_idx = SceneManager.GetActiveScene().buildIndex+1;
        SceneManager.LoadScene(next_idx);
    }

    public void StatsScene()
    {
        if(ItemCollector.puan < 20)
        {
            SceneManager.LoadScene(6);
        }
        else if (ItemCollector.puan < 40)
        {
            SceneManager.LoadScene(7);
        }
        else if (ItemCollector.puan < 60)
        {
            SceneManager.LoadScene(8);
        }
        else if (ItemCollector.puan < 80)
        {
            SceneManager.LoadScene(9);
        }
        else
        { 
            SceneManager.LoadScene(10);
        }
    }

    public void QuitGame()
    {
        Application.Quit();
        PlayerPrefs.DeleteAll(); //Oyun çıkışı tutulan tüm verileri siler.
        Debug.Log("Quit");
    }
}
