using UnityEngine;
using UnityEngine.UI;

public class ButtonDelay : MonoBehaviour
{
    public Button myButton;
    public float delayInSeconds = 10f;

    private CanvasGroup canvasGroup;

    void Start()
    {
        // 버튼 투명도 조절을 위한 CanvasGroup 컴포넌트 가져오기
        canvasGroup = myButton.GetComponent<CanvasGroup>();
        if (canvasGroup == null)
        {
            // CanvasGroup이 없다면 추가
            canvasGroup = myButton.gameObject.AddComponent<CanvasGroup>();
        }

        // 초기에 버튼을 투명하게 설정
        canvasGroup.alpha = 0f;

        // 일정 시간 후에 버튼을 나타나게 함
        Invoke("ShowButton", delayInSeconds);
    }

    void ShowButton()
    {
        // 버튼을 나타나게 하기 (투명도 1로 설정)
        canvasGroup.alpha = 1f;
    }
}