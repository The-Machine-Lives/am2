using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004BD")]
	public class AM2Message : RuntimeData<RDAM2Message>
	{
		[Token(Token = "0x17000600")]
		public string messageText
		{
			[Token(Token = "0x60023D3")]
			[Address(RVA = "0xA1EACC", Offset = "0xA1EACC", VA = "0xA1EACC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60023D4")]
		[Address(RVA = "0xA1EAF8", Offset = "0xA1EAF8", VA = "0xA1EAF8")]
		public AM2Message()
		{
		}
	}
}
