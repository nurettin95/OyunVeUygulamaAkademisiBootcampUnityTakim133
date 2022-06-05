using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{

    public static int puan;
    [SerializeField] TextMeshProUGUI puanText;

    void Start()
    {
        puan = PlayerPrefs.GetInt("CurrentPlayerScore");
    }

    void Update()
    {
        if (puan < 0)
            puan = 0;
        puanText.text = "Score: " + puan;
    }

    public void ArtiPuan ( int _puan)
    {
        puan += _puan;
        PlayerPrefs.SetInt ("CurrentPlayerScore", puan);
    }

    public void EksiPuan ( int _puan)
    {
        puan -= _puan;
        PlayerPrefs.SetInt ("CurrentPlayerScore", puan);
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Positive"))
        {
            Destroy(other.gameObject);
            ArtiPuan(4);
            puanText.text = "Score: " + puan;
        }

        if(other.gameObject.CompareTag("Negative"))
        {
            Destroy(other.gameObject);
            EksiPuan(4);
            puanText.text = "Score: " + puan;
        }
    }
}
