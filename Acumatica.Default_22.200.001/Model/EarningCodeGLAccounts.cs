using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class EarningCodeGLAccounts : Entity_v4
	{

		[DataMember(Name="BenefitExpenseAccount", EmitDefaultValue=false)]
		public StringValue BenefitExpenseAccount { get; set; }

		[DataMember(Name="BenefitExpenseSub", EmitDefaultValue=false)]
		public StringValue BenefitExpenseSub { get; set; }

		[DataMember(Name="EarningsAccount", EmitDefaultValue=false)]
		public StringValue EarningsAccount { get; set; }

		[DataMember(Name="EarningsSub", EmitDefaultValue=false)]
		public StringValue EarningsSub { get; set; }

		[DataMember(Name="PTOExpenseAccount", EmitDefaultValue=false)]
		public StringValue PTOExpenseAccount { get; set; }

		[DataMember(Name="PTOExpenseSub", EmitDefaultValue=false)]
		public StringValue PTOExpenseSub { get; set; }

		[DataMember(Name="TaxExpenseAccount", EmitDefaultValue=false)]
		public StringValue TaxExpenseAccount { get; set; }

		[DataMember(Name="TaxExpenseSub", EmitDefaultValue=false)]
		public StringValue TaxExpenseSub { get; set; }

	}
}