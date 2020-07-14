using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace jimmysmod.Items.VanillaChanges
{
    public class Chlorophyte : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            // Chlorophyte Claymore
            if (item.type == ItemID.ChlorophyteClaymore)
            {
                item.damage = 100; // From 75
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

            // Chlorophyte Shotbow
            if (item.type == ItemID.ChlorophyteShotbow)
            {
                item.damage = 43; // From 34
            }

            // Chlorophyte Greataxe
            if (item.type == ItemID.ChlorophyteGreataxe)
            {
                item.damage = 95; // From 70
            }

            // Chlorophyte Warhammer
            if (item.type == ItemID.ChlorophyteWarhammer)
            {
                item.damage = 110; // From 80
            }

            // Chlorophyte Pickaxe
            if (item.type == ItemID.ChlorophytePickaxe)
            {
                item.damage = 50; // From 40
                item.useTime = 6; // From 7
                item.useAnimation = 20; // From 25
            }

            // Chlorophyte Drill
            if (item.type == ItemID.ChlorophyteDrill)
            {
                item.damage = 45; // From 35
                item.useTime = 6; // From 7
                item.useAnimation = 20; // From 25
            }
        }
    }
}
