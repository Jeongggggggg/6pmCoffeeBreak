using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Inspector���� ������ �� �̸� ����
    public string sceneToLoad = "";

    public void SceneChange()
    {
        // ������ �� �̸����� �� ��ȯ
        SceneManager.LoadScene(sceneToLoad);
    }
}