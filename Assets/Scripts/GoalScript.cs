using UnityEngine;

public class GoalScript : MonoBehaviour
{
    public SpawnManager spawner;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        spawner.UpdateScore();
        spawner.SpawnObject();
        Destroy(gameObject);
    }
}