using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PikasMod.Projectiles
{
    public class projectileBigEye : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 32;
            projectile.height = 32;
            projectile.friendly = true;
            projectile.magic = true;
            projectile.tileCollide = false;
            projectile.penetrate = 10000;
            projectile.ignoreWater = true;
            projectile.timeLeft = 300;
        }
    }
}