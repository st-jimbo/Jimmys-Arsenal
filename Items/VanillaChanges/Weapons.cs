using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items.VanillaChanges
{
    public class Weapons : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            // Brand of the Inferno
            if (item.type == ItemID.DD2SquireDemonSword)
            {
                item.damage = 64; // From 44
            }
        }
    }
}
