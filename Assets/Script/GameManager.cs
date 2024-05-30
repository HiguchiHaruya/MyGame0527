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
            DontDestroyOnLoad(gameObject); // シーンが切り替わっても破棄されないようにする
        }
        else
        {
            Destroy(gameObject); // すでに存在する場合は破棄する
        }
    }

    public void StartGame()
    {
        // ゲーム開始の処理
        SceneManager.LoadScene("GameScene");
    }

    public void EndGame()
    {
        // ゲーム終了の処理
        SceneManager.LoadScene("EndScene");
    }

    public void RestartGame()
    {
        // ゲームリスタートの処理
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}