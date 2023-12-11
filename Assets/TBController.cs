using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using KoreanTyper;

public class TBController : MonoBehaviour
{
    string originText;
    Text myText;
    public Button myButton;
    public Button myButton2;

    // Inspector���� ������ ��� �ð� ����
    public float initialWaitTime = 0.0f;

    private void Awake()
    {
        myText = GetComponent<Text>();
    }

    private void Start()
    {
        myButton.gameObject.SetActive(false);
        myButton2.gameObject.SetActive(false);
        originText = myText.text;
        myText.text = "";

        StartCoroutine(TypingRoutine());
    }

    IEnumerator TypingRoutine()
    {
        // Inspector���� ������ ��� �ð���ŭ ��ٸ�
        yield return new WaitForSeconds(initialWaitTime);

        int typingLength = originText.GetTypingLength();

        for (int index = 0; index <= typingLength; index++)
        {
            myText.text = originText.Typing(index);
            yield return new WaitForSeconds(0.05f);
        }

        yield return new WaitForSeconds(1.0f);

        // ��ư Ȱ��ȭ
        myButton.gameObject.SetActive(true);
        myButton2.gameObject.SetActive(true);
    }
}