using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public GameObject front;
    public GameObject back;

    public Animator anim;

    public SpriteRenderer frontImage;

    public int idx;

    public void Setting(int num)
    {
        idx = num;
        frontImage.sprite = Resources.Load<Sprite>($"rtan{idx}");
    }

    public void OpenCard()
    {
        anim.SetBool("isOpen", true);
        front.SetActive(true);
        back.SetActive(false);

        // firstCard�� ����ٸ�
        if(GameManager.Instance.firstCard == null)
        {
            // firstCard�� �� ������ �Ѱ��ش�.
            GameManager.Instance.firstCard = this;
        }
        // firstCard�� ������� �ʴٸ�
        else
        {
            // secondCard�� �� ������ �Ѱ��ش�.
            GameManager.Instance.secondCard = this;
            // Matched �Լ��� ȣ���Ѵ�.
            GameManager.Instance.Matched();
        }
    }

    public void DestroyCard()
    {
        Invoke("DestroyCardInvoke", 1.0f);
    }

    public void DestroyCardInvoke()
    {
        Destroy(gameObject);
    }

    public void CloseCard()
    {
        Invoke("CloseCardInvoke", 1.0f);
    }

    public void CloseCardInvoke()
    {
        anim.SetBool("isOpen", false);
        front.SetActive(false);
        back.SetActive(true);
    }
}
