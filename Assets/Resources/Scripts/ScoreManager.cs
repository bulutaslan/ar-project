using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText; // Canvas'taki anlýk puan göstergesi
    public GameObject gameOverScreen; // Oyun sonu ekraný
    public Text finalScoreText; // Oyun sonunda gösterilecek puan

    public int score = 0; // Baþlangýç puaný
    public int correctAnswerPoints = 10; // Doðru cevapta artacak puan
    public int wrongAnswerPoints = 5; // Yanlýþ cevapta azalacak puan

    // Puaný artýrýr ve günceller
    public void AddScore()
    {
        score += correctAnswerPoints;
        UpdateScoreText();
    }

    // Puaný azaltýr ve günceller
    public void SubtractScore()
    {
        score -= wrongAnswerPoints;
        if (score < 0)
        {
            score = 0; // Puan sýfýrýn altýna inmesin
        }
        UpdateScoreText();
    }

    // Oyun sonunda puaný gösterir
    public void ShowGameOverScreen()
    {
        gameOverScreen.SetActive(true); // Oyun sonu ekranýný aç
        finalScoreText.text = "Toplam Puan: " + score.ToString(); // Puaný göster
    }

    // Puan Text'ini günceller
    private void UpdateScoreText()
    {
        scoreText.text = "Toplam Puan: " + score.ToString();
    }
}
