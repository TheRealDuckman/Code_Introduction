using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //movementSpeed er en variabel, der bestemmer bevægelseshastigheden.
    //Vi skriver "public" fordi vi gerne vil kunne tilgå den i Unity Inspector
    //Vi skriver "float" fordi det er et decimaltal
    //"movementSpeed" er det navn, vi har givet vores variabel. Vi kunne også kalde den "speed", "x" eller "StopMedAtKiggePaaJeresSkaermeNaarJegGennemgaarTingPaaTavlen"
   

    public float movementSpeed;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * movementSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //SLET DETTE OG SKRIV DEN RIGTIGE FUNKTION FOR BEVÆGELSE HER
        }

       
        //HVAD SKAL DU SKRIVE HER FOR AT BEVÆGE DIG TIL HØJRE, NÅR DU TRYKKER PÅ HØJRE PILETAST?

    }
}
