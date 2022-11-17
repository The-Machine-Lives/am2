using Il2CppDummyDll;

namespace Com.Uken.Analog
{
	[Token(Token = "0x200000F")]
	[Attribute(Name = "JsonConverterAttribute", RVA = "0x813ADC", Offset = "0x813ADC")]
	public enum AdStatus
	{
		[Token(Token = "0x4000040")]
		success = 0,
		[Token(Token = "0x4000041")]
		cancel = 1,
		[Token(Token = "0x4000042")]
		fail = 2
	}
}
