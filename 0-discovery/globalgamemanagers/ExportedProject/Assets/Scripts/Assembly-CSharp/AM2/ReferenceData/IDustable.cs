using Il2CppDummyDll;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000379")]
	public interface IDustable
	{
		[Token(Token = "0x170004D4")]
		string dustInputItem
		{
			[Token(Token = "0x6001B95")]
			get;
		}

		[Token(Token = "0x170004D5")]
		long dustOutputAmount
		{
			[Token(Token = "0x6001B96")]
			get;
		}

		[Token(Token = "0x6001B97")]
		bool Dust(long count);
	}
}
