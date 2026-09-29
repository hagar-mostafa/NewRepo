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
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _TrackingCode = value;
            }
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
            set
            {
                if (value > 0)
                    _DeliveryFee = value;
            }

        }

        public Address Address;
        private static string DefaultCity;

        public Shipment() // Prameterless Constructor
        {
            TrackingCode = "Unknown";
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Address.City = "UnKnown";
        }


        //------constructor overloading-----
        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee , Address address)
        {
            if (!string.IsNullOrWhiteSpace(trackingCode))
                _TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Address = address;

        }

        public Shipment CopyShipment()
        {
            return new Shipment(this.TrackingCode, this.Description, this.Weight, this.DeliveryFee , this.Address);
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

        // The Clone way in Deep Copy
        public Shipment Deep_Copy()
        {
            Shipment shipment = (Shipment)MemberwiseClone();
            shipment.Address = new Address(Address.City);
            return shipment;
        }
        public override string ToString()
        {
            return $"{TrackingCode} , {Description} ,  {Weight}  , {DeliveryFee} , {Address.City}";
        }

        // Static Field 
        #region Static Field 
        public static int TotalShipments = 0 ;
        public void countShipments()
        {
            TotalShipments++;
        }
        #endregion
    }

}





