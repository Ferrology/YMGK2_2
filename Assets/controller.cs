using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controller : MonoBehaviour
{
    public int top;
    public int top2;
    public GameObject panel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(top == top2)
        {
            panel.SetActive(true);
            Invoke("bitir", 2f);
        }
    }
    public void bitir()
    {
        SceneManager.LoadScene("main");
    }
}
