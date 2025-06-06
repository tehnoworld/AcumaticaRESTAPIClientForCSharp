using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class WorkCalendarExceptionDetail : Entity_v4
	{

		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue Date { get; set; }

		[DataMember(Name="DayOfWeek", EmitDefaultValue=false)]
		public StringValue DayOfWeek { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="EndTime", EmitDefaultValue=false)]
		public DateTimeValue EndTime { get; set; }

		[DataMember(Name="StartTime", EmitDefaultValue=false)]
		public DateTimeValue StartTime { get; set; }

		[DataMember(Name="UnpaidBreakTime", EmitDefaultValue=false)]
		public StringValue UnpaidBreakTime { get; set; }

		[DataMember(Name="WorkDay", EmitDefaultValue=false)]
		public BooleanValue WorkDay { get; set; }

	}
}