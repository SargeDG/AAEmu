using AAEmu.Commons.Network;

namespace AAEmu.Game.Models.Game
{
    public class Portal : PacketMarshaler
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ZoneId { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public float ZRot { get; set; }

        public override PacketStream Write(PacketStream stream)
        {
            stream.Write(Id);
            stream.Write(Name); // TODO max length 128
            stream.Write(ZoneId);
            stream.Write(X);
            stream.Write(Y);
            stream.Write(Z);
            stream.Write(ZRot);
            return stream;
        }
    }
}