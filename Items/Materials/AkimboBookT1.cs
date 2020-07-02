using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items.Materials
{
	public class AkimboBookT1 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Akimbo Handbook - Vol. 1");
			Tooltip.SetDefault("Everything you need to know about wielding two firearms at the same time.");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 32;
			item.maxStack = 999;
			item.value = Item.buyPrice(gold: 15);
			item.rare = 1;
		}
	}
}