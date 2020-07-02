using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items.Akimbo
{
	public class AkimboBoomstick : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Akimbo Boomsticks");
			Tooltip.SetDefault("Fires two blasts in quick succession");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.Boomstick);
			item.width = 54;
			item.height = 16;
			item.useAnimation = 40; // burst fire
			item.useTime = 20;
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Boomstick, 2);
            recipe.AddIngredient(mod.ItemType("AkimboBookT1"));
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

		// Sound
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 3 + Main.rand.Next(2);
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(20));
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			Main.PlaySound(SoundID.Item36, player.Center);
			return false;
		}

		// Change hold position
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-2, 1);
		}
	}
}