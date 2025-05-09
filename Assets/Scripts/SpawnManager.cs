using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpawnManager : MonoBehaviour
{
    public GoalScript objectToSpawn; // Object to spawn
    public Camera mainCamera;
    public int score;
    public TextMeshProUGUI textComponent;

    void Start()
    {
        mainCamera = Camera.main;
        // K�r SpawnObject() funktion for at spawne et game object indenfor kameraets gr�nser
        SpawnObject();
        score = 0;
    }

    public void SpawnObject()
    {

        // Finder position p� det nederste venstre hj�rne
        Vector3 bottomLeft = mainCamera.ViewportToWorldPoint(new Vector3(0, 0, mainCamera.nearClipPlane));

        // Finder positionen p� det �verste h�jre hj�rne
        Vector3 topRight = mainCamera.ViewportToWorldPoint(new Vector3(1, 1, mainCamera.nearClipPlane));

        // Generer tilf�ldige X og Y v�rdier baseret p� kamereats gr�nser
        float randomX = Random.Range(bottomLeft.x, topRight.x);
        float randomY = Random.Range(bottomLeft.y, topRight.y);

        // Skaber en tilf�ldig position indenfor kameraets gr�nser
        Vector3 spawnPosition = new Vector3(randomX, randomY, 0);

        // Spawner vores game object p� den tilf�ldige position
        Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);

        //Gemmer en reference til vores SpawnManager i det objekt, vi har spawnet
        //Dette er s� vores game object kan fort�lle vores SpawnManager, n�r den d�r, s� vores SpawnManager kan spawne et nyt game object
        objectToSpawn.spawner = this;
    }

    public void UpdateScore()
    {
        score++;
        textComponent.text = "Score: " + score;
    }
}