using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items.Akimbo
{
	public class AkimboUndertaker : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Akimbo Undertakers");
			Tooltip.SetDefault("Fires two shots in quick succession");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.TheUndertaker);
			item.width = 62;
			item.height = 24;
			item.useAnimation = 23; // burst fire
			item.useTime = 11;
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.TheUndertaker, 2);
            recipe.AddIngredient(mod.ItemType("AkimboBookT1"));
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

		// Sound
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			// Inaccuracy
			Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(7));
			speedX = perturbedSpeed.X;
			speedY = perturbedSpeed.Y;
			
			Main.PlaySound(SoundID.Item11, player.Center);
			return true;
		}

		// Change hold position
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-2, 2);
		}
	}
}