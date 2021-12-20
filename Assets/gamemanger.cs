using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class gamemanger : MonoBehaviour
{

    public GameObject button;
    public TextMeshProUGUI text;
    int timer = 100;
    int flashtimer = 100;
    void Start()
    {
 
        Time.timeScale = 0;
    }

    
    private void Update()
    {
        timer++;
        if(timer > flashtimer )
        {
            timer = 0;
            if (text.color == Color.black)
                text.color = Color.white;
            else if (text.color == Color.white)
                text.color = Color.black;
        }
      

       
    }
    public void mainmenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Disable()
    {
        Time.timeScale = 1;
        text.gameObject.SetActive(false);
        button.SetActive(false);
    }

}
