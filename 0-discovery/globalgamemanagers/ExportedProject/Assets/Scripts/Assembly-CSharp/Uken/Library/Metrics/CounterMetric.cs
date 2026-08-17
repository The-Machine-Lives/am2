using Il2CppDummyDll;

namespace Uken.Library.Metrics
{
	[Token(Token = "0x2000412")]
	public class CounterMetric : BaseMetric
	{
		[Token(Token = "0x40012EF")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E3F8", Offset = "0x82E3F8")]
		private double _003Cdelta_003Ek__BackingField;

		[Token(Token = "0x1700059F")]
		public double delta
		{
			[Token(Token = "0x6001EE8")]
			[Address(RVA = "0xBAB6CC", Offset = "0xBAB6CC", VA = "0xBAB6CC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838F20", Offset = "0x838F20")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6001EE9")]
			[Address(RVA = "0xBAB6D4", Offset = "0xBAB6D4", VA = "0xBAB6D4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838F30", Offset = "0x838F30")]
			private set
			{
			}
		}

		[Token(Token = "0x6001EEA")]
		[Address(RVA = "0xBAB6DC", Offset = "0xBAB6DC", VA = "0xBAB6DC")]
		public CounterMetric(string metric, double delta)
		{
		}

		[Token(Token = "0x6001EEB")]
		[Address(RVA = "0xBAB718", Offset = "0xBAB718", VA = "0xBAB718")]
		public void Increment(int delta)
		{
		}
	}
}
