using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items
{
	public class HellfireTypewriter : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hellfire Typewriter");
			Tooltip.SetDefault("Right click to launch napalm\n33% chance to not consume ammo");
		}

		public override void SetDefaults()
		{
			item.damage = 14;
			item.ranged = true;
			item.width = 60;
			item.height = 20;
            item.useTime = 9;
			item.useAnimation = 9;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 1.5f;
			item.value = 300000;
			item.rare = 3;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 10f;
			item.useAmmo = AmmoID.Bullet;
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HellstoneBar, 14);
            recipe.AddIngredient(ItemID.IllegalGunParts, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

		// Napalm
        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

		public override bool CanUseItem(Player player)
        {
			// napalm mode
            if (player.altFunctionUse == 2)
            {
            	item.useTime = 9;
				item.useAnimation = 30;
				item.shoot = 400;
				item.shootSpeed = 10f;
				item.useAmmo = 0;
				item.UseSound = SoundID.Item34;
			}
			// normal mode
            else
            {
            	item.useTime = 9;
				item.useAnimation = 9;
                item.shoot = 10;
				item.shootSpeed = 10f;
                item.useAmmo = AmmoID.Bullet;
				item.UseSound = SoundID.Item11;
            }
            return base.CanUseItem(player);
		}

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			// Inaccuracy
			Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(2));
			speedX = perturbedSpeed.X;
			speedY = perturbedSpeed.Y;
			
			return true;
		}
		
		// Change hold position
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-8, 1);
		}
		
		// Chance to not use ammo
		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .33f;
		}
	}
}