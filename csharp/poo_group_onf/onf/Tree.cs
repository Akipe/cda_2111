using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONF
{
    class Tree
    {
        private TypeOfTree _typeOfTree;
        private uint _heightInCm;
        private uint _diameterInCm;

        public Tree(uint heightInCm, uint diameterInCm, TypeOfTree typeOfTree)
        {
            TypeOfTree = typeOfTree;
            HeightInCm = heightInCm;
            DiameterInCm = diameterInCm;
        }

        public TypeOfTree TypeOfTree
        {
            get => this._typeOfTree;
            init => this._typeOfTree = value;
        }

        public uint HeightInCm
        {
            get => this._heightInCm;
            init => this._heightInCm = value;
        }

        public uint DiameterInCm
        {
            get => this._diameterInCm;
            init => this._diameterInCm = value;
        }
    }
}
