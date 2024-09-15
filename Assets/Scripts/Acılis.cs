using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector2 startPosition; // Oyuncunun başlangıç pozisyonu
    public Vector2 targetPosition; // Hedef pozisyon
    public float speed = 2.0f; // Hareket hızı

    private bool hasReachedTarget = false; // Hedefe ulaşılıp ulaşılmadığını kontrol eder

    void Start()
    {
        // Oyuncuyu başlangıç pozisyonuna yerleştir
        transform.position = startPosition;
    }

    void Update()
    {
        // Eğer hedefe ulaşılmadıysa hareket ettir
        if (!hasReachedTarget)
        {
            // Oyuncunun şu anki pozisyonundan hedef pozisyona doğru hareketini sağlar
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

            // Eğer oyuncu hedef pozisyona ulaştıysa
            if (Vector2.Distance(transform.position, targetPosition) < 0.1f)
            {
                hasReachedTarget = true; // Hedefe ulaştığını işaretle
            }
        }
    }
}