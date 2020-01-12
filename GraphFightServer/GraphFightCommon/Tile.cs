using Newtonsoft.Json;

namespace GraphFightCommon
{
    public class Tile
    {
        public TileMovementFlags MovementFlags { get; set; }
        public int Id { get; set; }

        public Tile()
        {
            MovementFlags = TileMovementFlags.None;
            Id = 0;
        }

        public Tile(int id, TileMovementFlags movementFlags)
        {
            MovementFlags = movementFlags;
            Id = id;
        }

        [JsonIgnore]
        public bool IsPassable => (MovementFlags & TileMovementFlags.Passable) == TileMovementFlags.Passable;
        [JsonIgnore]
        public bool IsStandable => (MovementFlags & TileMovementFlags.Standable) == TileMovementFlags.Standable;
        [JsonIgnore]
        public bool IsBulletPassable => (MovementFlags & TileMovementFlags.BulletPassable) == TileMovementFlags.BulletPassable;

        public override string ToString()
        {
            return $"{Id} - {MovementFlags}";
        }
    }
}