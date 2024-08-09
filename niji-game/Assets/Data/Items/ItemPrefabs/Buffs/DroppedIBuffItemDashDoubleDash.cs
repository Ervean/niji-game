using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ervean.Utilities.Items;
using Ervean.Utilities.Player;
namespace Ervean.NijiGame.Items.Buffs
{
    public class DroppedIBuffItemDashDoubleDash : DroppedBuffItem
    {
        public override void Consume(IItemConsumer consumer)
        {

            Destroy(this.gameObject);
        }
    }
}