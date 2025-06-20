using TMPro;
using UnityEngine;

public class TimerUI : MonoBehaviour
{
    [Header("Referances")]
    [SerializeField] private TextMeshProUGUI timerText;

    private float elapsedTime;
    private bool isTimerRunning;

    private void Start()
    {
        elapsedTime = 0f;
        isTimerRunning = true;
    }

    private void Update()
    {
        if (isTimerRunning)
        {
            elapsedTime += Time.deltaTime;
            UpdateTimerUI();
        }
    }

    private void UpdateTimerUI()
    {
        int minutes = Mathf.FloorToInt(elapsedTime / 60f);
        int seconds = Mathf.FloorToInt(elapsedTime % 60f);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    // Timer'ı durdurmak istersen
    public void StopTimer()
    {
        isTimerRunning = false;
    }

    // Timer'ı yeniden başlatmak istersen
    public void StartTimer()
    {
        isTimerRunning = true;
    }
}
