using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using KoreanTyper;

public class BasicTyper2 : MonoBehaviour
{
    public float initialWaitTime = 2.5f;  // 외부에서 설정할 초기 대기 시간
    string originText;
    Text myText;

    private void Awake()
    {
        myText = GetComponent<Text>();
    }

    private void Start()
    {
        originText = myText.text;
        myText.text = "";

        StartCoroutine(TypingRoutine());
    }

    IEnumerator TypingRoutine()
    {
        yield return new WaitForSeconds(initialWaitTime);
        int typingLength = originText.GetTypingLength();

        // Type in the text
        for (int index = 0; index <= typingLength; index++)
        {
            myText.text = originText.Typing(index);
            yield return new WaitForSeconds(0.2f);
        }

        // Wait for 1 second after typing
        yield return new WaitForSeconds(1.0f);

        // You can add additional actions here after typing
    }
}