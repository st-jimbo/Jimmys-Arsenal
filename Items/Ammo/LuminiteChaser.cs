using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items.Ammo
{
    public class LuminiteChaser : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Luminite Chaser");
            Tooltip.SetDefault("Luminite rounds augmented with homing fins\nDoes not pierce enemies");
        }

        public override void SetDefaults()
        {
            item.damage = 20;
            item.ranged = true;
            item.width = 16;
            item.height = 22;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 3f;
            item.value = Item.sellPrice(copper: 5);
            item.rare = ItemRarityID.Cyan;
            item.shoot = mod.ProjectileType("LuminiteChaser");
            item.shootSpeed = 8f;
            item.ammo = AmmoID.Bullet;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MoonlordBullet, 100);
            recipe.AddIngredient(ItemID.ShroomiteBar, 1);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this, 100);
            recipe.AddRecipe();
        }
    }
}