using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items
{
	public class MarksmanRifle : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Marksman Rifle");
			Tooltip.SetDefault("Bridging the gap between assault and sniper rifle");
		}

		public override void SetDefaults()
		{
			item.damage = 150;
            item.crit = 14;
			item.ranged = true;
			item.width = 80;
			item.height = 20;
			item.useTime = 26;
			item.useAnimation = 26;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 4.5f;
			item.value = Item.sellPrice(gold: 25);
			item.rare = 8;
            item.UseSound = SoundID.Item40;
            item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 22f;
			item.useAmmo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("ThisMachine"));
			recipe.AddIngredient(ItemID.ShroomiteBar, 10);
			recipe.AddIngredient(ItemID.SpectreBar, 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
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
			return new Vector2(-12, 1);
		}
	}
}