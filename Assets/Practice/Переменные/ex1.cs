using UnityEngine;
/// <summary>
/// пример переменных и доступности
/// </summary>
public class Player : MonoBehaviour
{
    public int health = 100; // Доступна в Inspector
    private float speed = 5.0f; // В Inspector не видна
    [SerializeField] private string playerName = "Hero"; // Видна в Inspector, но приватная

    void Start()
    {
        Debug.Log($"Player: {playerName}, Health: {health}, Speed: {speed}");
    }
}
public class GameManager
{
    public static int score = 0;   //GameManager.score += 10; Доступ к score


}
