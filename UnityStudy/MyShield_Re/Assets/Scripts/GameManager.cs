using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject rain;
    public GameObject gameoverUI;
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI bestTime;
    public TextMeshProUGUI curTime;
    public Animator anim;

    float time = 0.0f;
    string key = "bestTime";
    bool isPlay;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }

    private void Start()
    {
        Time.timeScale = 1.0f;
        isPlay = true;
        InvokeRepeating("MakeRain", 1.0f, 1.0f);
    }
    // Update is called once per frame
    void Update()
    {
        if (isPlay)
        {
            time += Time.deltaTime;
            timeText.text = time.ToString("N2");
        }
    }

    void MakeRain()
    {
        Instantiate(rain);
    }
    
    public void GameOver()
    {
        Invoke("TimeToZero", 0.5f);
        anim.SetBool("isDie", true);
        isPlay = false;

        if (PlayerPrefs.HasKey(key))
        {
            if(PlayerPrefs.GetFloat(key) < time)
            {
                PlayerPrefs.SetFloat(key, time);
            }
        }
        else
        {
            PlayerPrefs.SetFloat(key, time);
        }
        bestTime.text = PlayerPrefs.GetFloat(key).ToString("N2");
        curTime.text = time.ToString("N2");
        gameoverUI.SetActive(true);
    }
    void TimeToZero()
    {
        Time.timeScale = 0.0f;
    }
}
