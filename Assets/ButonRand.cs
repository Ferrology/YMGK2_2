using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButonRand : MonoBehaviour
{
    public TextMeshProUGUI Sayi;
    int sayiDeger = 0;
    void Start()
    {
        sayiDeger = Random.Range(7, 1000);

        if (sayiDeger % 7 == 0)
        {
            FindObjectOfType<controller>().top++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Sayi.text = sayiDeger.ToString();
    }

    public void ButtonClick()
    {
        if(sayiDeger % 7 == 0)
        {
            print("test");
            this.gameObject.GetComponent<Image>().color = Color.green;
            FindObjectOfType<controller>().top2++;
        }
    }
}
