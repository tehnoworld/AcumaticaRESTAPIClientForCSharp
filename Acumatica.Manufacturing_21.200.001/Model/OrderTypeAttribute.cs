using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class OrderTypeAttribute : Entity_v4
	{

		[DataMember(Name="AttributeID", EmitDefaultValue=false)]
		public StringValue AttributeID { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="Enabled", EmitDefaultValue=false)]
		public BooleanValue Enabled { get; set; }

		[DataMember(Name="Label", EmitDefaultValue=false)]
		public StringValue Label { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue LineNbr { get; set; }

		[DataMember(Name="TransactionRequired", EmitDefaultValue=false)]
		public BooleanValue TransactionRequired { get; set; }

		[DataMember(Name="Value", EmitDefaultValue=false)]
		public StringValue Value { get; set; }

	}
}