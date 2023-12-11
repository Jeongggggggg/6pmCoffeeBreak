using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Inspector에서 설정할 씬 이름 변수
    public string sceneToLoad = "";

    public void SceneChange()
    {
        // 설정된 씬 이름으로 씬 전환
        SceneManager.LoadScene(sceneToLoad);
    }
}