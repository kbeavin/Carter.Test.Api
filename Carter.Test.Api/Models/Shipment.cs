using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carter.Test.Api.Models
{

    #region Api Models

    public class Header
    {
        public string correlationId { get; set; }
        public string fvShipmentId { get; set; }
    }

    public class ShipmentDataModel
    {
        public Header Header { get; set; }

        public shipment Shipment { get; set; }
    }

    public class ShipmentEventDataModel
    {
        public Header Header { get; set; }
        public ShipmentEvent ShipmentEvent { get; set; }
    }

    #endregion



    #region Shipment Models

    public class shipment
    {
        public carrier carrier { get; set; }
        public customer customer { get; set; }
        public shipmentIdentification shipmentIdentification { get; set; }
        public telematics telematics { get; set; }
        public List<stop> stops { get; set; }
        public List<shipmentReference> shipmentReferences { get; set; }
    }

    public class shipmentIdentification
    {
        public string shipmentId { get; set; }
        public string proNumber { get; set; }
    }

    public class shipmentReference
    {
        public string qualifier { get; set; }
        public string description { get; set; }
        public string value { get; set; }
    }

    #region Shipment Events

    public class ShipmentEvent
    {
        public carrier carrier { get; set; }
        public int stopSequence { get; set; }
        public location location { get; set; }
        public telematics telematics { get; set; }
        public eventDetail eventDetail { get; set; }
    }

    public class eventDetail
    {
        public DateTime eventDate { get; set; }
        public string @event { get; set; }
    }

    #endregion

    #region Stops

    public class stop
    {
        public int stopSequence { get; set; }
        public string stopType { get; set; }
        public string stopRole { get; set; }
        public DateTime earlyArrival { get; set; }
        public DateTime lateArrival { get; set; }
        public location location { get; set; }
    }

    #endregion

    #endregion



    #region Location Models

    public class location
    {
        public locationId locationId { get; set; }
        public string name { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postalCode { get; set; }
    }

    public class locationId
    {
        public string qualifier { get; set; }
        public string value { get; set; }
    }

    #endregion



    #region Customer Models

    public class customer
    {
        public string fvCustomerId { get; set; }
    }

    public class carrier
    {
        public string fvCarrierId { get; set; }
        public string scac { get; set; }
    }

    public class telematics
    {
        public string provider { get; set; }
        public string trackingAssetId { get; set; }
    }

    #endregion

}

