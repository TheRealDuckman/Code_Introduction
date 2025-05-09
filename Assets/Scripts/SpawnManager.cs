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
        // Kør SpawnObject() funktion for at spawne et game object indenfor kameraets grænser
        SpawnObject();
        score = 0;
    }

    public void SpawnObject()
    {

        // Finder position på det nederste venstre hjørne
        Vector3 bottomLeft = mainCamera.ViewportToWorldPoint(new Vector3(0, 0, mainCamera.nearClipPlane));

        // Finder positionen på det øverste højre hjørne
        Vector3 topRight = mainCamera.ViewportToWorldPoint(new Vector3(1, 1, mainCamera.nearClipPlane));

        // Generer tilfældige X og Y værdier baseret på kamereats grænser
        float randomX = Random.Range(bottomLeft.x, topRight.x);
        float randomY = Random.Range(bottomLeft.y, topRight.y);

        // Skaber en tilfældig position indenfor kameraets grænser
        Vector3 spawnPosition = new Vector3(randomX, randomY, 0);

        // Spawner vores game object på den tilfældige position
        Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);

        //Gemmer en reference til vores SpawnManager i det objekt, vi har spawnet
        //Dette er så vores game object kan fortælle vores SpawnManager, når den dør, så vores SpawnManager kan spawne et nyt game object
        objectToSpawn.spawner = this;
    }

    public void UpdateScore()
    {
        score++;
        textComponent.text = "Score: " + score;
    }
}