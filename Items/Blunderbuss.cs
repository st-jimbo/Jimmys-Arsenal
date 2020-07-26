using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items
{
    public class Blunderbuss : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Blunderbuss");
            Tooltip.SetDefault("Fires a large spread of pellets");
        }

        public override void SetDefaults()
        {
            item.damage = 11;
            item.ranged = true;
            item.width = 58;
            item.height = 18;
            item.useTime = 48;
            item.useAnimation = 48;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.noMelee = true;
            item.knockBack = 6;
            item.value = 100000;
            item.rare = 2;
            item.UseSound = SoundID.Item38;
            item.autoReuse = false;
            item.shoot = 10;
            item.shootSpeed = 6f;
            item.useAmmo = AmmoID.Bullet;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Musket, 1);
            recipe.AddIngredient(ItemID.SilverBar, 8);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Musket, 1);
            recipe.AddIngredient(ItemID.TungstenBar, 8);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.TheUndertaker, 1);
            recipe.AddIngredient(ItemID.SilverBar, 8);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.TheUndertaker, 1);
            recipe.AddIngredient(ItemID.TungstenBar, 8);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        // Shotgun
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 5 + Main.rand.Next(2); // amount of shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30));
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }

        // Change hold position
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-10, 0);
        }
    }
}