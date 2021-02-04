using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class PutOnHoldExpenseReceipt : EntityAction<ExpenseReceipt>
	{
		public PutOnHoldExpenseReceipt(ExpenseReceipt entity) : base(entity)
		{ }
		public PutOnHoldExpenseReceipt() : base()
		{ }
	}
}
