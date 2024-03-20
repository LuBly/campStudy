using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject rain;

    int totalScore = 0;
    [SerializeField] float totalTime = 30.0f;
    public Text totalScoreText;
    public Text TimeText;
    public GameObject endPanel;
    private void Awake()
    {
        Instance = this;
        Time.timeScale = 1.0f;
    }

    private void Start()
    {
        InvokeRepeating("MakeRain", 0f, 1f);
    }
    void Update()
    {
        if(totalTime > 0)
        {
            totalTime -= Time.deltaTime;
        }
        else
        {
            totalTime = 0f;
            Time.timeScale = 0f;
            endPanel.SetActive(true);
        }
        TimeText.text = totalTime.ToString("N2");
    }

    void MakeRain()
    {
        Instantiate(rain);
    }

    public void AddScore(int score)
    {
        totalScore += score;
        totalScoreText.text = totalScore.ToString();
    }
}
