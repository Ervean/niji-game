using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Ervean.Utilities.Player.Dash
{
    public interface IDash 
    {
        bool CanDash { get; set; }
        bool IsDashing {  get; set; }
        IEnumerator StartDash();

        event EventHandler<StartDashEventArgs> StartedDash;
        event EventHandler<EndDashEventArgs> EndedDash;

    }

    public class StartDashEventArgs
    {
        
    }
    public class EndDashEventArgs
    {

    }
}