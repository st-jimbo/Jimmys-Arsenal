using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items
{
	public class Bulldog : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bulldog");
			Tooltip.SetDefault("Fires a five round burst and a homing rocket");
		}

		public override void SetDefaults()
		{
			item.damage = 65;
			item.ranged = true;
			item.width = 76;
			item.height = 26;
            item.useAnimation = 20; // burst fire
            item.useTime = 4;
            item.reuseDelay = 16;
            item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 1.5f;
            item.value = Item.sellPrice(gold: 20);
            item.rare = 9;
            item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/AR2");
            //item.UseSound = SoundID.Item11;
            item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 14f;
			item.useAmmo = AmmoID.Bullet;
		}

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            // Secondary Projectile
            if (player.itemAnimation > item.useAnimation - 2)
            {
                Projectile.NewProjectile(position.X, position.Y, speedX/2, speedY/2, ProjectileID.VortexBeaterRocket, damage, knockBack, player.whoAmI);
            }

            // Sound for each shot
            Main.PlaySound(mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/AR2"), player.Center);
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
            recipe.AddIngredient(mod.ItemType("ShroomitePulseRifle"));
            recipe.AddIngredient(ItemID.FragmentVortex, 14);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        // Change hold position
        public override Vector2? HoldoutOffset()
		{
			return new Vector2(-20, 0);
		}
	}
}