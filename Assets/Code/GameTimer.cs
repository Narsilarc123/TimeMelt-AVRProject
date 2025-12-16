using UnityEngine;
using TMPro;

public class GameTimer : MonoBehaviour
{
    public static GameTimer instance;   // Singleton access point

    public float startTime = 20f;       // Countdown starting time
    public TextMeshProUGUI timerText;   // UI text reference
    private float timeRemaining;
    private bool isRunning = true;

    void Awake()
    {
        instance = this;
        Debug.Log("GameTimer instance set");
    }

    void Start()
    {
        timeRemaining = startTime;  // Initialize timer
    }

    void Update()
    {
        if (!isRunning) return;

        timeRemaining -= Time.deltaTime;

        if (timeRemaining <= 0)
        {
            timeRemaining = 0;
            isRunning = false;
            Debug.Log("Time's up!");
        }

        // Update UI text
        timerText.text = "Time: " + Mathf.Ceil(timeRemaining);
    }

    public void AddTime(float amount)
    {
        timeRemaining += amount;    // Add bonus time
    }
}
