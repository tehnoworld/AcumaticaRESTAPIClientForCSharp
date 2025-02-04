using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class WipAdjustmentEntry : Entity_v4
	{

		[DataMember(Name="BatchNbr", EmitDefaultValue=false)]
		public StringValue BatchNbr { get; set; }

		[DataMember(Name="ControlAmount", EmitDefaultValue=false)]
		public DecimalValue ControlAmount { get; set; }

		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue Date { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<WipAdjustmentEntryDetail> Details { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue Hold { get; set; }

		[DataMember(Name="OrigBatchNbr", EmitDefaultValue=false)]
		public StringValue OrigBatchNbr { get; set; }

		[DataMember(Name="OrigDocType", EmitDefaultValue=false)]
		public StringValue OrigDocType { get; set; }

		[DataMember(Name="PostPeriod", EmitDefaultValue=false)]
		public StringValue PostPeriod { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

		[DataMember(Name="TotalAmount", EmitDefaultValue=false)]
		public DecimalValue TotalAmount { get; set; }

	}
}