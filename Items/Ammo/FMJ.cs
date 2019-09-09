using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items.Ammo
{
    public class FMJ : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("FMJ Rounds");
            Tooltip.SetDefault("Penetrates a single enemy\nBypasses invulnerability frames");
        }

        public override void SetDefaults()
        {
            item.damage = 9;
            item.ranged = true;
            item.width = 10;
            item.height = 22;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 1f;
            item.value = 15;
            item.rare = 1;
            item.shoot = mod.ProjectileType("FMJ");
            item.shootSpeed = 12f;
            item.ammo = AmmoID.Bullet;
        }
    }
}