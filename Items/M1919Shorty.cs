using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items
{
	public class M1919Shorty : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("M1919 Beast Mode");
			Tooltip.SetDefault("50% chance to not consume ammo\nJust keep it on target");
		}

		public override void SetDefaults()
		{
			item.damage = 48;
			item.ranged = true;
			item.width = 58;
			item.height = 28;
			item.useTime = 7;
			item.useAnimation = 7;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 1.25f;
			item.value = 500000;
			item.rare = 7;
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/M1919");
            //item.UseSound = SoundID.Item11;
            item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 10f;
			item.useAmmo = AmmoID.Bullet;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			// Inaccuracy
			Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(15));
			speedX = perturbedSpeed.X;
			speedY = perturbedSpeed.Y;

            return true;
		}
		
		// Change hold position
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(0, 3);
		}
		
		// Chance to not use ammo
		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .50f;
		}
	}
}