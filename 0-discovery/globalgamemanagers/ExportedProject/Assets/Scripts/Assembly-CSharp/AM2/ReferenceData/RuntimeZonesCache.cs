using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000335")]
	public class RuntimeZonesCache : RuntimeResearchableDataCache<Zone, RDZone, ZoneItem>
	{
		[Token(Token = "0x4000FD0")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x828814", Offset = "0x828814")]
		private Dictionary<string, Zone> _003CavailableZones_003Ek__BackingField;

		[Token(Token = "0x4000FD1")]
		[FieldOffset(Offset = "0x80")]
		protected RuntimeDataCache<Encounter, RDEncounter> m_encountersCache;

		[Token(Token = "0x1700040C")]
		public Dictionary<string, Zone> availableZones
		{
			[Token(Token = "0x60019CC")]
			[Address(RVA = "0x96F6C4", Offset = "0x96F6C4", VA = "0x96F6C4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837CB0", Offset = "0x837CB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60019CD")]
			[Address(RVA = "0x96F6CC", Offset = "0x96F6CC", VA = "0x96F6CC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837CC0", Offset = "0x837CC0")]
			private set
			{
			}
		}

		[Token(Token = "0x60019CE")]
		[Address(RVA = "0x96F6D4", Offset = "0x96F6D4", VA = "0x96F6D4")]
		public RuntimeZonesCache(DepotEntity<RDZone> depot, RuntimeDataCache<Encounter, RDEncounter> encountersCache, RuntimeDataCache<RewardGroup, RDRewardGroup> rewardGroupsCache, RuntimeDataCache<SubTab, RDSubTab> subtabCache, RuntimeDataCache<Section, RDSection> sectionCache, RuntimeCostResourceCache costResourceCache)
		{
		}

		[Token(Token = "0x60019CF")]
		[Address(RVA = "0x96F7BC", Offset = "0x96F7BC", VA = "0x96F7BC", Slot = "12")]
		public override void OnAcquire(string zoneRef)
		{
		}

		[Token(Token = "0x60019D0")]
		[Address(RVA = "0x96F890", Offset = "0x96F890", VA = "0x96F890", Slot = "13")]
		public override void OnUnacquire(string zoneRef)
		{
		}

		[Token(Token = "0x60019D1")]
		[Address(RVA = "0x96F918", Offset = "0x96F918", VA = "0x96F918", Slot = "5")]
		protected override Zone CreateRuntimeData(string reference, RDZone refDataDocument)
		{
			return null;
		}
	}
}
