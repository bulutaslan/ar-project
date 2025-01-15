using UnityEngine;
using UnityEngine.UI;

public class MusicController : MonoBehaviour
{
    public AudioSource audioSource; // Ses kaynaðý referansý
    public Button toggleMusicButton; // Buton referansý

    private bool isPlaying = true;

    void Start()
    {
        // Buton týklandýðýnda ToggleMusic fonksiyonunu çaðýr
        toggleMusicButton.onClick.AddListener(ToggleMusic);
    }

    void ToggleMusic()
    {
        if (isPlaying)
        {
            audioSource.Pause(); // Müziði durdur
        }
        else
        {
            audioSource.Play(); // Müziði baþlat
        }

        isPlaying = !isPlaying; // Durum deðiþtir
    }
}