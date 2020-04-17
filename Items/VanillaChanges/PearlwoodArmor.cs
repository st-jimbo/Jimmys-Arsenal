using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace jimmysmod.Items.VanillaChanges
{
    public class PearlwoodArmor : GlobalItem
    {


        public override void SetDefaults(Item item) // Stats
        {
            // Pearlwood Helmet
            if (item.type == ItemID.PearlwoodHelmet)
            {
			    item.defense = 8; // From 2
                item.rare = 4; // From 0
            }

            // Pearlwood Breastplate
            if (item.type == ItemID.PearlwoodBreastplate)
            {
			    item.defense = 8; // From 3
                item.rare = 4; // From 0
            }

            // Pearlwood Greaves
            if (item.type == ItemID.PearlwoodGreaves)
            {
			    item.defense = 7; // From 2
                item.rare = 4; // From 0
            }
        }

		public override void UpdateEquip(Item item, Player player) // Buffs
        {
            // Pearlwood Helmet
            if (item.type == ItemID.PearlwoodHelmet)
            {
			    player.allDamage += 0.05f;
            }

            // Pearlwood Breastplate
            if (item.type == ItemID.PearlwoodBreastplate)
            {
			    player.allDamage += 0.05f;
            }

            // Pearlwood Greaves
            if (item.type == ItemID.PearlwoodGreaves)
            {
			    player.moveSpeed += 0.15f;
            }
		}

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (item.type == ItemID.PearlwoodHelmet)
            {
                TooltipLine line = new TooltipLine(mod, "tooltip", "5% increased damage");
                tooltips.Insert(3, line);
            }

            if (item.type == ItemID.PearlwoodBreastplate)
            {
                TooltipLine line = new TooltipLine(mod, "tooltip", "5% increased damage");
                tooltips.Insert(3, line);
            }

            if (item.type == ItemID.PearlwoodGreaves)
            {
                TooltipLine line = new TooltipLine(mod, "tooltip", "15% increased movement speed");
                tooltips.Insert(3, line);
            }
        }

		public override string IsArmorSet(Item head, Item body, Item legs) // Set bonus
        {
			if (head.type == ItemID.PearlwoodHelmet && body.type == ItemID.PearlwoodBreastplate && legs.type == ItemID.PearlwoodGreaves)
            {
                return "Pearlwood Armor";
            }
            return "";
		}
		public override void UpdateArmorSet(Player player, string set)
        {
            if (set == "Pearlwood Armor")
            {
			    player.setBonus = "+40 max mana and max life";
                player.statLifeMax2 += 40;
                player.statManaMax2 += 40;
                player.statDefense -= 1;
            }
		}

    }
}
