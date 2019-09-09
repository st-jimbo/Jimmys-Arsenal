using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items
{
	public class LewisGun : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lewis Gun");
			Tooltip.SetDefault("40% chance to not consume ammo\nAlso known as the Belgian Rattlesnake");
		}

		public override void SetDefaults()
		{
			item.damage = 15;
			item.ranged = true;
			item.width = 82;
			item.height = 18;
			item.useTime = 9;
			item.useAnimation = 9;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 1.5f;
			item.value = 400000;
			item.rare = 2;
            item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/MG");
            item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 8f;
			item.useAmmo = AmmoID.Bullet;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			// Inaccuracy
			Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(5));
			speedX = perturbedSpeed.X;
			speedY = perturbedSpeed.Y;
			
			return true;
		}
		
		// Change hold position
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-10, 0);
		}
		
		// Chance to not use ammo
		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .40f;
		}
	}
}