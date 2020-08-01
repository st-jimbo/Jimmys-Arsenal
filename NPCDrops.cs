using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace jimmysmod
{
    public class NPCDrops : GlobalNPC
    {
		public override void NPCLoot(NPC npc)
		{
			if (npc.type == NPCID.Plantera)
			{
				if (Main.rand.NextFloat() < .1429f)
					Item.NewItem(npc.getRect(), ModContent.ItemType<Items.M1919Shorty>(), 1);
			}
			if (npc.type == NPCID.SandElemental)
			{
				if (Main.rand.NextFloat() < .1f && NPC.downedPlantBoss)
					Item.NewItem(npc.getRect(), ModContent.ItemType<Items.SCAR>(), 1);
			}
		}
	}
}