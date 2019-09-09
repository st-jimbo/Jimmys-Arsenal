using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items.Ammo
{
    public class StoneBullet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Stone Bullet");
            Tooltip.SetDefault("This ammunition is too crude to be used with most firearms");
        }

        public override void SetDefaults()
        {
            item.damage = 3;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 1.5f;
            item.value = 1;
            item.rare = 0;
            item.shoot = 14;
            item.shootSpeed = 8f;
            item.ammo = item.type;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 10);
            recipe.AddRecipe();
        }
    }
}