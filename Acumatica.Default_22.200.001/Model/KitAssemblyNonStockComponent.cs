using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class KitAssemblyNonStockComponent : Entity_v4
	{

		[DataMember(Name="ComponentQty", EmitDefaultValue=false)]
		public DecimalValue ComponentQty { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue LineNbr { get; set; }

		[DataMember(Name="NonStockInventoryID", EmitDefaultValue=false)]
		public StringValue NonStockInventoryID { get; set; }

		[DataMember(Name="Qty", EmitDefaultValue=false)]
		public DecimalValue Qty { get; set; }

		[DataMember(Name="ReasonCode", EmitDefaultValue=false)]
		public StringValue ReasonCode { get; set; }

		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue UnitCost { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue UOM { get; set; }

	}
}