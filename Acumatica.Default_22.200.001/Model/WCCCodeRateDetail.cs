using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class WCCCodeRateDetail : Entity_v4
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public GuidValue Active { get; set; }

		[DataMember(Name="BenefitRate", EmitDefaultValue=false)]
		public DecimalValue BenefitRate { get; set; }

		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue Branch { get; set; }

		[DataMember(Name="DeductionRate", EmitDefaultValue=false)]
		public DecimalValue DeductionRate { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue EffectiveDate { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="WCCCode", EmitDefaultValue=false)]
		public StringValue WCCCode { get; set; }

		[DataMember(Name="WCCCodeMaxInsurableWages", EmitDefaultValue=false)]
		public List<WCCCodeMaxInsurableWageDetail> WCCCodeMaxInsurableWages { get; set; }

	}
}