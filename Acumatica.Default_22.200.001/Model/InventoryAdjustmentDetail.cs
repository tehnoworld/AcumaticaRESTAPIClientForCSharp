using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class InventoryAdjustmentDetail : Entity_v4
	{

		[DataMember(Name="BranchID", EmitDefaultValue=false)]
		public StringValue BranchID { get; set; }

		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue CostCode { get; set; }

		[DataMember(Name="CostLayerType", EmitDefaultValue=false)]
		public StringValue CostLayerType { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
		public DateTimeValue ExpirationDate { get; set; }

		[DataMember(Name="ExtendedCost", EmitDefaultValue=false)]
		public DecimalValue ExtendedCost { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue LocationID { get; set; }

		[DataMember(Name="LotSerialNbr", EmitDefaultValue=false)]
		public StringValue LotSerialNbr { get; set; }

		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue Project { get; set; }

		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue ProjectTask { get; set; }

		[DataMember(Name="Qty", EmitDefaultValue=false)]
		public DecimalValue Qty { get; set; }

		[DataMember(Name="ReasonCode", EmitDefaultValue=false)]
		public StringValue ReasonCode { get; set; }

		[DataMember(Name="ReceiptNbr", EmitDefaultValue=false)]
		public StringValue ReceiptNbr { get; set; }

		[DataMember(Name="SpecialOrderNbr", EmitDefaultValue=false)]
		public StringValue SpecialOrderNbr { get; set; }

		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue Subitem { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue UOM { get; set; }

		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue WarehouseID { get; set; }

	}
}