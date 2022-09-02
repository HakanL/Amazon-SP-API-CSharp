using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.ShippingV2 {

  /// <summary>
  /// The payload for the directPurchaseShipment operation.
  /// </summary>
  [DataContract]
  public class DirectPurchaseResult {
    /// <summary>
    /// Gets or Sets ShipmentId
    /// </summary>
    [DataMember(Name="shipmentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipmentId")]
    public ShipmentId ShipmentId { get; set; }

    /// <summary>
    /// Gets or Sets PackageDocumentDetailList
    /// </summary>
    [DataMember(Name="packageDocumentDetailList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "packageDocumentDetailList")]
    public PackageDocumentDetailList PackageDocumentDetailList { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DirectPurchaseResult {\n");
      sb.Append("  ShipmentId: ").Append(ShipmentId).Append("\n");
      sb.Append("  PackageDocumentDetailList: ").Append(PackageDocumentDetailList).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}