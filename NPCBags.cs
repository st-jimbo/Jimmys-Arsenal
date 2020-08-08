using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace jimmysmod
{
    public class NPCBags : GlobalItem
    {
        public override void OpenVanillaBag(string context, Player player, int arg)
        {
            if (context == "bossbag" && arg == ItemID.PlanteraBossBag)
            {
                player.QuickSpawnItem(mod.ItemType("M1919Shorty"));
            }
        }
    }
}