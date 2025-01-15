using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText; // Canvas'taki anl�k puan g�stergesi
    public GameObject gameOverScreen; // Oyun sonu ekran�
    public Text finalScoreText; // Oyun sonunda g�sterilecek puan

    public int score = 0; // Ba�lang�� puan�
    public int correctAnswerPoints = 10; // Do�ru cevapta artacak puan
    public int wrongAnswerPoints = 5; // Yanl�� cevapta azalacak puan

    // Puan� art�r�r ve g�nceller
    public void AddScore()
    {
        score += correctAnswerPoints;
        UpdateScoreText();
    }

    // Puan� azalt�r ve g�nceller
    public void SubtractScore()
    {
        score -= wrongAnswerPoints;
        if (score < 0)
        {
            score = 0; // Puan s�f�r�n alt�na inmesin
        }
        UpdateScoreText();
    }

    // Oyun sonunda puan� g�sterir
    public void ShowGameOverScreen()
    {
        gameOverScreen.SetActive(true); // Oyun sonu ekran�n� a�
        finalScoreText.text = "Toplam Puan: " + score.ToString(); // Puan� g�ster
    }

    // Puan Text'ini g�nceller
    private void UpdateScoreText()
    {
        scoreText.text = "Toplam Puan: " + score.ToString();
    }
}
