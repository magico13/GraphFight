namespace GraphFightCommon
{
    public class Tile
    {
        public TileMovementFlags MovementFlags { get; }
        public int Id { get; }

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

        public bool IsPassable => (MovementFlags & TileMovementFlags.Passable) == TileMovementFlags.Passable;
        public bool IsStandable => (MovementFlags & TileMovementFlags.Standable) == TileMovementFlags.Standable;
        public bool IsBulletPassable => (MovementFlags & TileMovementFlags.BulletPassable) == TileMovementFlags.BulletPassable;
    }
}