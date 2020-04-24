using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items
{
	public class ThisMachine : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("This Machine");
			Tooltip.SetDefault("Ping");
		}

		public override void SetDefaults()
		{
			item.damage = 74;
            item.crit = 8;
			item.ranged = true;
			item.width = 74;
			item.height = 18;
			item.useTime = 22;
			item.useAnimation = 22;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 5f;
			item.value = Item.sellPrice(gold: 25);
			item.rare = 4;
            item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/Rifle");
            //item.UseSound = SoundID.Item41;
            item.autoReuse = false;
			item.shoot = 10;
			item.shootSpeed = 22f;
			item.useAmmo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("jimmysmod:Adamantite", 12);
			recipe.AddIngredient(mod.ItemType("Enfield"));
			recipe.AddTile(TileID.Anvils);
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
			return new Vector2(-9, 0);
		}
	}
}