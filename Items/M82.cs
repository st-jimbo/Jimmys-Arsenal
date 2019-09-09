using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items
{
	public class M82 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tank Hunter");
			Tooltip.SetDefault("Fires a powerful piercing bullet");
		}

		public override void SetDefaults()
		{
			item.damage = 196;
            item.crit = 10;
			item.ranged = true;
			item.width = 94;
			item.height = 24;
			item.useTime = 50;
			item.useAnimation = 50;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 7f;
			item.value = 500000;
			item.rare = 4;
            item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/ATRifle");
            //item.UseSound = SoundID.Item40;
            item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 30f;
			item.useAmmo = AmmoID.Bullet;
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.TitaniumBar, 12);
            recipe.AddIngredient(mod.ItemType("ATRifle"));
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.AdamantiteBar, 12);
            recipe.AddIngredient(mod.ItemType("ATRifle"));
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
            // Change bullet type
            if (type != mod.ProjectileType("ATBullet"))
			{
                type = mod.ProjectileType("ATBullet"); ;
			}
			return true;
		}

        // Change hold position
        public override Vector2? HoldoutOffset()
		{
			return new Vector2(-15, -2);
		}
	}
}