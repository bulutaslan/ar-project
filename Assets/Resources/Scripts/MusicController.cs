using UnityEngine;
using UnityEngine.UI;

public class MusicController : MonoBehaviour
{
    public AudioSource audioSource; // Ses kayna�� referans�
    public Button toggleMusicButton; // Buton referans�

    private bool isPlaying = true;

    void Start()
    {
        // Buton t�kland���nda ToggleMusic fonksiyonunu �a��r
        toggleMusicButton.onClick.AddListener(ToggleMusic);
    }

    void ToggleMusic()
    {
        if (isPlaying)
        {
            audioSource.Pause(); // M�zi�i durdur
        }
        else
        {
            audioSource.Play(); // M�zi�i ba�lat
        }

        isPlaying = !isPlaying; // Durum de�i�tir
    }
}