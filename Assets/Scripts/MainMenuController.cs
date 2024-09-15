using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // Play butonu i�in fonksiyon
    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene"); // Oyun sahnenizin ismini buraya yaz�n
    }

    // Credits butonu i�in fonksiyon
    public void ShowCredits()
    {
        // Credits ekran�na ge�i� i�in benzer bir i�lem
        SceneManager.LoadScene("Creditts"); // Yap�mc�lar�n oldu�u sahne ismi
    }

    // Exit butonu i�in fonksiyon
    public void ExitGame()
    {
        Application.Quit(); // Oyunu kapat�r
        Debug.Log("Game is exiting"); // Editor'da ��k��� g�zlemlemek i�in (Oyun kapat�l�nca bu �al��maz)
    }
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("menu"); // Ana men� sahnesinin ismi
    }
}