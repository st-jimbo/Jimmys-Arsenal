using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items
{
	public class M2Browning : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("M2 Browning");
			Tooltip.SetDefault("50% chance to not consume ammo\nThe lead storm roars.");
		}

		public override void SetDefaults()
		{
			item.damage = 145;
            item.crit = 6;
			item.ranged = true;
			item.width = 146;
			item.height = 32;
			item.useTime = 9;
			item.useAnimation = 9;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 3.5f;
			item.value = Item.sellPrice(gold: 20);
			item.rare = 10;
            item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/M2Browning");
            //item.UseSound = SoundID.Item11;
            item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 24f;
			item.useAmmo = AmmoID.Bullet;
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LunarBar, 12);
            recipe.AddIngredient(mod.ItemType("M1919"));
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			// Inaccuracy
			Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(3));
			speedX = perturbedSpeed.X;
			speedY = perturbedSpeed.Y;

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
			return new Vector2(-5, 6);
		}
		
		// Chance to not use ammo
		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .50f;
		}
	}
}