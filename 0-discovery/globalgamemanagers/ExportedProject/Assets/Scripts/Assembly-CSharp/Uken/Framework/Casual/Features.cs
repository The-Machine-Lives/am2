using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004F7")]
	public class Features : DepotController
	{
		[Token(Token = "0x17000690")]
		private DepotEntity<RDFeature> m_Features
		{
			[Token(Token = "0x6002644")]
			[Address(RVA = "0xA67E44", Offset = "0xA67E44", VA = "0xA67E44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002645")]
		[Address(RVA = "0xA67FA8", Offset = "0xA67FA8", VA = "0xA67FA8")]
		public Features(CasualDataStoreController controller)
		{
		}

		[Token(Token = "0x6002646")]
		[Address(RVA = "0xA67FB0", Offset = "0xA67FB0", VA = "0xA67FB0", Slot = "10")]
		public virtual bool GetValue(string reference)
		{
			return default(bool);
		}
	}
}
