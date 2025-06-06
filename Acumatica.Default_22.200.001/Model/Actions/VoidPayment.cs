using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class VoidPayment : EntityAction<Payment>
	{
		public VoidPayment(Payment entity) : base(entity)
		{ }
		public VoidPayment() : base()
		{ }
	}
}
