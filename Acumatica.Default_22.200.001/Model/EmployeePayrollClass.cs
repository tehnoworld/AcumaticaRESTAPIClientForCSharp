using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class EmployeePayrollClass : Entity_v4
	{

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="EmployeePayrollClassID", EmitDefaultValue=false)]
		public StringValue EmployeePayrollClassID { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="PayrollDefaults", EmitDefaultValue=false)]
		public EmployeePayrollClassDefaults PayrollDefaults { get; set; }

		[DataMember(Name="PTODefaults", EmitDefaultValue=false)]
		public List<EmployeeClassPTOBankDefault> PTODefaults { get; set; }

	}
}