using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items.Ammo
{
    public class Grenade : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.Grenade) // Make grenades an ammo type and increase their stack size
            {
                item.maxStack = 999;
                item.ammo = ItemID.Grenade;
                item.shoot = 30;
            }
        }
    }
}
