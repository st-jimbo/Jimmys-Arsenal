using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items
{
	public class M1919 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("M1919 Browning");
			Tooltip.SetDefault("50% chance to not consume ammo");
		}

		public override void SetDefaults()
		{
			item.damage = 62;
			item.ranged = true;
			item.width = 104;
			item.height = 26;
			item.useTime = 8;
			item.useAnimation = 8;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 2.5f;
			item.value = Item.sellPrice(gold: 10);
			item.rare = 8;
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/M1919");
            //item.UseSound = SoundID.Item11;
            item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 21f;
			item.useAmmo = AmmoID.Bullet;
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ShroomiteBar, 16);
            recipe.AddIngredient(mod.ItemType("M1919Shorty"));
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			// Inaccuracy
			Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(5));
			speedX = perturbedSpeed.X;
			speedY = perturbedSpeed.Y;

            return true;
		}
		
		// Change hold position
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-3, 3);
		}
		
		// Chance to not use ammo
		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .50f;
		}
	}
}