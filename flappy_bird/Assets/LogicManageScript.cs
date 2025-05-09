using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManageScript : MonoBehaviour
{
    public int score;
    public Text textScore;
    public GameObject gameOverScreen;
    [ContextMenu("increase score")]
    public void increaseScore(int scoreToAdd)
    {
        score = score + scoreToAdd;
        textScore.text= score.ToString();
    }
    public void restartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
