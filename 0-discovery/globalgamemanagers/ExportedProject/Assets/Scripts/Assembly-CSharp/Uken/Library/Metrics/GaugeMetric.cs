using System;
using Il2CppDummyDll;

namespace Uken.Library.Metrics
{
	[Serializable]
	[Token(Token = "0x2000413")]
	public class GaugeMetric : BaseMetric
	{
		[Token(Token = "0x40012F0")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E408", Offset = "0x82E408")]
		private double _003Cgauge_value_003Ek__BackingField;

		[Token(Token = "0x170005A0")]
		public double gauge_value
		{
			[Token(Token = "0x6001EEC")]
			[Address(RVA = "0xBAB72C", Offset = "0xBAB72C", VA = "0xBAB72C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838F40", Offset = "0x838F40")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6001EED")]
			[Address(RVA = "0xBAB734", Offset = "0xBAB734", VA = "0xBAB734")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838F50", Offset = "0x838F50")]
			private set
			{
			}
		}

		[Token(Token = "0x6001EEE")]
		[Address(RVA = "0xBAB73C", Offset = "0xBAB73C", VA = "0xBAB73C")]
		public GaugeMetric(string metric, double value)
		{
		}
	}
}
