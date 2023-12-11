using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneCController : MonoBehaviour
{
    private void Start()
    {
        // ���� ���۵� �� PlayerPrefs �ʱ�ȭ
        PlayerPrefs.SetInt("P", 0);
        PlayerPrefs.SetInt("J", 0);
    }

    public void Button5Clicked()
    {
        // ��ư 1�� Ŭ���ϸ� P�� 1 ������Ű�� PlayerPrefs�� ����
        PlayerPrefs.SetInt("P", PlayerPrefs.GetInt("P", 0) + 1);

        // ���� ������ �̵�
        SceneManager.LoadScene("ingame4-1");
    }

    public void Button6Clicked()
    {
        // ��ư 2�� Ŭ���ϸ� J�� 1 ������Ű�� PlayerPrefs�� ����
        PlayerPrefs.SetInt("J", PlayerPrefs.GetInt("J", 0) + 1);

        // ���� ������ �̵�
        SceneManager.LoadScene("ingame4-2");
    }
}