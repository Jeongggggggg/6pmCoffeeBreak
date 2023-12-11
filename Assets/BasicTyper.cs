using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using KoreanTyper;

public class BasicTyper : MonoBehaviour
{
    public float initialWaitTime;  // �ܺο��� ������ ��� �ð�
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

        // Wait for 1 second after typing
        yield return new WaitForSeconds(1.0f);

        // You can add additional actions here after typing
    }
}