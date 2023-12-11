using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneDController : MonoBehaviour
{
    private void Start()
    {
        // ���� ���۵� �� PlayerPrefs �ʱ�ȭ
        PlayerPrefs.SetInt("N", 0);
        PlayerPrefs.SetInt("S", 0);
    }

    public void Button7Clicked()
    {
        // ��ư 1�� Ŭ���ϸ� N�� 1 ������Ű�� PlayerPrefs�� ����
        PlayerPrefs.SetInt("N", PlayerPrefs.GetInt("N", 0) + 1);

        // ���� ������ �̵�
        SceneManager.LoadScene("ingame5-1");
    }

    public void Button8Clicked()
    {
        // ��ư 2�� Ŭ���ϸ� S�� 1 ������Ű�� PlayerPrefs�� ����
        PlayerPrefs.SetInt("S", PlayerPrefs.GetInt("S", 0) + 1);

        // ���� ������ �̵�
        SceneManager.LoadScene("ingame5-2");
    }
}