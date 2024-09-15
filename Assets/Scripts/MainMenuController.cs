using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // Play butonu için fonksiyon
    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene"); // Oyun sahnenizin ismini buraya yazýn
    }

    // Credits butonu için fonksiyon
    public void ShowCredits()
    {
        // Credits ekranýna geçiþ için benzer bir iþlem
        SceneManager.LoadScene("Creditts"); // Yapýmcýlarýn olduðu sahne ismi
    }

    // Exit butonu için fonksiyon
    public void ExitGame()
    {
        Application.Quit(); // Oyunu kapatýr
        Debug.Log("Game is exiting"); // Editor'da çýkýþý gözlemlemek için (Oyun kapatýlýnca bu çalýþmaz)
    }
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("menu"); // Ana menü sahnesinin ismi
    }
}