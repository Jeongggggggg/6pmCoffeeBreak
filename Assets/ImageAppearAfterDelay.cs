using UnityEngine;
using UnityEngine.UI;

public class ImageAppearAfterDelay : MonoBehaviour
{
    public Image myImage;
    public float delayInSeconds = 5f; // ������ ������ �ð�

    void Start()
    {
        // �̹��� ��Ȱ��ȭ
        myImage.enabled = false;

        // ���� �ð� �Ŀ� �̹��� ����
        Invoke("ShowImage", delayInSeconds);
    }

    void ShowImage()
    {
        // �̹��� Ȱ��ȭ
        myImage.enabled = true;
    }
}