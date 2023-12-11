using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneDController : MonoBehaviour
{
    private void Start()
    {
        // 씬이 시작될 때 PlayerPrefs 초기화
        PlayerPrefs.SetInt("N", 0);
        PlayerPrefs.SetInt("S", 0);
    }

    public void Button7Clicked()
    {
        // 버튼 1을 클릭하면 N을 1 증가시키고 PlayerPrefs에 저장
        PlayerPrefs.SetInt("N", PlayerPrefs.GetInt("N", 0) + 1);

        // 다음 씬으로 이동
        SceneManager.LoadScene("ingame5-1");
    }

    public void Button8Clicked()
    {
        // 버튼 2를 클릭하면 S를 1 증가시키고 PlayerPrefs에 저장
        PlayerPrefs.SetInt("S", PlayerPrefs.GetInt("S", 0) + 1);

        // 다음 씬으로 이동
        SceneManager.LoadScene("ingame5-2");
    }
}