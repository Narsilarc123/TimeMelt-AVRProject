using UnityEngine;

public class GameOverUI : MonoBehaviour
{
    public static GameOverUI instance;

    public GameObject gameOverPanel;

    void Awake()
    {
        instance = this;
    }

    public void Show()
    {
        gameOverPanel.SetActive(true);
    }
}
