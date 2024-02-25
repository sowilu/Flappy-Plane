using TMPro;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    
    public void DisplayScore(int score)
    {
        scoreText.text = score.ToString();
    }
}
