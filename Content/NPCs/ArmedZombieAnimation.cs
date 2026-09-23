using Terraria;

namespace JourneysReborn.Content.NPCs
{
    public static class ArmedZombieAnimation
    {
        private const int WalkFrames = 3;
        private const int AttackFrames = 4;

        public static void FindFrame(NPC npc, int frameHeight)
        {
            npc.spriteDirection = npc.direction;

            bool attacking = false;
            if (npc.HasValidTarget)
            {
                Player player = Main.player[npc.target];
                attacking = npc.velocity.Y == 0f
                    && System.Math.Abs(npc.velocity.X) < 1.2f
                    && System.Math.Abs(player.Center.X - npc.Center.X) < 56f
                    && System.Math.Abs(player.Center.Y - npc.Center.Y) < 48f;
            }

            if (npc.velocity.Y != 0f)
            {
                npc.frameCounter = 0;
                npc.frame.Y = 0;
                return;
            }

            if (attacking)
            {
                int index = npc.frame.Y / frameHeight;
                if (index < WalkFrames || index >= WalkFrames + AttackFrames)
                    index = WalkFrames;

                if (++npc.frameCounter > 6)
                {
                    npc.frameCounter = 0;
                    index++;
                    if (index >= WalkFrames + AttackFrames)
                        index = WalkFrames;
                }

                npc.frame.Y = index * frameHeight;
                return;
            }

            if (System.Math.Abs(npc.velocity.X) < 0.05f)
            {
                npc.frameCounter = 0;
                npc.frame.Y = 0;
                return;
            }

            int walk = npc.frame.Y / frameHeight;
            if (walk < 0 || walk >= WalkFrames)
                walk = 0;

            npc.frameCounter += System.Math.Abs(npc.velocity.X);
            if (npc.frameCounter > 8)
            {
                npc.frameCounter = 0;
                walk = (walk + 1) % WalkFrames;
            }

            npc.frame.Y = walk * frameHeight;
        }
    }
}
