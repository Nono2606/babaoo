using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TeasingGame;

public class Timer : MonoBehaviour
{
    private float timer = 1f * 60f;
    public GameObject Defeat;
    private Text txt;
    private void Awake()
    {
        timer = (int)timer;
        txt = GetComponent<Text>();
    }
    void Update()
    {
        timer -= Time.deltaTime;
        //J'affiche le temps en minute
        txt.text = string.Format ("{0:0}:{1:00}",Mathf.Floor(timer/60),timer%60);

        //Si le temps atteint 0 alors ativer la condition de défaite
        if(timer <= 0)
        {
            GameOver();
        }
        
    }
    private float times = 5f;
    //On met un affichage animé qui indique que nous avons perdu car le temps est écoulé et on charge la scène Home(qui est le menu)
    void GameOver()
    {
        Defeat.SetActive(true);
        times -= Time.deltaTime;
        if(times <= 0)
        {
            SceneManager.LoadScene("Home");
        }
        
    }
}
