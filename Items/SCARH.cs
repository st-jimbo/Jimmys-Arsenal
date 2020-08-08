using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items
{
	public class SCARH : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("SCAR-H");
			Tooltip.SetDefault("33% chance to not consume ammo\nThe desert storm rages on");
		}

		public override void SetDefaults()
		{
			item.damage = 184;
            item.crit = 2;
			item.ranged = true;
			item.width = 80;
			item.height = 24;
			item.useTime = 13;
			item.useAnimation = 13;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 3.5f;
			item.value = Item.sellPrice(gold: 20);
			item.rare = 10;
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/AR");
			//item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 27f;
			item.useAmmo = AmmoID.Bullet;
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LunarBar, 12);
            recipe.AddIngredient(mod.ItemType("SCAR"));
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        // Change hold position
        public override Vector2? HoldoutOffset()
		{
            return new Vector2(-12, 1);
        }
		
		// Chance to not use ammo
		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .33f;
		}
	}
}