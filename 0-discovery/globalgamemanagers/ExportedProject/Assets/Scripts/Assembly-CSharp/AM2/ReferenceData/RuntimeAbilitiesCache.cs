using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Inventory;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000320")]
	public class RuntimeAbilitiesCache : RuntimeItemModelDataCache<Ability, RDAbility>
	{
		[Token(Token = "0x4000F94")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<string, IAbilityEffect> m_allAbilityEffects;

		[Token(Token = "0x4000F95")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x827E44", Offset = "0x827E44")]
		private Dictionary<string, Ability> _003CownedAbilities_003Ek__BackingField;

		[Token(Token = "0x4000F96")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<string, List<Ability>> m_abilitiesByAmmo;

		[Token(Token = "0x170003E1")]
		public Dictionary<string, Ability> ownedAbilities
		{
			[Token(Token = "0x600196D")]
			[Address(RVA = "0x96B834", Offset = "0x96B834", VA = "0x96B834")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837BF0", Offset = "0x837BF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600196E")]
			[Address(RVA = "0x96B83C", Offset = "0x96B83C", VA = "0x96B83C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837C00", Offset = "0x837C00")]
			private set
			{
			}
		}

		[Token(Token = "0x600196F")]
		[Address(RVA = "0x96B844", Offset = "0x96B844", VA = "0x96B844")]
		public RuntimeAbilitiesCache(DepotEntity<RDAbility> depot, Dictionary<string, IAbilityEffect> allAbilityEffects, InventoryController inventoryController)
		{
		}

		[Token(Token = "0x6001970")]
		[Address(RVA = "0x96B91C", Offset = "0x96B91C", VA = "0x96B91C", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6001971")]
		[Address(RVA = "0x96BC2C", Offset = "0x96BC2C", VA = "0x96BC2C")]
		public bool IsItemAnAbilityAmmo(string itemRef)
		{
			return default(bool);
		}

		[Token(Token = "0x6001972")]
		[Address(RVA = "0x96BC9C", Offset = "0x96BC9C", VA = "0x96BC9C")]
		public List<Ability> GetAllAbilitiesForAmmo(string itemRef)
		{
			return null;
		}

		[Token(Token = "0x6001973")]
		[Address(RVA = "0x96BD4C", Offset = "0x96BD4C", VA = "0x96BD4C", Slot = "5")]
		protected override Ability CreateRuntimeData(string reference, RDAbility refDataDocument)
		{
			return null;
		}

		[Token(Token = "0x6001974")]
		[Address(RVA = "0x96BE44", Offset = "0x96BE44", VA = "0x96BE44")]
		public void OnAcquireAbility(Ability ability)
		{
		}

		[Token(Token = "0x6001975")]
		[Address(RVA = "0x96BF50", Offset = "0x96BF50", VA = "0x96BF50")]
		public void OnUnAcquireAbility(Ability ability)
		{
		}

		[Token(Token = "0x6001976")]
		[Address(RVA = "0x96C018", Offset = "0x96C018", VA = "0x96C018", Slot = "7")]
		public override Dictionary<string, ItemMinimalDetails> GetAllItemDetails()
		{
			return null;
		}
	}
}
