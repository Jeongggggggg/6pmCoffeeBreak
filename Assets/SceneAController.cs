using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneAController : MonoBehaviour
{
    private void Start()
    {
        // ���� ���۵� �� PlayerPrefs �ʱ�ȭ
        PlayerPrefs.SetInt("I", 0);
        PlayerPrefs.SetInt("E", 0);
    }

    public void Button1Clicked()
    {
        // ��ư 1�� Ŭ���ϸ� E�� 1 ������Ű�� PlayerPrefs�� ����
        PlayerPrefs.SetInt("E", PlayerPrefs.GetInt("E", 0) + 1);

        // ���� ������ �̵�
        SceneManager.LoadScene("ingame1-1");
    }

    public void Button2Clicked()
    {
        // ��ư 2�� Ŭ���ϸ� I�� 1 ������Ű�� PlayerPrefs�� ����
        PlayerPrefs.SetInt("I", PlayerPrefs.GetInt("I", 0) + 1);

        // ���� ������ �̵�
        SceneManager.LoadScene("ingame1-2");
    }
}