/* 
 * Default/18.200.001
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * OpenAPI spec version: 3
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using Newtonsoft.Json;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace Acumatica.DefaultEndpoint_18_200_001.Model
{
    /// <summary>
    /// ConfirmShipment
    /// </summary>
    [DataContract]
    public partial class ConfirmShipment : EntityAction<Shipment>
    {
        public ConfirmShipment(Shipment entity) : base(entity)
        { }

        [DataMember(Name = "entity", EmitDefaultValue = false)]
        public Shipment Entity
        {
            get
            {
                return _Entity;
            }
            set
            {
                _Entity = value;
            }
        }
    }
}
