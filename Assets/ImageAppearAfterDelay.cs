using UnityEngine;
using UnityEngine.UI;

public class ImageAppearAfterDelay : MonoBehaviour
{
    public Image myImage;
    public float delayInSeconds = 5f; // 등장을 지연할 시간

    void Start()
    {
        // 이미지 비활성화
        myImage.enabled = false;

        // 일정 시간 후에 이미지 등장
        Invoke("ShowImage", delayInSeconds);
    }

    void ShowImage()
    {
        // 이미지 활성화
        myImage.enabled = true;
    }
}