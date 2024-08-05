using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ervean.NijiGame.Player
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private float moveSpeedX;
        [SerializeField] private float moveSpeedY;
        [SerializeField] private Rigidbody2D rb;

        private float defaultSpeedX;
        private float defaultSpeedY;

        private Vector2 moveDirection;
        public void SetSpeed(float speed, float timeToLast)
        {

        }

        private void Awake()
        {
            defaultSpeedX = moveSpeedX;
            defaultSpeedY = moveSpeedY;
        }

        private void Update()
        {
            ProcessInputs();
        }

        void FixedUpdate()
        {
            Move();
        }

        private void ProcessInputs()
        {
            float moveX = Input.GetAxisRaw("Horizontal");
            float moveY = Input.GetAxisRaw("Vertical");

            moveDirection = new Vector2(moveX, moveY).normalized;
        }

        private void Move()
        {
            rb.velocity = new Vector2(moveDirection.x * moveSpeedX, moveDirection.y * moveSpeedY);
        }
    }
}