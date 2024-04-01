using UnityEngine;
using System.Linq;
public class Board : MonoBehaviour
{
    public GameObject card;
    float dist = 1.4f;
    private void Start()
    {
        int[] arr = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7 };
        arr = arr.OrderBy(x => Random.Range(0f,7f)).ToArray();
        for(int i = 0; i < 16; i++)
        {
            GameObject go = Instantiate(card, transform);
            
            float x = (i % 4) * dist - 2.1f;
            float y = (i / 4) * dist - 3.0f;

            go.transform.position = new Vector3(x, y, 0);
            go.GetComponent<Card>().Setting(arr[i]);
            //�� ī�庰�� ��� images�� ��� �ִ°� ���� 
            //Board�ϳ����� images�� ������ �ְ�, �̸� card Sprite���濡�� ����ϴ°� �� ȿ�������� ������?
            //-->Resources ������ Ȱ���ؼ� �������� ������ ���� ����� ä���ߴ�. �ʿ��� item�� �������ϱ� �� ȿ������ �� ����.
            /*
             * ī�� �̹����� �迭�̳� List�� �̿��ؼ� hierarchy�� �߰���Ű�� ����� Resources.Load�� ����ϴ� ����� �������� ������� ������ �����ϴ�.

                1. �迭�̳� List�� �̿��ؼ� hierarchy�� �߰���Ű�� ���
                    - ����:
                        - �迭�̳� List�� �̿��ϸ� �̸� �ε�� �̹������� ���� ������ �� �ֽ��ϴ�.
                        - �̹������� �������� �߰��ϰų� ������ �� �־� �������� �����ϴ�.
                        - hierarchy�� �߰��� �̹������� �ڵ�� ���� ������ �� �ֽ��ϴ�.

                    - ����:
                        - �̹������� �迭�̳� List�� �̸� �����ؾ� �ϹǷ� �޸� ��뷮�� ������ �� �ֽ��ϴ�.
                        - �̹������� ������ �߰��ؾ� �ϹǷ� ���ŷο� �� �ֽ��ϴ�.

                2. Resources.Load�� ����ϴ� ���
                    - ����:
                        - Resources.Load�� ����ϸ� �ʿ��� �̹����� �������� �ε��� �� �־� �޸𸮸� ȿ�������� ������ �� �ֽ��ϴ�.
                        - �̹����� Resources ������ �����ϰ� ������ ��η� �ε��� �� �־� ���մϴ�.

                    - ����:
                        - Resources.Load�� ����ϸ� �̹����� �ε��� ������ ���� �ý��ۿ� �����ؾ� �ϹǷ� ���ɿ� ������ �� �� �ֽ��ϴ�.
                        - Resources ������ �̹����� �����ؾ� �ϹǷ� ������Ʈ ������ �������� �� �ֽ��ϴ�.

                ����, �迭�̳� List�� �̿��ؼ� hierarchy�� �߰���Ű�� ����� �̹����� �����ϰ� �����ϴ� �� �������� ������ �޸� ��뷮�� ������ �� �ְ� ���ŷο� �� �ֽ��ϴ�. 
                �ݸ鿡 Resources.Load�� ����ϴ� ����� �޸𸮸� ȿ�������� ������ �� ������ ���� �ý��ۿ� �����ؾ� �ϰ� ������Ʈ ������ �������� �� �ֽ��ϴ�
             */
            GameManager.Instance.cardCount = arr.Length;
        }
    }
}
