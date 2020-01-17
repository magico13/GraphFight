using System.Collections.Generic;

namespace GraphFightCommon
{
    public class GameState
    {
        public Map Map { get; set; }
        public List<Tile> Tiles { get; set; }
        public List<List<Pawn>> Teams { get; set; }
    }
}
