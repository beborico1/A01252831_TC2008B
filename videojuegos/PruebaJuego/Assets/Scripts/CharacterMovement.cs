using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {
    public float velocidadMovimiento = 5.0f; // Velocidad de movimiento del personaje
    public Animator animator; // Referencia al Animator del personaje
    
    // Variables privadas
    private Vector2 movimiento; // Vector de movimiento del personaje

    public int skinNr; // Numero de la skin actualmente seleccionada
    public Skins[] skins; // Arreglo de Skins disponibles

    SpriteRenderer spriteRenderer; // Referencia al SpriteRenderer del personaje
    
    void Start() { // Start es llamado antes del primer frame de la ejecucion
        spriteRenderer = GetComponent<SpriteRenderer>();  // Obtener el SpriteRenderer del personaje
    }

    void Update() { // Actualiza el movimiento del personaje en cada frame
        skinNr = skinNr % skins.Length; // Restricción para que el número de skin no exceda el número total de skins disponibles

        // Obtener las entradas del usuario para mover el personaje
        float movimientoHorizontal = Input.GetAxisRaw("Horizontal");
        float movimientoVertical = Input.GetAxisRaw("Vertical");
        
        // Normalizar el vector de movimiento para asegurarse de que el personaje se mueva a la misma velocidad en todas las direcciones
        movimiento = new Vector2(movimientoHorizontal, movimientoVertical).normalized;
        
        animator.SetBool("Walking", false);  // Establecer la animacion de caminar en falso por defecto
        
        // Establecer la dirección del personaje en función del vector de movimiento
        if (movimiento.x > 0) { // Mirando hacia la derecha
            movimiento.y = 0; // Direccion exclusiva, para no permitir movimiento diagonal
            animator.SetBool("Right", true); // Activar la animacion de caminar hacia la derecha
            animator.SetBool("Left", false); // Desactivar la animacion de caminar hacia la izquierda
            animator.SetBool("Up", false); // Desactivar la animacion de caminar hacia arriba
            animator.SetBool("Down", false); // Desactivar la animacion de caminar hacia abajo
            animator.SetBool("Walking", true); // Activar la animacion de caminar en general
        } else if (movimiento.x < 0) { // Mirando hacia la izquierda
            movimiento.y = 0; // Direccion exclusiva, para no permitir movimiento diagonal
            animator.SetBool("Right", false); // Desactivar la animacion de caminar hacia la derecha
            animator.SetBool("Left", true); // Activar la animacion de caminar hacia la izquierda
            animator.SetBool("Up", false); // Desactivar la animacion de caminar hacia arriba
            animator.SetBool("Down", false); // Desactivar la animacion de caminar hacia abajo
            animator.SetBool("Walking", true); // Activar la animacion de caminar en general
        }
        if (movimiento.y > 0) { // Mirando hacia arriba
            movimiento.x = 0; // Direccion exclusiva, para no permitir movimiento diagonal
            animator.SetBool("Right", false); // Desactivar la animacion de caminar hacia la derecha
            animator.SetBool("Left", false); // Desactivar la animacion de caminar hacia la izquierda
            animator.SetBool("Up", true); // Activar la animacion de caminar hacia arriba
            animator.SetBool("Down", false); // Desactivar la animacion de caminar hacia abajo
            animator.SetBool("Walking", true); // Activar la animación de caminar
        } else if (movimiento.y < 0) { // Mirando hacia abajo
            movimiento.x = 0; // Direccion exclusiva, para no permitir movimiento diagonal
            animator.SetBool("Right", false);
            animator.SetBool("Left", false);
            animator.SetBool("Up", false);
            animator.SetBool("Down", true); // Activar la animación de movimiento hacia abajo
            animator.SetBool("Walking", true); // Activar la animación de caminar
        }

        // Actualizar la posición del personaje utilizando el vector de movimiento, la velocidad de movimiento y el tiempo transcurrido desde el último frame
        transform.position += new Vector3(movimiento.x, movimiento.y, 0) * velocidadMovimiento * Time.deltaTime;
    }

    void LateUpdate() {
        SkinChoice(); // Cambiar la skin del personaje en el frame actual
    }

    void SkinChoice() {
        if (spriteRenderer.sprite.name.Contains("Bebo")) { // Si la skin actual es una de las skins de Bebo
            string spriteName = spriteRenderer.sprite.name; // Obtener el nombre de la skin actual
            spriteName = spriteName.Replace("Bebo_",""); // Eliminar la parte del nombre que indica que es una skin de Bebo
            int spriteNr = int.Parse(spriteName); // Obtener el número de la skin actual
        
            spriteRenderer.sprite = skins[skinNr].sprites[spriteNr];  // Cambia el sprite actual del personaje por el correspondiente a la skin seleccionada y al número de sprite actual
        }
    }
}

// Estructura que almacena los sprites de cada skin
[System.Serializable]
public struct Skins{
    public Sprite[] sprites; // Arreglo de sprites correspondiente a cada skin
}