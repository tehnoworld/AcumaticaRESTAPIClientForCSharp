using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.Manufacturing_21_200_001.Model;

namespace Acumatica.Manufacturing_21_200_001.Api
{
	public class ConfigurationFeatureApi : BaseEndpointApi<ConfigurationFeature>
	{
		public ConfigurationFeatureApi(Configuration configuration) : base(configuration)
		{ }
	}
}