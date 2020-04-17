using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items.VanillaChanges
{
    public class Armor : GlobalItem
    {


        public override void SetDefaults(Item item) // Stats
        {
            // Pearlwood Helmet
            if (item.type == ItemID.PearlwoodHelmet)
            {
			    item.defense = 5; // From 2
                item.rare = 4; // From 0
            }

            // Pearlwood Breastplate
            if (item.type == ItemID.PearlwoodBreastplate)
            {
			    item.defense = 6; // From 3
                item.rare = 4; // From 0
            }

            // Pearlwood Greaves
            if (item.type == ItemID.PearlwoodGreaves)
            {
			    item.defense = 5; // From 2
                item.rare = 4; // From 0
            }
        }


    }
}
