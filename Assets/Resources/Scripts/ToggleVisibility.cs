using System.Collections;
using UnityEngine;

public class ToggleVisibility : MonoBehaviour
{
    public GameObject objectToHide; // G�r�n�rl��� kapat�lacak obje
    public GameObject objectToShow; // G�r�n�rl��� a��lacak obje
    public float delayInSeconds = 1.0f; // Gecikme s�resi (saniye)

    // Butona ba�lanacak fonksiyon
    public void ToggleWithDelay()
    {
        StartCoroutine(ToggleVisibilityAfterDelay());
    }

    // Gecikmeli g�r�n�rl�k de�i�imi i�in Coroutine
    private IEnumerator ToggleVisibilityAfterDelay()
    {
        // Belirtilen s�re kadar bekle
        yield return new WaitForSeconds(delayInSeconds);

        // G�r�n�rl�k de�i�tirme i�lemi
        if (objectToHide != null)
        {
            objectToHide.SetActive(false); // Objeyi kapat
        }

        if (objectToShow != null)
        {
            objectToShow.SetActive(true); // Objeyi a�
        }
    }
}
