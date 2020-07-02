using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items.Akimbo
{
	public class AkimboUzi : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Akimbo Uzis");
			Tooltip.SetDefault("Fires two shots in quick succession");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.Uzi);
			item.scale = 0.65f;
			item.width = 66;
			item.height = 36;
			item.useAnimation = 9; // burst fire
			item.useTime = 4;
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Uzi, 2);
            recipe.AddIngredient(mod.ItemType("AkimboBookT2"));
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

		// Sound
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			if (type == ProjectileID.Bullet)
			{
				type = ProjectileID.BulletHighVelocity;
			}

			// Inaccuracy
			Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(10));
			speedX = perturbedSpeed.X;
			speedY = perturbedSpeed.Y;

			Main.PlaySound(SoundID.Item11, player.Center);
			return true;
		}

		// Change hold position
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-14, 2);
		}
	}
}