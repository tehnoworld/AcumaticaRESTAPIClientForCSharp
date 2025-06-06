using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class ConvertBusinessAccountToCustomer : EntityAction<BusinessAccount>
	{
		public ConvertBusinessAccountToCustomer(BusinessAccount entity) : base(entity)
		{ }
		public ConvertBusinessAccountToCustomer() : base()
		{ }
	}
}
