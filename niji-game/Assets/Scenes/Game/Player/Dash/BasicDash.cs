using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ervean.Utilities.Player.Dash
{
    public class BasicDash : MonoBehaviour, IDash
    {
        [Header("Required")]
        [SerializeField] private Rigidbody2D rb;

        [Header("Settings")]
        [SerializeField] private float dashingPower = 50f;
        [SerializeField] private float dashingTime = 0.1f;
        [SerializeField] private float dashingCooldown = 1f;


        private bool canDash;
        private bool isDashing;
        public bool CanDash { get => canDash; set => canDash = value; }
        public bool IsDashing { get => isDashing; set => isDashing = value; }

        public event EventHandler<StartDashEventArgs> StartedDash;
        public event EventHandler<EndDashEventArgs> EndedDash;

        private void Awake()
        {
            canDash = true;
        }

        public IEnumerator StartDash()
        {
            canDash = false;
            isDashing = true;
            StartedDash?.Invoke(this, new StartDashEventArgs());
            float og = rb.gravityScale;
            rb.gravityScale = 0;
            rb.velocity = this.transform.right * dashingPower;
            yield return new WaitForSeconds(dashingTime);
            rb.gravityScale = og;            
            isDashing = false;
            EndedDash?.Invoke(this, new EndDashEventArgs());
            yield return new WaitForSeconds(dashingCooldown);
            canDash = true;
        }

        public void Initialize(DashInitializationArgs i)
        {
            this.rb = i.Rb;
        }
    }
}