using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
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
			item.damage = 145;
			item.ranged = true;
			item.width = 44;
			item.height = 38;
			item.scale = 0.9f;
			item.useTime = 16;
			item.useAnimation = 16;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 3f;
			item.value = Item.sellPrice(gold: 20);
			item.rare = ItemRarityID.Red;
            item.UseSound = SoundID.Item61;
            item.autoReuse = true;
			item.shoot = ProjectileType<Projectiles.Coconut>();
			item.shootSpeed = 15f;
			item.useAmmo = AmmoID.Rocket;
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 12);
			recipe.AddIngredient(ItemID.Stynger, 1);
			recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			// Change bullet type
			if (type != mod.ProjectileType("Coconut"))
			{
				type = mod.ProjectileType("Coconut"); ;
			}
			return true;
		}

		// Change hold position
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-1, 0);
		}
	}
}