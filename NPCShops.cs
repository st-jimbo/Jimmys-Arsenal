using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace jimmysmod
{
    public class NPCShops : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type == NPCID.ArmsDealer)  // always available
            {
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<Items.Ammo.FMJ>());
                nextSlot++;

                shop.item[nextSlot].SetDefaults(ModContent.ItemType<Items.LewisGun>());
                nextSlot++;

                shop.item[nextSlot].SetDefaults(ModContent.ItemType<Items.SMG>());
                nextSlot++;

                shop.item[nextSlot].SetDefaults(ModContent.ItemType<Items.Materials.AkimboBookT1>());
                nextSlot++;
            }
            if (type == NPCID.ArmsDealer && NPC.downedBoss3) // after skeletron
            {
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<Items.ATRifle>());
                nextSlot++;
            }
            if (type == NPCID.ArmsDealer && Main.hardMode) // hardmode
            {
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<Items.Ammo.DepletedUranium>());
                nextSlot++;
            }
            if (type == NPCID.ArmsDealer && NPC.downedPlantBoss) // after plantera
            {
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<Items.M1919Shorty>());
                nextSlot++;
            }
            if (type == NPCID.ArmsDealer && NPC.downedGolemBoss) // after golem
            {

                shop.item[nextSlot].SetDefaults(ModContent.ItemType<Items.SCAR>());
                nextSlot++;
            }
        }
    }
}