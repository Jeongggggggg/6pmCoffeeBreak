using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneAController : MonoBehaviour
{
    private void Start()
    {
        // 씬이 시작될 때 PlayerPrefs 초기화
        PlayerPrefs.SetInt("I", 0);
        PlayerPrefs.SetInt("E", 0);
    }

    public void Button1Clicked()
    {
        // 버튼 1을 클릭하면 E를 1 증가시키고 PlayerPrefs에 저장
        PlayerPrefs.SetInt("E", PlayerPrefs.GetInt("E", 0) + 1);

        // 다음 씬으로 이동
        SceneManager.LoadScene("ingame1-1");
    }

    public void Button2Clicked()
    {
        // 버튼 2를 클릭하면 I를 1 증가시키고 PlayerPrefs에 저장
        PlayerPrefs.SetInt("I", PlayerPrefs.GetInt("I", 0) + 1);

        // 다음 씬으로 이동
        SceneManager.LoadScene("ingame1-2");
    }
}