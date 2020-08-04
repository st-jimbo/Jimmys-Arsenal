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
			Tooltip.SetDefault("Fires a five round burst and a homing rocket\nRight click to rapid fire vortex lasers with reduced damage");
		}

		public override void SetDefaults()
		{
			item.damage = 66;
			item.ranged = true;
			item.width = 76;
			item.height = 26;
            item.useAnimation = 15; // burst fire
            item.useTime = 3;
            item.reuseDelay = 16;
            item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 1.5f;
            item.value = Item.sellPrice(gold: 20);
            item.rare = 9;
            item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/AR");
            //item.UseSound = SoundID.Item11;
            item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 14f;
			item.useAmmo = AmmoID.Bullet;
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

        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            // alt stats
            if (player.altFunctionUse == 2)
            {
                item.damage = 33;
                item.useAnimation = 9; // burst fire
                item.useTime = 9;
                item.reuseDelay = 0;
                item.UseSound = SoundID.Item72;
                item.shoot = mod.ProjectileType("VortexLaser");
                item.useAmmo = 0;
            }
            // normal stats
            else
            {
                item.damage = 66;
                item.useAnimation = 15; // burst fire
                item.useTime = 3;
                item.reuseDelay = 16;
                item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/AR");
                item.shoot = 10;
                item.useAmmo = AmmoID.Bullet;
            }
            return base.CanUseItem(player);
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            // alt
            if (player.altFunctionUse == 2)
            {
                return true;
            }
            // normal
            else
            {
                // rocket
                if (player.itemAnimation > item.useAnimation - 2)
                {
                    Projectile.NewProjectile(position.X, position.Y, speedX / 2, speedY / 2, ProjectileID.VortexBeaterRocket, damage, knockBack, player.whoAmI);
                }
                Main.PlaySound(mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/AR"), player.Center);
                return true;
            }
        }

        // Only consume ammo once
        public override bool ConsumeAmmo(Player player)
        {
            return !(player.itemAnimation < item.useAnimation - 2);
        }

        // Change hold position
        public override Vector2? HoldoutOffset()
		{
			return new Vector2(-20, 0);
		}
	}
}