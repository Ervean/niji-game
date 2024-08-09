using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ervean.Utilities.Player.Dash
{
    public class DoubleDash : MonoBehaviour, IDash
    {
        [Header("Required")]
        [SerializeField] private Rigidbody2D rb;

        [Header("Settings")]
        [SerializeField] private float dashingPower = 50f;
        [SerializeField] private float dashingTime = 0.1f;
        [SerializeField] private float dashingCooldown = 1f;
        [SerializeField] private float secondDashCooldown = 1f;


        private bool canDash;
        private bool isSecondDash = false;
        private bool isDashing;
        private bool doSecondDash = false;
        public bool CanDash { get => canDash; set => canDash = value; }
        public bool IsDashing { get => isDashing; set => isDashing = value; }

        public event EventHandler<StartDashEventArgs> StartedDash;
        public event EventHandler<EndDashEventArgs> EndedDash;

        public void Initialize(DashInitializationArgs i)
        {
            this.rb = i.Rb;
        }

        private void Awake()
        {
            canDash = true;
            isSecondDash = false;
        }

        public IEnumerator StartDash()
        {
            if(isSecondDash)
            {
                doSecondDash = true;
                canDash = false;
                yield break;
            }
            canDash = false;
            isDashing = true;
            StartedDash?.Invoke(this, new StartDashEventArgs());
            float og = rb.gravityScale;
            rb.gravityScale = 0;
            rb.velocity = this.transform.right * dashingPower;
            yield return new WaitForSeconds(dashingTime);
            rb.gravityScale = og;
            isDashing = false;
            isSecondDash = true;
            canDash = true;
            float timer = 0;
            while(true)
            {
                yield return new WaitForSeconds(0.05f);
                timer += 0.05f;
                if(doSecondDash)
                {
                    break;
                }
                if(timer > secondDashCooldown)
                {
                    break;
                }
            }
            if(doSecondDash)
            {
                canDash = false;
                isDashing = true;
                rb.gravityScale = 0;
                rb.velocity = this.transform.right * dashingPower;
                yield return new WaitForSeconds(dashingTime);
                rb.gravityScale = og;
                isDashing = false;
                isSecondDash = false;
                doSecondDash = false;
            }
            isSecondDash = false;
            EndedDash?.Invoke(this, new EndDashEventArgs());
            yield return new WaitForSeconds(dashingCooldown);
            canDash = true;
        }
    }
}