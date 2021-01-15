﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acumatica.RESTClient.Model
{
	[DataContract]
	public abstract class Entity_v4 : Entity
	{
		/// <summary>
		/// Gets or Sets Note
		/// </summary>
		[DataMember(Name = "note", EmitDefaultValue = false)]
		public StringValue Note { get; set; }
	}
}
