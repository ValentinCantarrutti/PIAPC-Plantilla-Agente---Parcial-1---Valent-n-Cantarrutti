using UnityEngine;

public class Jugador : MonoBehaviour
{
    public float velocidad = 5f;
    public float fuerzaSalto = 4f;

    private Rigidbody2D rb;
    private bool estaEnSuelo;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float movimiento = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(movimiento * velocidad, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && estaEnSuelo)
        {
            rb.velocity = new Vector2(rb.velocity.x, fuerzaSalto);
            estaEnSuelo = false;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.contacts[0].normal.y > 0.5f)
        {
            estaEnSuelo = true;
        }
    }
}