using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000374")]
	public class ForceClearInventory : RuntimeData<RDForceClearInventory>
	{
		[Token(Token = "0x6001B7F")]
		[Address(RVA = "0x9B306C", Offset = "0x9B306C", VA = "0x9B306C")]
		public bool ShouldForceClearInventory(string previousVersionString)
		{
			return default(bool);
		}

		[Token(Token = "0x6001B80")]
		[Address(RVA = "0x9B3188", Offset = "0x9B3188", VA = "0x9B3188")]
		public bool WasPreviousVersionBeta(string previousVersionString)
		{
			return default(bool);
		}

		[Token(Token = "0x6001B81")]
		[Address(RVA = "0x9B327C", Offset = "0x9B327C", VA = "0x9B327C")]
		public ForceClearInventory()
		{
		}
	}
}
