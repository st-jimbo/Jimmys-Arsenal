using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items.MetalWeapons
{
    public class HallowedHandcannon : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hallowed Handcannon");
        }

        public override void SetDefaults()
        {
            item.damage = 76;
            item.crit = 8;
            item.ranged = true;
            item.width = 46;
            item.height = 26;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 5;
            item.value = 150000;
            item.rare = 4;
            item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/Deagle");
            //item.UseSound = SoundID.Item11;
            item.autoReuse = false;
            item.shoot = 10;
            item.shootSpeed = 12f;
            item.useAmmo = AmmoID.Bullet;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HallowedBar, 12);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        // Change hold position
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(0, 1);
        }
    }
}