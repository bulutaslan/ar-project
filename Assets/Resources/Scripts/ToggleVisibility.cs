using UnityEngine;

public class ToggleVisibility : MonoBehaviour
{
    // Inspector'da atanacak alanlar
    public GameObject objectToClose; // Kapat�lacak GameObject
    public GameObject objectToOpen;  // A��lacak GameObject

    // Bu fonksiyon, buton taraf�ndan �a�r�l�r
    public void Toggle()
    {
        // E�er kapat�lacak obje atanm��sa, kapat
        if (objectToClose != null)
        {
            objectToClose.SetActive(false);
        }

        // E�er a��lacak obje atanm��sa, a�
        if (objectToOpen != null)
        {
            objectToOpen.SetActive(true);
        }
    }
}
