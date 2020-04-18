using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items.VanillaChanges
{
    public class Chlorophyte : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            // Chlorophyte Claymore
            if (item.type == ItemID.ChlorophyteClaymore)
            {
                item.damage = 105; // From 75
                item.autoReuse = true; // From false
            }

            // Chlorophyte Saber
            if (item.type == ItemID.ChlorophyteSaber)
            {
                item.damage = 60; // From 48
            }

            // Chlorophyte Partisan
            if (item.type == ItemID.ChlorophytePartisan)
            {
                item.damage = 58; // From 49
            }

            // Brand of the Inferno
            if (item.type == ItemID.DD2SquireDemonSword)
            {
                item.damage = 64; // From 44
            }
        }
    }
}
