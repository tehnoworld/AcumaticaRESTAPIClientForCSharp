using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class ConfigurationMaintFeatureRule : Entity_v4
	{

		[DataMember(Name="ConfigurationID", EmitDefaultValue=false)]
		public StringValue ConfigurationID { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue LineNbr { get; set; }

		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue Revision { get; set; }

		[DataMember(Name="Rule", EmitDefaultValue=false)]
		public StringValue Rule { get; set; }

		[DataMember(Name="RuleSource", EmitDefaultValue=false)]
		public StringValue RuleSource { get; set; }

		[DataMember(Name="SourceLineNbr", EmitDefaultValue=false)]
		public IntValue SourceLineNbr { get; set; }

		[DataMember(Name="SourceOption", EmitDefaultValue=false)]
		public StringValue SourceOption { get; set; }

		[DataMember(Name="TargetFeature", EmitDefaultValue=false)]
		public StringValue TargetFeature { get; set; }

		[DataMember(Name="TargetOption", EmitDefaultValue=false)]
		public StringValue TargetOption { get; set; }

	}
}