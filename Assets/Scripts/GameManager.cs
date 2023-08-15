using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI deathCountText;
    public int deathCount = 0;

    private void Start()
    {
        LoadDeathCount();
        UpdateDeathCountText();
    }

    public void PlayerDied()
    {
        deathCount++;
        SaveDeathCount();
        UpdateDeathCountText();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void UpdateDeathCountText()
    {
        deathCountText.text = "Deaths: " + deathCount.ToString();
    }

    private void SaveDeathCount()
    {
        PlayerPrefs.SetInt("DeathCount", deathCount);
        PlayerPrefs.Save();
    }

    private void LoadDeathCount()
    {
        if (PlayerPrefs.HasKey("DeathCount"))
        {
            deathCount = PlayerPrefs.GetInt("DeathCount");
        }
    }
}