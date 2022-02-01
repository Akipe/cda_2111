using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONF
{
    class GpsCoordonate
    {
        private double _longitude;
        private double _latidude;
        private Parcel _theParcel;

        public GpsCoordonate(double latidude, double longitude)
        {
            this.Latitude = latidude;
            this.Longitude = longitude;
            this.TheParcel = null;
        }

        public Parcel TheParcel
        {
            get => this._theParcel;
            set => this._theParcel = value;
        }

        public double Longitude
        {
            get => this._longitude;
            set => this._longitude = value;
        }

        public double Latitude
        {
            get => this._latidude;
            set => this._latidude = value;
        }
    }
}
