using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

        int best = 0, second = 0;
        if (PlayerPrefs.HasKey("best"))
        {
            best = PlayerPrefs.GetInt("best");

            if (score > best)
            {
                best = score;
                PlayerPrefs.SetInt("best", best);
                PlayerPrefs.Save();
            }

            bestScoreText.text = best.ToString();
        }
        else
        {
            bestScoreText.text = score.ToString();
            PlayerPrefs.SetInt("best", score);

        }

        if (PlayerPrefs.HasKey("second"))
        {
            second = PlayerPrefs.GetInt("second");
            
            if (score > second && score < best)
            {
                second = score;
                PlayerPrefs.SetInt("second", second);
               
            }
        }
        else
        {
            second = score;
        }
        
        PlayerPrefs.Save();
         
        //medal according to score
        if (score >= best)
        {
            medalImage.sprite = medals[0];
        }
        else if (score >= second)
        {
            medalImage.sprite = medals[1];
        }
        else
        {
            medalImage.sprite = medals[2];
        }
        
        
        //medalImage.sprite = medals[Random.Range(0, medals.Length)];
    }
    
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
