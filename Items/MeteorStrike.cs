using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items
{
    public class MeteorStrike : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Meteor Strike");
            Tooltip.SetDefault("Firearm/melee hybrid, jab with <right>");
            Item.staff[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.damage = 22;
            item.ranged = true;
            item.width = 46;
            item.height = 46;
            item.scale = 1.3f;
            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.noMelee = true;
            item.knockBack = 3;
            item.value = 20000;
            item.rare = 1;
            item.UseSound = SoundID.Item40;
            item.autoReuse = false;
            item.shoot = 10;
            item.shootSpeed = 8f;
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
                item.useTime = 34;
                item.useAnimation = 34;
                item.knockBack = 6;
                item.shootSpeed = 2.2f;
                item.noUseGraphic = true;
                item.UseSound = SoundID.Item1;
                item.shoot = mod.ProjectileType("MeteorStrikeProjectile");
                item.useAmmo = 0;
            }
            else
            {
                // gun mode
                item.useTime = 30;
                item.useAnimation = 30;
                item.knockBack = 3;
                item.shootSpeed = 8f;
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
            recipe.AddIngredient(ItemID.MeteoriteBar, 20);
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