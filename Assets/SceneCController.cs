using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneCController : MonoBehaviour
{
    private void Start()
    {
        // 씬이 시작될 때 PlayerPrefs 초기화
        PlayerPrefs.SetInt("P", 0);
        PlayerPrefs.SetInt("J", 0);
    }

    public void Button5Clicked()
    {
        // 버튼 1을 클릭하면 P를 1 증가시키고 PlayerPrefs에 저장
        PlayerPrefs.SetInt("P", PlayerPrefs.GetInt("P", 0) + 1);

        // 다음 씬으로 이동
        SceneManager.LoadScene("ingame4-1");
    }

    public void Button6Clicked()
    {
        // 버튼 2를 클릭하면 J를 1 증가시키고 PlayerPrefs에 저장
        PlayerPrefs.SetInt("J", PlayerPrefs.GetInt("J", 0) + 1);

        // 다음 씬으로 이동
        SceneManager.LoadScene("ingame4-2");
    }
}