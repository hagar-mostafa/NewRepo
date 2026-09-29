using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Xml.Linq;
#nullable disable
namespace OOP_05.Shipment
{
    public class Shipment
    {
        private string _TrackingCode;
        public string TrackingCode
        {
            get
            { return _TrackingCode; }
        }
        private string _Description;
        public string Description
        {
            get { return _Description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _Description = value;
            }
        }
        private decimal _Weight;
        public decimal Weight
        {
            get { return _Weight; }
            set
            {
                if (value > 0)
                    _Weight = value;
            }
        }
        private decimal _DeliveryFee;
        public decimal DeliveryFee
        {
            get { return _DeliveryFee; }
            private set
            {
                if (value > 0)
                    _DeliveryFee = value;
            }

        }

        public Shipment(string trackingCode)
        {
            if (!string.IsNullOrWhiteSpace(trackingCode))
                _TrackingCode = trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
        }
        //------constructor overloading-----
        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee)
        {
            if (!string.IsNullOrWhiteSpace(trackingCode))
                _TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
        }

        public Shipment CopyShipment()
        {
            return new Shipment(this.TrackingCode, this.Description, this.Weight, this.DeliveryFee);
        }
        // Way one in Shallow copy
        public Shipment Shallow_Copy()
        {
            return (Shipment)this.MemberwiseClone();
        }
        // Way two in Shallow copy
        public object Clone()
        {
            return MemberwiseClone();
        }

        public override string ToString()
        {
            return $"{TrackingCode} , {Description} ,  {Weight}  , {DeliveryFee}";
        }

    }

}





