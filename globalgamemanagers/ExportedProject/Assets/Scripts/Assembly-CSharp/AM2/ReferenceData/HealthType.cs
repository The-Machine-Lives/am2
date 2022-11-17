using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200032B")]
	public class HealthType : RuntimeData<RDHealthType>
	{
		[Token(Token = "0x170003EA")]
		public bool isReverse
		{
			[Token(Token = "0x6001995")]
			[Address(RVA = "0x9B4D10", Offset = "0x9B4D10", VA = "0x9B4D10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170003EB")]
		public string deadText
		{
			[Token(Token = "0x6001996")]
			[Address(RVA = "0x9B4D3C", Offset = "0x9B4D3C", VA = "0x9B4D3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001997")]
		[Address(RVA = "0x9B4D68", Offset = "0x9B4D68", VA = "0x9B4D68")]
		public HealthType()
		{
		}
	}
}
