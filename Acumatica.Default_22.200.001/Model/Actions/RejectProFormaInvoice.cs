using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class RejectProFormaInvoice : EntityAction<ProFormaInvoice>
	{
		public RejectProFormaInvoice(ProFormaInvoice entity) : base(entity)
		{ }
		public RejectProFormaInvoice() : base()
		{ }
	}
}
