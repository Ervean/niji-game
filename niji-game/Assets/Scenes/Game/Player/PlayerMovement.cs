using Ervean.Utilities.Player.Dash;
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

        private IDash dash;

        public void SetSpeed(float speed, float timeToLast)
        {

        }

        private void Awake()
        {
            dash = GetComponent<IDash>();
            defaultSpeedX = moveSpeedX;
            defaultSpeedY = moveSpeedY;
        }

        private void Update()
        {
            ProcessInputs();
        }

        void FixedUpdate()
        {
            if(dash.IsDashing)
            {
                return;
            }
            Move();

            if(Input.GetKey(KeyCode.Space) && dash.CanDash)
            {
                StartCoroutine(dash.StartDash());
            }

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
            Vector2 moveDirection2 = rb.velocity;
            if (moveDirection2 != Vector2.zero)
            {
                float angle = Mathf.Atan2(moveDirection2.y, moveDirection2.x) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            }
        }
    }
}