using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace jimmysmod.Items.VanillaChanges
{
    public class Weapons : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            // Brand of the Inferno
            if (item.type == ItemID.DD2SquireDemonSword)
            {
                item.damage = 85; // From 44
            }

            // Flying Dragon
            if (item.type == ItemID.DD2SquireBetsySword)
            {
                item.damage = 115; // From 90
            }

            // Starfury
            if (item.type == ItemID.Starfury)
            {
                item.damage = 28; // From 22
                item.autoReuse = true; // From false
            }

            // Flintlock
            if (item.type == ItemID.FlintlockPistol)
            {
                item.damage = 13; // From 10
                item.knockBack  = 1.5f; // From 0
            }

            // Phantom Phoenix
            if (item.type == ItemID.DD2PhoenixBow)
            {
                item.damage = 32; // From 24
                item.useTime = 18; // From 18
            }
        }
    }
}
