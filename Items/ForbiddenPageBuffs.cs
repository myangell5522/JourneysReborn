using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneysReborn.Items
{
    public class AccForbiddenPage : ModPlayer
    {
        public bool forbiddenPage;
        public override void ModifyHitNPCWithProj(Projectile proj, NPC target, ref NPC.HitModifiers modifiers)
        {
            if(forbiddenPage) {
                if(proj.type == ProjectileID.WaterBolt) {
                    if(target.wet) {
                        modifiers.SetCrit();
                    }
                }
                if(proj.type == ProjectileID.GoldenShowerFriendly) {
                    if(target.HasBuff(BuffID.Ichor) && Main.rand.NextBool(1, 3)) {
                        modifiers.FinalDamage *= 1.2f;
                    }
                }
                if(proj.type == ProjectileID.DemonScythe) {
                    if(Main.rand.NextBool(1, 4)) {
                        target.AddBuff(BuffID.ShadowFlame, 60);
                    }
                }
                if(proj.type == ProjectileID.CursedFlameFriendly) {
                    if(target.HasBuff(BuffID.CursedInferno) && Main.rand.NextBool(1, 3)) {
                        modifiers.FinalDamage *= 1.2f;
                    }
                }
                if(proj.type == ProjectileID.Typhoon) {
                    if(target.wet && Main.rand.NextBool(1, 2)) {
                        target.AddBuff(BuffID.Confused, 60);
                    }
                }
                if(proj.type == ProjectileID.LunarFlare) {
                    if(Main.rand.NextBool(1, 3)) {
                        target.AddBuff(BuffID.Confused, 90);
                    }
                }
            }
        }

        public override void ModifyWeaponDamage(Item item, ref StatModifier damage)
        {
            if(forbiddenPage) {
                if(item.type == ItemID.WaterBolt) {
                    damage *= 1.2f;
                }
                if(item.type == ItemID.GoldenShower) {
                    damage *= 1.15f;
                }
                if(item.type == ItemID.BookofSkulls) {
                    damage *= 1.25f;
                }
                if(item.type == ItemID.CrystalStorm) {
                    damage *= 1.2f;
                }
                if(item.type == ItemID.DemonScythe) {
                    damage *= 1.1f;
                }
                if(item.type == ItemID.MagnetSphere) {
                    damage *= 1.2f;
                }
                if(item.type == ItemID.CursedFlames) {
                    damage *= 1.15f;
                }
                if(item.type == ItemID.RazorbladeTyphoon) {
                    damage *= 1.05f;
                }
                if(item.type == ItemID.LunarFlareBook) {
                    damage *= 1.121f;
                }
            }
        }

        public override void ModifyManaCost(Item item, ref float reduce, ref float mult)
        {
            if(forbiddenPage) {
                if(item.type == ItemID.WaterBolt) {
                    mult *= 0.8f;
                }
                if(item.type == ItemID.GoldenShower) {
                    mult *= 0.75f;
                }
                if(item.type == ItemID.BookofSkulls) {
                    mult *= 0.8f;
                }
                if(item.type == ItemID.CrystalStorm) {
                    mult *= 0.9f;
                }
                if(item.type == ItemID.DemonScythe) {
                    mult *= 0.85f;
                }
                if(item.type == ItemID.MagnetSphere) {
                    mult *= 0.85f;
                }
                if(item.type == ItemID.CursedFlames) {
                    mult *= 0.8f;
                }
                if(item.type == ItemID.RazorbladeTyphoon) {
                    mult *= 0.9f;
                }
                if(item.type == ItemID.LunarFlareBook) {
                    mult *= 0.8f;
                }
            }
        }

        public override void ResetEffects()
        {
            forbiddenPage = false;
        }
    }
}