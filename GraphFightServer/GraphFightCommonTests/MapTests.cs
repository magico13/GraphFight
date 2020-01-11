using GraphFightCommon;
using NUnit.Framework;
using System.Collections.Generic;

namespace GraphFightCommonTests
{
    [TestFixture]
    public class MapTests
    {
        [Test]
        public void MapInitializesEmptyTileArray()
        {
            Map map = new Map();
            Assert.That(map.Tiles, Is.Empty);
        }

        [Test]
        public void DefiningSizeSetsArrayDimensions()
        {
            int width = 10;
            int height = 11;
            Map map = new Map(width: width, height: height);
            Assert.That(map.Width, Is.EqualTo(width));
            Assert.That(map.Height, Is.EqualTo(height));
            Assert.That(map.Tiles.Length, Is.EqualTo(width));
            Assert.That(map.Tiles[0].Length, Is.EqualTo(height));
        }

        [Test]
        public void CanPassIEnumerableOfIEnumerablesToDefineMap()
        {
            int width = 5;
            int height = 3;
            Tile tile = new Tile();

            //build list of lists to pass in
            List<List<Tile>> myMap = new List<List<Tile>>(width);
            for (int i=0; i<width; i++)
            {
                myMap.Add(new List<Tile>(height));
                for (int j=0; j<height; j++)
                {
                    myMap[i].Add(tile);
                }
            }

            Map map = new Map(myMap);
            Assert.That(map.Tiles.Length, Is.EqualTo(width));
            Assert.That(map.Tiles[0].Length, Is.EqualTo(height));
            for (int i=0; i<width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Assert.That(map.Tiles[i][j], Is.EqualTo(tile));
                }
            }
        }
    }
}
