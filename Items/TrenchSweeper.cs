using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items
{
    public class TrenchSweeper : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Trench Sweeper");
            Tooltip.SetDefault("Hold the trigger and watch everything in the room turn into ketchup");
        }

        public override void SetDefaults()
        {
            item.damage = 24;
            item.ranged = true;
            item.width = 74;
            item.height = 18;
            item.useTime = 26;
            item.useAnimation = 26;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.noMelee = true;
            item.knockBack = 6f;
            item.value = Item.sellPrice(gold: 7);
            item.rare = 4;
            item.UseSound = SoundID.Item36;
            item.autoReuse = true;
            item.shoot = 10;
            item.shootSpeed = 7f;
            item.useAmmo = AmmoID.Bullet;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("jimmysmod:Adamantite", 12);
            recipe.AddIngredient(mod.ItemType("TrenchGun"));
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        // Shotgun
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 4; // amount of shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(9));
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }

        // Change hold position
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-10, 0);
        }
    }
}