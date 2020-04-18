using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace jimmysmod.Items.VanillaChanges
{
    public class Weapons : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            // Brand of the Inferno
            if (item.type == ItemID.DD2SquireDemonSword)
            {
                item.damage = 64; // From 44
            }

            // Cobalt Sword
            if (item.type == ItemID.CobaltSword)
            {
                item.damage = 55; // From 39
                item.knockBack = 4.75f; // From 3.85
            }

            // Palladium Sword
            if (item.type == ItemID.PalladiumSword)
            {
                item.damage = 55; // From 41
                item.useTime = 23; // From 25
                item.useAnimation = 23; // From 25
            }

            // Mythril Sword
            if (item.type == ItemID.MythrilSword)
            {
                item.damage = 63; // From 44
            }

            // Orichalcum Sword
            if (item.type == ItemID.OrichalcumSword)
            {
                item.damage = 63; // From 47
            }

            // Adamantite Sword
            if (item.type == ItemID.AdamantiteSword)
            {
                item.damage = 70; // From 50
                item.useTime = 26; // From 27
                item.useAnimation = 26; // From 27
            }

            // Titanium Sword
            if (item.type == ItemID.TitaniumSword)
            {
                item.damage = 70; // From 52
            }

            // Spears //
            // Dark Lance
            if (item.type == ItemID.DarkLance)
            {
                item.damage = 41; // From 29
            }

            // Cobalt Spear
            if (item.type == ItemID.CobaltNaginata)
            {
                item.damage = 45; // From 29
                item.knockBack = 4.5f; // From 4
                item.useTime = 27; // From 28
                item.useAnimation = 27; // From 28
            }

            // Palladium Spear
            if (item.type == ItemID.PalladiumPike)
            {
                item.damage = 45; // From 44
            }

            // Mythril Spear
            if (item.type == ItemID.MythrilHalberd)
            {
                item.damage = 50; // From 35
                item.knockBack = 5.5f; // From 5
                item.useTime = 25; // From 26
                item.useAnimation = 25; // From 26
            }

            // Orichalcum Spear
            if (item.type == ItemID.OrichalcumHalberd)
            {
                item.damage = 50; // From 36
            }

            // Adamantite Spear
            if (item.type == ItemID.AdamantiteGlaive)
            {
                item.damage = 56; // From 38
                item.knockBack = 6.2f; // From 6
                item.useTime = 23; // From 25
                item.useAnimation = 23; // From 25
            }

            // Titanium Spear
            if (item.type == ItemID.TitaniumTrident)
            {
                item.damage = 56; // From 40
            }

            // Axes //
            // Cobalt Axe
            if (item.type == ItemID.CobaltWaraxe)
            {
                item.damage = 72; // From 33
                item.knockBack = 5.5f; // From 5
            }

            // Palladium Axe
            if (item.type == ItemID.PalladiumWaraxe)
            {
                item.damage = 72; // From 36
            }

            // Mythril Axe
            if (item.type == ItemID.MythrilWaraxe)
            {
                item.damage = 82; // From 39
                item.knockBack = 6.5f; // From 6
            }

            // Orichalcum Axe
            if (item.type == ItemID.OrichalcumWaraxe)
            {
                item.damage = 82; // From 41
            }

            // Adamantite Axe
            if (item.type == ItemID.AdamantiteWaraxe)
            {
                item.damage = 88; // From 43
                item.knockBack = 7.5f; // From 7
            }

            // Titanium Axe
            if (item.type == ItemID.TitaniumWaraxe)
            {
                item.damage = 88; // From 44
            }

            // Repeaters //
            // Cobalt Repeater
            if (item.type == ItemID.CobaltRepeater)
            {
                item.damage = 43; // From 32
                item.knockBack = 1.75f; // From 1.5
            }

            // Palladium Repeater
            if (item.type == ItemID.PalladiumRepeater)
            {
                item.damage = 43; // From 34
            }

            // Mythril Repeater
            if (item.type == ItemID.MythrilRepeater)
            {
                item.damage = 48; // From 36
            }

            // Orichalcum Repeater
            if (item.type == ItemID.OrichalcumRepeater)
            {
                item.damage = 48; // From 38
            }

            // Adamantite Repeater
            if (item.type == ItemID.AdamantiteRepeater)
            {
                item.damage = 51; // From 40
            }

            // Titanium Repeater
            if (item.type == ItemID.TitaniumRepeater)
            {
                item.damage = 51; // From 41
            }

            // Hallowed Repeater
            if (item.type == ItemID.HallowedRepeater)
            {
                item.damage = 54; // From 43
            }
        }
    }
}
