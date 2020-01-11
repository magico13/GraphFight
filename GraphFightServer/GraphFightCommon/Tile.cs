namespace GraphFightCommon
{
    public class Tile
    {
        public TileMovementFlags MovementFlags { get; }

        public Tile()
        {
            MovementFlags = TileMovementFlags.None;
        }

        public Tile(TileMovementFlags movementFlags)
        {
            MovementFlags = movementFlags;
        }

        public bool IsPassable => (MovementFlags & TileMovementFlags.Passable) == TileMovementFlags.Passable;
        public bool IsStandable => (MovementFlags & TileMovementFlags.Standable) == TileMovementFlags.Standable;
        public bool IsBulletPassable => (MovementFlags & TileMovementFlags.BulletPassable) == TileMovementFlags.BulletPassable;
    }
}