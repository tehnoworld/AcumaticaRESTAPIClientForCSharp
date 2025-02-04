using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class BCShipmentsResult : Entity_v4
	{

		[DataMember(Name="ExternalShipmentUpdated", EmitDefaultValue=false)]
		public BooleanValue ExternalShipmentUpdated { get; set; }

		[DataMember(Name="InvoiceNbr", EmitDefaultValue=false)]
		public StringValue InvoiceNbr { get; set; }

		[DataMember(Name="InvoiceType", EmitDefaultValue=false)]
		public StringValue InvoiceType { get; set; }

		[DataMember(Name="Confirmed", EmitDefaultValue=false)]
		public BooleanValue Confirmed { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue NoteID { get; set; }

		[DataMember(Name="OrderNbr", EmitDefaultValue=false)]
		public StringValue OrderNbr { get; set; }

		[DataMember(Name="OrderNoteID", EmitDefaultValue=false)]
		public GuidValue OrderNoteID { get; set; }

		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue OrderType { get; set; }

		[DataMember(Name="ShipmentNumber", EmitDefaultValue=false)]
		public StringValue ShipmentNumber { get; set; }

		[DataMember(Name="ShipmentType", EmitDefaultValue=false)]
		public StringValue ShipmentType { get; set; }

	}
}