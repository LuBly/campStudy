using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public Card firstCard;
    public Card secondCard;

    public TextMeshProUGUI timeText;
    public GameObject endText;

    public int cardCount = 0;

    float time = 0.0f;
    

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
    }
    private void Update()
    {
        time += Time.deltaTime;
        timeText.text = time.ToString("N2");

        if (time >= 30.0f)
        {
            time = 30.0f;
            Time.timeScale = 0.0f;
            endText.SetActive(true);
        }
    }

    public void Matched()
    {
        if(firstCard.idx == secondCard.idx)
        {
            // �ı��ض�.
            firstCard.DestroyCard();
            secondCard.DestroyCard();
            cardCount -= 2;
            if(cardCount == 0)
            {
                Time.timeScale = 0.0f;
                endText.SetActive(true);
            }
        }
        else
        {
            // �ݾƶ�.
            firstCard.CloseCard();
            secondCard.CloseCard();
        }

        // ī�� �ʱ�ȭ
        firstCard = null;
        secondCard = null;
    }
}
