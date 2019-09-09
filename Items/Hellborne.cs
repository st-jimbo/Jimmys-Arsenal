using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items
{
    public class Hellborne : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hellborne");
            Tooltip.SetDefault("Firearm/melee hybrid, jab with <right>\nNow fully automatic!");
            Item.staff[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.damage = 27;
            item.ranged = true;
            item.width = 46;
            item.height = 46;
            item.scale = 1.3f;
            item.useTime = 25;
            item.useAnimation = 25;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 4;
            item.value = 30000;
            item.rare = 2;
            item.UseSound = SoundID.Item40;
            item.autoReuse = true;
            item.shoot = 10;
            item.shootSpeed = 10f;
            item.useAmmo = AmmoID.Bullet;
        }

        // Shoot on left click, jab on right click
        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {
                // spear mode
                item.useTime = 28;
                item.useAnimation = 28;
                item.knockBack = 6;
                item.shootSpeed = 2.6f;
                item.noUseGraphic = true;
                item.UseSound = SoundID.Item1;
                item.shoot = mod.ProjectileType("HellborneProjectile");
                item.useAmmo = 0;
            }
            else
            {
                // gun mode
                item.useTime = 25;
                item.useAnimation = 25;
                item.knockBack = 4;
                item.shootSpeed = 10f;
                item.noUseGraphic = false;
                item.UseSound = SoundID.Item40;
                item.shoot = 10;
                item.useAmmo = AmmoID.Bullet;
            }
            return base.CanUseItem(player);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HellstoneBar, 20);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override Vector2? HoldoutOrigin()
        {
            return new Vector2(0, 0);
        }
    }
}