using System;
using _app.Scripts.Manager;
using UnityEngine;
using UnityEngine.InputSystem;

namespace _app.Scripts.Player
{
    public class CharacterController : MonoBehaviour
    {
        [Header("Movement Components")]
        public float movementSpeed;
        public Vector2 movementVector;
        public Vector3 jumpForce;
        public bool crouching;

        [Header("Player Components")]
        public Rigidbody rb;
        public Camera playerCamera;
        public PlayerInput pInput;
        private void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (GameManager.instance != null)
                {
                    GameManager.instance.playerScore++;

                }
                else
                {
                    Debug.Log("GameManager is missing");
                }
                PlayerJump();
            }
            movementVector.x = Input.GetAxis("Horizontal");
            movementVector.y = Input.GetAxis("Vertical");
            PlayerMovement(movementVector);
            
        }

        private void PlayerJump()
        {
            rb.AddForce(jumpForce, ForceMode.Impulse);
        }

        private void PlayerMovement(Vector2 movement)
        {
            transform.Translate(new Vector3(movement.x, 0, movement.y) * (movementSpeed * Time.deltaTime));
        }
    }
}