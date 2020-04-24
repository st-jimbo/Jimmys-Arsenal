using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items
{
	public class Enfield : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Enfield");
			Tooltip.SetDefault("Fires a powerful high velocity round");
		}

		public override void SetDefaults()
		{
			item.damage = 46;
            item.crit = 8;
			item.ranged = true;
			item.width = 72;
			item.height = 18;
			item.useTime = 34;
			item.useAnimation = 34;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 5.5f;
			item.value = 350000;
			item.rare = 3;
            item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/BoltAction2");
            //item.UseSound = SoundID.Item41;
            item.autoReuse = false;
			item.shoot = 10;
			item.shootSpeed = 22f;
			item.useAmmo = AmmoID.Bullet;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			// Change bullet type
			if (type == ProjectileID.Bullet)
			{
				type = ProjectileID.BulletHighVelocity;
			}
			return true;
		}

		// Change hold position
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-9, 0);
		}
	}
}