using TMPro;
using UnityEngine;

public class MenuTimerUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _level1text;
    [SerializeField] private TextMeshProUGUI _level2text;
    [SerializeField] private TextMeshProUGUI _level3text;

private void Start()
{
    LoadBestTimes();
}
    public void LoadBestTimes()
    {
        float bestTimeLevel1 = PlayerPrefs.GetFloat("BestTime_Level 1", 0f);
        float bestTimeLevel2 = PlayerPrefs.GetFloat("BestTime_Level 2", 0f);
        float bestTimeLevel3 = PlayerPrefs.GetFloat("BestTime_Level3", 0f);

        _level1text.text = FormatTime(bestTimeLevel1);
        _level2text.text = FormatTime(bestTimeLevel2);
        _level3text.text = FormatTime(bestTimeLevel3);
    }
private string FormatTime(float time)
{
    if (time == 0f)
        return "--:--";

    int minutes = Mathf.FloorToInt(time / 60f);
    int seconds = Mathf.FloorToInt(time % 60f);
    return string.Format("{0:00}:{1:00}", minutes, seconds);
}

}
