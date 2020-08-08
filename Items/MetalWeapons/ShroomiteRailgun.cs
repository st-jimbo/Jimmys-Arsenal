using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items.MetalWeapons
{
	public class ShroomiteRailgun : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shroomite Railgun");
			Tooltip.SetDefault("Fires a high-velocity piercing slug");
		}

		public override void SetDefaults()
		{
			item.damage = 235;
            item.crit = 25;
			item.ranged = true;
			item.width = 72;
			item.height = 22;
			item.useTime = 34;
			item.useAnimation = 34;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 8;
			item.value = Item.sellPrice(gold: 10);
			item.rare = 8;
            item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/Railgun");
            item.autoReuse = false;
			item.shoot = 10;
			item.shootSpeed = 30f;
			item.useAmmo = AmmoID.Bullet;
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ShroomiteBar, 20);
            recipe.AddTile(TileID.MythrilAnvil);
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