using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneysReborn.Content.Buffs
{
	public class EaglePrecision : ModBuff
	{
		public override void SetStaticDefaults() {
			Main.buffNoTimeDisplay[Type] = false;
            Main.buffNoSave[Type] = false;
		}

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<EaglePrecisionBuff>().eaglePrecision = true;
        }
	}

    public class EaglePrecisionBuff : ModPlayer
    {
        public bool eaglePrecision;
        public override void ModifyWeaponDamage(Item item, ref StatModifier damage)
        {
            if(eaglePrecision && (item.useAmmo == AmmoID.Bullet || item.useAmmo == AmmoID.Dart || item.useAmmo == AmmoID.NailFriendly || item.useAmmo == AmmoID.StyngerBolt)) {
                damage *= 1.1f;
            };
        }
        public override void ModifyShootStats(Item item, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            if(eaglePrecision && (item.useAmmo == AmmoID.Bullet || item.useAmmo == AmmoID.Dart || item.useAmmo == AmmoID.NailFriendly || item.useAmmo == AmmoID.StyngerBolt)) {
                velocity *= 1.15f;
            };
        }
        public override void ResetEffects()
        {
            eaglePrecision = false;
        }
    }
}