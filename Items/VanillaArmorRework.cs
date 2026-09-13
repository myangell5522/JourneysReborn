using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace JourneysReborn.Items // Замените на своё пространство имён
{
    public class BeeArmorSet : GlobalItem
    {
        // Метод проверяет, является ли комбинация предметов сетом
        public override string IsArmorSet(Item head, Item body, Item legs)
        {
            // Проверяем, что надет полный набор Bee Armor
            if (head.type == ItemID.BeeHeadgear &&
                body.type == ItemID.BeeBreastplate &&
                legs.type == ItemID.BeeGreaves)
            {
                // Возвращаем уникальное имя для этого сета
                return "BeeArmor";
            }

            return null; // Если сет не надет
        }

        // Метод применяет эффекты сета, если IsArmorSet вернул не null
        public override void UpdateArmorSet(Player player, string set)
        {
            if (set == "BeeArmor")
            {
                // Включаем наш эффект в ModPlayer
                player.GetModPlayer<BeeArmorPlayer>().BeeArmorSetBonus = true;
            }
        }
		
		 public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (item.type == ItemID.BeeHeadgear || 
                item.type == ItemID.BeeBreastplate || 
                item.type == ItemID.BeeGreaves)
            {
			    TooltipLine line = new TooltipLine(Mod, "SetBonus", "Set bonus: Douses the user in honey while dealing damage to enemies");
                tooltips.Add(line);
            }
        }
    }
}

namespace JourneysReborn.Items // Замените на своё пространство имён
{
    public class BeeArmorPlayer : ModPlayer
    {
        // Флаг, указывающий, активен ли бонус от сета
        public bool BeeArmorSetBonus;

        // Сбрасываем флаг каждый кадр, чтобы он не оставался активным
        // после снятия брони
        public override void ResetEffects()
        {
            BeeArmorSetBonus = false;
        }

        // Хук, который срабатывает при попадании по врагу снарядом (включая хлысты)
        public override void OnHitNPCWithProj(Projectile proj, NPC target, NPC.HitInfo hit, int damageDone)
        {
            // Проверяем, активен ли бонус сета и является ли снаряд хлыстом
            if (BeeArmorSetBonus && ProjectileID.Sets.IsAWhip[proj.type])
            {
                // Шанс 10% (1/10)
                if (Main.rand.NextBool(10))
                {
                    // Длительность баффа от 1 до 2 секунд (60 тиков = 1 секунда)
                    int duration = Main.rand.Next(60, 121); // 60-120 тиков
                    
                    // Накладываем бафф Honey на игрока
                    Player.AddBuff(BuffID.Honey, duration);
                }
            }
        }
    }
}