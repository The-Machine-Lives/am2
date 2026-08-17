using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000330")]
	public class Substance : RuntimeData<RDSubstance>
	{
		[Token(Token = "0x170003F7")]
		public string readableName
		{
			[Token(Token = "0x60019AC")]
			[Address(RVA = "0x970F9C", Offset = "0x970F9C", VA = "0x970F9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60019AD")]
		[Address(RVA = "0x970FC8", Offset = "0x970FC8", VA = "0x970FC8")]
		public Substance()
		{
		}
	}
}
