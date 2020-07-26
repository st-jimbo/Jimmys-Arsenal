using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items
{
	public class CaulkNBurn : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Caulk n' Burn");
			Tooltip.SetDefault("Homemade flamethrower, for when you really need to spew fire\nUses gel for ammo");
		}

		public override void SetDefaults()
		{
			item.damage = 11;
			item.ranged = true;
			item.width = 62;
			item.height = 20;
            item.useTime = 8;
			item.useAnimation = 24;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 0f;
			item.value = Item.sellPrice(silver: 54);
			item.rare = ItemRarityID.Blue;
            item.UseSound = SoundID.Item34;
            item.autoReuse = true;
			item.shoot = ProjectileID.Flames;
			item.shootSpeed = 6.5f;
			item.useAmmo = AmmoID.Gel;
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
			int numberProjectiles = 4; // amount of shots
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(20));
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