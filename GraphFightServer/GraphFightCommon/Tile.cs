namespace GraphFightCommon
{
    public class Tile
    {
        private readonly TileMovementFlags _movementFlags;

        public Tile()
        {
            _movementFlags = TileMovementFlags.None;
        }

        public Tile(TileMovementFlags movementFlags)
        {
            _movementFlags = movementFlags;
        }

        public bool IsPassable => (_movementFlags & TileMovementFlags.Passable) == TileMovementFlags.Passable;
        public bool IsStandable => (_movementFlags & TileMovementFlags.Standable) == TileMovementFlags.Standable;
        public bool IsBulletPassable => (_movementFlags & TileMovementFlags.BulletPassable) == TileMovementFlags.BulletPassable;
    }
}