using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public float delayInSeconds = 2.0f;  // �� ��ȯ�� �� �� �Ŀ� �������� ����
    public string targetScene;  // ��ȯ�� ��� ���� ����

    void Start()
    {
        // delayInSeconds �Ŀ� SwitchScene �޼��带 ȣ��
        Invoke("SwitchScene", delayInSeconds);
    }

    void SwitchScene()
    {
        // targetScene���� �� ��ȯ
        SceneManager.LoadScene(targetScene);
    }
}