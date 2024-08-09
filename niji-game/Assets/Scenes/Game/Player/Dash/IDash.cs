using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Ervean.Utilities.Player.Dash
{
    public interface IDash 
    {
        void Initialize(DashInitializationArgs i);
        bool CanDash { get; set; }
        bool IsDashing {  get; set; }
        IEnumerator StartDash();

        event EventHandler<StartDashEventArgs> StartedDash;
        event EventHandler<EndDashEventArgs> EndedDash;

    }
    public class DashInitializationArgs
    {
        public Rigidbody2D Rb;
    }


    public class StartDashEventArgs
    {
        
    }
    public class EndDashEventArgs
    {

    }
}