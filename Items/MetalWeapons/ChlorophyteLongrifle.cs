using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items.MetalWeapons
{
	public class ChlorophyteLongrifle : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chlorophyte Longrifle");
			Tooltip.SetDefault("Also fires a powerful crystal leaf");
		}

		public override void SetDefaults()
		{
			item.damage = 120;
            item.crit = 11;
			item.ranged = true;
			item.width = 72;
			item.height = 18;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 6.5f;
			item.value = Item.sellPrice(gold: 5);
			item.rare = 7;
            item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/BoltAction2");
            //item.UseSound = SoundID.Item41;
            item.autoReuse = false;
			item.shoot = 10;
			item.shootSpeed = 16f;
			item.useAmmo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 12);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			// Secondary Projectile
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.CrystalLeafShot, damage, knockBack, player.whoAmI);

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
			return new Vector2(-6, 0);
		}
	}
}