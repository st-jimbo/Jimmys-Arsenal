using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items
{
	public class SCAR : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("SCAR");
			Tooltip.SetDefault("33% chance to not consume ammo");
		}

		public override void SetDefaults()
		{
			item.damage = 76;
            item.crit = 2;
			item.ranged = true;
			item.width = 68;
			item.height = 24;
			item.useTime = 11;
			item.useAnimation = 11;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 2f;
			item.value = 1000000;
			item.rare = 8;
            item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/AR");
            //item.UseSound = SoundID.Item11;
            item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 24f;
			item.useAmmo = AmmoID.Bullet;
		}
		
		// Change hold position
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-12, 2);
		}
		
		// Chance to not use ammo
		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .33f;
		}
	}
}