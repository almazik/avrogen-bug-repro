// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen, version 1.11.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Test.Avro
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class ReproduceType : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"ReproduceType\",\"namespace\":\"Test.Avro\",\"fields\":[{\"name\"" +
				":\"EnumJustToCheck\",\"type\":{\"type\":\"enum\",\"name\":\"EnumJustToCheck\",\"namespace\":\"T" +
				"est.Avro\",\"symbols\":[\"One\",\"Two\"]}}]}");
		private Test.Avro.EnumJustToCheck _EnumJustToCheck;
		public virtual Schema Schema
		{
			get
			{
				return ReproduceType._SCHEMA;
			}
		}
		public Test.Avro.EnumJustToCheck EnumJustToCheck
		{
			get
			{
				return this._EnumJustToCheck;
			}
			set
			{
				this._EnumJustToCheck = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.EnumJustToCheck;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.EnumJustToCheck = (Test.Avro.EnumJustToCheck)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
