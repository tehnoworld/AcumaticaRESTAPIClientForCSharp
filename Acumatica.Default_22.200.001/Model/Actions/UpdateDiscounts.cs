using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class UpdateDiscounts : EntityActionWithParameters<Discount, UpdateDiscountsParameters>
	{
		public UpdateDiscounts() : base()
		{ }
		public UpdateDiscounts(Discount entity, UpdateDiscountsParameters parameters) : base(entity, parameters)
		{ }

		public DateTimeValue Date
		{
			get { return Parameters.Date; }
			set { Parameters.Date = value; }
		}
	}
}