using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace jimmysmod.Items.VanillaChanges
{
    public class MetalWeapons : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            // Broadwords //
            // Copper Broadsword
            if (item.type == ItemID.CopperBroadsword)
            {
                item.CloneDefaults(ItemID.TinBroadsword);
            }

            // Iron Broadsword
            if (item.type == ItemID.IronBroadsword)
            {
                item.CloneDefaults(ItemID.LeadBroadsword);
            }

            // Silver Broadsword
            if (item.type == ItemID.SilverBroadsword)
            {
                item.CloneDefaults(ItemID.TungstenBroadsword);
            }

            // Gold Broadsword
            if (item.type == ItemID.GoldBroadsword)
            {
                item.CloneDefaults(ItemID.PlatinumBroadsword);
            }

            // Tin Broadsword
            if (item.type == ItemID.TinBroadsword)
            {
                item.damage = 12;
                item.scale = 1.2f;
            }

            // Lead Broadsword
            if (item.type == ItemID.LeadBroadsword)
            {
                item.damage = 14;
                item.scale = 1.2f;
            }

            // Tungsten Broadsword
            if (item.type == ItemID.TungstenBroadsword)
            {
                item.damage = 15;
                item.scale = 1.2f;
            }

            // Platinum Broadsword
            if (item.type == ItemID.PlatinumBroadsword)
            {
                item.damage = 18;
                item.scale = 1.2f;
                item.autoReuse = true;
            }

            // Shortswords //
            // Copper Shortsword
            if (item.type == ItemID.CopperShortsword)
            {
                item.CloneDefaults(ItemID.TinShortsword);
            }

            // Iron Shortsword
            if (item.type == ItemID.IronShortsword)
            {
                item.CloneDefaults(ItemID.LeadShortsword);
            }

            // Silver Shortsword
            if (item.type == ItemID.SilverShortsword)
            {
                item.CloneDefaults(ItemID.TungstenShortsword);
            }

            // Gold Shortsword
            if (item.type == ItemID.GoldShortsword)
            {
                item.CloneDefaults(ItemID.PlatinumShortsword);
            }

            // Tin Shortsword
            if (item.type == ItemID.TinShortsword)
            {
                item.damage = 10;
                item.scale = 1.3f;
                item.autoReuse = true;
            }

            // Lead Shortsword
            if (item.type == ItemID.LeadShortsword)
            {
                item.damage = 12;
                item.scale = 1.3f;
                item.autoReuse = true;
            }

            // Tungsten Shortsword
            if (item.type == ItemID.TungstenShortsword)
            {
                item.damage = 13;
                item.scale = 1.3f;
                item.autoReuse = true;
            }

            // Platinum Shortsword
            if (item.type == ItemID.PlatinumShortsword)
            {
                item.damage = 16;
                item.scale = 1.3f;
                item.autoReuse = true;
            }

            // Bows //
            // Copper Bow
            if (item.type == ItemID.CopperBow)
            {
                item.CloneDefaults(ItemID.TinBow);
            }

            // Iron Bow
            if (item.type == ItemID.IronBow)
            {
                item.CloneDefaults(ItemID.LeadBow);
            }

            // Silver Bow
            if (item.type == ItemID.SilverBow)
            {
                item.CloneDefaults(ItemID.TungstenBow);
            }

            // Gold Bow
            if (item.type == ItemID.GoldBow)
            {
                item.CloneDefaults(ItemID.PlatinumBow);
            }
        }
    }
}
