using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneBController : MonoBehaviour
{
    private void Start()
    {
        // ���� ���۵� �� PlayerPrefs �ʱ�ȭ
        PlayerPrefs.SetInt("T", 0);
        PlayerPrefs.SetInt("F", 0);
    }

    public void Button3Clicked()
    {
        // ��ư 1�� Ŭ���ϸ� T�� 1 ������Ű�� PlayerPrefs�� ����
        PlayerPrefs.SetInt("T", PlayerPrefs.GetInt("T", 0) + 1);

        // ���� ������ �̵�
        SceneManager.LoadScene("ingame3-1");
    }

    public void Button4Clicked()
    {
        // ��ư 2�� Ŭ���ϸ� F�� 1 ������Ű�� PlayerPrefs�� ����
        PlayerPrefs.SetInt("F", PlayerPrefs.GetInt("F", 0) + 1);

        // ���� ������ �̵�
        SceneManager.LoadScene("ingame3-2");
    }
}