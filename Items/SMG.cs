using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items
{
	public class SMG : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Submachine Gun");
			Tooltip.SetDefault("33% chance to not consume ammo\nWatch your ammo");
		}

		public override void SetDefaults()
		{
			item.damage = 4;
			item.ranged = true;
			item.width = 52;
			item.height = 28;
			item.useTime = 5;
			item.useAnimation = 5;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 0;
			item.value = 200000;
			item.rare = 1;
            item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/SMG");
            item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 7f;
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
			return new Vector2(-5, -7);
		}
		
		// Chance to not use ammo
		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .33f;
		}
	}
}