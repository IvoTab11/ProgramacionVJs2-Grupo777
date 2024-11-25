using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*La clase PlayerClimb gestiona el movimiento del personaje principal al escalar.*/
public class PlayerClimb : Player
{
    /**/
    /* La variable velocidadEscalada dedefine la velocidad de escalar del personaje.*/
    [SerializeField] private float velocidadEscalada = 2f;
    /* La variable escalando indica si el personaje está actualmente escalando.*/
    private bool escalando;
    /* Esta variable hace de referencia al componente Rigidbody2D del personaje.*/
    private Rigidbody2D rb;
    /* Esta variable almacena la entrada del teclado del jugador para controlar la dirección de la escalada.*/
    private Vector2 input;
    /* Esta variable referencia al colisionador del personaje.*/
    private CapsuleCollider2D capsuleCollider2D;
    /* Esta variable almacena la escala de gravedad original del personaje.*/
    private float gravedadInicial;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        capsuleCollider2D=GetComponent<CapsuleCollider2D>();
        gravedadInicial=rb.gravityScale;
    }

    void Update()
    {
        input.y=Input.GetAxisRaw("Vertical");
        Escalar();
    }
    /* Este metodo gestiona la logica de escalada del personaje.*/
    private void Escalar(){
      //Se comprueba si el jugador se esta moviendo hacia arriba o hacia abajo y si esta en contacto con la capa "Escaleras".
        if((input.y !=0 || escalando ) && (capsuleCollider2D.IsTouchingLayers(LayerMask.GetMask("Escaleras")))){
            Vector2 velocidadSubida = new Vector2(rb.velocity.x,input.y * velocidadEscalada);
            rb.velocity=velocidadSubida;
            rb.gravityScale = 0; //Se desactiva la gravedad para permitir la escalada.
            escalando = true;
            //Se ignora las colisiones entre las capas "Plataformas" y "Personaje". Permite que el personaje atraviese las plataformas al escalar.
            Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Plataformas"), LayerMask.NameToLayer("Personaje"), true);

        }else{
          
            rb.gravityScale = gravedadInicial;//Se reestablece la gravedad.
            escalando =false;
            //Se reestablecen las colisiones.
            Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Plataformas"), LayerMask.NameToLayer("Personaje"), false);
        }
    }
    /* Metodo OnCollisionEnter2D para manejar colisiones con objetos específicos.*/
    public override void OnCollisionEnter2D(Collision2D collision)
{
        // Se intenta obtener el componente ICollectible del objeto colisionado
        ICollectible collectible = collision.gameObject.GetComponent<ICollectible>();
        if (collectible != null)
        {
            collectible.Collect(this); // Manejar la lógica de colección
        }

        // Se intenta tambien manejar otros objetos interactuables (usando ICollisionHandler)
        ICollisionHandler handler = collision.gameObject.GetComponent<ICollisionHandler>();
        if (handler != null)
        {
            handler.HandleCollision(this);
        }
    }

}
