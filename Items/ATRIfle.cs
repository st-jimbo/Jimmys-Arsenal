using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items
{
	public class ATRifle : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Anti-Tank Rifle");
			Tooltip.SetDefault("Fires a powerful piercing bullet");
		}

		public override void SetDefaults()
		{
			item.damage = 105;
            item.crit = 8;
			item.ranged = true;
			item.width = 90;
			item.height = 18;
			item.useTime = 57;
			item.useAnimation = 57;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 7f;
			item.value = 500000;
			item.rare = 3;
            item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/ATRifle");
            //item.UseSound = SoundID.Item40;
            item.autoReuse = false;
			item.shoot = 10;
			item.shootSpeed = 30f;
			item.useAmmo = AmmoID.Bullet;
		}

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            // Change bullet type
            if (type != mod.ProjectileType("ATBullet"))
            {
                type = mod.ProjectileType("ATBullet"); ;
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