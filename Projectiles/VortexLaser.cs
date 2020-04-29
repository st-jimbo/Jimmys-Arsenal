using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace jimmysmod.Projectiles
{
	class VortexLaser : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.width = 4;
			projectile.height = 4;
			projectile.friendly = true;
			projectile.ranged = true;
			projectile.extraUpdates = 100;
			projectile.timeLeft = 125;
			projectile.penetrate = 3;
			projectile.usesLocalNPCImmunity = true;
		}

		public override string Texture => "Terraria/Projectile_" + ProjectileID.ShadowBeamFriendly;

		public override void ModifyHitNPC(NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
		{
			projectile.damage = (int)(projectile.damage * 0.75);
		}

		public override void AI()
		{
			projectile.localAI[0] += 1f;
			if (projectile.localAI[0] > 9f)
			{
				for (int i = 0; i < 16; i++)
				{
					Vector2 projectilePosition = projectile.position;
					projectilePosition -= projectile.velocity * ((float)i * 0.45f);
					projectile.alpha = 255;
					int dust = Dust.NewDust(projectilePosition, 1, 1, 229, 0f, 0f, 0, default(Color), 1f);
					Main.dust[dust].noGravity = true;
					Main.dust[dust].position = projectilePosition;
					Main.dust[dust].scale = (float)Main.rand.Next(70, 110) * 0.012f;
					Main.dust[dust].velocity *= 0.2f;
				}
			}
		}
	}
}