using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x20003B5")]
	public class InventoryDefaults : DepotController
	{
		[Token(Token = "0x1700055F")]
		private DepotEntity<RDInventoryDefault> m_InventoryDefaults
		{
			[Token(Token = "0x6001CA4")]
			[Address(RVA = "0x9B51FC", Offset = "0x9B51FC", VA = "0x9B51FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001CA3")]
		[Address(RVA = "0x9B51F4", Offset = "0x9B51F4", VA = "0x9B51F4")]
		public InventoryDefaults(AM2DataStoreController controller)
		{
		}

		[Token(Token = "0x6001CA5")]
		[Address(RVA = "0x9B5360", Offset = "0x9B5360", VA = "0x9B5360")]
		public List<RDInventoryDefault> GetInventoryItems()
		{
			return null;
		}
	}
}
