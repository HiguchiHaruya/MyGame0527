using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // �V�[�����؂�ւ���Ă��j������Ȃ��悤�ɂ���
        }
        else
        {
            Destroy(gameObject); // ���łɑ��݂���ꍇ�͔j������
        }
    }

    public void StartGame()
    {
        // �Q�[���J�n�̏���
        SceneManager.LoadScene("GameScene");
    }

    public void EndGame()
    {
        // �Q�[���I���̏���
        SceneManager.LoadScene("EndScene");
    }

    public void RestartGame()
    {
        // �Q�[�����X�^�[�g�̏���
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}