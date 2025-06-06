using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class ProjectTaskDefaultValues : Entity_v4
	{

		[DataMember(Name="AccrualAccount", EmitDefaultValue=false)]
		public StringValue AccrualAccount { get; set; }

		[DataMember(Name="AccrualSubaccount", EmitDefaultValue=false)]
		public StringValue AccrualSubaccount { get; set; }

		[DataMember(Name="DefaultAccount", EmitDefaultValue=false)]
		public StringValue DefaultAccount { get; set; }

		[DataMember(Name="DefaultSubaccount", EmitDefaultValue=false)]
		public StringValue DefaultSubaccount { get; set; }

		[DataMember(Name="DefaultCostAccount", EmitDefaultValue=false)]
		public StringValue DefaultCostAccount { get; set; }

		[DataMember(Name="DefaultCostSubaccount", EmitDefaultValue=false)]
		public StringValue DefaultCostSubaccount { get; set; }

		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue TaxCategory { get; set; }

	}
}