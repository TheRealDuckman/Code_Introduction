using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //movementSpeed er en variabel, der bestemmer bevægelseshastigheden.
    //Vi skriver "public" fordi vi gerne vil kunne tilgå den i Unity Inspector
    //Vi skriver "float" fordi det er et decimaltal
    //"movementSpeed" er det navn, vi har givet vores variabel. Vi kunne også kalde den "speed", "x" eller "Fortnite4Ever"
   

    public float movementSpeed;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xMovement = Input.GetAxisRaw("Horizontal");
        float yMovement = Input.GetAxisRaw("Vertical");

        transform.Translate(new Vector3(xMovement, yMovement, 0).normalized * movementSpeed * Time.deltaTime);
    }
}
