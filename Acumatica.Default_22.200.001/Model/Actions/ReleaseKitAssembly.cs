using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class ReleaseKitAssembly : EntityAction<KitAssembly>
	{
		public ReleaseKitAssembly(KitAssembly entity) : base(entity)
		{ }
		public ReleaseKitAssembly() : base()
		{ }
	}
}
