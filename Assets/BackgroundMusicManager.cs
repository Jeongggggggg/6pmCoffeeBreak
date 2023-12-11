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
            // �ν��Ͻ��� ������ ���� ������Ʈ�� �ν��Ͻ��� �����ϰ�,
            // �ٸ� ������ �̵��ص� �ı����� �ʵ��� ��
            instance = this;
            DontDestroyOnLoad(gameObject);

            // AudioSource ����
            audioSource = GetComponent<AudioSource>();
            audioSource.clip = backgroundMusicClip;
            audioSource.loop = true; // ���� �ݺ� ����
            audioSource.Play(); // ������� ���
        }
        else
        {
            // �̹� �ν��Ͻ��� �ִ� ��� �ߺ� ���� ������ ���� ���� ������Ʈ �ı�
            Destroy(gameObject);
        }
    }

    private void OnEnable()
    {
        // �� ��ȯ�� ������ ȣ��Ǵ� �̺�Ʈ�� ���� �ڵ鷯 �߰�
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        // �ڵ鷯 ����
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // �ε�� ���� �ٲ���� �� ȣ��Ǵ� �ݹ� �޼���
        // ���⿡�� ��������� ��� ����ǵ��� ���� ����
        if (audioSource != null && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
}