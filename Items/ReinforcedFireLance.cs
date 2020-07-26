using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items
{
    public class ReinforcedFireLance : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Reinforced Fire Lance");
            Tooltip.SetDefault("Firearm/melee hybrid, jab with <right>\nUses stone bullets");
            Item.staff[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.damage = 15;
            item.ranged = true;
            item.width = 44;
            item.height = 44;
            item.scale = 1.3f;
            item.useTime = 40;
            item.useAnimation = 40;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.noMelee = true;
            item.knockBack = 2;
            item.value = 2000;
            item.rare = 0;
            item.UseSound = SoundID.Item40;
            item.autoReuse = false;
            item.shoot = 10;
            item.shootSpeed = 3f;
            item.useAmmo = mod.ItemType("StoneBullet");
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
                item.useTime = 38;
                item.useAnimation = 38;
                item.knockBack = 6;
                item.shootSpeed = 1.6f;
                item.noUseGraphic = true;
                item.UseSound = SoundID.Item1;
                item.shoot = mod.ProjectileType("ReinforcedFireLanceProjectile");
                item.useAmmo = 0;
            }
            else
            {
                // gun mode
                item.useTime = 40;
                item.useAnimation = 40;
                item.knockBack = 2;
                item.shootSpeed = 3f;
                item.noUseGraphic = false;
                item.UseSound = SoundID.Item40;
                item.shoot = 10;
                item.useAmmo = mod.ItemType("StoneBullet");
            }
            return base.CanUseItem(player);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("IronBar", 8);
            recipe.AddIngredient(mod.ItemType("FireLance"));
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