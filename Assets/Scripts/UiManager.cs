using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    
    [Header("Score Board")]
    public GameObject scoreBoard;
    public TextMeshProUGUI finalScoreText;
    public TextMeshProUGUI bestScoreText;
    public Image medalImage;
    
    public Sprite[] medals;
    
    public void DisplayScore(int score)
    {
        scoreText.text = score.ToString();
    }
    
    public void DisplayScoreBoard(int score)
    {
        scoreBoard.SetActive(true);
        finalScoreText.text = score.ToString();
        
        scoreText.gameObject.SetActive(false);
        
        //TODO: Implement best score
        bestScoreText.text = "9999";
        medalImage.sprite = medals[Random.Range(0, medals.Length)];
    }
}
