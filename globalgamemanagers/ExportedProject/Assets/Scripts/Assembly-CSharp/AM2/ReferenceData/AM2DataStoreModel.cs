using Il2CppDummyDll;
using Newtonsoft.Json;
using Uken.Framework.Casual;
using Uken.Library.ReferenceData;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200030E")]
	public class AM2DataStoreModel : CasualDataStoreModel
	{
		[Token(Token = "0x4000E6D")]
		public const string c_currentVersion = "1.9.3";

		[Token(Token = "0x4000E6E")]
		public const string c_metaDataItemsDepotKey = "MetaDataItems_9_3";

		[Token(Token = "0x4000E6F")]
		public const string c_userInventoryItemsDepotKey = "UserInventoryItems_9_3";

		[Token(Token = "0x4000E70")]
		public const string c_storesDepotKey = "Stores_9_3";

		[Token(Token = "0x4000E71")]
		public const string c_storeItemsDepotKey = "StoreItems_9_3";

		[Token(Token = "0x4000E72")]
		public const string c_inventoryDefaultsDepotKey = "InventoryDefaults_9_3";

		[Token(Token = "0x4000E73")]
		public const string c_iAPProductsDepotKey = "IAPProducts_9_3";

		[Token(Token = "0x4000E74")]
		public const string c_featuresDepotKey = "Features_9_3";

		[Token(Token = "0x4000E75")]
		public const string c_userSegmentsDepotKey = "UserSegments_9_3";

		[Token(Token = "0x4000E76")]
		public const string c_rewardGroupsDepotKey = "RewardGroups_9_3";

		[Token(Token = "0x4000E77")]
		public const string c_rewardsDepotKey = "Rewards_9_3";

		[Token(Token = "0x4000E78")]
		public const string c_jingotTestsDepotKey = "JingotTests_9_3";

		[Token(Token = "0x4000E79")]
		public const string c_alertsDepotKey = "Alerts_9_3";

		[Token(Token = "0x4000E7A")]
		public const string c_eventTicketItemsDepotKey = "EventTicketItems_9_3";

		[Token(Token = "0x4000E7B")]
		public const string c_localNotificationsDepotKey = "LocalNotifications_9_3";

		[Token(Token = "0x4000E7C")]
		public const string c_localNotificationEventsDepotKey = "LocalNotificationEvents_9_3";

		[Token(Token = "0x4000E7D")]
		public const string c_productsDepotKey = "Products_9_3";

		[Token(Token = "0x4000E7E")]
		public const string c_saleItemsDepotKey = "SaleItems_9_3";

		[Token(Token = "0x4000E7F")]
		public const string c_dynamicSaleItemsDepotKey = "DynamicSaleItems_9_3";

		[Token(Token = "0x4000E80")]
		public const string c_lTOSetsDepotKey = "LTOSets_9_3";

		[Token(Token = "0x4000E81")]
		public const string c_localizationsDepotKey = "Localizations_9_3";

		[Token(Token = "0x4000E82")]
		public const string c_vIPTiersDepotKey = "VIPTiers_9_3";

		[Token(Token = "0x4000E83")]
		public const string c_adConfigsDepotKey = "AdConfigs_9_3";

		[Token(Token = "0x4000E84")]
		public const string c_eventSchedulesDepotKey = "EventSchedules_9_3";

		[Token(Token = "0x4000E85")]
		public const string c_userProfileFieldsDepotKey = "UserProfileFields_9_3";

		[Token(Token = "0x4000E86")]
		public const string c_itemsDepotKey = "Items_9_3";

		[Token(Token = "0x4000E87")]
		public const string c_gameSettingsDepotKey = "GameSettings_9_3";

		[Token(Token = "0x4000E88")]
		public const string c_globalLeaderboardsDepotKey = "GlobalLeaderboards_9_3";

		[Token(Token = "0x4000E89")]
		public const string c_repeatingEventSchedulesDepotKey = "RepeatingEventSchedules_9_3";

		[Token(Token = "0x4000E8A")]
		public const string c_timeSlotDepotKey = "TimeSlots_9_3";

		[Token(Token = "0x4000E8B")]
		public const string c_recipesDepotKey = "Recipes_9_3";

		[Token(Token = "0x4000E8C")]
		public const string c_regentsDepotKey = "Regents_9_3";

		[Token(Token = "0x4000E8D")]
		public const string c_costResourcesDepotKey = "CostResources_9_3";

		[Token(Token = "0x4000E8E")]
		public const string c_formulasDepotKey = "Formulas_9_3";

		[Token(Token = "0x4000E8F")]
		public const string c_powerDepotKey = "Power_9_3";

		[Token(Token = "0x4000E90")]
		public const string c_researchSystemDepotKey = "ResearchSystem_9_3";

		[Token(Token = "0x4000E91")]
		public const string c_zonesDepotKey = "Zones_9_3";

		[Token(Token = "0x4000E92")]
		public const string c_upgradablesDepotKey = "Upgradables_9_3";

		[Token(Token = "0x4000E93")]
		public const string c_encountersDepotKey = "Encounters_9_3";

		[Token(Token = "0x4000E94")]
		public const string c_monstersDepotKey = "Monsters_9_3";

		[Token(Token = "0x4000E95")]
		public const string c_abilityGroupsDepotKey = "AbilityGroups_9_3";

		[Token(Token = "0x4000E96")]
		public const string c_abilityDepotKey = "Abilities_9_3";

		[Token(Token = "0x4000E97")]
		public const string c_buffDepotKey = "Buffs_9_3";

		[Token(Token = "0x4000E98")]
		public const string c_healthDiffDepotKey = "HealthDiff_9_3";

		[Token(Token = "0x4000E99")]
		public const string c_statusEffectStunDepotKey = "StatusEffectsStun_9_3";

		[Token(Token = "0x4000E9A")]
		public const string c_statusEffectReflectDamageDepotKey = "StatusEffectsReflectDamage_9_3";

		[Token(Token = "0x4000E9B")]
		public const string c_statusEffectStatModifierDepotKey = "StatusEffectsStatModifier_9_3";

		[Token(Token = "0x4000E9C")]
		public const string c_statusEffectImmuneToBuffDepotKey = "StatusEffectsImmuneToBuff_9_3";

		[Token(Token = "0x4000E9D")]
		public const string c_healthTypeDepotKey = "HealthTypes_9_3";

		[Token(Token = "0x4000E9E")]
		public const string c_tagsDepotKey = "Tags_9_3";

		[Token(Token = "0x4000E9F")]
		public const string c_substancesDepotKey = "Substances_9_3";

		[Token(Token = "0x4000EA0")]
		public const string c_textScenesDepotKey = "TextScenes_9_3";

		[Token(Token = "0x4000EA1")]
		public const string c_fightScenesDepotKey = "FightScenes_9_3";

		[Token(Token = "0x4000EA2")]
		public const string c_choiceScenesDepotKey = "ChoiceScenes_9_3";

		[Token(Token = "0x4000EA3")]
		public const string c_choicesDepotKey = "Choices_9_3";

		[Token(Token = "0x4000EA4")]
		public const string c_questScenesDepotKey = "QuestScenes_9_3";

		[Token(Token = "0x4000EA5")]
		public const string c_bundleScenesDepotKey = "BundleScenes_9_3";

		[Token(Token = "0x4000EA6")]
		public const string c_questSystemsDepotKey = "QuestSystems_9_3";

		[Token(Token = "0x4000EA7")]
		public const string c_eventQuestsDepotkey = "EventQuests_9_3";

		[Token(Token = "0x4000EA8")]
		public const string c_questsDepotKey = "Quests_9_3";

		[Token(Token = "0x4000EA9")]
		public const string c_tasksDepotKey = "Tasks_9_3";

		[Token(Token = "0x4000EAA")]
		public const string c_unlockersDepotKey = "Unlockers_9_3";

		[Token(Token = "0x4000EAB")]
		public const string c_conditionsDepotKey = "Conditions_9_3";

		[Token(Token = "0x4000EAC")]
		public const string c_storyLogsDepotKey = "StoryLogs_9_3";

		[Token(Token = "0x4000EAD")]
		public const string c_speedBoostersDepotKey = "SpeedBoosters_9_3";

		[Token(Token = "0x4000EAE")]
		public const string c_tabsDepotKey = "Tabs_9_3";

		[Token(Token = "0x4000EAF")]
		public const string c_subTabsDepotKey = "SubTabs_9_3";

		[Token(Token = "0x4000EB0")]
		public const string c_sectionsDepotKey = "Sections_9_3";

		[Token(Token = "0x4000EB1")]
		public const string c_itemConverterDepotKey = "ItemConverters_9_3";

		[Token(Token = "0x4000EB2")]
		public const string c_equipmentsDepotKey = "Equipments_9_3";

		[Token(Token = "0x4000EB3")]
		public const string c_equipmentEffectsDepotKey = "EquipmentEffects_9_3";

		[Token(Token = "0x4000EB4")]
		public const string c_codeButtonCombosDepotKey = "CodeButtonCombos_9_3";

		[Token(Token = "0x4000EB5")]
		public const string c_dynamicAdsDepotKey = "DynamicAds_9_3";

		[Token(Token = "0x4000EB6")]
		public const string c_am2MessageDepotKey = "AM2Message_9_3";

		[Token(Token = "0x4000EB7")]
		public const string c_speedBoosterRewardDepotKey = "SpeedBoosterReward_9_3";

		[Token(Token = "0x4000EB8")]
		public const string c_rewardScaleSetDepotKey = "RewardScaleSets_9_3";

		[Token(Token = "0x4000EB9")]
		public const string c_scaleSetEntryDepotKey = "ScaleSetEntries_9_3";

		[Token(Token = "0x4000EBA")]
		public const string c_tierDropSetDepotKey = "TierDropSets_9_3";

		[Token(Token = "0x4000EBB")]
		public const string c_tierDropRateDepotKey = "TierDropRates_9_3";

		[Token(Token = "0x4000EBC")]
		public const string c_dyesDepotKey = "Dyes_9_3";

		[Token(Token = "0x4000EBD")]
		public const string c_badgesDepotKey = "Badges_9_3";

		[Token(Token = "0x4000EBE")]
		public const string c_titlesDepotKey = "Titles_9_3";

		[Token(Token = "0x4000EBF")]
		public const string c_titleConnectorsDepotKey = "TitleConnectors_9_3";

		[Token(Token = "0x4000EC0")]
		public const string c_prestigePermanentItemsDepotKey = "PrestigePermanentItems_9_3";

		[Token(Token = "0x4000EC1")]
		public const string c_prestigeLevelUpRewardsDepotKey = "PrestigeLevelUpRewards_9_3";

		[Token(Token = "0x4000EC2")]
		public const string c_prestigeSystemDepotKey = "PrestigeSystem_9_3";

		[Token(Token = "0x4000EC3")]
		public const string c_prestigesDepotKey = "Prestiges_9_3";

		[Token(Token = "0x4000EC4")]
		public const string c_prestigeLevelDepotKey = "PrestigeLevel_9_3";

		[Token(Token = "0x4000EC5")]
		public const string c_forceClearInventoryDepotKey = "ForceClearInventory_9_3";

		[Token(Token = "0x4000EC6")]
		public const string c_creditsDepotKey = "Credits_9_3";

		[Token(Token = "0x4000EC7")]
		public const string c_miniEventDepotKey = "MiniEvent_9_3";

		[Token(Token = "0x4000EC8")]
		public const string c_lTOGroupsDepotKey = "LTOGroups_9_3";

		[Token(Token = "0x4000EC9")]
		public const string c_globalScalerDepotKey = "GlobalScaler_9_3";

		[Token(Token = "0x4000ECA")]
		public const string c_autoConversionDepotKey = "AutoConversion_9_3";

		[Token(Token = "0x4000ECB")]
		public const string c_banConditionDepotKey = "BanCondition_9_3";

		[Token(Token = "0x4000ECC")]
		public const string c_vIPStatusDepotKey = "VIPStatus_9_3";

		[Token(Token = "0x4000ECD")]
		public const string c_inboxMessageDepotKey = "InboxMessage_9_3";

		[Token(Token = "0x4000ECE")]
		[FieldOffset(Offset = "0x38")]
		public DepotEntity<RDMetaDataItem> MetaDataItems_9_3;

		[Token(Token = "0x4000ECF")]
		[FieldOffset(Offset = "0x40")]
		public DepotEntity<RDUserInventoryItem> UserInventoryItems_9_3;

		[Token(Token = "0x4000ED0")]
		[FieldOffset(Offset = "0x48")]
		public DepotEntity<RDStoreItem> StoreItems_9_3;

		[Token(Token = "0x4000ED1")]
		[FieldOffset(Offset = "0x50")]
		public DepotEntity<RDInventoryDefault> InventoryDefaults_9_3;

		[Token(Token = "0x4000ED2")]
		[FieldOffset(Offset = "0x58")]
		public DepotEntity<RDFeature> Features_9_3;

		[Token(Token = "0x4000ED3")]
		[FieldOffset(Offset = "0x60")]
		public DepotEntity<RDRewardGroup> RewardGroups_9_3;

		[Token(Token = "0x4000ED4")]
		[FieldOffset(Offset = "0x68")]
		public DepotEntity<RDReward> Rewards_9_3;

		[Token(Token = "0x4000ED5")]
		[FieldOffset(Offset = "0x70")]
		public DepotEntity<RDJingotTest> JingotTests_9_3;

		[Token(Token = "0x4000ED6")]
		[FieldOffset(Offset = "0x78")]
		public DepotEntity<RDAlert> Alerts_9_3;

		[Token(Token = "0x4000ED7")]
		[FieldOffset(Offset = "0x80")]
		public DepotEntity<RDUserSegment> UserSegments_9_3;

		[Token(Token = "0x4000ED8")]
		[FieldOffset(Offset = "0x88")]
		public DepotEntity<RDLocalNotification> LocalNotifications_9_3;

		[Token(Token = "0x4000ED9")]
		[FieldOffset(Offset = "0x90")]
		public DepotEntity<RDLocalNotificationEvent> LocalNotificationEvents_9_3;

		[Token(Token = "0x4000EDA")]
		[FieldOffset(Offset = "0x98")]
		public DepotEntity<RDEventTicketItem> EventTicketItems_9_3;

		[Token(Token = "0x4000EDB")]
		[FieldOffset(Offset = "0xA0")]
		public DepotEntity<RDSaleItem> SaleItems_9_3;

		[Token(Token = "0x4000EDC")]
		[FieldOffset(Offset = "0xA8")]
		public DepotEntity<RDDynamicSaleItem> DynamicSaleItems_9_3;

		[Token(Token = "0x4000EDD")]
		[FieldOffset(Offset = "0xB0")]
		public DepotEntity<RDProduct> Products_9_3;

		[Token(Token = "0x4000EDE")]
		[FieldOffset(Offset = "0xB8")]
		public DepotEntity<RDLTOSet> LTOSets_9_3;

		[Token(Token = "0x4000EDF")]
		[FieldOffset(Offset = "0xC0")]
		public DepotEntity<RDLocalization> Localizations_9_3;

		[Token(Token = "0x4000EE0")]
		[FieldOffset(Offset = "0xC8")]
		public DepotEntity<RDVIPTier> VIPTiers_9_3;

		[Token(Token = "0x4000EE1")]
		[FieldOffset(Offset = "0xD0")]
		public DepotEntity<RDAdConfig> AdConfigs_9_3;

		[Token(Token = "0x4000EE2")]
		[FieldOffset(Offset = "0xD8")]
		public DepotEntity<RDEventSchedule> EventSchedules_9_3;

		[Token(Token = "0x4000EE3")]
		[FieldOffset(Offset = "0xE0")]
		public DepotEntity<RDUserProfileField> UserProfileFields_9_3;

		[Token(Token = "0x4000EE4")]
		[FieldOffset(Offset = "0xE8")]
		public DepotEntity<RDItem> Items_9_3;

		[Token(Token = "0x4000EE5")]
		[FieldOffset(Offset = "0xF0")]
		public DepotEntity<RDGameSetting> GameSettings_9_3;

		[Token(Token = "0x4000EE6")]
		[FieldOffset(Offset = "0xF8")]
		public DepotEntity<RDGlobalLeaderboard> GlobalLeaderboards_9_3;

		[Token(Token = "0x4000EE7")]
		[FieldOffset(Offset = "0x100")]
		public DepotEntity<RDRepeatingEventSchedule> RepeatingEventSchedules_9_3;

		[Token(Token = "0x4000EE8")]
		[FieldOffset(Offset = "0x108")]
		public DepotEntity<RDTimeSlot> TimeSlots_9_3;

		[Token(Token = "0x4000EE9")]
		[FieldOffset(Offset = "0x110")]
		public DepotEntity<RDRecipe> Recipes_9_3;

		[Token(Token = "0x4000EEA")]
		[FieldOffset(Offset = "0x118")]
		public DepotEntity<RDRegent> Regents_9_3;

		[Token(Token = "0x4000EEB")]
		[FieldOffset(Offset = "0x120")]
		public DepotEntity<RDCostResource> CostResources_9_3;

		[Token(Token = "0x4000EEC")]
		[FieldOffset(Offset = "0x128")]
		public DepotEntity<RDFormula> Formulas_9_3;

		[Token(Token = "0x4000EED")]
		[FieldOffset(Offset = "0x130")]
		public DepotEntity<RDPower> Power_9_3;

		[Token(Token = "0x4000EEE")]
		[FieldOffset(Offset = "0x138")]
		public DepotEntity<RDResearchSystem> ResearchSystem_9_3;

		[Token(Token = "0x4000EEF")]
		[FieldOffset(Offset = "0x140")]
		public DepotEntity<RDZone> Zones_9_3;

		[Token(Token = "0x4000EF0")]
		[FieldOffset(Offset = "0x148")]
		public DepotEntity<RDUpgradable> Upgradables_9_3;

		[Token(Token = "0x4000EF1")]
		[FieldOffset(Offset = "0x150")]
		public DepotEntity<RDEncounter> Encounters_9_3;

		[Token(Token = "0x4000EF2")]
		[FieldOffset(Offset = "0x158")]
		public DepotEntity<RDMonster> Monsters_9_3;

		[Token(Token = "0x4000EF3")]
		[FieldOffset(Offset = "0x160")]
		public DepotEntity<RDAbilityGroup> AbilityGroups_9_3;

		[Token(Token = "0x4000EF4")]
		[FieldOffset(Offset = "0x168")]
		public DepotEntity<RDAbility> Abilities_9_3;

		[Token(Token = "0x4000EF5")]
		[FieldOffset(Offset = "0x170")]
		public DepotEntity<RDBuff> Buffs_9_3;

		[Token(Token = "0x4000EF6")]
		[FieldOffset(Offset = "0x178")]
		public DepotEntity<RDDiffHealth> HealthDiff_9_3;

		[Token(Token = "0x4000EF7")]
		[FieldOffset(Offset = "0x180")]
		public DepotEntity<RDStatusEffectStun> StatusEffectsStun_9_3;

		[Token(Token = "0x4000EF8")]
		[FieldOffset(Offset = "0x188")]
		public DepotEntity<RDStatusEffectReflectDamage> StatusEffectsReflectDamage_9_3;

		[Token(Token = "0x4000EF9")]
		[FieldOffset(Offset = "0x190")]
		public DepotEntity<RDStatusEffectStatModifier> StatusEffectsStatModifier_9_3;

		[Token(Token = "0x4000EFA")]
		[FieldOffset(Offset = "0x198")]
		public DepotEntity<RDStatusEffectImmuneToBuff> StatusEffectsImmuneToBuff_9_3;

		[Token(Token = "0x4000EFB")]
		[FieldOffset(Offset = "0x1A0")]
		public DepotEntity<RDHealthType> HealthTypes_9_3;

		[Token(Token = "0x4000EFC")]
		[FieldOffset(Offset = "0x1A8")]
		public DepotEntity<RDTag> Tags_9_3;

		[Token(Token = "0x4000EFD")]
		[FieldOffset(Offset = "0x1B0")]
		public DepotEntity<RDSubstance> Substances_9_3;

		[Token(Token = "0x4000EFE")]
		[FieldOffset(Offset = "0x1B8")]
		public DepotEntity<RDTextScene> TextScenes_9_3;

		[Token(Token = "0x4000EFF")]
		[FieldOffset(Offset = "0x1C0")]
		public DepotEntity<RDFightScene> FightScenes_9_3;

		[Token(Token = "0x4000F00")]
		[FieldOffset(Offset = "0x1C8")]
		public DepotEntity<RDChoiceScene> ChoiceScenes_9_3;

		[Token(Token = "0x4000F01")]
		[FieldOffset(Offset = "0x1D0")]
		public DepotEntity<RDChoice> Choices_9_3;

		[Token(Token = "0x4000F02")]
		[FieldOffset(Offset = "0x1D8")]
		public DepotEntity<RDQuestScene> QuestScenes_9_3;

		[Token(Token = "0x4000F03")]
		[FieldOffset(Offset = "0x1E0")]
		public DepotEntity<RDBundleScene> BundleScenes_9_3;

		[Token(Token = "0x4000F04")]
		[FieldOffset(Offset = "0x1E8")]
		public DepotEntity<RDQuestSystem> QuestSystems_9_3;

		[Token(Token = "0x4000F05")]
		[FieldOffset(Offset = "0x1F0")]
		public DepotEntity<RDEventQuest> EventQuests_9_3;

		[Token(Token = "0x4000F06")]
		[FieldOffset(Offset = "0x1F8")]
		public DepotEntity<RDQuest> Quests_9_3;

		[Token(Token = "0x4000F07")]
		[FieldOffset(Offset = "0x200")]
		public DepotEntity<RDTask> Tasks_9_3;

		[Token(Token = "0x4000F08")]
		[FieldOffset(Offset = "0x208")]
		public DepotEntity<RDUnlocker> Unlockers_9_3;

		[Token(Token = "0x4000F09")]
		[FieldOffset(Offset = "0x210")]
		public DepotEntity<RDCondition> Conditions_9_3;

		[Token(Token = "0x4000F0A")]
		[FieldOffset(Offset = "0x218")]
		public DepotEntity<RDStoryLog> StoryLogs_9_3;

		[Token(Token = "0x4000F0B")]
		[FieldOffset(Offset = "0x220")]
		public DepotEntity<RDSpeedBooster> SpeedBoosters_9_3;

		[Token(Token = "0x4000F0C")]
		[FieldOffset(Offset = "0x228")]
		public DepotEntity<RDTab> Tabs_9_3;

		[Token(Token = "0x4000F0D")]
		[FieldOffset(Offset = "0x230")]
		public DepotEntity<RDSubTab> SubTabs_9_3;

		[Token(Token = "0x4000F0E")]
		[FieldOffset(Offset = "0x238")]
		public DepotEntity<RDSection> Sections_9_3;

		[Token(Token = "0x4000F0F")]
		[FieldOffset(Offset = "0x240")]
		public DepotEntity<RDItemConverter> ItemConverters_9_3;

		[Token(Token = "0x4000F10")]
		[FieldOffset(Offset = "0x248")]
		public DepotEntity<RDAM2Message> AM2Message_9_3;

		[Token(Token = "0x4000F11")]
		[FieldOffset(Offset = "0x250")]
		public DepotEntity<RDSpeedBoosterReward> SpeedBoosterReward_9_3;

		[Token(Token = "0x4000F12")]
		[FieldOffset(Offset = "0x258")]
		public DepotEntity<RDEquipment> Equipments_9_3;

		[Token(Token = "0x4000F13")]
		[FieldOffset(Offset = "0x260")]
		public DepotEntity<RDEquipmentEffect> EquipmentEffects_9_3;

		[Token(Token = "0x4000F14")]
		[FieldOffset(Offset = "0x268")]
		public DepotEntity<RDCodeButtonCombo> CodeButtonCombos_9_3;

		[Token(Token = "0x4000F15")]
		[FieldOffset(Offset = "0x270")]
		public DepotEntity<RDDynamicAds> DynamicAds_9_3;

		[Token(Token = "0x4000F16")]
		[FieldOffset(Offset = "0x278")]
		public DepotEntity<RDRewardScaleSet> RewardScaleSets_9_3;

		[Token(Token = "0x4000F17")]
		[FieldOffset(Offset = "0x280")]
		public DepotEntity<RDScaleSetEntry> ScaleSetEntries_9_3;

		[Token(Token = "0x4000F18")]
		[FieldOffset(Offset = "0x288")]
		public DepotEntity<RDTierDropSet> TierDropSets_9_3;

		[Token(Token = "0x4000F19")]
		[FieldOffset(Offset = "0x290")]
		public DepotEntity<RDTierDropRate> TierDropRates_9_3;

		[Token(Token = "0x4000F1A")]
		[FieldOffset(Offset = "0x298")]
		public DepotEntity<RDDye> Dyes_9_3;

		[Token(Token = "0x4000F1B")]
		[FieldOffset(Offset = "0x2A0")]
		public DepotEntity<RDBadge> Badges_9_3;

		[Token(Token = "0x4000F1C")]
		[FieldOffset(Offset = "0x2A8")]
		public DepotEntity<RDTitle> Titles_9_3;

		[Token(Token = "0x4000F1D")]
		[FieldOffset(Offset = "0x2B0")]
		public DepotEntity<RDTitleConnector> TitleConnectors_9_3;

		[Token(Token = "0x4000F1E")]
		[FieldOffset(Offset = "0x2B8")]
		public DepotEntity<RDPrestigePermanentItems> PrestigePermanentItems_9_3;

		[Token(Token = "0x4000F1F")]
		[FieldOffset(Offset = "0x2C0")]
		public DepotEntity<RDPrestigeLevelUpRewards> PrestigeLevelUpRewards_9_3;

		[Token(Token = "0x4000F20")]
		[FieldOffset(Offset = "0x2C8")]
		public DepotEntity<RDPrestigeSystem> PrestigeSystem_9_3;

		[Token(Token = "0x4000F21")]
		[FieldOffset(Offset = "0x2D0")]
		public DepotEntity<RDPrestiges> Prestiges_9_3;

		[Token(Token = "0x4000F22")]
		[FieldOffset(Offset = "0x2D8")]
		public DepotEntity<RDPrestigeLevel> PrestigeLevel_9_3;

		[Token(Token = "0x4000F23")]
		[FieldOffset(Offset = "0x2E0")]
		public DepotEntity<RDForceClearInventory> ForceClearInventory_9_3;

		[Token(Token = "0x4000F24")]
		[FieldOffset(Offset = "0x2E8")]
		public DepotEntity<RDCredits> Credits_9_3;

		[Token(Token = "0x4000F25")]
		[FieldOffset(Offset = "0x2F0")]
		public DepotEntity<RDMiniEvent> MiniEvent_9_3;

		[Token(Token = "0x4000F26")]
		[FieldOffset(Offset = "0x2F8")]
		public DepotEntity<RDLTOGroups> LTOGroups_9_3;

		[Token(Token = "0x4000F27")]
		[FieldOffset(Offset = "0x300")]
		public DepotEntity<RDGlobalScaler> GlobalScaler_9_3;

		[Token(Token = "0x4000F28")]
		[FieldOffset(Offset = "0x308")]
		public DepotEntity<RDAutoConversion> AutoConversion_9_3;

		[Token(Token = "0x4000F29")]
		[FieldOffset(Offset = "0x310")]
		public DepotEntity<RDBanCondition> BanCondition_9_3;

		[Token(Token = "0x4000F2A")]
		[FieldOffset(Offset = "0x318")]
		public DepotEntity<RDVIPStatus> VIPStatus_9_3;

		[Token(Token = "0x4000F2B")]
		[FieldOffset(Offset = "0x320")]
		public DepotEntity<RDInboxMessage> InboxMessage_9_3;

		[Token(Token = "0x17000349")]
		public override DepotEntity<RDRewardGroup> RewardGroups
		{
			[Token(Token = "0x600188A")]
			[Address(RVA = "0x9A7038", Offset = "0x9A7038", VA = "0x9A7038", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700034A")]
		public override DepotEntity<RDReward> Rewards
		{
			[Token(Token = "0x600188B")]
			[Address(RVA = "0x9A7040", Offset = "0x9A7040", VA = "0x9A7040", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700034B")]
		public override DepotEntity<RDJingotTest> JingotTests
		{
			[Token(Token = "0x600188C")]
			[Address(RVA = "0x9A7048", Offset = "0x9A7048", VA = "0x9A7048", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700034C")]
		public override DepotEntity<RDAlert> Alerts
		{
			[Token(Token = "0x600188D")]
			[Address(RVA = "0x9A7050", Offset = "0x9A7050", VA = "0x9A7050", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700034D")]
		public override DepotEntity<RDUserSegment> UserSegments
		{
			[Token(Token = "0x600188E")]
			[Address(RVA = "0x9A7058", Offset = "0x9A7058", VA = "0x9A7058", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700034E")]
		public override DepotEntity<RDLocalNotification> LocalNotifications
		{
			[Token(Token = "0x600188F")]
			[Address(RVA = "0x9A7060", Offset = "0x9A7060", VA = "0x9A7060", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700034F")]
		public override DepotEntity<RDLocalNotificationEvent> LocalNotificationEvents
		{
			[Token(Token = "0x6001890")]
			[Address(RVA = "0x9A7068", Offset = "0x9A7068", VA = "0x9A7068", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000350")]
		public override DepotEntity<RDEventTicketItem> EventTicketItems
		{
			[Token(Token = "0x6001891")]
			[Address(RVA = "0x9A7070", Offset = "0x9A7070", VA = "0x9A7070", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000351")]
		public override DepotEntity<RDFeature> Features
		{
			[Token(Token = "0x6001892")]
			[Address(RVA = "0x9A7078", Offset = "0x9A7078", VA = "0x9A7078", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000352")]
		public override DepotEntity<RDLTOSet> LTOSets
		{
			[Token(Token = "0x6001893")]
			[Address(RVA = "0x9A7080", Offset = "0x9A7080", VA = "0x9A7080", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000353")]
		public override DepotEntity<RDLocalization> Localizations
		{
			[Token(Token = "0x6001894")]
			[Address(RVA = "0x9A7088", Offset = "0x9A7088", VA = "0x9A7088", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000354")]
		public override DepotEntity<RDVIPTier> VIPTiers
		{
			[Token(Token = "0x6001895")]
			[Address(RVA = "0x9A7090", Offset = "0x9A7090", VA = "0x9A7090", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000355")]
		public override DepotEntity<RDStoreItem> StoreItems
		{
			[Token(Token = "0x6001896")]
			[Address(RVA = "0x9A7098", Offset = "0x9A7098", VA = "0x9A7098", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000356")]
		public override DepotEntity<RDAdConfig> AdConfigs
		{
			[Token(Token = "0x6001897")]
			[Address(RVA = "0x9A70A0", Offset = "0x9A70A0", VA = "0x9A70A0", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000357")]
		public override DepotEntity<RDEventSchedule> EventSchedules
		{
			[Token(Token = "0x6001898")]
			[Address(RVA = "0x9A70A8", Offset = "0x9A70A8", VA = "0x9A70A8", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000358")]
		public override DepotEntity<RDUserProfileField> UserProfileFields
		{
			[Token(Token = "0x6001899")]
			[Address(RVA = "0x9A70B0", Offset = "0x9A70B0", VA = "0x9A70B0", Slot = "30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000359")]
		public override DepotEntity<RDItem> CasualItems
		{
			[Token(Token = "0x600189A")]
			[Address(RVA = "0x9A70B8", Offset = "0x9A70B8", VA = "0x9A70B8", Slot = "31")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700035A")]
		public override DepotEntity<RDGameSetting> CasualGameSettings
		{
			[Token(Token = "0x600189B")]
			[Address(RVA = "0x9A70C0", Offset = "0x9A70C0", VA = "0x9A70C0", Slot = "32")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700035B")]
		public override DepotEntity<RDRepeatingEventSchedule> RepeatingEventSchedules
		{
			[Token(Token = "0x600189C")]
			[Address(RVA = "0x9A70C8", Offset = "0x9A70C8", VA = "0x9A70C8", Slot = "28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700035C")]
		[JsonIgnore]
		public DepotEntity<RDGlobalLeaderboard> GlobalLeaderboards
		{
			[Token(Token = "0x600189D")]
			[Address(RVA = "0x9A70D0", Offset = "0x9A70D0", VA = "0x9A70D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700035D")]
		[JsonIgnore]
		public DepotEntity<RDTimeSlot> timeSlots
		{
			[Token(Token = "0x600189E")]
			[Address(RVA = "0x9A70D8", Offset = "0x9A70D8", VA = "0x9A70D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700035E")]
		[JsonIgnore]
		public DepotEntity<RDInventoryDefault> InventoryDefaults
		{
			[Token(Token = "0x600189F")]
			[Address(RVA = "0x9A70E0", Offset = "0x9A70E0", VA = "0x9A70E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700035F")]
		[JsonIgnore]
		public DepotEntity<RDProduct> Products
		{
			[Token(Token = "0x60018A0")]
			[Address(RVA = "0x9A70E8", Offset = "0x9A70E8", VA = "0x9A70E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000360")]
		[JsonIgnore]
		public DepotEntity<RDRewardScaleSet> rewardScaleSets
		{
			[Token(Token = "0x60018A1")]
			[Address(RVA = "0x9A70F0", Offset = "0x9A70F0", VA = "0x9A70F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000361")]
		[JsonIgnore]
		public DepotEntity<RDScaleSetEntry> scaleSetEntries
		{
			[Token(Token = "0x60018A2")]
			[Address(RVA = "0x9A70F8", Offset = "0x9A70F8", VA = "0x9A70F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000362")]
		[JsonIgnore]
		public DepotEntity<RDTierDropSet> tierDropSets
		{
			[Token(Token = "0x60018A3")]
			[Address(RVA = "0x9A7100", Offset = "0x9A7100", VA = "0x9A7100")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000363")]
		[JsonIgnore]
		public DepotEntity<RDTierDropRate> tierDropRates
		{
			[Token(Token = "0x60018A4")]
			[Address(RVA = "0x9A7108", Offset = "0x9A7108", VA = "0x9A7108")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000364")]
		[JsonIgnore]
		public DepotEntity<RDRecipe> recipes
		{
			[Token(Token = "0x60018A5")]
			[Address(RVA = "0x9A7110", Offset = "0x9A7110", VA = "0x9A7110")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000365")]
		[JsonIgnore]
		public DepotEntity<RDRegent> regents
		{
			[Token(Token = "0x60018A6")]
			[Address(RVA = "0x9A7118", Offset = "0x9A7118", VA = "0x9A7118")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000366")]
		[JsonIgnore]
		public DepotEntity<RDCostResource> costResources
		{
			[Token(Token = "0x60018A7")]
			[Address(RVA = "0x9A7120", Offset = "0x9A7120", VA = "0x9A7120")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000367")]
		[JsonIgnore]
		public DepotEntity<RDFormula> formulas
		{
			[Token(Token = "0x60018A8")]
			[Address(RVA = "0x9A7128", Offset = "0x9A7128", VA = "0x9A7128")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000368")]
		[JsonIgnore]
		public DepotEntity<RDPower> power
		{
			[Token(Token = "0x60018A9")]
			[Address(RVA = "0x9A7130", Offset = "0x9A7130", VA = "0x9A7130")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000369")]
		[JsonIgnore]
		public DepotEntity<RDResearchSystem> researchSystem
		{
			[Token(Token = "0x60018AA")]
			[Address(RVA = "0x9A7138", Offset = "0x9A7138", VA = "0x9A7138")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700036A")]
		[JsonIgnore]
		public DepotEntity<RDZone> zones
		{
			[Token(Token = "0x60018AB")]
			[Address(RVA = "0x9A7140", Offset = "0x9A7140", VA = "0x9A7140")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700036B")]
		[JsonIgnore]
		public DepotEntity<RDUpgradable> upgradables
		{
			[Token(Token = "0x60018AC")]
			[Address(RVA = "0x9A7148", Offset = "0x9A7148", VA = "0x9A7148")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700036C")]
		[JsonIgnore]
		public DepotEntity<RDEncounter> encounters
		{
			[Token(Token = "0x60018AD")]
			[Address(RVA = "0x9A7150", Offset = "0x9A7150", VA = "0x9A7150")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700036D")]
		[JsonIgnore]
		public DepotEntity<RDMonster> monsters
		{
			[Token(Token = "0x60018AE")]
			[Address(RVA = "0x9A7158", Offset = "0x9A7158", VA = "0x9A7158")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700036E")]
		[JsonIgnore]
		public DepotEntity<RDAbilityGroup> abilityGroups
		{
			[Token(Token = "0x60018AF")]
			[Address(RVA = "0x9A7160", Offset = "0x9A7160", VA = "0x9A7160")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700036F")]
		[JsonIgnore]
		public DepotEntity<RDAbility> abilities
		{
			[Token(Token = "0x60018B0")]
			[Address(RVA = "0x9A7168", Offset = "0x9A7168", VA = "0x9A7168")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000370")]
		[JsonIgnore]
		public DepotEntity<RDBuff> buffs
		{
			[Token(Token = "0x60018B1")]
			[Address(RVA = "0x9A7170", Offset = "0x9A7170", VA = "0x9A7170")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000371")]
		[JsonIgnore]
		public DepotEntity<RDDiffHealth> healthDiffs
		{
			[Token(Token = "0x60018B2")]
			[Address(RVA = "0x9A7178", Offset = "0x9A7178", VA = "0x9A7178")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000372")]
		[JsonIgnore]
		public DepotEntity<RDStatusEffectStun> statusEffectsStun
		{
			[Token(Token = "0x60018B3")]
			[Address(RVA = "0x9A7180", Offset = "0x9A7180", VA = "0x9A7180")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000373")]
		[JsonIgnore]
		public DepotEntity<RDStatusEffectReflectDamage> statusEffectsReflectDamage
		{
			[Token(Token = "0x60018B4")]
			[Address(RVA = "0x9A7188", Offset = "0x9A7188", VA = "0x9A7188")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000374")]
		[JsonIgnore]
		public DepotEntity<RDStatusEffectStatModifier> statusEffectsStatModifier
		{
			[Token(Token = "0x60018B5")]
			[Address(RVA = "0x9A7190", Offset = "0x9A7190", VA = "0x9A7190")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000375")]
		[JsonIgnore]
		public DepotEntity<RDStatusEffectImmuneToBuff> statusEffectsImmuneToBuff
		{
			[Token(Token = "0x60018B6")]
			[Address(RVA = "0x9A7198", Offset = "0x9A7198", VA = "0x9A7198")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000376")]
		[JsonIgnore]
		public DepotEntity<RDHealthType> healthTypes
		{
			[Token(Token = "0x60018B7")]
			[Address(RVA = "0x9A71A0", Offset = "0x9A71A0", VA = "0x9A71A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000377")]
		[JsonIgnore]
		public DepotEntity<RDTag> tags
		{
			[Token(Token = "0x60018B8")]
			[Address(RVA = "0x9A71A8", Offset = "0x9A71A8", VA = "0x9A71A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000378")]
		[JsonIgnore]
		public DepotEntity<RDSubstance> substances
		{
			[Token(Token = "0x60018B9")]
			[Address(RVA = "0x9A71B0", Offset = "0x9A71B0", VA = "0x9A71B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000379")]
		[JsonIgnore]
		public DepotEntity<RDTextScene> textScenes
		{
			[Token(Token = "0x60018BA")]
			[Address(RVA = "0x9A71B8", Offset = "0x9A71B8", VA = "0x9A71B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700037A")]
		[JsonIgnore]
		public DepotEntity<RDFightScene> fightScenes
		{
			[Token(Token = "0x60018BB")]
			[Address(RVA = "0x9A71C0", Offset = "0x9A71C0", VA = "0x9A71C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700037B")]
		[JsonIgnore]
		public DepotEntity<RDChoiceScene> choiceScenes
		{
			[Token(Token = "0x60018BC")]
			[Address(RVA = "0x9A71C8", Offset = "0x9A71C8", VA = "0x9A71C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700037C")]
		[JsonIgnore]
		public DepotEntity<RDChoice> choices
		{
			[Token(Token = "0x60018BD")]
			[Address(RVA = "0x9A71D0", Offset = "0x9A71D0", VA = "0x9A71D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700037D")]
		[JsonIgnore]
		public DepotEntity<RDQuestScene> questScenes
		{
			[Token(Token = "0x60018BE")]
			[Address(RVA = "0x9A71D8", Offset = "0x9A71D8", VA = "0x9A71D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700037E")]
		[JsonIgnore]
		public DepotEntity<RDBundleScene> bundleScenes
		{
			[Token(Token = "0x60018BF")]
			[Address(RVA = "0x9A71E0", Offset = "0x9A71E0", VA = "0x9A71E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700037F")]
		[JsonIgnore]
		public DepotEntity<RDQuestSystem> questSystems
		{
			[Token(Token = "0x60018C0")]
			[Address(RVA = "0x9A71E8", Offset = "0x9A71E8", VA = "0x9A71E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000380")]
		[JsonIgnore]
		public DepotEntity<RDEventQuest> eventQuests
		{
			[Token(Token = "0x60018C1")]
			[Address(RVA = "0x9A71F0", Offset = "0x9A71F0", VA = "0x9A71F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000381")]
		[JsonIgnore]
		public DepotEntity<RDQuest> quests
		{
			[Token(Token = "0x60018C2")]
			[Address(RVA = "0x9A71F8", Offset = "0x9A71F8", VA = "0x9A71F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000382")]
		[JsonIgnore]
		public DepotEntity<RDTask> tasks
		{
			[Token(Token = "0x60018C3")]
			[Address(RVA = "0x9A7200", Offset = "0x9A7200", VA = "0x9A7200")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000383")]
		[JsonIgnore]
		public DepotEntity<RDUnlocker> unlockers
		{
			[Token(Token = "0x60018C4")]
			[Address(RVA = "0x9A7208", Offset = "0x9A7208", VA = "0x9A7208")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000384")]
		[JsonIgnore]
		public DepotEntity<RDCondition> conditions
		{
			[Token(Token = "0x60018C5")]
			[Address(RVA = "0x9A7210", Offset = "0x9A7210", VA = "0x9A7210")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000385")]
		[JsonIgnore]
		public DepotEntity<RDStoryLog> storyLogs
		{
			[Token(Token = "0x60018C6")]
			[Address(RVA = "0x9A7218", Offset = "0x9A7218", VA = "0x9A7218")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000386")]
		[JsonIgnore]
		public DepotEntity<RDSpeedBooster> speedBoosters
		{
			[Token(Token = "0x60018C7")]
			[Address(RVA = "0x9A7220", Offset = "0x9A7220", VA = "0x9A7220")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000387")]
		[JsonIgnore]
		public DepotEntity<RDTab> tabs
		{
			[Token(Token = "0x60018C8")]
			[Address(RVA = "0x9A7228", Offset = "0x9A7228", VA = "0x9A7228")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000388")]
		[JsonIgnore]
		public DepotEntity<RDSubTab> subTabs
		{
			[Token(Token = "0x60018C9")]
			[Address(RVA = "0x9A7230", Offset = "0x9A7230", VA = "0x9A7230")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000389")]
		[JsonIgnore]
		public DepotEntity<RDSection> sections
		{
			[Token(Token = "0x60018CA")]
			[Address(RVA = "0x9A7238", Offset = "0x9A7238", VA = "0x9A7238")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700038A")]
		[JsonIgnore]
		public DepotEntity<RDItemConverter> itemConverters
		{
			[Token(Token = "0x60018CB")]
			[Address(RVA = "0x9A7240", Offset = "0x9A7240", VA = "0x9A7240")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700038B")]
		[JsonIgnore]
		public DepotEntity<RDAM2Message> am2Message
		{
			[Token(Token = "0x60018CC")]
			[Address(RVA = "0x9A7248", Offset = "0x9A7248", VA = "0x9A7248")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700038C")]
		[JsonIgnore]
		public DepotEntity<RDSpeedBoosterReward> speedBoosterRewards
		{
			[Token(Token = "0x60018CD")]
			[Address(RVA = "0x9A7250", Offset = "0x9A7250", VA = "0x9A7250")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700038D")]
		[JsonIgnore]
		public DepotEntity<RDForceClearInventory> forceClearInventory
		{
			[Token(Token = "0x60018CE")]
			[Address(RVA = "0x9A7258", Offset = "0x9A7258", VA = "0x9A7258")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700038E")]
		[JsonIgnore]
		public DepotEntity<RDEquipment> equipments
		{
			[Token(Token = "0x60018CF")]
			[Address(RVA = "0x9A7260", Offset = "0x9A7260", VA = "0x9A7260")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700038F")]
		[JsonIgnore]
		public DepotEntity<RDEquipmentEffect> equipmentEffects
		{
			[Token(Token = "0x60018D0")]
			[Address(RVA = "0x9A7268", Offset = "0x9A7268", VA = "0x9A7268")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000390")]
		[JsonIgnore]
		public DepotEntity<RDCodeButtonCombo> codeButtonCombos
		{
			[Token(Token = "0x60018D1")]
			[Address(RVA = "0x9A7270", Offset = "0x9A7270", VA = "0x9A7270")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000391")]
		[JsonIgnore]
		public DepotEntity<RDDynamicAds> dynamicAds
		{
			[Token(Token = "0x60018D2")]
			[Address(RVA = "0x9A7278", Offset = "0x9A7278", VA = "0x9A7278")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000392")]
		[JsonIgnore]
		public DepotEntity<RDDye> dyes
		{
			[Token(Token = "0x60018D3")]
			[Address(RVA = "0x9A7280", Offset = "0x9A7280", VA = "0x9A7280")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000393")]
		[JsonIgnore]
		public DepotEntity<RDBadge> badges
		{
			[Token(Token = "0x60018D4")]
			[Address(RVA = "0x9A7288", Offset = "0x9A7288", VA = "0x9A7288")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000394")]
		[JsonIgnore]
		public DepotEntity<RDTitle> titles
		{
			[Token(Token = "0x60018D5")]
			[Address(RVA = "0x9A7290", Offset = "0x9A7290", VA = "0x9A7290")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000395")]
		[JsonIgnore]
		public DepotEntity<RDTitleConnector> titleConnectors
		{
			[Token(Token = "0x60018D6")]
			[Address(RVA = "0x9A7298", Offset = "0x9A7298", VA = "0x9A7298")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000396")]
		[JsonIgnore]
		public DepotEntity<RDPrestigePermanentItems> prestigePermanentItems
		{
			[Token(Token = "0x60018D7")]
			[Address(RVA = "0x9A72A0", Offset = "0x9A72A0", VA = "0x9A72A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000397")]
		[JsonIgnore]
		public DepotEntity<RDPrestigeLevelUpRewards> prestigeLevelUpRewards
		{
			[Token(Token = "0x60018D8")]
			[Address(RVA = "0x9A72A8", Offset = "0x9A72A8", VA = "0x9A72A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000398")]
		[JsonIgnore]
		public DepotEntity<RDPrestigeSystem> prestigeSystem
		{
			[Token(Token = "0x60018D9")]
			[Address(RVA = "0x9A72B0", Offset = "0x9A72B0", VA = "0x9A72B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000399")]
		[JsonIgnore]
		public DepotEntity<RDPrestiges> prestiges
		{
			[Token(Token = "0x60018DA")]
			[Address(RVA = "0x9A72B8", Offset = "0x9A72B8", VA = "0x9A72B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700039A")]
		[JsonIgnore]
		public DepotEntity<RDPrestigeLevel> prestigeLevel
		{
			[Token(Token = "0x60018DB")]
			[Address(RVA = "0x9A72C0", Offset = "0x9A72C0", VA = "0x9A72C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700039B")]
		[JsonIgnore]
		public DepotEntity<RDCredits> credits
		{
			[Token(Token = "0x60018DC")]
			[Address(RVA = "0x9A72C8", Offset = "0x9A72C8", VA = "0x9A72C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700039C")]
		[JsonIgnore]
		public DepotEntity<RDMiniEvent> miniEvent
		{
			[Token(Token = "0x60018DD")]
			[Address(RVA = "0x9A72D0", Offset = "0x9A72D0", VA = "0x9A72D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700039D")]
		public DepotEntity<RDLTOGroups> lTOGroups
		{
			[Token(Token = "0x60018DE")]
			[Address(RVA = "0x9A72D8", Offset = "0x9A72D8", VA = "0x9A72D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700039E")]
		[JsonIgnore]
		public DepotEntity<RDGlobalScaler> globalScaler
		{
			[Token(Token = "0x60018DF")]
			[Address(RVA = "0x9A72E0", Offset = "0x9A72E0", VA = "0x9A72E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700039F")]
		[JsonIgnore]
		public DepotEntity<RDAutoConversion> autoConversion
		{
			[Token(Token = "0x60018E0")]
			[Address(RVA = "0x9A72E8", Offset = "0x9A72E8", VA = "0x9A72E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003A0")]
		[JsonIgnore]
		public DepotEntity<RDBanCondition> banConditions
		{
			[Token(Token = "0x60018E1")]
			[Address(RVA = "0x9A72F0", Offset = "0x9A72F0", VA = "0x9A72F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003A1")]
		[JsonIgnore]
		public DepotEntity<RDVIPStatus> vIPStatus
		{
			[Token(Token = "0x60018E2")]
			[Address(RVA = "0x9A72F8", Offset = "0x9A72F8", VA = "0x9A72F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003A2")]
		[JsonIgnore]
		public DepotEntity<RDInboxMessage> inboxMessage
		{
			[Token(Token = "0x60018E3")]
			[Address(RVA = "0x9A7300", Offset = "0x9A7300", VA = "0x9A7300")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60018E4")]
		[Address(RVA = "0x9A7308", Offset = "0x9A7308", VA = "0x9A7308")]
		public AM2DataStoreModel()
		{
		}

		[Token(Token = "0x60018E5")]
		[Address(RVA = "0x9A9734", Offset = "0x9A9734", VA = "0x9A9734", Slot = "4")]
		public override bool OnDataStoreUpdated(StoreModel newDataStore, DataSource dataSource)
		{
			return default(bool);
		}

		[Token(Token = "0x60018E6")]
		[Address(RVA = "0x9A9468", Offset = "0x9A9468", VA = "0x9A9468")]
		protected void RefreshMultiReferenceDepots()
		{
		}
	}
}
