using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using KoreanTyper;

public class BasicTyperErase : MonoBehaviour
{
    public float initialWaitTime = 0.0f;  // 초기에 대기할 시간
    public float eraseAfterTime = 0.0f;    // 텍스트를 지우기 시작할 시간

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
            yield return new WaitForSeconds(0.06f);
        }

        // Wait for a specified time before erasing
        yield return new WaitForSeconds(eraseAfterTime);

        // Erase the text
        myText.text = "";

        // You can add additional actions here after erasing
    }
}