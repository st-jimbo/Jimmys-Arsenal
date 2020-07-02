using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items.Akimbo
{
	public class AkimboTacticalShotgun : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Akimbo Tactical Shotguns");
			Tooltip.SetDefault("Fires two blasts in quick succession");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.TacticalShotgun);
			item.width = 63;
			item.height = 26;
			item.useAnimation = 34; // burst fire
			item.useTime = 17;
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.TacticalShotgun, 2);
            recipe.AddIngredient(mod.ItemType("AkimboBookT2"));
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

		// Sound
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 6;
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(20));
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			Main.PlaySound(SoundID.Item38, player.Center);
			return false;
		}

		// Change hold position
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-4, 2);
		}
	}
}