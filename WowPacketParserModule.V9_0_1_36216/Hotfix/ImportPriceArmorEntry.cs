using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V9_0_1_36216.Hotfix
{
    [HotfixStructure(DB2Hash.ImportPriceArmor, HasIndexInData = false)]
    public class ImportPriceArmorEntry
    {
        public float ClothModifier { get; set; }
        public float LeatherModifier { get; set; }
        public float ChainModifier { get; set; }
        public float PlateModifier { get; set; }
    }
}
