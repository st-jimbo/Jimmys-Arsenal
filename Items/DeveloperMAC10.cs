using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items
{
	public class MAC10 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Monika's Deletion");
			Tooltip.SetDefault("And if this world won't write me an ending,\nWhat will it take just for me to have it all?\n95% chance to not consume ammo");
		}

		public override void SetDefaults()
		{
			item.damage = 50000;
			item.ranged = true;
			item.width = 44;
			item.height = 40;
            item.scale = 0.75f;
            item.useTime = 4;
			item.useAnimation = 4;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 0;
			item.value = 350000;
			item.rare = -12;
            item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/SMG");
            item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 16f;
			item.useAmmo = AmmoID.Bullet;
		}

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			// Inaccuracy
			Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(3));
			speedX = perturbedSpeed.X;
			speedY = perturbedSpeed.Y;
			
			return true;
		}
		
		// Change hold position
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-4, 2);
		}
		
		// Chance to not use ammo
		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .95f;
		}
	}
}