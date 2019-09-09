using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items
{
	public class ImperialHammer : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Imperial Hammer");
			Tooltip.SetDefault("Knock em down...");
		}

		public override void SetDefaults()
		{
			item.damage = 480;
            item.crit = 25;
			item.ranged = true;
			item.width = 72;
			item.height = 22;
			item.useTime = 32;
			item.useAnimation = 32;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 9;
			item.value = 1000000;
			item.rare = 10;
            item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/Railgun");
            item.autoReuse = false;
			item.shoot = 10;
			item.shootSpeed = 38f;
			item.useAmmo = AmmoID.Bullet;
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LunarBar, 12);
            recipe.AddIngredient(mod.ItemType("ShroomiteRailgun"));
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            // Change bullet type
            if (type != ProjectileID.MoonlordBullet)
            {
                type = ProjectileID.MoonlordBullet;
            }
            return true;
        }

        // Change hold position
        public override Vector2? HoldoutOffset()
		{
			return new Vector2(-8, 0);
		}
	}
}