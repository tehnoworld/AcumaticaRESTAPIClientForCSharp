using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class Tool : Entity_v4
	{

		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue Account { get; set; }

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue Active { get; set; }

		[DataMember(Name="ConsumedCost", EmitDefaultValue=false)]
		public DecimalValue ConsumedCost { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="Schedule", EmitDefaultValue=false)]
		public BooleanValue Schedule { get; set; }

		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue Subaccount { get; set; }

		[DataMember(Name="ToolID", EmitDefaultValue=false)]
		public StringValue ToolID { get; set; }

		[DataMember(Name="TotalCost", EmitDefaultValue=false)]
		public DecimalValue TotalCost { get; set; }

		[DataMember(Name="TotalScheduleQty", EmitDefaultValue=false)]
		public IntValue TotalScheduleQty { get; set; }

		[DataMember(Name="TotalUses", EmitDefaultValue=false)]
		public DecimalValue TotalUses { get; set; }

		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue UnitCost { get; set; }

	}
}