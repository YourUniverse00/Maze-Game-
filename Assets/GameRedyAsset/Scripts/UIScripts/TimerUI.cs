using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerUI : MonoBehaviour
{
    [Header("Referances")]
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private WinLoseUI _winloseUI;


    const string BestTimeKey = "BestTime_Level1";
    const string BestTimeKey2 = "BestTime_Level2";

    private float elapsedTime;
    private bool isTimerRunning;
      private string bestTimeKey;

    private void Start()
    {
        bestTimeKey = "BestTime_" + SceneManager.GetActiveScene().name;

        _winloseUI.OnSpeedBoost += OnspeedBost_Timerui;
        elapsedTime = 0f;
        isTimerRunning = true;
    }
    public void OnspeedBost_Timerui()
    {
 float bestTime = PlayerPrefs.GetFloat(bestTimeKey, float.MaxValue);

        if (elapsedTime < bestTime)
        {
            bestTime = elapsedTime;
            PlayerPrefs.SetFloat(bestTimeKey, bestTime);
            PlayerPrefs.Save();
            Debug.Log("Yeni en iyi süre: " + bestTime);
        }
        else
        {
            Debug.Log("Bu süre rekor değil: " + elapsedTime);
        }
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
