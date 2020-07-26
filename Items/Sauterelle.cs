using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items
{
    public class Sauterelle : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sauterelle");
            Tooltip.SetDefault("Improvised grenade launcher\nUses grenades");
        }

        public override void SetDefaults()
        {
            item.damage = 5;
            item.ranged = true;
            item.width = 56;
            item.height = 24;
            item.useTime = 42;
            item.useAnimation = 42;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.noMelee = true;
            item.knockBack = 4;
            item.value = 1500;
            item.rare = 0;
            item.UseSound = SoundID.Item102;
            item.autoReuse = false;
            item.shoot = 10;
            item.shootSpeed = 5f;
            item.useAmmo = ItemID.Grenade;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Wood", 16);
            recipe.AddRecipeGroup("IronBar", 6);
            recipe.AddIngredient(ItemID.Cobweb, 25);
            recipe.AddTile(TileID.WorkBenches);
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