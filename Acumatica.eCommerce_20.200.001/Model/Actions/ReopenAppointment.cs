using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class ReopenAppointment : EntityAction<Appointment>
	{
		public ReopenAppointment(Appointment entity) : base(entity)
		{ }
		public ReopenAppointment() : base()
		{ }
	}
}
