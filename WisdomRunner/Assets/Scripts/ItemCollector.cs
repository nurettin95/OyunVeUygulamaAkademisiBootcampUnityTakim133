using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{

    int puan = 0;
    
    [SerializeField] Text puanText;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Positive"))
        {
            Destroy(other.gameObject);
            puan++;
            puanText.text = "Puan: " + puan;
        }

        if(other.gameObject.CompareTag("Negative"))
        {
            Destroy(other.gameObject);
            puan--;
            puanText.text = "Puan: " + puan;
        }
    }
}
