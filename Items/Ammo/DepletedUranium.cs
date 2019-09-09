using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items.Ammo
{
    public class DepletedUranium : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Depleted Uranium Rounds");
            Tooltip.SetDefault("Penetrates up to two enemies\nBypasses invulnerability frames");
        }

        public override void SetDefaults()
        {
            item.damage = 12;
            item.ranged = true;
            item.width = 10;
            item.height = 22;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 3f;
            item.value = 15;
            item.rare = 1;
            item.shoot = mod.ProjectileType("DepletedUranium");
            item.shootSpeed = 12f;
            item.ammo = AmmoID.Bullet;
        }
    }
}