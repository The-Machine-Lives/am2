using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000509")]
	public class JingotTests : DepotController
	{
		[Token(Token = "0x1700069F")]
		private DepotEntity<RDJingotTest> m_jingotTests
		{
			[Token(Token = "0x600268E")]
			[Address(RVA = "0xA6BE08", Offset = "0xA6BE08", VA = "0xA6BE08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600268D")]
		[Address(RVA = "0xA6BE00", Offset = "0xA6BE00", VA = "0xA6BE00")]
		public JingotTests(DataStoreController dataController)
		{
		}

		[Token(Token = "0x600268F")]
		[Address(RVA = "0xA6BEC8", Offset = "0xA6BEC8", VA = "0xA6BEC8", Slot = "9")]
		public override void OnDataUpdated()
		{
		}
	}
}
