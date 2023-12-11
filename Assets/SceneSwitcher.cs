using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public float delayInSeconds = 2.0f;  // 씬 전환을 몇 초 후에 실행할지 설정
    public string targetScene;  // 전환할 대상 씬을 설정

    void Start()
    {
        // delayInSeconds 후에 SwitchScene 메서드를 호출
        Invoke("SwitchScene", delayInSeconds);
    }

    void SwitchScene()
    {
        // targetScene으로 씬 전환
        SceneManager.LoadScene(targetScene);
    }
}