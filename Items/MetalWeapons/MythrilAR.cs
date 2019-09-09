using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items.MetalWeapons
{
    public class MythrilAR : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mythril Assault Rifle");
            Tooltip.SetDefault("Three round burst\nOnly the first shot consumes ammo");
        }

        public override void SetDefaults()
        {
            item.damage = 30;
            item.ranged = true;
            item.width = 68;
            item.height = 22;
            item.useAnimation = 18; // burst fire
            item.useTime = 6;
            item.reuseDelay = 21;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 1f;
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
            recipe.AddIngredient(ItemID.MythrilBar, 10);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        // Only consume ammo once
		public override bool ConsumeAmmo(Player player)
		{
			return !(player.itemAnimation < item.useAnimation - 2);
		}

        // Sound for each shot
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
            Main.PlaySound(mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/AR"), player.Center);
            //Main.PlaySound(SoundID.Item11, player.Center);
            return true;
		}

        // Change hold position
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-9, 3);
        }
    }
}