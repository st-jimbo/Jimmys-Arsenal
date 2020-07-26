using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items.MetalWeapons
{
    public class PalladiumRevolver : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Palladium Revolver");
        }

        public override void SetDefaults()
        {
            item.damage = 48;
            item.crit = 4;
            item.ranged = true;
            item.width = 50;
            item.height = 26;
            item.useTime = 23;
            item.useAnimation = 23;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.noMelee = true;
            item.knockBack = 4;
            item.value = 60000;
            item.rare = 4;
            item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/Deagle");
            //item.UseSound = SoundID.Item11;
            item.autoReuse = false;
            item.shoot = 10;
            item.shootSpeed = 10f;
            item.useAmmo = AmmoID.Bullet;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.PalladiumBar, 12);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        // Change hold position
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(0, 0);
        }
    }
}