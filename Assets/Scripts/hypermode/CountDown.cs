using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public Text text;
    private SceneMg _sceneMg;
    
    public float timeLeft = 120.0f;
    public bool stop = false;
    
        
    private float minutes;
    private float seconds;
        
    void Start()
    {
        //for test outcomment
//        _sceneMg = GameObject.Find("SceneMg").GetComponent<SceneMg>();
        startTimer(timeLeft);
    }
    
    
    void Update()
    {
        if (stop)
        {
            //jump back to lvl 1
//            ChangeLevel(1);
            GameObject.DestroyImmediate(this);
            return;
        }
        
        timeLeft -= Time.deltaTime;
         
        minutes = Mathf.Floor(timeLeft / 60);
        seconds = timeLeft % 60;
        if(seconds > 59) seconds = 59;
        if(minutes < 0) {
            stop = true;
            minutes = 0;
            seconds = 0;
            StopAllCoroutines();
        }
        
        
    }
    public void startTimer(float from){
        stop = false;
        timeLeft = from;
        Update();
        StartCoroutine(updateTxt());
    }
    
    IEnumerator updateTxt()
    {
        while (!stop)
        {
            text.text = $"{minutes:0}:{seconds:00}";
            yield return new WaitForSeconds(0.02f);
        }
            
        
    }


    void ChangeLevel(int id)
    {
        _sceneMg.FadeToScene(id);
    }
    
    
}
