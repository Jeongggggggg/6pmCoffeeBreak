using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundMusicManager : MonoBehaviour
{
    private static BackgroundMusicManager instance;

    public AudioClip backgroundMusicClip;
    private AudioSource audioSource;

    private void Awake()
    {
        if (instance == null)
        {
            // 인스턴스가 없으면 현재 오브젝트를 인스턴스로 설정하고,
            // 다른 씬으로 이동해도 파괴되지 않도록 함
            instance = this;
            DontDestroyOnLoad(gameObject);

            // AudioSource 설정
            audioSource = GetComponent<AudioSource>();
            audioSource.clip = backgroundMusicClip;
            audioSource.loop = true; // 무한 반복 설정
            audioSource.Play(); // 배경음악 재생
        }
        else
        {
            // 이미 인스턴스가 있는 경우 중복 생성 방지를 위해 현재 오브젝트 파괴
            Destroy(gameObject);
        }
    }

    private void OnEnable()
    {
        // 씬 전환할 때마다 호출되는 이벤트에 대한 핸들러 추가
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        // 핸들러 제거
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // 로드된 씬이 바뀌었을 때 호출되는 콜백 메서드
        // 여기에서 배경음악이 계속 재생되도록 설정 가능
        if (audioSource != null && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
}