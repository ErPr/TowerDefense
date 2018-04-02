using System.Linq;

namespace TowerDefense
{
    public class Path
    {
        private readonly MapLocation[] _path;

        public int Length => _path.Length;

        public Path(MapLocation[] path)
        {
            _path = path;
        }

        public MapLocation GetLocationAt(int pathStep)
        {
            return (pathStep < _path.Length) ? _path[pathStep] : null;
        }

        // Below are three different ways to code the IsOnPath method; leaving them in as notes.

        // 1.
        //LINQ IsOnPath method
        //public bool IsOnPath(MapLocation mapLocation) => _path.Contains(mapLocation);

        // 2.
        public bool IsOnPath(MapLocation location)
        {
            // 3.
            //return Array.IndexOf(pathLocations, mapLocation) >= 0;

            foreach(var pathLocation in _path)
            {
                if(location.Equals(pathLocation))
                {
                    return true;
                }
            }

            return false;
        }
    }
}