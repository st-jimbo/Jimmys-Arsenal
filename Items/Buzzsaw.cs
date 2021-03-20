using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items
{
	public class Buzzsaw : ModItem
	{
		int rocketCount = 0;

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Buzzsaw");
			Tooltip.SetDefault("Every 10 shots fires a vortex rocket\n50% chance to not consume ammo");
		}

		public override void SetDefaults()
		{
			item.damage = 46;
			item.ranged = true;
			item.width = 100;
			item.height = 24;
			item.useTime = 4;
			item.useAnimation = 4;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 1.5f;
			item.value = Item.sellPrice(gold: 10);
			item.rare = 9;
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/MG");
            item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 10f;
			item.useAmmo = AmmoID.Bullet;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("LewisGun"));
			recipe.AddIngredient(mod.ItemType("MAC10"));
			recipe.AddIngredient(ItemID.FragmentVortex, 14);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			// Secondary Projectile
			rocketCount += 1;
			if (rocketCount == 10)
			{
				Projectile.NewProjectile(position.X, position.Y, speedX / 2, speedY / 2, ProjectileID.VortexBeaterRocket, damage, knockBack, player.whoAmI);
				rocketCount = 0;
			}

			// Inaccuracy
			Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(2));
			speedX = perturbedSpeed.X;
			speedY = perturbedSpeed.Y;
			
			return true;
		}
		
		// Change hold position
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-17, 1);
		}
		
		// Chance to not use ammo
		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .5f;
		}
	}
}