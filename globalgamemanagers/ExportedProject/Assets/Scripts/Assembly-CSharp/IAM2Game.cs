using System;
using AM2;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Framework.Casual.Leaderboards;
using Uken.Library.AID;
using Uken.Library.IAP;
using Uken.Library.Inventory;
using Uken.Library.Jingot;
using Uken.Library.ReferenceData;
using Uken.Library.UkenTime;
using Utilities;

[Token(Token = "0x200009D")]
public interface IAM2Game
{
	[Token(Token = "0x1700005A")]
	SharedDataCacheController dataCacheController
	{
		[Token(Token = "0x6000345")]
		get;
	}

	[Token(Token = "0x1700005B")]
	UkenAuth authenticator
	{
		[Token(Token = "0x6000346")]
		get;
	}

	[Token(Token = "0x1700005C")]
	JingotController jingot
	{
		[Token(Token = "0x6000347")]
		get;
	}

	[Token(Token = "0x1700005D")]
	AM2InventoryController am2InventoryController
	{
		[Token(Token = "0x6000348")]
		get;
	}

	[Token(Token = "0x1700005E")]
	InventoryController inventoryController
	{
		[Token(Token = "0x6000349")]
		get;
	}

	[Token(Token = "0x1700005F")]
	UkenTimeController timeController
	{
		[Token(Token = "0x600034A")]
		get;
	}

	[Token(Token = "0x17000060")]
	Localizations localizationController
	{
		[Token(Token = "0x600034B")]
		get;
	}

	[Token(Token = "0x17000061")]
	NetworkStatusCentre networkStatus
	{
		[Token(Token = "0x600034C")]
		get;
	}

	[Token(Token = "0x17000062")]
	AM2SoundController audioController
	{
		[Token(Token = "0x600034D")]
		get;
	}

	[Token(Token = "0x17000063")]
	CasualEnvironment environment
	{
		[Token(Token = "0x600034E")]
		get;
	}

	[Token(Token = "0x17000064")]
	AIDController aid
	{
		[Token(Token = "0x600034F")]
		get;
	}

	[Token(Token = "0x17000065")]
	LeaderboardController leaderboardController
	{
		[Token(Token = "0x6000350")]
		get;
	}

	[Token(Token = "0x17000066")]
	GlobalLeaderboardController globalLeaderboardController
	{
		[Token(Token = "0x6000351")]
		get;
	}

	[Token(Token = "0x17000067")]
	UIAlertController uiAlertController
	{
		[Token(Token = "0x6000352")]
		get;
	}

	[Token(Token = "0x17000068")]
	ConstructionController constructionController
	{
		[Token(Token = "0x6000353")]
		get;
	}

	[Token(Token = "0x17000069")]
	FTUEController ftueController
	{
		[Token(Token = "0x6000354")]
		get;
	}

	[Token(Token = "0x1700006A")]
	PowerController powerController
	{
		[Token(Token = "0x6000355")]
		get;
	}

	[Token(Token = "0x1700006B")]
	ResearchController researchController
	{
		[Token(Token = "0x6000356")]
		get;
	}

	[Token(Token = "0x1700006C")]
	RecipeController recipeController
	{
		[Token(Token = "0x6000357")]
		get;
	}

	[Token(Token = "0x1700006D")]
	RecipeDifferentialController recipeDifferentialController
	{
		[Token(Token = "0x6000358")]
		get;
	}

	[Token(Token = "0x1700006E")]
	ZoneController zoneController
	{
		[Token(Token = "0x6000359")]
		get;
	}

	[Token(Token = "0x1700006F")]
	QuestController questController
	{
		[Token(Token = "0x600035A")]
		get;
	}

	[Token(Token = "0x17000070")]
	StoryLogController storyLogController
	{
		[Token(Token = "0x600035B")]
		get;
	}

	[Token(Token = "0x17000071")]
	LoadoutController loadoutController
	{
		[Token(Token = "0x600035C")]
		get;
	}

	[Token(Token = "0x17000072")]
	AbilitiesController abilitiesController
	{
		[Token(Token = "0x600035D")]
		get;
	}

	[Token(Token = "0x17000073")]
	OfflineGenerationController offlineGenerationController
	{
		[Token(Token = "0x600035E")]
		get;
	}

	[Token(Token = "0x17000074")]
	AM2TextDisplayController textDisplayController
	{
		[Token(Token = "0x600035F")]
		get;
	}

	[Token(Token = "0x17000075")]
	ActionController actionController
	{
		[Token(Token = "0x6000360")]
		get;
	}

	[Token(Token = "0x17000076")]
	UpdatesController updatesController
	{
		[Token(Token = "0x6000361")]
		get;
	}

	[Token(Token = "0x17000077")]
	ObjectPoolController objectPoolController
	{
		[Token(Token = "0x6000362")]
		get;
	}

	[Token(Token = "0x17000078")]
	SpeedBoosterController speedBoosterController
	{
		[Token(Token = "0x6000363")]
		get;
	}

	[Token(Token = "0x17000079")]
	ItemConverterController itemConverterController
	{
		[Token(Token = "0x6000364")]
		get;
	}

	[Token(Token = "0x1700007A")]
	EquipmentController equipmentController
	{
		[Token(Token = "0x6000365")]
		get;
	}

	[Token(Token = "0x1700007B")]
	CodeButtonController codeButtonController
	{
		[Token(Token = "0x6000366")]
		get;
	}

	[Token(Token = "0x1700007C")]
	AM2MessageController am2MessageController
	{
		[Token(Token = "0x6000367")]
		get;
	}

	[Token(Token = "0x1700007D")]
	ProfilePageController profilePageController
	{
		[Token(Token = "0x6000368")]
		get;
	}

	[Token(Token = "0x1700007E")]
	PrestigeController prestigeController
	{
		[Token(Token = "0x6000369")]
		get;
	}

	[Token(Token = "0x1700007F")]
	AutoBanController autoBanController
	{
		[Token(Token = "0x600036A")]
		get;
	}

	[Token(Token = "0x17000080")]
	AutomaticConversionController autoConversionController
	{
		[Token(Token = "0x600036B")]
		get;
	}

	[Token(Token = "0x17000081")]
	CasualAnalog analogController
	{
		[Token(Token = "0x600036C")]
		get;
	}

	[Token(Token = "0x17000082")]
	Features features
	{
		[Token(Token = "0x600036D")]
		get;
	}

	[Token(Token = "0x17000083")]
	UserSegments userSegments
	{
		[Token(Token = "0x600036E")]
		get;
	}

	[Token(Token = "0x17000084")]
	VIPStatusController vipStatusController
	{
		[Token(Token = "0x600036F")]
		get;
	}

	[Token(Token = "0x17000085")]
	MiniEventController miniEventController
	{
		[Token(Token = "0x6000370")]
		get;
	}

	[Token(Token = "0x17000086")]
	AdConfigs adConfigs
	{
		[Token(Token = "0x6000381")]
		get;
	}

	[Token(Token = "0x17000087")]
	AdsController adController
	{
		[Token(Token = "0x6000382")]
		get;
	}

	[Token(Token = "0x17000088")]
	DynamicAdsController dynamicAdsController
	{
		[Token(Token = "0x6000383")]
		get;
	}

	[Token(Token = "0x17000089")]
	RewardGroupsController rewardGroupsController
	{
		[Token(Token = "0x6000384")]
		get;
	}

	[Token(Token = "0x1700008A")]
	Stores stores
	{
		[Token(Token = "0x6000385")]
		get;
	}

	[Token(Token = "0x1700008B")]
	UkenPaymentProvider paymentProvider
	{
		[Token(Token = "0x6000386")]
		get;
	}

	[Token(Token = "0x1700008C")]
	BIAdjust adjust
	{
		[Token(Token = "0x6000387")]
		get;
	}

	[Token(Token = "0x1700008D")]
	CasualDataCacheController casualDataCacheController
	{
		[Token(Token = "0x6000388")]
		get;
	}

	[Token(Token = "0x1700008E")]
	StoreModel storeModel
	{
		[Token(Token = "0x6000389")]
		get;
	}

	[Token(Token = "0x6000371")]
	void Logout(Action<LogoutResult> logoutComplete);

	[Token(Token = "0x6000372")]
	void SendAppToBackground();

	[Token(Token = "0x6000373")]
	bool OfflineForALongTime();

	[Token(Token = "0x6000374")]
	bool IsOnlineAndTimeValid();

	[Token(Token = "0x6000375")]
	bool IsSignedIn();

	[Token(Token = "0x6000376")]
	void DeleteUser();

	[Token(Token = "0x6000377")]
	void ScrubUser(Action<bool> onComplete);

	[Token(Token = "0x6000378")]
	void ResetToLoginLoadState();

	[Token(Token = "0x6000379")]
	void UpdateRemoteData();

	[Token(Token = "0x600037A")]
	string GetLoadingString();

	[Token(Token = "0x600037B")]
	bool IsNewUser();

	[Token(Token = "0x600037C")]
	string GetUserID();

	[Token(Token = "0x600037D")]
	string GetUserName();

	[Token(Token = "0x600037E")]
	void SetUserName(string name);

	[Token(Token = "0x600037F")]
	bool CheckGameStatus();

	[Token(Token = "0x6000380")]
	bool WasInBetaTest();
}
