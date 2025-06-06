using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class ActivateProjectTemplate : EntityAction<ProjectTemplate>
	{
		public ActivateProjectTemplate(ProjectTemplate entity) : base(entity)
		{ }
		public ActivateProjectTemplate() : base()
		{ }
	}
}
