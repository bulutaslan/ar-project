using System.Collections;
using UnityEngine;

public class ToggleVisibility : MonoBehaviour
{
    public GameObject objectToHide; // Görünürlüðü kapatýlacak obje
    public GameObject objectToShow; // Görünürlüðü açýlacak obje
    public float delayInSeconds = 1.0f; // Gecikme süresi (saniye)

    // Butona baðlanacak fonksiyon
    public void ToggleWithDelay()
    {
        StartCoroutine(ToggleVisibilityAfterDelay());
    }

    // Gecikmeli görünürlük deðiþimi için Coroutine
    private IEnumerator ToggleVisibilityAfterDelay()
    {
        // Belirtilen süre kadar bekle
        yield return new WaitForSeconds(delayInSeconds);

        // Görünürlük deðiþtirme iþlemi
        if (objectToHide != null)
        {
            objectToHide.SetActive(false); // Objeyi kapat
        }

        if (objectToShow != null)
        {
            objectToShow.SetActive(true); // Objeyi aç
        }
    }
}
