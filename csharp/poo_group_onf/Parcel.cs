using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONF
{
    class Parcel
    {
        private uint _id;
        private List<Tree> _trees;
        private List<GpsCoordonate> _coordonates;

        public Parcel(uint _id, List<GpsCoordonate> coordonates)
        {
            this.ParcelId = _id;
            this.Coordonates = coordonates;
            this.Trees = new List<Tree> { };
        }

        public List<GpsCoordonate> Coordonates
        {
            get => this._coordonates;
            set 
            {
                if (value.Count != 4)
                {
                    throw new ApplicationException("We need 4 GPS coordonates");
                }

                _coordonates = value;
            }
        }

        public uint ParcelId
        {
            get => this._id;
            set => this._id = value;
        }

        public List<Tree> Trees
        {
            get => this._trees;
            set => this._trees = value;
        }

        public int GetNumberTrees()
        {
            return this.Trees.Count;
        }

        public void PlantATree(Tree tree)
        {
            this.Trees.Add(tree);
        }

        public float GetSurface()
        {
            return 0;
        }
    }
}
