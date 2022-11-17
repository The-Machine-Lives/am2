using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200036D")]
	public class RuntimeUpgradablesCache : RuntimeItemModelDataCache<Upgradable, RDUpgradable>
	{
		[Token(Token = "0x40010EA")]
		[FieldOffset(Offset = "0x48")]
		private RuntimeDataCache<SubTab, RDSubTab> m_subTabs;

		[Token(Token = "0x40010EB")]
		[FieldOffset(Offset = "0x50")]
		private RuntimeDataCache<Formula, RDFormula> m_formulas;

		[Token(Token = "0x40010EC")]
		[FieldOffset(Offset = "0x58")]
		private RuntimeDataCache<Section, RDSection> m_sections;

		[Token(Token = "0x40010ED")]
		[FieldOffset(Offset = "0x60")]
		private RuntimeCostResourceCache m_costResourceCache;

		[Token(Token = "0x40010EE")]
		[FieldOffset(Offset = "0x68")]
		private Localizations m_localizationController;

		[Token(Token = "0x6001B67")]
		[Address(RVA = "0x96EF38", Offset = "0x96EF38", VA = "0x96EF38")]
		public RuntimeUpgradablesCache(DepotEntity<RDUpgradable> depot, RuntimeDataCache<SubTab, RDSubTab> subTabs, RuntimeDataCache<Formula, RDFormula> formulas, RuntimeDataCache<Section, RDSection> sections, RuntimeCostResourceCache costResourceCache)
		{
		}

		[Token(Token = "0x6001B68")]
		[Address(RVA = "0x96F0E4", Offset = "0x96F0E4", VA = "0x96F0E4", Slot = "5")]
		protected override Upgradable CreateRuntimeData(string reference, RDUpgradable refDataDocument)
		{
			return null;
		}

		[Token(Token = "0x6001B69")]
		[Address(RVA = "0x96F4B4", Offset = "0x96F4B4", VA = "0x96F4B4")]
		public List<string> GetAllUpgradablesOfType(EBuyType buyType)
		{
			return null;
		}
	}
}
