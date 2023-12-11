using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneBController : MonoBehaviour
{
    private void Start()
    {
        // 씬이 시작될 때 PlayerPrefs 초기화
        PlayerPrefs.SetInt("T", 0);
        PlayerPrefs.SetInt("F", 0);
    }

    public void Button3Clicked()
    {
        // 버튼 1을 클릭하면 T를 1 증가시키고 PlayerPrefs에 저장
        PlayerPrefs.SetInt("T", PlayerPrefs.GetInt("T", 0) + 1);

        // 다음 씬으로 이동
        SceneManager.LoadScene("ingame3-1");
    }

    public void Button4Clicked()
    {
        // 버튼 2를 클릭하면 F를 1 증가시키고 PlayerPrefs에 저장
        PlayerPrefs.SetInt("F", PlayerPrefs.GetInt("F", 0) + 1);

        // 다음 씬으로 이동
        SceneManager.LoadScene("ingame3-2");
    }
}