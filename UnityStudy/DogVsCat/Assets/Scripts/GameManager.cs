using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
   
    public GameObject normalCat;
    public GameObject fatCat;
    public GameObject pirateCat;
    
    public GameObject retryBtn;
    
    public RectTransform levelFront;
   
    public TextMeshProUGUI levelText;

    int level = 0;
    int score = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        Application.targetFrameRate = 60;
    }
    private void Start()
    {
        Time.timeScale = 1.0f;
        InvokeRepeating("MakeCat", 0.0f, 1.0f);
    }

    void MakeCat()
    {
        Instantiate(normalCat);

        // lv1 20% 확률로 고양이를 더 생성
        if (level == 1)
        {
            int p = Random.Range(0, 10);
            if (p < 2) Instantiate(normalCat);
        }

        // lv2 50% 확률로 고양이를 더 생성
        else if (level == 2)
        {
            int p = Random.Range(0, 10);
            if (p < 5) Instantiate(normalCat);
        }
        // lv3 뚱뚱한 고양이를 생성
        else if (level == 3) 
        {
            int p = Random.Range(0, 10);
            if (p < 5) Instantiate(normalCat);
            Instantiate(fatCat);
        }

        // lv4 해적 고양이를 생성
        else if (level >= 4)
        {
            int p = Random.Range(0, 10);
            if (p < 5) Instantiate(normalCat);
            Instantiate(fatCat);
            Instantiate(pirateCat);
        }


    }

    public void GameOver()
    {
        Time.timeScale = 0.0f;
        retryBtn.SetActive(true);
    }

    public void AddScore()
    {
        score++;
        level = score / 5;
        levelText.text = level.ToString();
        levelFront.localScale = new Vector3((score - level * 5) / 5.0f, 1f, 1f);
    } 
}
