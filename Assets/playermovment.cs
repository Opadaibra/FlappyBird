using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class playermovment : MonoBehaviour
{
    public Rigidbody2D rb;
    public TextMeshProUGUI scortext;
    public TextMeshProUGUI Highscortext;
    public GameObject GameOver;
    public float jumbamount = 8;
    bool holdjump = false;
    bool gameoverbool = false;
    
    int score;
    int Highscore;

    private void Start()
    {
        Highscore = PlayerPrefs.GetInt("score", 0);
        Highscortext.text = Highscore.ToString();
    }
    void Update()
    {
        if (holdjump)
            return;
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            
            StartCoroutine(jump());
            rb.velocity = new Vector2(0, jumbamount);
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("score"))
        {
            score++;
            if(score > Highscore)
            {
                Highscore = score;
                PlayerPrefs.SetInt("score", Highscore);
            }
            scortext.text = score.ToString();
            Highscortext.text = Highscore.ToString();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Invoke("gameover", 0);
    }
    IEnumerator jump()
    {
        holdjump = true;
        yield return new WaitForSeconds(0.5f);
        holdjump = false;

    }
    void gameover()
    {

        Time.timeScale = 0;
        GameOver.SetActive(true);
        gameoverbool = true;

    }
   
}
