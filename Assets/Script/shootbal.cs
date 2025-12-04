using UnityEngine;
using UnityEngine.InputSystem;

public class ShootBal : MonoBehaviour

{
    // Hoe hard de bal wordt weggeduwd
    public float ShootForce = 500f;

    // Richting van de kracht (0,1 = omhoog)
    public Vector3 Direction = new Vector3(0f, 1f, 0f);

    private Rigidbody2D rb;

    void Start()
    {
        // Haalt automatisch de Rigidbody2D op van dit object
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Wanneer je op A of Spatie drukt
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.Space))
        {
            // Geeft een kracht in de opgegeven richting * sterkte
            rb.AddForce(Direction * ShootForce);
        }
    }
}
