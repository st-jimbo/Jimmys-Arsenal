using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items
{
	public class Helltaker : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Helltaker");
			Tooltip.SetDefault("And henceforth you were known as the Helltaker\nUses gel for ammo");
		}

		public override void SetDefaults()
		{
			item.damage = 25;
			item.ranged = true;
			item.width = 62;
			item.height = 20;
            item.useTime = 12;
			item.useAnimation = 24;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 4f;
			item.value = Item.sellPrice(silver: 54);
			item.rare = ItemRarityID.Orange;
            item.UseSound = SoundID.Item34;
            item.autoReuse = true;
			item.shoot = ProjectileID.Flames;
			item.shootSpeed = 8f;
			item.useAmmo = AmmoID.Gel;
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HellstoneBar, 12);
            recipe.AddIngredient(ItemID.IllegalGunParts, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
		
		// Change hold position
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-2, 0);
		}
	}
}