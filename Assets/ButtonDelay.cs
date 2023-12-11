using UnityEngine;
using UnityEngine.UI;

public class ButtonDelay : MonoBehaviour
{
    public Button myButton;
    public float delayInSeconds = 10f;

    private CanvasGroup canvasGroup;

    void Start()
    {
        // ��ư ���� ������ ���� CanvasGroup ������Ʈ ��������
        canvasGroup = myButton.GetComponent<CanvasGroup>();
        if (canvasGroup == null)
        {
            // CanvasGroup�� ���ٸ� �߰�
            canvasGroup = myButton.gameObject.AddComponent<CanvasGroup>();
        }

        // �ʱ⿡ ��ư�� �����ϰ� ����
        canvasGroup.alpha = 0f;

        // ���� �ð� �Ŀ� ��ư�� ��Ÿ���� ��
        Invoke("ShowButton", delayInSeconds);
    }

    void ShowButton()
    {
        // ��ư�� ��Ÿ���� �ϱ� (���� 1�� ����)
        canvasGroup.alpha = 1f;
    }
}