using System.Collections.Generic;
using AM2;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Core;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004A5")]
	public class AutomaticConversionController : UkenController
	{
		[Token(Token = "0x400156B")]
		private const string c_automaticConversionEvent = "auto_conversion";

		[Token(Token = "0x400156C")]
		[FieldOffset(Offset = "0x18")]
		private SharedDataCacheController m_dataCacheController;

		[Token(Token = "0x400156D")]
		[FieldOffset(Offset = "0x20")]
		private AM2InventoryController m_inventoryController;

		[Token(Token = "0x600224C")]
		[Address(RVA = "0xA255E0", Offset = "0xA255E0", VA = "0xA255E0")]
		public AutomaticConversionController(SharedDataCacheController dataCacheController, AM2InventoryController inventoryController)
		{
		}

		[Token(Token = "0x600224D")]
		[Address(RVA = "0xA25618", Offset = "0xA25618", VA = "0xA25618", Slot = "6")]
		public override bool PostLoadContent()
		{
			return default(bool);
		}

		[Token(Token = "0x600224E")]
		[Address(RVA = "0xA25630", Offset = "0xA25630", VA = "0xA25630")]
		private void PerformConversions()
		{
		}

		[Token(Token = "0x600224F")]
		[Address(RVA = "0xA256F0", Offset = "0xA256F0", VA = "0xA256F0")]
		private List<AutoConversion> GetSortedAutoConversions()
		{
			return null;
		}

		[Token(Token = "0x6002250")]
		[Address(RVA = "0xA25790", Offset = "0xA25790", VA = "0xA25790")]
		private void PerformConversion(AutoConversion conversion)
		{
		}
	}
}
