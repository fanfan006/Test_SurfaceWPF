using System;

namespace DeepZoom.Samples.OpenStreetMap
{
    public class OpenStreetMapTileSource : MultiScaleTileSource
    {
        public OpenStreetMapTileSource() : base(0x8000000, 0x8000000, 256, 0) { }

        protected override object GetTileLayers(int tileLevel, int tilePositionX, int tilePositionY)
        {
            var zoom = tileLevel - 8;
            if (zoom >= 0)
                return new Uri(string.Format("http://tah.openstreetmap.org/Tiles/tile/{0}/{1}/{2}.png", zoom, tilePositionX, tilePositionY));
            else
                return null;
        }
    }
}
