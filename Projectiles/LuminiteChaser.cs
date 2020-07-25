﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using System;
using Terraria.ID;
using Terraria.ModLoader;

namespace jimmysmod.Projectiles
{
	class LuminiteChaser : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Luminite Chaser");     //The English name of the projectile
			ProjectileID.Sets.TrailCacheLength[projectile.type] = 1;    //The length of old position to be recorded
			ProjectileID.Sets.TrailingMode[projectile.type] = 0;        //The recording mode
		}

		public override void SetDefaults()
		{
			projectile.width = 4;
			projectile.height = 4;
			projectile.friendly = true;
			projectile.ranged = true;
			projectile.extraUpdates = 2;
			projectile.timeLeft = 600;
			projectile.penetrate = 1;
			projectile.light = 0.5f;
			projectile.alpha = 255;
			projectile.scale = 1.2f;
			projectile.ignoreWater = true;
			projectile.tileCollide = true;
			projectile.aiStyle = 1;
			aiType = ProjectileID.Bullet;
		}
		public override string Texture => "Terraria/Projectile_" + ProjectileID.ChlorophyteBullet;

		public override void AI()
		{
			if (projectile.alpha < 170)
			{
				for (int num130 = 0; num130 < 10; num130++)
				{
					float x2 = projectile.position.X - projectile.velocity.X / 10f * (float)num130;
					float y2 = projectile.position.Y - projectile.velocity.Y / 10f * (float)num130;
					int num131 = Dust.NewDust(new Vector2(x2, y2), 1, 1, 229, 0f, 0f, 0, default(Color), 0.5f);
					Main.dust[num131].alpha = projectile.alpha;
					Main.dust[num131].position.X = x2;
					Main.dust[num131].position.Y = y2;
					Dust obj67 = Main.dust[num131];
					obj67.velocity *= 0f;
					Main.dust[num131].noGravity = true;
				}
			}
			float num132 = (float)Math.Sqrt((double)(projectile.velocity.X * projectile.velocity.X + projectile.velocity.Y * projectile.velocity.Y));
			float num133 = projectile.localAI[0];
			if (num133 == 0f)
			{
				projectile.localAI[0] = num132;
				num133 = num132;
			}
			if (projectile.alpha > 0)
			{
				projectile.alpha -= 25;
			}
			if (projectile.alpha < 0)
			{
				projectile.alpha = 0;
			}
			float num134 = projectile.position.X;
			float num135 = projectile.position.Y;
			float num136 = 300f;
			bool flag3 = false;
			int num137 = 0;
			if (projectile.ai[1] == 0f)
			{
				for (int num138 = 0; num138 < 200; num138++)
				{
					if (Main.npc[num138].CanBeChasedBy(projectile, false) && (projectile.ai[1] == 0f || projectile.ai[1] == (float)(num138 + 1)))
					{
						float num139 = Main.npc[num138].position.X + (float)(Main.npc[num138].width / 2);
						float num140 = Main.npc[num138].position.Y + (float)(Main.npc[num138].height / 2);
						float num141 = Math.Abs(projectile.position.X + (float)(projectile.width / 2) - num139) + Math.Abs(projectile.position.Y + (float)(projectile.height / 2) - num140);
						if (num141 < num136 && Collision.CanHit(new Vector2(projectile.position.X + (float)(projectile.width / 2), projectile.position.Y + (float)(projectile.height / 2)), 1, 1, Main.npc[num138].position, Main.npc[num138].width, Main.npc[num138].height))
						{
							num136 = num141;
							num134 = num139;
							num135 = num140;
							flag3 = true;
							num137 = num138;
						}
					}
				}
				if (flag3)
				{
					projectile.ai[1] = (float)(num137 + 1);
				}
				flag3 = false;
			}
			if (projectile.ai[1] > 0f)
			{
				int num142 = (int)(projectile.ai[1] - 1f);
				if (Main.npc[num142].active && Main.npc[num142].CanBeChasedBy(projectile, true) && !Main.npc[num142].dontTakeDamage)
				{
					float num143 = Main.npc[num142].position.X + (float)(Main.npc[num142].width / 2);
					float num144 = Main.npc[num142].position.Y + (float)(Main.npc[num142].height / 2);
					if (Math.Abs(projectile.position.X + (float)(projectile.width / 2) - num143) + Math.Abs(projectile.position.Y + (float)(projectile.height / 2) - num144) < 1000f)
					{
						flag3 = true;
						num134 = Main.npc[num142].position.X + (float)(Main.npc[num142].width / 2);
						num135 = Main.npc[num142].position.Y + (float)(Main.npc[num142].height / 2);
					}
				}
				else
				{
					projectile.ai[1] = 0f;
				}
			}
			if (!projectile.friendly)
			{
				flag3 = false;
			}
			if (flag3)
			{
				float num145 = num133;
				Vector2 vector10 = new Vector2(projectile.position.X + (float)projectile.width * 0.5f, projectile.position.Y + (float)projectile.height * 0.5f);
				float num146 = num134 - vector10.X;
				float num147 = num135 - vector10.Y;
				float num148 = (float)Math.Sqrt((double)(num146 * num146 + num147 * num147));
				num148 = num145 / num148;
				num146 *= num148;
				num147 *= num148;
				int num149 = 8;
				projectile.velocity.X = (projectile.velocity.X * (float)(num149 - 1) + num146) / (float)num149;
				projectile.velocity.Y = (projectile.velocity.Y * (float)(num149 - 1) + num147) / (float)num149;
			}
		}
		public override bool PreDraw(SpriteBatch spriteBatch, Color lightColor)
		{
			// Redraw the projectile with the color not influenced by light
			Vector2 drawOrigin = new Vector2(Main.projectileTexture[projectile.type].Width * 0.5f, projectile.height * 0.5f);
			for (int k = 0; k < projectile.oldPos.Length; k++)
			{
				Vector2 drawPos = projectile.oldPos[k] - Main.screenPosition + drawOrigin + new Vector2(0f, projectile.gfxOffY);
				Color color = projectile.GetAlpha(lightColor) * ((float)(projectile.oldPos.Length - k) / (float)projectile.oldPos.Length);
				spriteBatch.Draw(Main.projectileTexture[projectile.type], drawPos, null, color, projectile.rotation, drawOrigin, projectile.scale, SpriteEffects.None, 0f);
			}
			return true;
		}

		public override void Kill(int timeLeft)
		{
			// projectile code and the similar code above in OnTileCollide spawn dust from the tiles collided with. SoundID.Item10 is the bounce sound you hear.
			Collision.HitTiles(projectile.position + projectile.velocity, projectile.velocity, projectile.width, projectile.height);
			Main.PlaySound(SoundID.Item10, projectile.position);
		}
	}
}