using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items
{
	public class ShroomitePulseRifle : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shroomite Pulse Rifle");
			Tooltip.SetDefault("Fires a burst of high-velocity piercing rounds");
		}

		public override void SetDefaults()
		{
			item.damage = 48;
			item.ranged = true;
			item.width = 68;
			item.height = 22;
            item.useAnimation = 9; // burst fire
            item.useTime = 3;
            item.reuseDelay = 16;
            item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 1.5f;
            item.value = Item.sellPrice(gold: 10);
            item.rare = 8;
            item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/AR");
            //item.UseSound = SoundID.Item11;
            item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 28f;
			item.useAmmo = AmmoID.Bullet;
		}

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            // Change bullet type
            if (type != ProjectileID.MoonlordBullet)
            {
                type = ProjectileID.MoonlordBullet;
            }

            // Sound for each shot
            Main.PlaySound(mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/AR"), player.Center);
            //Main.PlaySound(SoundID.Item11, player.Center);

            return true;
        }

        // Only consume ammo once
        public override bool ConsumeAmmo(Player player)
        {
            return !(player.itemAnimation < item.useAnimation - 2);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ShroomiteBar, 20);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        // Change hold position
        public override Vector2? HoldoutOffset()
		{
			return new Vector2(-12, 0);
		}
	}
}