using WowPacketParser.Misc;
using WowPacketParser.Store.Objects.UpdateFields;

namespace WowPacketParserModule.V8_0_1_27101.UpdateFields.V8_2_5_31921
{
    public class ScaleCurve : IScaleCurve
    {
        public uint StartTimeOffset { get; set; }
        public Vector2[] Points { get; } = new Vector2[2];
        public uint ParameterCurve { get; set; }
        public bool OverrideActive { get; set; }
    }
}

