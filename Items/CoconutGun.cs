using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items
{
	public class CoconutGun : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nucifera Neutralizer");
			Tooltip.SetDefault("It's gonna hurt!");
		}

		public override void SetDefaults()
		{
			item.damage = 10;
			item.ranged = true;
			item.width = 44;
			item.height = 38;
            item.useTime = 10;
			item.useAnimation = 30;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 0f;
			item.value = Item.sellPrice(gold: 20);
			item.rare = ItemRarityID.Red;
            item.UseSound = SoundID.Item61;
            item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 5f;
			item.useAmmo = AmmoID.Rocket;
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("IronBar", 12);
			recipe.AddRecipeGroup("jimmysmod:Copper", 8);
			recipe.AddIngredient(ItemID.Torch, 4);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

		// Shotgun
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 3; // amount of shots
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
			return new Vector2(-10, 1);
		}
	}
}