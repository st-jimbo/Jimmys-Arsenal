using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace RecipeGroups
{
	class RecipeGroups : Mod
	{
		public RecipeGroups()
		{
		}
		public override void AddRecipeGroups()
		{
			RecipeGroup group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Adamantite Bar", new int[]
			{
				ItemID.AdamantiteBar,
				ItemID.TitaniumBar
			});
			RecipeGroup.RegisterGroup("jimmysmod:Adamantite", group);
		}
	}
}
