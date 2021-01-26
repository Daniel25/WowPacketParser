using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V9_0_1_36216.Hotfix
{
    [HotfixStructure(DB2Hash.SpellDuration, HasIndexInData = false)]
    public class SpellDurationEntry
    {
        public int Duration { get; set; }
        public int MaxDuration { get; set; }
    }
}
