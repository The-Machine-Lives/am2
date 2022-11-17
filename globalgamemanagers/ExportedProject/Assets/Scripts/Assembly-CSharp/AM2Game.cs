using System;
using System.Collections.Generic;
using AM2;
using AM2.ReferenceData;
using Com.Uken.Analog;
using Il2CppDummyDll;
using Uken.Core;
using Uken.Framework.Casual;
using Uken.Library.IAP;
using Uken.Library.Inventory;
using Uken.Library.Jingot;
using Uken.Library.Notifications;
using Uken.Library.Web;
using UnityEngine;
using Utilities;

[Token(Token = "0x200009E")]
public class AM2Game : CasualGame, IAM2Game
{
	[Token(Token = "0x2000612")]
	public enum EControllerType
	{
		[Token(Token = "0x4001D8B")]
		Analytics = 0,
		[Token(Token = "0x4001D8C")]
		AudioController = 1,
		[Token(Token = "0x4001D8D")]
		DynamicSaleItems = 2,
		[Token(Token = "0x4001D8E")]
		FacebookGraph = 3,
		[Token(Token = "0x4001D8F")]
		GameFeatures = 4,
		[Token(Token = "0x4001D90")]
		Jingot = 5,
		[Token(Token = "0x4001D91")]
		JingotTestData = 6,
		[Token(Token = "0x4001D92")]
		InventoryDefaults = 7,
		[Token(Token = "0x4001D93")]
		InventoryRevisions = 8,
		[Token(Token = "0x4001D94")]
		ItemCatalog = 9,
		[Token(Token = "0x4001D95")]
		ItemInfo = 10,
		[Token(Token = "0x4001D96")]
		LTOSets = 11,
		[Token(Token = "0x4001D97")]
		Messages = 12,
		[Token(Token = "0x4001D98")]
		Products = 13,
		[Token(Token = "0x4001D99")]
		PurchaseProfiler = 14,
		[Token(Token = "0x4001D9A")]
		RewardGroupsController = 15,
		[Token(Token = "0x4001D9B")]
		SaleItems = 16,
		[Token(Token = "0x4001D9C")]
		UserController = 17,
		[Token(Token = "0x4001D9D")]
		Updates = 18,
		[Token(Token = "0x4001D9E")]
		GlobalLeaderboards = 19,
		[Token(Token = "0x4001D9F")]
		UserSegments = 20,
		[Token(Token = "0x4001DA0")]
		ConstructionController = 21,
		[Token(Token = "0x4001DA1")]
		PowerController = 22,
		[Token(Token = "0x4001DA2")]
		ResearchController = 23,
		[Token(Token = "0x4001DA3")]
		RecipeController = 24,
		[Token(Token = "0x4001DA4")]
		RecipeDifferentialController = 25,
		[Token(Token = "0x4001DA5")]
		ZoneController = 26,
		[Token(Token = "0x4001DA6")]
		QuestController = 27,
		[Token(Token = "0x4001DA7")]
		FTUEController = 28,
		[Token(Token = "0x4001DA8")]
		StoryLogController = 29,
		[Token(Token = "0x4001DA9")]
		OfflineGenerationController = 30,
		[Token(Token = "0x4001DAA")]
		TextDisplayController = 31,
		[Token(Token = "0x4001DAB")]
		ActionController = 32,
		[Token(Token = "0x4001DAC")]
		LoadoutController = 33,
		[Token(Token = "0x4001DAD")]
		AbilitiesController = 34,
		[Token(Token = "0x4001DAE")]
		ObjectPoolController = 35,
		[Token(Token = "0x4001DAF")]
		SpeedBoosterController = 36,
		[Token(Token = "0x4001DB0")]
		AM2MessageController = 37,
		[Token(Token = "0x4001DB1")]
		ItemConverterController = 38,
		[Token(Token = "0x4001DB2")]
		UIAlertController = 39,
		[Token(Token = "0x4001DB3")]
		DataCacheController = 40,
		[Token(Token = "0x4001DB4")]
		EquipmentController = 41,
		[Token(Token = "0x4001DB5")]
		CodeButtonController = 42,
		[Token(Token = "0x4001DB6")]
		ProfilePageController = 43,
		[Token(Token = "0x4001DB7")]
		PrestigeController = 44,
		[Token(Token = "0x4001DB8")]
		AutoConversionController = 45,
		[Token(Token = "0x4001DB9")]
		VIPStatusController = 46,
		[Token(Token = "0x4001DBA")]
		MiniEventController = 47
	}

	[Token(Token = "0x2000613")]
	public enum ELoadingState
	{
		[Token(Token = "0x4001DBC")]
		Invalid = 0,
		[Token(Token = "0x4001DBD")]
		Initializing = 1,
		[Token(Token = "0x4001DBE")]
		LoadingContent = 2,
		[Token(Token = "0x4001DBF")]
		PostLoadSetup = 3,
		[Token(Token = "0x4001DC0")]
		Login = 4,
		[Token(Token = "0x4001DC1")]
		NativeAuthLogin = 5,
		[Token(Token = "0x4001DC2")]
		LoadAssets = 6,
		[Token(Token = "0x4001DC3")]
		Ready = 7
	}

	[Token(Token = "0x2000614")]
	public enum Scenes
	{
		[Token(Token = "0x4001DC5")]
		Splash = 0,
		[Token(Token = "0x4001DC6")]
		Construction = 1,
		[Token(Token = "0x4001DC7")]
		Zone = 2
	}

	[Token(Token = "0x2000615")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820368", Offset = "0x820368")]
	private sealed class _003C_003Ec__DisplayClass128_0
	{
		[Token(Token = "0x4001DC8")]
		[FieldOffset(Offset = "0x10")]
		public Action<LogoutResult> onComplete;

		[Token(Token = "0x4001DC9")]
		[FieldOffset(Offset = "0x18")]
		public AM2Game _003C_003E4__this;

		[Token(Token = "0x6002CE1")]
		[Address(RVA = "0x97CA34", Offset = "0x97CA34", VA = "0x97CA34")]
		public _003C_003Ec__DisplayClass128_0()
		{
		}

		[Token(Token = "0x6002CE2")]
		[Address(RVA = "0x981754", Offset = "0x981754", VA = "0x981754")]
		internal void _003CLogout_003Eb__0(LogoutResult result)
		{
		}
	}

	[Token(Token = "0x2000616")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820378", Offset = "0x820378")]
	private sealed class _003C_003Ec__DisplayClass148_0
	{
		[Token(Token = "0x4001DCA")]
		[FieldOffset(Offset = "0x10")]
		public Action<AuthenticationStatus> onComplete;

		[Token(Token = "0x6002CE3")]
		[Address(RVA = "0x9802D8", Offset = "0x9802D8", VA = "0x9802D8")]
		public _003C_003Ec__DisplayClass148_0()
		{
		}

		[Token(Token = "0x6002CE4")]
		[Address(RVA = "0x9817E8", Offset = "0x9817E8", VA = "0x9817E8")]
		internal void _003CLinkToNativeAuth_003Eb__0(AuthenticationStatus authStatus, LinkResult linkResult)
		{
		}
	}

	[Token(Token = "0x2000617")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820388", Offset = "0x820388")]
	private sealed class _003C_003Ec__DisplayClass158_0
	{
		[Token(Token = "0x4001DCB")]
		[FieldOffset(Offset = "0x10")]
		public Action<AuthenticationStatus> onComplete;

		[Token(Token = "0x6002CE5")]
		[Address(RVA = "0x980964", Offset = "0x980964", VA = "0x980964")]
		public _003C_003Ec__DisplayClass158_0()
		{
		}

		[Token(Token = "0x6002CE6")]
		[Address(RVA = "0x981898", Offset = "0x981898", VA = "0x981898")]
		internal void _003CNativeAuthSplashLogin_003Eb__0(AuthenticationStatus authStatus, LinkResult linkResult)
		{
		}
	}

	[Token(Token = "0x2000618")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820398", Offset = "0x820398")]
	private sealed class _003C_003Ec__DisplayClass159_0
	{
		[Token(Token = "0x4001DCC")]
		[FieldOffset(Offset = "0x10")]
		public AM2Game _003C_003E4__this;

		[Token(Token = "0x4001DCD")]
		[FieldOffset(Offset = "0x18")]
		public float querySentTime;

		[Token(Token = "0x4001DCE")]
		[FieldOffset(Offset = "0x20")]
		public Action onLoginComplete;

		[Token(Token = "0x6002CE7")]
		[Address(RVA = "0x980A60", Offset = "0x980A60", VA = "0x980A60")]
		public _003C_003Ec__DisplayClass159_0()
		{
		}

		[Token(Token = "0x6002CE8")]
		[Address(RVA = "0x98190C", Offset = "0x98190C", VA = "0x98190C")]
		internal void _003CLogin_003Eb__0()
		{
		}
	}

	[Token(Token = "0x40002B6")]
	public const float c_longOfflineTime = 3f;

	[Token(Token = "0x40002B7")]
	[FieldOffset(Offset = "0x0")]
	private static IAM2Game m_am2GameInterface;

	[Token(Token = "0x40002B8")]
	[FieldOffset(Offset = "0x1E0")]
	public Dictionary<EControllerType, UkenController> m_globalControllers;

	[Token(Token = "0x40002B9")]
	[FieldOffset(Offset = "0x1E8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82233C", Offset = "0x82233C")]
	private Stores _003Cstores_003Ek__BackingField;

	[Token(Token = "0x40002BA")]
	[FieldOffset(Offset = "0x1F0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82234C", Offset = "0x82234C")]
	private AdConfigs _003CadConfigs_003Ek__BackingField;

	[Token(Token = "0x40002BB")]
	[FieldOffset(Offset = "0x1F8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82235C", Offset = "0x82235C")]
	private DynamicAdsController _003CdynamicAdsController_003Ek__BackingField;

	[Token(Token = "0x40002BC")]
	[FieldOffset(Offset = "0x200")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82236C", Offset = "0x82236C")]
	private AutoBanController _003CautoBanController_003Ek__BackingField;

	[Token(Token = "0x40002BD")]
	[FieldOffset(Offset = "0x208")]
	private ELoadingState m_eLoadState;

	[Token(Token = "0x40002BE")]
	[FieldOffset(Offset = "0x210")]
	private PlayerDataItem m_playerData;

	[Token(Token = "0x40002BF")]
	[FieldOffset(Offset = "0x218")]
	private bool m_bPlayServicesInit;

	[Token(Token = "0x40002C0")]
	[FieldOffset(Offset = "0x8")]
	public static readonly Dictionary<Scenes, string> SceneNames;

	[Token(Token = "0x40002C1")]
	[FieldOffset(Offset = "0x10")]
	private static string[] loadingStrings;

	[Token(Token = "0x1700008F")]
	public AM2Environment am2Environment
	{
		[Token(Token = "0x600038C")]
		[Address(RVA = "0x979C7C", Offset = "0x979C7C", VA = "0x979C7C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000090")]
	public Stores stores
	{
		[Token(Token = "0x600038D")]
		[Address(RVA = "0x979D08", Offset = "0x979D08", VA = "0x979D08", Slot = "155")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x833CFC", Offset = "0x833CFC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600038E")]
		[Address(RVA = "0x979D10", Offset = "0x979D10", VA = "0x979D10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x833D0C", Offset = "0x833D0C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000091")]
	public BIPurchaseProfiler biPurchaseProfiler
	{
		[Token(Token = "0x600038F")]
		[Address(RVA = "0x979D18", Offset = "0x979D18", VA = "0x979D18")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000092")]
	public AM2SoundController audioController
	{
		[Token(Token = "0x6000390")]
		[Address(RVA = "0x979DA4", Offset = "0x979DA4", VA = "0x979DA4", Slot = "99")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000093")]
	public AM2InventoryController am2Inventory
	{
		[Token(Token = "0x6000391")]
		[Address(RVA = "0x979E4C", Offset = "0x979E4C", VA = "0x979E4C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000094")]
	public JingotTests m_jingotTests
	{
		[Token(Token = "0x6000392")]
		[Address(RVA = "0x979ED8", Offset = "0x979ED8", VA = "0x979ED8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000095")]
	public InventoryDefaults m_inventoryDefaults
	{
		[Token(Token = "0x6000393")]
		[Address(RVA = "0x979F80", Offset = "0x979F80", VA = "0x979F80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000096")]
	public UserController m_user
	{
		[Token(Token = "0x6000394")]
		[Address(RVA = "0x97A028", Offset = "0x97A028", VA = "0x97A028")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000097")]
	public UpdatesController updatesController
	{
		[Token(Token = "0x6000395")]
		[Address(RVA = "0x97A0D0", Offset = "0x97A0D0", VA = "0x97A0D0", Slot = "119")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000098")]
	public Products m_products
	{
		[Token(Token = "0x6000396")]
		[Address(RVA = "0x97A178", Offset = "0x97A178", VA = "0x97A178")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000099")]
	public LTOSets m_LTOSets
	{
		[Token(Token = "0x6000397")]
		[Address(RVA = "0x97A220", Offset = "0x97A220", VA = "0x97A220")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700009A")]
	public GlobalLeaderboardController globalLeaderboardController
	{
		[Token(Token = "0x6000398")]
		[Address(RVA = "0x97A2C8", Offset = "0x97A2C8", VA = "0x97A2C8", Slot = "103")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700009B")]
	public AdConfigs adConfigs
	{
		[Token(Token = "0x6000399")]
		[Address(RVA = "0x97A370", Offset = "0x97A370", VA = "0x97A370", Slot = "151")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x833D1C", Offset = "0x833D1C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600039A")]
		[Address(RVA = "0x97A378", Offset = "0x97A378", VA = "0x97A378")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x833D2C", Offset = "0x833D2C")]
		private set
		{
		}
	}

	[Token(Token = "0x1700009C")]
	public DynamicAdsController dynamicAdsController
	{
		[Token(Token = "0x600039B")]
		[Address(RVA = "0x97A380", Offset = "0x97A380", VA = "0x97A380", Slot = "153")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x833D3C", Offset = "0x833D3C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600039C")]
		[Address(RVA = "0x97A388", Offset = "0x97A388", VA = "0x97A388")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x833D4C", Offset = "0x833D4C")]
		private set
		{
		}
	}

	[Token(Token = "0x1700009D")]
	public SharedDataCacheController dataCacheController
	{
		[Token(Token = "0x600039D")]
		[Address(RVA = "0x97A390", Offset = "0x97A390", VA = "0x97A390", Slot = "91")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700009E")]
	public AM2InventoryController am2InventoryController
	{
		[Token(Token = "0x600039E")]
		[Address(RVA = "0x97A438", Offset = "0x97A438", VA = "0x97A438", Slot = "94")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700009F")]
	public ConstructionController constructionController
	{
		[Token(Token = "0x600039F")]
		[Address(RVA = "0x97A4C4", Offset = "0x97A4C4", VA = "0x97A4C4", Slot = "105")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000A0")]
	public FTUEController ftueController
	{
		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x97A56C", Offset = "0x97A56C", VA = "0x97A56C", Slot = "106")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000A1")]
	public PowerController powerController
	{
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x97A614", Offset = "0x97A614", VA = "0x97A614", Slot = "107")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000A2")]
	public ResearchController researchController
	{
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x97A6BC", Offset = "0x97A6BC", VA = "0x97A6BC", Slot = "108")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000A3")]
	public RecipeDifferentialController recipeDifferentialController
	{
		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x97A764", Offset = "0x97A764", VA = "0x97A764", Slot = "110")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000A4")]
	public RecipeController recipeController
	{
		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x97A80C", Offset = "0x97A80C", VA = "0x97A80C", Slot = "109")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000A5")]
	public ZoneController zoneController
	{
		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x97A8B4", Offset = "0x97A8B4", VA = "0x97A8B4", Slot = "111")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000A6")]
	public QuestController questController
	{
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x97A95C", Offset = "0x97A95C", VA = "0x97A95C", Slot = "112")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000A7")]
	public StoryLogController storyLogController
	{
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x97AA04", Offset = "0x97AA04", VA = "0x97AA04", Slot = "113")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000A8")]
	public LoadoutController loadoutController
	{
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x97AAAC", Offset = "0x97AAAC", VA = "0x97AAAC", Slot = "114")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000A9")]
	public AbilitiesController abilitiesController
	{
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x97AB54", Offset = "0x97AB54", VA = "0x97AB54", Slot = "115")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000AA")]
	public OfflineGenerationController offlineGenerationController
	{
		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x97ABFC", Offset = "0x97ABFC", VA = "0x97ABFC", Slot = "116")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000AB")]
	public AM2TextDisplayController textDisplayController
	{
		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x97ACA4", Offset = "0x97ACA4", VA = "0x97ACA4", Slot = "117")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000AC")]
	public ActionController actionController
	{
		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x97AD4C", Offset = "0x97AD4C", VA = "0x97AD4C", Slot = "118")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000AD")]
	public ObjectPoolController objectPoolController
	{
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x97ADF4", Offset = "0x97ADF4", VA = "0x97ADF4", Slot = "120")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000AE")]
	public SpeedBoosterController speedBoosterController
	{
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x97AE9C", Offset = "0x97AE9C", VA = "0x97AE9C", Slot = "121")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000AF")]
	public EquipmentController equipmentController
	{
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x97AF44", Offset = "0x97AF44", VA = "0x97AF44", Slot = "123")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000B0")]
	public CodeButtonController codeButtonController
	{
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x97AFEC", Offset = "0x97AFEC", VA = "0x97AFEC", Slot = "124")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000B1")]
	public AM2MessageController am2MessageController
	{
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x97B094", Offset = "0x97B094", VA = "0x97B094", Slot = "125")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000B2")]
	public ItemConverterController itemConverterController
	{
		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x97B13C", Offset = "0x97B13C", VA = "0x97B13C", Slot = "122")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000B3")]
	public UIAlertController uiAlertController
	{
		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x97B1E4", Offset = "0x97B1E4", VA = "0x97B1E4", Slot = "104")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000B4")]
	public ProfilePageController profilePageController
	{
		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x97B28C", Offset = "0x97B28C", VA = "0x97B28C", Slot = "126")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000B5")]
	public PrestigeController prestigeController
	{
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x97B334", Offset = "0x97B334", VA = "0x97B334", Slot = "127")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000B6")]
	public VIPStatusController vipStatusController
	{
		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x97B3DC", Offset = "0x97B3DC", VA = "0x97B3DC", Slot = "133")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000B7")]
	public MiniEventController miniEventController
	{
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x97B484", Offset = "0x97B484", VA = "0x97B484", Slot = "134")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000B8")]
	public AutoBanController autoBanController
	{
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x97B52C", Offset = "0x97B52C", VA = "0x97B52C", Slot = "128")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x833D5C", Offset = "0x833D5C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x97B534", Offset = "0x97B534", VA = "0x97B534")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x833D6C", Offset = "0x833D6C")]
		private set
		{
		}
	}

	[Token(Token = "0x170000B9")]
	public AutomaticConversionController autoConversionController
	{
		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x97B53C", Offset = "0x97B53C", VA = "0x97B53C", Slot = "129")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000BA")]
	protected AM2DataStoreController am2DataStoreController
	{
		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x97B5E4", Offset = "0x97B5E4", VA = "0x97B5E4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000BB")]
	public BIAdjust adjust
	{
		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x97B670", Offset = "0x97B670", VA = "0x97B670", Slot = "157")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600038A")]
	[Address(RVA = "0x979C10", Offset = "0x979C10", VA = "0x979C10")]
	public static void SetAM2GameInterface(IAM2Game am2Interface)
	{
	}

	[Token(Token = "0x600038B")]
	[Address(RVA = "0x96B5F4", Offset = "0x96B5F4", VA = "0x96B5F4")]
	public new static IAM2Game Get()
	{
		return null;
	}

	[Token(Token = "0x60003BD")]
	[Address(RVA = "0x97B6F4", Offset = "0x97B6F4", VA = "0x97B6F4", Slot = "13")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60003BE")]
	[Address(RVA = "0x97B7F4", Offset = "0x97B7F4", VA = "0x97B7F4", Slot = "144")]
	public string GetLoadingString()
	{
		return null;
	}

	[Token(Token = "0x60003BF")]
	[Address(RVA = "0x97B8E8", Offset = "0x97B8E8", VA = "0x97B8E8")]
	public static string GetSceneName(Scenes scene)
	{
		return null;
	}

	[Token(Token = "0x60003C0")]
	[Address(RVA = "0x97BA18", Offset = "0x97BA18", VA = "0x97BA18", Slot = "34")]
	public override string GameName()
	{
		return null;
	}

	[Token(Token = "0x60003C1")]
	[Address(RVA = "0x97BA60", Offset = "0x97BA60", VA = "0x97BA60", Slot = "45")]
	public override NotificationManager CreateLocalNotificationManager()
	{
		return null;
	}

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0x97BAA8", Offset = "0x97BAA8", VA = "0x97BAA8", Slot = "62")]
	public override CasualDataStoreController CreateDataStoreController()
	{
		return null;
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0x97BBBC", Offset = "0x97BBBC", VA = "0x97BBBC", Slot = "37")]
	public override CasualEnvironment CreateEnvironment()
	{
		return null;
	}

	[Token(Token = "0x60003C4")]
	[Address(RVA = "0x97BC40", Offset = "0x97BC40", VA = "0x97BC40", Slot = "63")]
	public override InventoryController CreateInventory()
	{
		return null;
	}

	[Token(Token = "0x60003C5")]
	[Address(RVA = "0x97BF74", Offset = "0x97BF74", VA = "0x97BF74", Slot = "67")]
	public override PurchaseProfiler CreatePurchaseProfiler()
	{
		return null;
	}

	[Token(Token = "0x60003C6")]
	[Address(RVA = "0x97C054", Offset = "0x97C054", VA = "0x97C054", Slot = "51")]
	public override string SoftCurrencyName()
	{
		return null;
	}

	[Token(Token = "0x60003C7")]
	[Address(RVA = "0x97C09C", Offset = "0x97C09C", VA = "0x97C09C", Slot = "52")]
	public override string HardCurrencyName()
	{
		return null;
	}

	[Token(Token = "0x60003C8")]
	[Address(RVA = "0x97C0E4", Offset = "0x97C0E4", VA = "0x97C0E4", Slot = "42")]
	public override UkenPaymentProvider CreatePaymentProvider()
	{
		return null;
	}

	[Token(Token = "0x60003C9")]
	[Address(RVA = "0x97C438", Offset = "0x97C438", VA = "0x97C438", Slot = "43")]
	public override UkenPaymentValidator CreatePaymentValidator()
	{
		return null;
	}

	[Token(Token = "0x60003CA")]
	[Address(RVA = "0x97C5AC", Offset = "0x97C5AC", VA = "0x97C5AC", Slot = "44")]
	public override bool IsNewUser()
	{
		return default(bool);
	}

	[Token(Token = "0x60003CB")]
	[Address(RVA = "0x97C650", Offset = "0x97C650", VA = "0x97C650", Slot = "38")]
	public override string GetHothCredentialPath()
	{
		return null;
	}

	[Token(Token = "0x60003CC")]
	[Address(RVA = "0x97C780", Offset = "0x97C780", VA = "0x97C780")]
	public Dictionary<string, long> IAPGrantTransaction(UkenPaymentTransaction transaction)
	{
		return null;
	}

	[Token(Token = "0x60003CD")]
	[Address(RVA = "0x97C7B8", Offset = "0x97C7B8", VA = "0x97C7B8", Slot = "136")]
	public void SendAppToBackground()
	{
	}

	[Token(Token = "0x60003CE")]
	[Address(RVA = "0x97C944", Offset = "0x97C944", VA = "0x97C944", Slot = "135")]
	public void Logout(Action<LogoutResult> onComplete)
	{
	}

	[Token(Token = "0x60003CF")]
	[Address(RVA = "0x97CA3C", Offset = "0x97CA3C", VA = "0x97CA3C", Slot = "149")]
	public bool CheckGameStatus()
	{
		return default(bool);
	}

	[Token(Token = "0x60003D0")]
	[Address(RVA = "0x97CB48", Offset = "0x97CB48", VA = "0x97CB48", Slot = "4")]
	public override void Create()
	{
	}

	[Token(Token = "0x60003D1")]
	[Address(RVA = "0x97E88C", Offset = "0x97E88C", VA = "0x97E88C")]
	private void SetToDefaultData()
	{
	}

	[Token(Token = "0x60003D2")]
	[Address(RVA = "0x97E89C", Offset = "0x97E89C", VA = "0x97E89C", Slot = "137")]
	public bool OfflineForALongTime()
	{
		return default(bool);
	}

	[Token(Token = "0x60003D3")]
	[Address(RVA = "0x97E924", Offset = "0x97E924", VA = "0x97E924", Slot = "68")]
	public override ScoreboardEventBusController CreateScoreboardEventBusController()
	{
		return null;
	}

	[Token(Token = "0x60003D4")]
	[Address(RVA = "0x97E980", Offset = "0x97E980", VA = "0x97E980", Slot = "46")]
	public override void SaveScoreboardData(ScoreboardSaveData data)
	{
	}

	[Token(Token = "0x60003D5")]
	[Address(RVA = "0x97EAB0", Offset = "0x97EAB0", VA = "0x97EAB0", Slot = "47")]
	public override ScoreboardSaveData LoadScoreboardData()
	{
		return null;
	}

	[Token(Token = "0x60003D6")]
	[Address(RVA = "0x97EC34", Offset = "0x97EC34", VA = "0x97EC34")]
	private string StripLastName(string name)
	{
		return null;
	}

	[Token(Token = "0x60003D7")]
	[Address(RVA = "0x97ECDC", Offset = "0x97ECDC", VA = "0x97ECDC", Slot = "147")]
	public string GetUserName()
	{
		return null;
	}

	[Token(Token = "0x60003D8")]
	[Address(RVA = "0x97EEC0", Offset = "0x97EEC0", VA = "0x97EEC0", Slot = "148")]
	public void SetUserName(string name)
	{
	}

	[Token(Token = "0x60003D9")]
	[Address(RVA = "0x97EDC4", Offset = "0x97EDC4", VA = "0x97EDC4")]
	private string GetGuestUserName()
	{
		return null;
	}

	[Token(Token = "0x60003DA")]
	[Address(RVA = "0x97EF70", Offset = "0x97EF70", VA = "0x97EF70", Slot = "50")]
	public override string GetScoreboardUserData()
	{
		return null;
	}

	[Token(Token = "0x60003DB")]
	[Address(RVA = "0x97F230", Offset = "0x97F230", VA = "0x97F230", Slot = "7")]
	public override bool Initialize()
	{
		return default(bool);
	}

	[Token(Token = "0x60003DC")]
	[Address(RVA = "0x97F268", Offset = "0x97F268", VA = "0x97F268", Slot = "87")]
	public override Dictionary<string, string> GetAltValueDrivers()
	{
		return null;
	}

	[Token(Token = "0x60003DD")]
	[Address(RVA = "0x97F340", Offset = "0x97F340", VA = "0x97F340", Slot = "66")]
	public override UserProfiler CreateUserProfiler()
	{
		return null;
	}

	[Token(Token = "0x60003DE")]
	[Address(RVA = "0x97F3A4", Offset = "0x97F3A4", VA = "0x97F3A4")]
	public void LogJingotTests()
	{
	}

	[Token(Token = "0x60003DF")]
	[Address(RVA = "0x97F504", Offset = "0x97F504", VA = "0x97F504", Slot = "83")]
	public override void OnLoadComplete(bool success)
	{
	}

	[Token(Token = "0x60003E0")]
	[Address(RVA = "0x97FFFC", Offset = "0x97FFFC", VA = "0x97FFFC", Slot = "33")]
	public override bool LoadContent()
	{
		return default(bool);
	}

	[Token(Token = "0x60003E1")]
	[Address(RVA = "0x9800A0", Offset = "0x9800A0", VA = "0x9800A0", Slot = "39")]
	public override void SetupAdProvider(string newProvider)
	{
	}

	[Token(Token = "0x60003E2")]
	[Address(RVA = "0x9801FC", Offset = "0x9801FC", VA = "0x9801FC")]
	public void LinkToNativeAuth(Action<AuthenticationStatus> onComplete)
	{
	}

	[Token(Token = "0x60003E3")]
	[Address(RVA = "0x9802E0", Offset = "0x9802E0", VA = "0x9802E0", Slot = "142")]
	public void ResetToLoginLoadState()
	{
	}

	[Token(Token = "0x60003E4")]
	[Address(RVA = "0x9805C0", Offset = "0x9805C0", VA = "0x9805C0", Slot = "141")]
	public void ScrubUser(Action<bool> onComplete)
	{
	}

	[Token(Token = "0x60003E5")]
	[Address(RVA = "0x9805FC", Offset = "0x9805FC", VA = "0x9805FC", Slot = "140")]
	public void DeleteUser()
	{
	}

	[Token(Token = "0x60003E6")]
	[Address(RVA = "0x98073C", Offset = "0x98073C", VA = "0x98073C", Slot = "150")]
	public bool WasInBetaTest()
	{
		return default(bool);
	}

	[Token(Token = "0x60003E7")]
	[Address(RVA = "0x980750", Offset = "0x980750", VA = "0x980750")]
	private void AddBetaStatusToPlayerPref()
	{
	}

	[Token(Token = "0x60003E8")]
	[Address(RVA = "0x97FF44", Offset = "0x97FF44", VA = "0x97FF44")]
	private void AddBetaStatusToInventory(PlayerDataItem playerData)
	{
	}

	[Token(Token = "0x60003E9")]
	[Address(RVA = "0x980040", Offset = "0x980040", VA = "0x980040")]
	private void PostLoadSetup()
	{
	}

	[Token(Token = "0x60003EA")]
	[Address(RVA = "0x9807A0", Offset = "0x9807A0", VA = "0x9807A0")]
	public bool IsReadyToLaunch()
	{
		return default(bool);
	}

	[Token(Token = "0x60003EB")]
	[Address(RVA = "0x9807B0", Offset = "0x9807B0", VA = "0x9807B0")]
	public bool IsInNativeAuthLogin()
	{
		return default(bool);
	}

	[Token(Token = "0x60003EC")]
	[Address(RVA = "0x9807C0", Offset = "0x9807C0", VA = "0x9807C0")]
	public void NativeAuthSplashLogin(Action<AuthenticationStatus> onComplete)
	{
	}

	[Token(Token = "0x60003ED")]
	[Address(RVA = "0x98096C", Offset = "0x98096C", VA = "0x98096C", Slot = "74")]
	public override void Login(Action onLoginComplete)
	{
	}

	[Token(Token = "0x60003EE")]
	[Address(RVA = "0x980A68", Offset = "0x980A68", VA = "0x980A68", Slot = "72")]
	protected override UkenWebConfig GetWebConfig()
	{
		return null;
	}

	[Token(Token = "0x60003EF")]
	[Address(RVA = "0x97F684", Offset = "0x97F684", VA = "0x97F684")]
	private void ProcessInventoryRevisions()
	{
	}

	[Token(Token = "0x60003F0")]
	[Address(RVA = "0x980B8C", Offset = "0x980B8C", VA = "0x980B8C", Slot = "11")]
	protected override bool UpdateGame(float fDeltaTime)
	{
		return default(bool);
	}

	[Token(Token = "0x60003F1")]
	[Address(RVA = "0x97F4C8", Offset = "0x97F4C8", VA = "0x97F4C8")]
	private void LogABTests(List<ABTestGroup> abTests)
	{
	}

	[Token(Token = "0x60003F2")]
	[Address(RVA = "0x980B94", Offset = "0x980B94", VA = "0x980B94", Slot = "8")]
	protected override void OnGamePaused(bool paused)
	{
	}

	[Token(Token = "0x60003F3")]
	[Address(RVA = "0x980D74", Offset = "0x980D74", VA = "0x980D74")]
	protected void OnApplicationFocus(bool focus)
	{
	}

	[Token(Token = "0x60003F4")]
	[Address(RVA = "0x980F3C", Offset = "0x980F3C", VA = "0x980F3C", Slot = "9")]
	protected override void OnGameQuit()
	{
	}

	[Token(Token = "0x60003F5")]
	[Address(RVA = "0x980FD8", Offset = "0x980FD8", VA = "0x980FD8")]
	public void CheckAndLogCrashRecovery()
	{
	}

	[Token(Token = "0x60003F6")]
	[Address(RVA = "0x98111C", Offset = "0x98111C", VA = "0x98111C", Slot = "55")]
	public override RuntimeContext CreateAnalogContext()
	{
		return null;
	}

	[Token(Token = "0x60003F7")]
	[Address(RVA = "0x981304", Offset = "0x981304", VA = "0x981304")]
	private void LogCallback(string condition, string stackTrace, LogType type)
	{
	}

	[Token(Token = "0x60003F8")]
	[Address(RVA = "0x9813D0", Offset = "0x9813D0", VA = "0x9813D0", Slot = "89")]
	public override void GoToLogoutScreen()
	{
	}

	[Token(Token = "0x60003F9")]
	[Address(RVA = "0x9813F8", Offset = "0x9813F8", VA = "0x9813F8")]
	public AM2Game()
	{
	}

	[Token(Token = "0x60003FB")]
	[Address(RVA = "0x981720", Offset = "0x981720", VA = "0x981720")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x833D7C", Offset = "0x833D7C")]
	private void _003CGetWebConfig_003Eb__160_0(UkenRequest request)
	{
	}
}
