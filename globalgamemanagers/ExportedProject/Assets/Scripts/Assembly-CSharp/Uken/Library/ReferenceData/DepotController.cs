using Il2CppDummyDll;
using Uken.Core;

namespace Uken.Library.ReferenceData
{
	[Token(Token = "0x200046F")]
	public class DepotController : UkenController
	{
		[Token(Token = "0x400148B")]
		[FieldOffset(Offset = "0x18")]
		protected DataStoreController m_dataStoreController;

		[Token(Token = "0x600210C")]
		[Address(RVA = "0xB303D0", Offset = "0xB303D0", VA = "0xB303D0")]
		public DepotController(DataStoreController dataStoreController)
		{
		}
	}
}
