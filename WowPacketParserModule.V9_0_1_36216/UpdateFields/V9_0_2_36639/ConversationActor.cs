using WowPacketParser.Misc;
using WowPacketParser.Store.Objects.UpdateFields;

namespace WowPacketParserModule.V9_0_1_36216.UpdateFields.V9_0_2_36639
{
    public class ConversationActor : IConversationActor
    {
        public uint Id { get; }
        public uint CreatureID { get; set; }
        public uint CreatureDisplayInfoID { get; set; }
        public WowGuid ActorGUID { get; set; }
        public int Field_18 { get; set; }
        public uint Type { get; set; }
        public uint NoActorObject { get; set; }
    }
}

