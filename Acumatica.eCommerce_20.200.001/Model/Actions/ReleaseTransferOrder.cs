using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class ReleaseTransferOrder : EntityAction<TransferOrder>
	{
		public ReleaseTransferOrder(TransferOrder entity) : base(entity)
		{ }
		public ReleaseTransferOrder() : base()
		{ }
	}
}
