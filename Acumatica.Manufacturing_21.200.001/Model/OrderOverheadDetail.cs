using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class OrderOverheadDetail : Entity_v4
	{

		[DataMember(Name="CostRate", EmitDefaultValue=false)]
		public DecimalValue CostRate { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="Factor", EmitDefaultValue=false)]
		public DecimalValue Factor { get; set; }

		[DataMember(Name="LineID", EmitDefaultValue=false)]
		public IntValue LineID { get; set; }

		[DataMember(Name="OperationNbr", EmitDefaultValue=false)]
		public StringValue OperationNbr { get; set; }

		[DataMember(Name="Overhead", EmitDefaultValue=false)]
		public StringValue Overhead { get; set; }

		[DataMember(Name="OverheadDescription", EmitDefaultValue=false)]
		public StringValue OverheadDescription { get; set; }

		[DataMember(Name="OverheadType", EmitDefaultValue=false)]
		public StringValue OverheadType { get; set; }

		[DataMember(Name="PhantomBomID", EmitDefaultValue=false)]
		public StringValue PhantomBomID { get; set; }

		[DataMember(Name="PhantomBOMLineID", EmitDefaultValue=false)]
		public IntValue PhantomBOMLineID { get; set; }

		[DataMember(Name="PhantomBOMOperNbr", EmitDefaultValue=false)]
		public StringValue PhantomBOMOperNbr { get; set; }

		[DataMember(Name="PhantomLevel", EmitDefaultValue=false)]
		public IntValue PhantomLevel { get; set; }

		[DataMember(Name="PhantomMatlLineID", EmitDefaultValue=false)]
		public IntValue PhantomMatlLineID { get; set; }

		[DataMember(Name="PhantomMatlOperNbr", EmitDefaultValue=false)]
		public StringValue PhantomMatlOperNbr { get; set; }

		[DataMember(Name="TotalActualCost", EmitDefaultValue=false)]
		public DecimalValue TotalActualCost { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue Type { get; set; }

		[DataMember(Name="WCFlag", EmitDefaultValue=false)]
		public BooleanValue WCFlag { get; set; }

	}
}