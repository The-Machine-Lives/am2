using System.Collections.Generic;
using AM2;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Core;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x200049D")]
	public class AbilitiesController : UkenController
	{
		[Token(Token = "0x4001532")]
		[FieldOffset(Offset = "0x18")]
		private AM2InventoryController m_inventoryController;

		[Token(Token = "0x4001533")]
		[FieldOffset(Offset = "0x20")]
		private SharedDataCacheController m_dataCacheController;

		[Token(Token = "0x170005DD")]
		public Dictionary<string, Ability> ownedAbilities
		{
			[Token(Token = "0x60021F5")]
			[Address(RVA = "0xA1F190", Offset = "0xA1F190", VA = "0xA1F190")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60021F6")]
		[Address(RVA = "0xA1F1D8", Offset = "0xA1F1D8", VA = "0xA1F1D8")]
		public AbilitiesController(AM2InventoryController inventoryController, SharedDataCacheController dataCacheController)
		{
		}

		[Token(Token = "0x60021F7")]
		[Address(RVA = "0xA1F210", Offset = "0xA1F210", VA = "0xA1F210")]
		public bool IsItemAnAbilityAmmo(string itemRef)
		{
			return default(bool);
		}

		[Token(Token = "0x60021F8")]
		[Address(RVA = "0xA1F260", Offset = "0xA1F260", VA = "0xA1F260")]
		public Ability GetAbility(string reference)
		{
			return null;
		}

		[Token(Token = "0x60021F9")]
		[Address(RVA = "0xA1F2E8", Offset = "0xA1F2E8", VA = "0xA1F2E8", Slot = "6")]
		public override bool PostLoadContent()
		{
			return default(bool);
		}
	}
}
