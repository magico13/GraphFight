using System;

namespace GraphFightCommon
{
    [Flags]
    public enum TileMovementFlags
    {
        None = 0x00,
        Passable = 0x01,
        Standable = 0x02,
        BulletPassable = 0x04
    }
}
