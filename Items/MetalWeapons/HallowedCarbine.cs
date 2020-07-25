using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items.MetalWeapons
{
    public class HallowedCarbine : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hallowed Carbine");
            Tooltip.SetDefault("Two round burst\nOnly the first shot consumes ammo");
        }

        public override void SetDefaults()
        {
            item.damage = 46;
            item.ranged = true;
            item.width = 62;
            item.height = 24;
            item.useAnimation = 8; // burst fire
            item.useTime = 4;
            item.reuseDelay = 14;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 1f;
            item.value = 200000;
            item.rare = 4;
            item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/AR2");
            //item.UseSound = SoundID.Item11;
            item.autoReuse = true;
            item.shoot = 10;
            item.shootSpeed = 15f;
            item.useAmmo = AmmoID.Bullet;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HallowedBar, 10);
            recipe.AddIngredient(ItemID.SoulofSight, 3);
            recipe.AddIngredient(ItemID.SoulofMight, 3);
            recipe.AddIngredient(ItemID.SoulofFright, 3);
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
            Main.PlaySound(mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/AR2"), player.Center);
            //Main.PlaySound(SoundID.Item11, player.Center);
            return true;
		}

        // Change hold position
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-5, 0);
        }
    }
}