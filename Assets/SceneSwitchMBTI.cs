using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneSwitchMBTI : MonoBehaviour
{
    private void Start()
    {
        // 10초 후에 SwitchScene 메서드 호출
        Invoke("SwitchScene", 12.5f);
    }

    void SwitchScene()
    {
        //값을 가져옴
        int I = GetPlayerPref("I", 0);
        int E = GetPlayerPref("E", 0);

        int N = GetPlayerPref("N", 0);
        int S = GetPlayerPref("S", 0);

        int T = GetPlayerPref("T", 0);
        int J = GetPlayerPref("J", 0);

        int P = GetPlayerPref("P", 0);
        int F = GetPlayerPref("F", 0);

        Debug.Log("I Value: " + I);
        Debug.Log("E Value: " + E);

        // 성격에 따른 결과창으로 이동
        if (I == 1 && N == 1 && T == 1 && P == 1)
        {
            SceneManager.LoadScene("INTP");
        }
        else if (I == 1 && N == 1 && T == 1 && J == 1)
        {
            SceneManager.LoadScene("INTJ");
        }
        else if (I == 1 && N == 1 && F == 1 && P == 1)
        {
            SceneManager.LoadScene("INFP");
        }
        else if (I == 1 && N == 1 && F == 1 && J == 1)
        {
            SceneManager.LoadScene("INFJ");
        }
        else if (I == 1 && S == 1 && T == 1 && P == 1)
        {
            SceneManager.LoadScene("ISTP");
        }
        else if (I == 1 && S == 1 && T == 1 && J == 1)
        {
            SceneManager.LoadScene("ISTJ");
        }
        else if (I == 1 && S == 1 && F == 1 && P == 1)
        {
            SceneManager.LoadScene("ISFP");
        }
        else if (I == 1 && S == 1 && F == 1 && J == 1)
        {
            SceneManager.LoadScene("ISFJ");
        }
        else if (E == 1 && N == 1 && T == 1 && P == 1)
        {
            SceneManager.LoadScene("ENTP");
        }
        else if (E == 1 && N == 1 && T == 1 && J == 1)
        {
            SceneManager.LoadScene("ENTJ");
        }
        else if (E == 1 && N == 1 && F == 1 && P == 1)
        {
            SceneManager.LoadScene("ENFP");
        }
        else if (E == 1 && N == 1 && F == 1 && J == 1)
        {
            SceneManager.LoadScene("ENFJ");
        }
        else if (E == 1 && S == 1 && T == 1 && P == 1)
        {
            SceneManager.LoadScene("ESTP");
        }
        else if (E == 1 && S == 1 && T == 1 && J == 1)
        {
            SceneManager.LoadScene("ESTJ");
        }
        else if (E == 1 && S == 1 && F == 1 && P == 1)
        {
            SceneManager.LoadScene("ESFP");
        }
        else if (E == 1 && S == 1 && F == 1 && J == 1)
        {
            SceneManager.LoadScene("ESFJ");
        }
        
    }

    int GetPlayerPref(string key, int defaultValue)
    {
        if (PlayerPrefs.HasKey(key))
        {
            return PlayerPrefs.GetInt(key);
        }
        else
        {
            PlayerPrefs.SetInt(key, defaultValue);
            return defaultValue;
        }
    }
}