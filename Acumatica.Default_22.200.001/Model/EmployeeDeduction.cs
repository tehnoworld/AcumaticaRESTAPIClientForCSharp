using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class EmployeeDeduction : Entity_v4
	{

		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue Amount { get; set; }

		[DataMember(Name="ApplicableEarnings", EmitDefaultValue=false)]
		public StringValue ApplicableEarnings { get; set; }

		[DataMember(Name="CalculationMethod", EmitDefaultValue=false)]
		public StringValue CalculationMethod { get; set; }

		[DataMember(Name="MaximumAmount", EmitDefaultValue=false)]
		public DecimalValue MaximumAmount { get; set; }

		[DataMember(Name="MaximumFrequency", EmitDefaultValue=false)]
		public StringValue MaximumFrequency { get; set; }

		[DataMember(Name="Percent", EmitDefaultValue=false)]
		public DecimalValue Percent { get; set; }

		[DataMember(Name="ReportingTypeCA", EmitDefaultValue=false)]
		public StringValue ReportingTypeCA { get; set; }

		[DataMember(Name="ReportingTypeUS", EmitDefaultValue=false)]
		public StringValue ReportingTypeUS { get; set; }

	}
}