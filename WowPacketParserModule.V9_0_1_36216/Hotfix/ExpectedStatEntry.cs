using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V9_0_1_36216.Hotfix
{
    [HotfixStructure(DB2Hash.ExpectedStat, HasIndexInData = false)]
    public class ExpectedStatEntry
    {
        public int ExpansionID { get; set; }
        public float CreatureHealth { get; set; }
        public float PlayerHealth { get; set; }
        public float CreatureAutoAttackDps { get; set; }
        public float CreatureArmor { get; set; }
        public float PlayerMana { get; set; }
        public float PlayerPrimaryStat { get; set; }
        public float PlayerSecondaryStat { get; set; }
        public float ArmorConstant { get; set; }
        public float CreatureSpellDamage { get; set; }
        public uint Lvl { get; set; }
    }
}
