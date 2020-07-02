using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items.Materials
{
	public class AkimboBookT2 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Akimbo Handbook - Vol. 2");
			Tooltip.SetDefault("Expands upon Vol. 1 with the introduction of some Gun Fu.");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 32;
			item.maxStack = 999;
			item.value = Item.buyPrice(gold: 75);
			item.rare = 1;
		}
	}
}