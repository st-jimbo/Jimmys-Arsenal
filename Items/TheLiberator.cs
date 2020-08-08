using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items
{
	public class TheLiberator : ModItem
	{
		int laserCount = 0;

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Liberator");
			Tooltip.SetDefault("Every other shot fires a piercing vortex laser");
		}

		public override void SetDefaults()
		{
			item.damage = 152;
            item.crit = 14;
			item.ranged = true;
			item.width = 82;
			item.height = 26;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 4.5f;
			item.value = Item.sellPrice(gold: 10);
			item.rare = 9;
            item.UseSound = SoundID.Item40;
            item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 22f;
			item.useAmmo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("MarksmanRifle"));
			recipe.AddIngredient(ItemID.FragmentVortex, 14);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			// Secondary Projectile
			laserCount += 1;
			if (laserCount == 2)
			{
				Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("VortexLaser"), damage, knockBack, player.whoAmI);
				Main.PlaySound(SoundID.Item72, player.Center);
				laserCount = 0;
			}
			// Change bullet type
			if (type == ProjectileID.Bullet)
			{
				type = ProjectileID.BulletHighVelocity;
			}
			return true;
		}

		// Change hold position
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-12, 0);
		}

	}
}