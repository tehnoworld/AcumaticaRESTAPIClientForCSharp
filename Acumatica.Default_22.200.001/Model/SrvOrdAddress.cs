using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class SrvOrdAddress : Entity_v4
	{

		[DataMember(Name="AddressLine1", EmitDefaultValue=false)]
		public StringValue AddressLine1 { get; set; }

		[DataMember(Name="AddressLine2", EmitDefaultValue=false)]
		public StringValue AddressLine2 { get; set; }

		[DataMember(Name="City", EmitDefaultValue=false)]
		public StringValue City { get; set; }

		[DataMember(Name="Country", EmitDefaultValue=false)]
		public StringValue Country { get; set; }

		[DataMember(Name="PostalCode", EmitDefaultValue=false)]
		public StringValue PostalCode { get; set; }

		[DataMember(Name="State", EmitDefaultValue=false)]
		public StringValue State { get; set; }

	}
}