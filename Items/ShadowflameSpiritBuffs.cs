using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneysReborn.Items
{
    public class AccShadowflameSpirit : ModPlayer
    {
        public bool shadowflameSpirit;
        public override void ModifyHitNPCWithProj(Projectile proj, NPC target, ref NPC.HitModifiers modifiers)/* tModPorter If you don't need the Projectile, consider using ModifyHitNPC instead */
        {
            if(shadowflameSpirit) {
                if(proj.type == ProjectileID.VilethornBase || proj.type == ProjectileID.VilethornTip) {
                    if(Main.rand.NextBool(3)) {
                        target.AddBuff(BuffID.Poisoned, 180);
                    };
                };
                if(proj.type == ProjectileID.ThunderSpearShot || proj.type == ProjectileID.ThunderStaffShot) {
                    modifiers.SetCrit();
                };
                if(proj.type == ProjectileID.WaterStream) {
                    if(Main.rand.NextBool(8)) {
                        target.AddBuff(BuffID.Frostburn, 150);
                    };
                };
                if(proj.type == ProjectileID.WandOfSparkingSpark) {
                    if(target.HasBuff(BuffID.OnFire) && Main.rand.NextBool(3)) {
                        target.DelBuff(target.FindBuffIndex(BuffID.OnFire));
                        target.AddBuff(BuffID.OnFire3, 120);
                    };
                };
                if(proj.type == ProjectileID.AmethystBolt) {
                    if(Main.rand.NextBool(3)) {
                        target.AddBuff(BuffID.ShadowFlame, 120);
                    };
                };
                if(proj.type == ProjectileID.TopazBolt) {
                    if(Main.rand.NextBool(3)) {
                        target.AddBuff(BuffID.Midas, 120);
                    };
                };
                if(proj.type == ProjectileID.SapphireBolt) {
                    if(Main.rand.NextBool(5)) {
                        Player.AddBuff(BuffID.MagicPower, 120);
                    };
                };
                if(proj.type == ProjectileID.EmeraldBolt) {
                    target.AddBuff(BuffID.Poisoned, 240);
                };
                if(proj.type == ProjectileID.RubyBolt) {
                    if(Main.rand.NextBool(5)) {
                        Player.AddBuff(BuffID.Regeneration, 120);
                    };
                };
                if(proj.type == ProjectileID.DiamondBolt) {
                    if(Main.rand.NextBool(3)) {
                        target.AddBuff(BuffID.Confused, 180);
                    };
                };
                if(proj.type == ProjectileID.AmberBolt) {
                    target.AddBuff(BuffID.OnFire, 180);
                };
                if(proj.type == ProjectileID.Flamelash || proj.type == ProjectileID.BallofFire) {
                    if(target.HasBuff(BuffID.OnFire) && Main.rand.NextBool(3)) {
                        target.DelBuff(target.FindBuffIndex(BuffID.OnFire));
                        target.AddBuff(BuffID.OnFire3, 180);
                    };
                };
                if(proj.type == ProjectileID.SkyFracture) {
                    if(Main.rand.NextBool(4)) {
                        target.AddBuff(BuffID.Confused, Main.rand.Next(60, 180));
                    };
                };
                if(proj.type == ProjectileID.Meteor1 || proj.type == ProjectileID.Meteor2 || proj.type == ProjectileID.Meteor3) {
                    if(Main.rand.NextBool(6)) {
                        target.AddBuff(BuffID.OnFire, Main.rand.Next(120, 240));
                    };
                };
                if(proj.type == ProjectileID.CrystalPulse || proj.type == ProjectileID.CrystalPulse2) {
                    if(Main.rand.NextBool(12)) {
                        Player.AddBuff(BuffID.ManaRegeneration, 240);
                    };
                };
                if(proj.type == ProjectileID.NettleBurstEnd || proj.type == ProjectileID.NettleBurstLeft || proj.type == ProjectileID.NettleBurstRight) {
                    if(Main.rand.NextBool(8)) {
                        target.AddBuff(BuffID.Venom, 150);
                    };
                };
                if(proj.type == ProjectileID.PoisonFang) {
                    if(target.HasBuff(BuffID.Poisoned) && Main.rand.NextBool(8)) {
                        target.DelBuff(target.FindBuffIndex(BuffID.Poisoned));
                        target.AddBuff(BuffID.Venom, 600);
                    };
                };
                if(proj.type == ProjectileID.VenomFang) {
                    if(target.HasBuff(BuffID.Venom) && Main.rand.NextBool(8)) {
                        modifiers.FinalDamage *= 2f;
                    };
                };
                if(proj.type == ProjectileID.Bat) {
                    if(Main.rand.NextBool(6)) {
                        target.AddBuff(BuffID.Confused, Main.rand.Next(60, 240));
                    };
                };
                if(proj.type == ProjectileID.FrostBoltStaff) {
                    if(Main.rand.NextBool(6)) {
                        target.AddBuff(BuffID.Frostburn, 300);
                    };
                };
                if(proj.type == ProjectileID.PineNeedleFriendly) {
                    target.AddBuff(BuffID.Poisoned, 600);
                };
                if(proj.type == ProjectileID.RainbowRodBullet) {
                    if(Main.rand.NextBool(4)) {
                        target.AddBuff(BuffID.Confused, 180);
                    };
                };
                if(proj.type == ProjectileID.Blizzard) {
                    if(Main.rand.NextBool(8)) {
                        target.AddBuff(BuffID.Frostburn2, 300);
                    };
                };
                if(proj.type == ProjectileID.BallofFrost) {
                    if(Main.rand.NextBool(4) && target.HasBuff(BuffID.Frostburn)) {
                        target.DelBuff(target.FindBuffIndex(BuffID.Frostburn));
                        target.AddBuff(BuffID.Frostburn2, 480);
                    };
                };
                if(proj.type == ProjectileID.ShadowBeamFriendly) {
                    if(Main.rand.NextBool(6)) {
                        target.AddBuff(BuffID.ShadowFlame, 300);
                    };
                };
                if(proj.type == ProjectileID.InfernoFriendlyBlast || proj.type == ProjectileID.InfernoFriendlyBolt) {
                    if(Main.rand.NextBool(3) && target.HasBuff(BuffID.OnFire)) {
                        target.DelBuff(target.FindBuffIndex(BuffID.OnFire));
                        target.AddBuff(BuffID.OnFire3, Main.rand.Next(480, 900));
                    };
                };
                if(proj.type == ProjectileID.LostSoulFriendly) {
                    if(Main.rand.NextBool(5)) {
                        target.AddBuff(BuffID.Confused, Main.rand.Next(30, 90));
                    };
                };
                if(proj.type == ProjectileID.UnholyTridentFriendly) {
                    if(Main.rand.NextBool(5)) {
                        target.AddBuff(BuffID.ShadowFlame, 480);
                    };
                };
            };
        }

        public override void ModifyWeaponDamage(Item item, ref StatModifier damage)
        {
            if(shadowflameSpirit) {
                if(item.type == ItemID.Vilethorn) {
                    damage *= 1.5f;
                };
                if(item.type == ItemID.ThunderSpear) {
                    damage *= 1.5f;
                };
                if(item.type == ItemID.WandofSparking) {
                    damage *= 1.35f;
                };
                if(item.type == ItemID.AmethystStaff || item.type == ItemID.TopazStaff || item.type == ItemID.SapphireStaff ||
                item.type == ItemID.EmeraldStaff || item.type == ItemID.AmberStaff || item.type == ItemID.RubyStaff ||
                item.type == ItemID.DiamondStaff) {
                    damage *= 1.4f;
                };
                if(item.type == ItemID.MagicMissile) {
                    damage *= 1.25f;
                };
                if(item.type == ItemID.Flamelash) {
                    damage *= 1.25f;
                };
                if(item.type == ItemID.FlowerofFire) {
                    damage *= 1.25f;
                };
                if(item.type == ItemID.CrystalVileShard) {
                    damage *= 1.25f;
                };
                if(item.type == ItemID.SoulDrain) {
                    damage *= 1.67f;
                };
                if(item.type == ItemID.NettleBurst) {
                    damage *= 1.35f;
                };
                if(item.type == ItemID.SkyFracture) {
                    damage *= 1.3f;
                };
                if(item.type == ItemID.CrystalSerpent) {
                    damage *= 1.25f;
                };
                if(item.type == ItemID.PoisonStaff || item.type == ItemID.VenomStaff) {
                    damage *= 1.25f;
                };
                if(item.type == ItemID.BatScepter) {
                    damage *= 1.3f;
                };
                if(item.type == ItemID.FrostStaff) {
                    damage *= 1.33f;
                };
                if(item.type == ItemID.Razorpine) {
                    damage *= 1.15f;
                };
                if(item.type == ItemID.MeteorStaff) {
                    damage *= 1.25f;
                };
                if(item.type == ItemID.RainbowRod) {
                    damage *= 1.2f;
                };
                if(item.type == ItemID.BlizzardStaff) {
                    damage *= 1.15f;
                };
                if(item.type == ItemID.FlowerofFrost) {
                    damage *= 1.2f;
                };
                if(item.type == ItemID.ShadowbeamStaff) {
                    damage *= 1.25f;
                };
                if(item.type == ItemID.InfernoFork) {
                    damage *= 1.2f;
                };
                if(item.type == ItemID.SpectreStaff) {
                    damage *= 1.1f;
                };
                if(item.type == ItemID.PrincessWeapon) {
                    damage *= 1.25f;
                };
                if(item.type == ItemID.UnholyTrident) {
                    damage *= 1.2f;
                };
                if(item.type == ItemID.StaffofEarth) {
                    damage *= 1.35f;
                };
            };
        }

        public override void ResetEffects()
        {
            shadowflameSpirit = false;
        }
    }
}