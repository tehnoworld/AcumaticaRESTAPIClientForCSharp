using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class ReleaseSalesPriceWorksheet : EntityAction<SalesPriceWorksheet>
	{
		public ReleaseSalesPriceWorksheet(SalesPriceWorksheet entity) : base(entity)
		{ }
		public ReleaseSalesPriceWorksheet() : base()
		{ }
	}
}
