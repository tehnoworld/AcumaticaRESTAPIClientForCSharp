using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class DisassemblyEntryMaterial : Entity_v4
	{

		[DataMember(Name="Allocations", EmitDefaultValue=false)]
		public List<DisassemblyEntryMaterialAllocation> Allocations { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
		public DateTimeValue ExpirationDate { get; set; }

		[DataMember(Name="ExtCost", EmitDefaultValue=false)]
		public DecimalValue ExtCost { get; set; }

		[DataMember(Name="GLBatchLineNbr", EmitDefaultValue=false)]
		public IntValue GLBatchLineNbr { get; set; }

		[DataMember(Name="GLBatchNbr", EmitDefaultValue=false)]
		public StringValue GLBatchNbr { get; set; }

		[DataMember(Name="INDocType", EmitDefaultValue=false)]
		public StringValue INDocType { get; set; }

		[DataMember(Name="INLineNbr", EmitDefaultValue=false)]
		public IntValue INLineNbr { get; set; }

		[DataMember(Name="INRefNbr", EmitDefaultValue=false)]
		public StringValue INRefNbr { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue LineNbr { get; set; }

		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue Location { get; set; }

		[DataMember(Name="LotSerialNbr", EmitDefaultValue=false)]
		public StringValue LotSerialNbr { get; set; }

		[DataMember(Name="MaterialLineNbr", EmitDefaultValue=false)]
		public IntValue MaterialLineNbr { get; set; }

		[DataMember(Name="OperationNbr", EmitDefaultValue=false)]
		public StringValue OperationNbr { get; set; }

		[DataMember(Name="ParentLotSerialNbr", EmitDefaultValue=false)]
		public StringValue ParentLotSerialNbr { get; set; }

		[DataMember(Name="QtyisScrap", EmitDefaultValue=false)]
		public BooleanValue QtyisScrap { get; set; }

		[DataMember(Name="Quantity", EmitDefaultValue=false)]
		public DecimalValue Quantity { get; set; }

		[DataMember(Name="ReasonCode", EmitDefaultValue=false)]
		public StringValue ReasonCode { get; set; }

		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue Subitem { get; set; }

		[DataMember(Name="TranType", EmitDefaultValue=false)]
		public StringValue TranType { get; set; }

		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue UnitCost { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue UOM { get; set; }

		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue Warehouse { get; set; }

	}
}