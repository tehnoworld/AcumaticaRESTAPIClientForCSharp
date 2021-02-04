using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class KitAssemblyAllocation : Entity_v4
	{

		[DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
		public DateTimeValue ExpirationDate { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue LineNbr { get; set; }

		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue LocationID { get; set; }

		[DataMember(Name="LotSerialNbr", EmitDefaultValue=false)]
		public StringValue LotSerialNbr { get; set; }

		[DataMember(Name="Qty", EmitDefaultValue=false)]
		public DecimalValue Qty { get; set; }

		[DataMember(Name="SplitLineNbr", EmitDefaultValue=false)]
		public IntValue SplitLineNbr { get; set; }

		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue Subitem { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue UOM { get; set; }

	}
}