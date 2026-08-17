using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000365")]
	public class Regent : RuntimeData<RDRegent>
	{
		[Token(Token = "0x17000487")]
		public string itemName
		{
			[Token(Token = "0x6001AEB")]
			[Address(RVA = "0x96AFA8", Offset = "0x96AFA8", VA = "0x96AFA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000488")]
		public long quantity
		{
			[Token(Token = "0x6001AEC")]
			[Address(RVA = "0x96AFD4", Offset = "0x96AFD4", VA = "0x96AFD4")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x6001AEA")]
		[Address(RVA = "0x96AF58", Offset = "0x96AF58", VA = "0x96AF58")]
		public Regent()
		{
		}
	}
}
