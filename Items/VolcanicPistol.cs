using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items
{
    public class VolcanicPistol : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Volcanic Pistol");
            Tooltip.SetDefault("Uses stone bullets");
        }

        public override void SetDefaults()
        {
            item.damage = 12;
            item.ranged = true;
            item.width = 42;
            item.height = 24;
            item.useTime = 26;
            item.useAnimation = 26;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.noMelee = true;
            item.knockBack = 1.5f;
            item.value = 2500;
            item.rare = 0;
            item.UseSound = SoundID.Item41;
            item.autoReuse = false;
            item.shoot = 10;
            item.shootSpeed = 3f;
            item.useAmmo = mod.ItemType("StoneBullet");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("IronBar", 8);
            recipe.AddIngredient(ItemID.CopperBar, 4);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("IronBar", 8);
            recipe.AddIngredient(ItemID.TinBar, 4);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            // Inaccuracy
            Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(7));
            speedX = perturbedSpeed.X;
            speedY = perturbedSpeed.Y;

            return true;
        }

        // Change hold position
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(0, 0);
        }
    }
}