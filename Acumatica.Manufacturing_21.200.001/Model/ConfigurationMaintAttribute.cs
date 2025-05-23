using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class ConfigurationMaintAttribute : Entity_v4
	{

		[DataMember(Name="AttributeID", EmitDefaultValue=false)]
		public StringValue AttributeID { get; set; }

		[DataMember(Name="ConfigurationID", EmitDefaultValue=false)]
		public StringValue ConfigurationID { get; set; }

		[DataMember(Name="DefaultValue", EmitDefaultValue=false)]
		public StringValue DefaultValue { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="Enabled", EmitDefaultValue=false)]
		public BooleanValue Enabled { get; set; }

		[DataMember(Name="IsFormula", EmitDefaultValue=false)]
		public BooleanValue IsFormula { get; set; }

		[DataMember(Name="Label", EmitDefaultValue=false)]
		public StringValue Label { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue LineNbr { get; set; }

		[DataMember(Name="Required", EmitDefaultValue=false)]
		public BooleanValue Required { get; set; }

		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue Revision { get; set; }

		[DataMember(Name="Rules", EmitDefaultValue=false)]
		public List<ConfigurationMaintAttributeRule> Rules { get; set; }

		[DataMember(Name="SortOrder", EmitDefaultValue=false)]
		public IntValue SortOrder { get; set; }

		[DataMember(Name="Variable", EmitDefaultValue=false)]
		public StringValue Variable { get; set; }

		[DataMember(Name="Visible", EmitDefaultValue=false)]
		public BooleanValue Visible { get; set; }

	}
}