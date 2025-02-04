using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class TaxAndReportingUS : Entity_v4
	{

		[DataMember(Name="ReportingType", EmitDefaultValue=false)]
		public StringValue ReportingType { get; set; }

		[DataMember(Name="SubjecttoTaxes", EmitDefaultValue=false)]
		public StringValue SubjecttoTaxes { get; set; }

		[DataMember(Name="TaxDetailsUS", EmitDefaultValue=false)]
		public List<EarningCodeTaxDetailUS> TaxDetailsUS { get; set; }

		[DataMember(Name="WageType", EmitDefaultValue=false)]
		public StringValue WageType { get; set; }

	}
}