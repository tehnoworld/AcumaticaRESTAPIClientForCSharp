using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class CheckLeadForDuplicates : EntityAction<Lead>
	{
		public CheckLeadForDuplicates(Lead entity) : base(entity)
		{ }
		public CheckLeadForDuplicates() : base()
		{ }
	}
}
