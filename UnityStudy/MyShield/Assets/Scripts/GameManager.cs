using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject square;
    public GameObject endPanel;
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI nowScore;
    public TextMeshProUGUI bestScore;
    public Animator anim;

    bool isPlay = true;
    float time = 0.0f;
    string key = "bestScore";

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
        InvokeRepeating("MakeSquare", 0f, 1f);
    }

    private void Update()
    {
        if (isPlay)
        {
            time += Time.deltaTime;
            timeText.text = time.ToString("N2");
        }
    }

    void MakeSquare()
    {
        Instantiate(square);
    }

    public void GameOver()
    {
        isPlay = false;
        anim.SetBool("isDie", true);

        Invoke("timeStop", 1.0f);

        // �ְ������� �ִٸ�
        if (PlayerPrefs.HasKey(key))
        {
            // �ְ� ���� < �������� -> ����
            if (PlayerPrefs.GetFloat(key) < time)
            {
                PlayerPrefs.SetFloat(key, time); 
            }
        }
        // �ְ������� ���ٸ�
        else
        {
            // ���� ������ ����
            PlayerPrefs.SetFloat(key, time);
        }
        bestScore.text = PlayerPrefs.GetFloat(key).ToString("N2");
        nowScore.text = time.ToString("N2");
        endPanel.SetActive(true);
    }

    void timeStop()
    {
        Time.timeScale = 0.0f;
    }
}
