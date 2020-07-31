using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items.MetalWeapons
{
	public class OrichalcumBR : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Orichalcum Battle Rifle");
		}

		public override void SetDefaults()
		{
			item.damage = 60;
            item.crit = 6;
			item.ranged = true;
			item.width = 80;
			item.height = 24;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 2.25f;
			item.value = 90000;
			item.rare = 4;
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
            recipe.AddIngredient(ItemID.OrichalcumBar, 12);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        // Change hold position
        public override Vector2? HoldoutOffset()
		{
            return new Vector2(-10, 0);
        }
	}
}