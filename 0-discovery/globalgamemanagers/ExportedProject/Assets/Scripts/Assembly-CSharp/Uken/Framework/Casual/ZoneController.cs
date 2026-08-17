using System.Collections.Generic;
using AM2;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Library.Inventory;
using Uken.Library.Observe;
using Uken.Library.ReferenceData;
using Uken.Library.UkenTime;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004A3")]
	public class ZoneController : DepotController, IInventoryProgressTracker
	{
		[Token(Token = "0x4001543")]
		public const long c_infiniteAmmoCount = 9999L;

		[Token(Token = "0x4001544")]
		public const string c_zoneUINotificationKey = "zone";

		[Token(Token = "0x4001545")]
		[FieldOffset(Offset = "0x20")]
		private RuntimeZonesCache m_zonesCache;

		[Token(Token = "0x4001546")]
		[FieldOffset(Offset = "0x28")]
		private RuntimeEncountersCache m_encountersCache;

		[Token(Token = "0x4001547")]
		[FieldOffset(Offset = "0x30")]
		private RuntimeMonstersCache m_monstersCache;

		[Token(Token = "0x4001548")]
		[FieldOffset(Offset = "0x38")]
		private RuntimeDataCache<HealthType, RDHealthType> m_healthTypesCache;

		[Token(Token = "0x4001549")]
		[FieldOffset(Offset = "0x40")]
		private RuntimeDataCache<Substance, RDSubstance> m_substancesCache;

		[Token(Token = "0x400154A")]
		[FieldOffset(Offset = "0x48")]
		private ActionSceneRuntimeDataCache<TextScene, RDTextScene> m_textSceneCache;

		[Token(Token = "0x400154B")]
		[FieldOffset(Offset = "0x50")]
		private RuntimeFightScenesCache m_fightSceneCache;

		[Token(Token = "0x400154C")]
		[FieldOffset(Offset = "0x58")]
		private RuntimeChoiceScenesCache m_choiceSceneCache;

		[Token(Token = "0x400154D")]
		[FieldOffset(Offset = "0x60")]
		private ActionSceneRuntimeDataCache<QuestScene, RDQuestScene> m_questSceneCache;

		[Token(Token = "0x400154E")]
		[FieldOffset(Offset = "0x68")]
		private ActionSceneRuntimeDataCache<BundleScene, RDBundleScene> m_bundleSceneCache;

		[Token(Token = "0x400154F")]
		[FieldOffset(Offset = "0x70")]
		protected UkenObservable<BattleReport> m_battleLogObservable;

		[Token(Token = "0x4001550")]
		[FieldOffset(Offset = "0x78")]
		private AM2InventoryController m_inventoryController;

		[Token(Token = "0x4001551")]
		[FieldOffset(Offset = "0x80")]
		private UkenTimeController m_timeController;

		[Token(Token = "0x4001552")]
		[FieldOffset(Offset = "0x88")]
		private RewardGroupsController m_rewardGroupController;

		[Token(Token = "0x4001553")]
		[FieldOffset(Offset = "0x90")]
		private Localizations m_localizationController;

		[Token(Token = "0x4001554")]
		[FieldOffset(Offset = "0x98")]
		private FTUEController m_ftueController;

		[Token(Token = "0x4001555")]
		[FieldOffset(Offset = "0xA0")]
		private AbilitiesController m_abilitiesController;

		[Token(Token = "0x4001556")]
		[FieldOffset(Offset = "0xA8")]
		private LoadoutController m_loadoutController;

		[Token(Token = "0x4001557")]
		[FieldOffset(Offset = "0xB0")]
		private UIAlertController m_uiAlertController;

		[Token(Token = "0x4001558")]
		[FieldOffset(Offset = "0xB8")]
		private SharedDataCacheController m_dataCacheController;

		[Token(Token = "0x4001559")]
		[FieldOffset(Offset = "0xC0")]
		private CasualAnalog m_analogController;

		[Token(Token = "0x400155A")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EA9C", Offset = "0x82EA9C")]
		private ZoneState _003CcurrentZoneState_003Ek__BackingField;

		[Token(Token = "0x400155B")]
		[FieldOffset(Offset = "0xD0")]
		private List<string> m_oneTimeRewards;

		[Token(Token = "0x170005E4")]
		public ZoneState currentZoneState
		{
			[Token(Token = "0x600220D")]
			[Address(RVA = "0xAE7F10", Offset = "0xAE7F10", VA = "0xAE7F10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839594", Offset = "0x839594")]
			get
			{
				return null;
			}
			[Token(Token = "0x600220E")]
			[Address(RVA = "0xAE7F18", Offset = "0xAE7F18", VA = "0xAE7F18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8395A4", Offset = "0x8395A4")]
			private set
			{
			}
		}

		[Token(Token = "0x170005E5")]
		public long playerHealth
		{
			[Token(Token = "0x600220F")]
			[Address(RVA = "0xAE7F20", Offset = "0xAE7F20", VA = "0xAE7F20")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6002210")]
			[Address(RVA = "0xAE7F34", Offset = "0xAE7F34", VA = "0xAE7F34")]
			set
			{
			}
		}

		[Token(Token = "0x170005E6")]
		public long playerMaxHealth
		{
			[Token(Token = "0x6002211")]
			[Address(RVA = "0xAE7F48", Offset = "0xAE7F48", VA = "0xAE7F48")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170005E7")]
		public List<Encounter> currentZoneEncounters
		{
			[Token(Token = "0x6002212")]
			[Address(RVA = "0xAE7F78", Offset = "0xAE7F78", VA = "0xAE7F78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002213")]
		[Address(RVA = "0xAE7FC0", Offset = "0xAE7FC0", VA = "0xAE7FC0")]
		public ZoneController(CasualDataStoreController dataController, AM2InventoryController inventoryController, UkenTimeController timeController, RewardGroupsController rewardGroupController, Localizations localizationController, FTUEController ftueController, LoadoutController loadoutController, UIAlertController uiAlertController, SharedDataCacheController dataCacheController, CasualAnalog analogController)
		{
		}

		[Token(Token = "0x6002214")]
		[Address(RVA = "0xAE80C8", Offset = "0xAE80C8", VA = "0xAE80C8", Slot = "9")]
		public override void OnDataUpdated()
		{
		}

		[Token(Token = "0x6002215")]
		[Address(RVA = "0xAE8A74", Offset = "0xAE8A74", VA = "0xAE8A74", Slot = "6")]
		public override bool PostLoadContent()
		{
			return default(bool);
		}

		[Token(Token = "0x6002216")]
		[Address(RVA = "0xAE8D74", Offset = "0xAE8D74", VA = "0xAE8D74")]
		public UkenUnsubscriber<BattleReport> SubscribeToBattleLog(IUkenObserver<BattleReport> observer)
		{
			return null;
		}

		[Token(Token = "0x6002217")]
		[Address(RVA = "0xAE8DE8", Offset = "0xAE8DE8", VA = "0xAE8DE8")]
		public List<Encounter> GetAllEncountersFromBundleScene(BundleScene bundleScene)
		{
			return null;
		}

		[Token(Token = "0x6002218")]
		[Address(RVA = "0xAE8E74", Offset = "0xAE8E74", VA = "0xAE8E74")]
		public Encounter GetEncounter(string key)
		{
			return null;
		}

		[Token(Token = "0x6002219")]
		[Address(RVA = "0xAE8EE4", Offset = "0xAE8EE4", VA = "0xAE8EE4")]
		public Dictionary<string, Zone> GetResearchableZones()
		{
			return null;
		}

		[Token(Token = "0x600221A")]
		[Address(RVA = "0xAE8F44", Offset = "0xAE8F44", VA = "0xAE8F44")]
		public bool IsPlayerAlive()
		{
			return default(bool);
		}

		[Token(Token = "0x600221B")]
		[Address(RVA = "0xAE8F6C", Offset = "0xAE8F6C", VA = "0xAE8F6C")]
		private void RemoveGivenOrDuplicateOneTimeRewards(List<Reward> rewards)
		{
		}

		[Token(Token = "0x600221C")]
		[Address(RVA = "0xAE9188", Offset = "0xAE9188", VA = "0xAE9188")]
		public void AddRewards(List<Reward> rewards)
		{
		}

		[Token(Token = "0x600221D")]
		[Address(RVA = "0xAE9588", Offset = "0xAE9588", VA = "0xAE9588")]
		public void AddRewardForMonster(Monster monster)
		{
		}

		[Token(Token = "0x600221E")]
		[Address(RVA = "0xAE93E8", Offset = "0xAE93E8", VA = "0xAE93E8")]
		public void AddRewardReport(Localizations localizationController, string readableName, long amount)
		{
		}

		[Token(Token = "0x600221F")]
		[Address(RVA = "0xAE9694", Offset = "0xAE9694", VA = "0xAE9694")]
		public void AddReport(EBattleReportType reportType, string report)
		{
		}

		[Token(Token = "0x6002220")]
		[Address(RVA = "0xAE88E8", Offset = "0xAE88E8", VA = "0xAE88E8")]
		private Dictionary<string, IActionScene> GetAllActionScenes()
		{
			return null;
		}

		[Token(Token = "0x6002221")]
		[Address(RVA = "0xAE9754", Offset = "0xAE9754", VA = "0xAE9754")]
		public ChoiceScene GetChoiceScene(string reference)
		{
			return null;
		}

		[Token(Token = "0x6002222")]
		[Address(RVA = "0xAE97C4", Offset = "0xAE97C4", VA = "0xAE97C4", Slot = "10")]
		public void TrackProgress(string reference, long delta, ItemMinimalDetails itemDetails)
		{
		}

		[Token(Token = "0x6002223")]
		[Address(RVA = "0xAE988C", Offset = "0xAE988C", VA = "0xAE988C")]
		public Dictionary<string, Zone> GetAvailableZones()
		{
			return null;
		}

		[Token(Token = "0x6002224")]
		[Address(RVA = "0xAE98BC", Offset = "0xAE98BC", VA = "0xAE98BC")]
		public Dictionary<string, Zone> GetUnlockedZones()
		{
			return null;
		}

		[Token(Token = "0x6002225")]
		[Address(RVA = "0xAE991C", Offset = "0xAE991C", VA = "0xAE991C")]
		public Zone GetZone(string reference)
		{
			return null;
		}

		[Token(Token = "0x6002226")]
		[Address(RVA = "0xAE998C", Offset = "0xAE998C", VA = "0xAE998C")]
		public int GetStepIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6002227")]
		[Address(RVA = "0xAE99BC", Offset = "0xAE99BC", VA = "0xAE99BC")]
		public void IncrementStep()
		{
		}

		[Token(Token = "0x6002228")]
		[Address(RVA = "0xAE9A1C", Offset = "0xAE9A1C", VA = "0xAE9A1C")]
		public InitZoneStateResult PayForZoneAndInitState(string zoneReference)
		{
			return default(InitZoneStateResult);
		}

		[Token(Token = "0x6002229")]
		[Address(RVA = "0xAE9E7C", Offset = "0xAE9E7C", VA = "0xAE9E7C")]
		public void CreateZoneState(Zone inZone)
		{
		}

		[Token(Token = "0x600222A")]
		[Address(RVA = "0xAE9F08", Offset = "0xAE9F08", VA = "0xAE9F08")]
		public void AwardAndFinalizeZone()
		{
		}

		[Token(Token = "0x600222B")]
		[Address(RVA = "0xAEA330", Offset = "0xAEA330", VA = "0xAEA330")]
		public void ClearZone()
		{
		}

		[Token(Token = "0x600222C")]
		[Address(RVA = "0xAEA338", Offset = "0xAEA338", VA = "0xAEA338")]
		public long GetAmmoForAbility(string constructionItemReference)
		{
			return default(long);
		}

		[Token(Token = "0x600222D")]
		[Address(RVA = "0xAEA3E4", Offset = "0xAEA3E4", VA = "0xAEA3E4")]
		public long GetAmmoForAbility(Ability ability)
		{
			return default(long);
		}

		[Token(Token = "0x600222E")]
		[Address(RVA = "0xAEA4BC", Offset = "0xAEA4BC", VA = "0xAEA4BC")]
		public void DecrementAmmoForAbility(Ability ability)
		{
		}

		[Token(Token = "0x600222F")]
		[Address(RVA = "0xAEA720", Offset = "0xAEA720", VA = "0xAEA720")]
		public Tag GetTag(string key)
		{
			return null;
		}

		[Token(Token = "0x6002230")]
		[Address(RVA = "0xAEA0A8", Offset = "0xAEA0A8", VA = "0xAEA0A8")]
		private void LogZoneStats()
		{
		}

		[Token(Token = "0x6002231")]
		[Address(RVA = "0xAEA7A8", Offset = "0xAEA7A8", VA = "0xAEA7A8")]
		public void SetZoneResearchLocked(string zoneRef)
		{
		}
	}
}
