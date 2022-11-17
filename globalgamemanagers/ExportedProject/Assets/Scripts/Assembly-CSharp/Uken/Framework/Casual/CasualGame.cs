using System;
using System.Collections.Generic;
using Com.Uken.Analog;
using Com.Uken.Core;
using Il2CppDummyDll;
using Uken.Core;
using Uken.Framework.Casual.Leaderboards;
using Uken.Framework.Casual.Signals;
using Uken.Library.AID;
using Uken.Library.Adjust;
using Uken.Library.Animation;
using Uken.Library.IAP;
using Uken.Library.Inbox;
using Uken.Library.Inventory;
using Uken.Library.Jingot;
using Uken.Library.Metrics;
using Uken.Library.Notifications;
using Uken.Library.PlatformInbox;
using Uken.Library.PlatformInbox.Internal;
using Uken.Library.ReferenceData;
using Uken.Library.Scoreboards;
using Uken.Library.TeamService;
using Uken.Library.UkenTime;
using Uken.Library.UserAnalytics;
using Uken.Library.Web;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004D8")]
	public abstract class CasualGame : UkenCore
	{
		[Token(Token = "0x2000837")]
		public class LoadingEvent
		{
			[Token(Token = "0x4002394")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x833080", Offset = "0x833080")]
			private string _003CloadingName_003Ek__BackingField;

			[Token(Token = "0x4002395")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x833090", Offset = "0x833090")]
			private Action<Action<bool>> _003CloadingAction_003Ek__BackingField;

			[Token(Token = "0x1700082D")]
			public string loadingName
			{
				[Token(Token = "0x6003338")]
				[Address(RVA = "0xA53798", Offset = "0xA53798", VA = "0xA53798")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BCBC", Offset = "0x83BCBC")]
				get
				{
					return null;
				}
				[Token(Token = "0x6003339")]
				[Address(RVA = "0xA537A0", Offset = "0xA537A0", VA = "0xA537A0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BCCC", Offset = "0x83BCCC")]
				set
				{
				}
			}

			[Token(Token = "0x1700082E")]
			public Action<Action<bool>> loadingAction
			{
				[Token(Token = "0x600333A")]
				[Address(RVA = "0xA537A8", Offset = "0xA537A8", VA = "0xA537A8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BCDC", Offset = "0x83BCDC")]
				get
				{
					return null;
				}
				[Token(Token = "0x600333B")]
				[Address(RVA = "0xA537B0", Offset = "0xA537B0", VA = "0xA537B0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83BCEC", Offset = "0x83BCEC")]
				set
				{
				}
			}

			[Token(Token = "0x600333C")]
			[Address(RVA = "0xA537B8", Offset = "0xA537B8", VA = "0xA537B8")]
			public LoadingEvent(string inLoadingName, Action<Action<bool>> inLoadingAction)
			{
			}
		}

		[Token(Token = "0x2000838")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8213F8", Offset = "0x8213F8")]
		private sealed class _003C_003Ec__DisplayClass209_0
		{
			[Token(Token = "0x4002396")]
			[FieldOffset(Offset = "0x10")]
			public UkenController controller;

			[Token(Token = "0x600333D")]
			[Address(RVA = "0xA53080", Offset = "0xA53080", VA = "0xA53080")]
			public _003C_003Ec__DisplayClass209_0()
			{
			}

			[Token(Token = "0x600333E")]
			[Address(RVA = "0xA53088", Offset = "0xA53088", VA = "0xA53088")]
			internal void _003CRegisterController_003Eb__0(Action<bool> onComplete)
			{
			}
		}

		[Token(Token = "0x2000839")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821408", Offset = "0x821408")]
		private sealed class _003C_003Ec__DisplayClass245_0
		{
			[Token(Token = "0x4002397")]
			[FieldOffset(Offset = "0x10")]
			public WebRequest request;

			[Token(Token = "0x600333F")]
			[Address(RVA = "0xA53118", Offset = "0xA53118", VA = "0xA53118")]
			public _003C_003Ec__DisplayClass245_0()
			{
			}

			[Token(Token = "0x6003340")]
			[Address(RVA = "0xA53120", Offset = "0xA53120", VA = "0xA53120")]
			internal void _003CWebSend_003Eb__0(bool success, UkenRequest ukenRequest)
			{
			}
		}

		[Token(Token = "0x200083A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821418", Offset = "0x821418")]
		private sealed class _003C_003Ec__DisplayClass256_0
		{
			[Token(Token = "0x4002398")]
			[FieldOffset(Offset = "0x10")]
			public Action onLoginComplete;

			[Token(Token = "0x4002399")]
			[FieldOffset(Offset = "0x18")]
			public string userIDBeforeLogin;

			[Token(Token = "0x400239A")]
			[FieldOffset(Offset = "0x20")]
			public CasualGame _003C_003E4__this;

			[Token(Token = "0x6003341")]
			[Address(RVA = "0xA5322C", Offset = "0xA5322C", VA = "0xA5322C")]
			public _003C_003Ec__DisplayClass256_0()
			{
			}

			[Token(Token = "0x6003342")]
			[Address(RVA = "0xA53234", Offset = "0xA53234", VA = "0xA53234")]
			internal void _003CLogin_003Eb__0(AuthenticationStatus status)
			{
			}
		}

		[Token(Token = "0x200083B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821428", Offset = "0x821428")]
		private sealed class _003C_003Ec__DisplayClass259_0
		{
			[Token(Token = "0x400239B")]
			[FieldOffset(Offset = "0x10")]
			public Action<bool> onComplete;

			[Token(Token = "0x400239C")]
			[FieldOffset(Offset = "0x18")]
			public CasualGame _003C_003E4__this;

			[Token(Token = "0x6003343")]
			[Address(RVA = "0xA532F4", Offset = "0xA532F4", VA = "0xA532F4")]
			public _003C_003Ec__DisplayClass259_0()
			{
			}

			[Token(Token = "0x6003344")]
			[Address(RVA = "0xA532FC", Offset = "0xA532FC", VA = "0xA532FC")]
			internal void _003CQueryJingot_003Eb__0(bool userSuccess)
			{
			}
		}

		[Token(Token = "0x200083C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821438", Offset = "0x821438")]
		private sealed class _003C_003Ec__DisplayClass261_0
		{
			[Token(Token = "0x400239D")]
			[FieldOffset(Offset = "0x10")]
			public Action<bool> onComplete;

			[Token(Token = "0x6003345")]
			[Address(RVA = "0xA53408", Offset = "0xA53408", VA = "0xA53408")]
			public _003C_003Ec__DisplayClass261_0()
			{
			}

			[Token(Token = "0x6003346")]
			[Address(RVA = "0xA53410", Offset = "0xA53410", VA = "0xA53410")]
			internal void _003CQueryUserAnalytics_003Eb__0(bool success)
			{
			}
		}

		[Token(Token = "0x200083D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821448", Offset = "0x821448")]
		private sealed class _003C_003Ec__DisplayClass262_0
		{
			[Token(Token = "0x400239E")]
			[FieldOffset(Offset = "0x10")]
			public Action<bool> onComplete;

			[Token(Token = "0x6003347")]
			[Address(RVA = "0xA53474", Offset = "0xA53474", VA = "0xA53474")]
			public _003C_003Ec__DisplayClass262_0()
			{
			}

			[Token(Token = "0x6003348")]
			[Address(RVA = "0xA5347C", Offset = "0xA5347C", VA = "0xA5347C")]
			internal void _003CQueryInbox_003Eb__0(PlatformInboxResponseCode response)
			{
			}
		}

		[Token(Token = "0x200083E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821458", Offset = "0x821458")]
		private sealed class _003C_003Ec__DisplayClass263_0
		{
			[Token(Token = "0x400239F")]
			[FieldOffset(Offset = "0x10")]
			public Action<bool> onComplete;

			[Token(Token = "0x6003349")]
			[Address(RVA = "0xA534E0", Offset = "0xA534E0", VA = "0xA534E0")]
			public _003C_003Ec__DisplayClass263_0()
			{
			}

			[Token(Token = "0x600334A")]
			[Address(RVA = "0xA534E8", Offset = "0xA534E8", VA = "0xA534E8")]
			internal void _003CQueryReferenceData_003Eb__0(bool success)
			{
			}
		}

		[Token(Token = "0x200083F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821468", Offset = "0x821468")]
		private sealed class _003C_003Ec__DisplayClass265_0
		{
			[Token(Token = "0x40023A0")]
			[FieldOffset(Offset = "0x10")]
			public CasualGame _003C_003E4__this;

			[Token(Token = "0x40023A1")]
			[FieldOffset(Offset = "0x18")]
			public Action<bool> onComplete;

			[Token(Token = "0x40023A2")]
			[FieldOffset(Offset = "0x20")]
			public Action<bool> _003C_003E9__1;

			[Token(Token = "0x600334B")]
			[Address(RVA = "0xA53558", Offset = "0xA53558", VA = "0xA53558")]
			public _003C_003Ec__DisplayClass265_0()
			{
			}

			[Token(Token = "0x600334C")]
			[Address(RVA = "0xA53560", Offset = "0xA53560", VA = "0xA53560")]
			internal void _003CQueryInventory_003Eb__0(bool tokenSuccess)
			{
			}

			[Token(Token = "0x600334D")]
			[Address(RVA = "0xA53674", Offset = "0xA53674", VA = "0xA53674")]
			internal void _003CQueryInventory_003Eb__1(bool inventorySuccess)
			{
			}
		}

		[Token(Token = "0x2000840")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821478", Offset = "0x821478")]
		private sealed class _003C_003Ec__DisplayClass266_0
		{
			[Token(Token = "0x40023A3")]
			[FieldOffset(Offset = "0x10")]
			public Action<bool> onComplete;

			[Token(Token = "0x600334E")]
			[Address(RVA = "0xA536E4", Offset = "0xA536E4", VA = "0xA536E4")]
			public _003C_003Ec__DisplayClass266_0()
			{
			}

			[Token(Token = "0x600334F")]
			[Address(RVA = "0xA536EC", Offset = "0xA536EC", VA = "0xA536EC")]
			internal void _003CQueryIAPData_003Eb__0(bool success)
			{
			}
		}

		[Token(Token = "0x40016B4")]
		[FieldOffset(Offset = "0x30")]
		public Com.Uken.Core.Device m_ukenDevice;

		[Token(Token = "0x40016B5")]
		[FieldOffset(Offset = "0x38")]
		public UkenAdjust m_adjust;

		[Token(Token = "0x40016B6")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82ED9C", Offset = "0x82ED9C")]
		private CasualEnvironment _003Cenvironment_003Ek__BackingField;

		[Token(Token = "0x40016B7")]
		[FieldOffset(Offset = "0x48")]
		public CasualGameLoader m_casualContentLoader;

		[Token(Token = "0x40016B8")]
		[FieldOffset(Offset = "0x50")]
		public CasualGameLoader m_casualNetworkLoader;

		[Token(Token = "0x40016B9")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EDAC", Offset = "0x82EDAC")]
		private UkenTimeController _003CtimeController_003Ek__BackingField;

		[Token(Token = "0x40016BA")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EDBC", Offset = "0x82EDBC")]
		private UkenPaymentProvider _003CpaymentProvider_003Ek__BackingField;

		[Token(Token = "0x40016BB")]
		[FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EDCC", Offset = "0x82EDCC")]
		private CasualAnalog _003CanalogController_003Ek__BackingField;

		[Token(Token = "0x40016BC")]
		[FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EDDC", Offset = "0x82EDDC")]
		private CasualSceneManager _003CsceneManager_003Ek__BackingField;

		[Token(Token = "0x40016BD")]
		[FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EDEC", Offset = "0x82EDEC")]
		private UkenAnim _003CukenAnim_003Ek__BackingField;

		[Token(Token = "0x40016BE")]
		[FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EDFC", Offset = "0x82EDFC")]
		private AdsController _003CadController_003Ek__BackingField;

		[Token(Token = "0x40016BF")]
		[FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EE0C", Offset = "0x82EE0C")]
		private UkenWebController _003CukenWebController_003Ek__BackingField;

		[Token(Token = "0x40016C0")]
		[FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EE1C", Offset = "0x82EE1C")]
		private NotificationsController _003CnotificationsController_003Ek__BackingField;

		[Token(Token = "0x40016C1")]
		[FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EE2C", Offset = "0x82EE2C")]
		private UkenAuth _003Cauthenticator_003Ek__BackingField;

		[Token(Token = "0x40016C2")]
		[FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EE3C", Offset = "0x82EE3C")]
		private CasualFacebook _003CfacebookController_003Ek__BackingField;

		[Token(Token = "0x40016C3")]
		[FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EE4C", Offset = "0x82EE4C")]
		private JingotController _003Cjingot_003Ek__BackingField;

		[Token(Token = "0x40016C4")]
		[FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EE5C", Offset = "0x82EE5C")]
		private InventoryController _003CinventoryController_003Ek__BackingField;

		[Token(Token = "0x40016C5")]
		[FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EE6C", Offset = "0x82EE6C")]
		private Alerts _003Calerts_003Ek__BackingField;

		[Token(Token = "0x40016C6")]
		[FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EE7C", Offset = "0x82EE7C")]
		private Features _003Cfeatures_003Ek__BackingField;

		[Token(Token = "0x40016C7")]
		[FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EE8C", Offset = "0x82EE8C")]
		private UserAnalyticsController _003CuserAnalyticsController_003Ek__BackingField;

		[Token(Token = "0x40016C8")]
		[FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EE9C", Offset = "0x82EE9C")]
		private UserSegments _003CuserSegments_003Ek__BackingField;

		[Token(Token = "0x40016C9")]
		[FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EEAC", Offset = "0x82EEAC")]
		private ScoreboardController _003Cscoreboards_003Ek__BackingField;

		[Token(Token = "0x40016CA")]
		[FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EEBC", Offset = "0x82EEBC")]
		private ScoreboardEventBusController _003CscoreboardEventController_003Ek__BackingField;

		[Token(Token = "0x40016CB")]
		[FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EECC", Offset = "0x82EECC")]
		private RewardGroupsController _003CrewardGroupsController_003Ek__BackingField;

		[Token(Token = "0x40016CC")]
		[FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EEDC", Offset = "0x82EEDC")]
		private EventTickets _003CeventTickets_003Ek__BackingField;

		[Token(Token = "0x40016CD")]
		[FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EEEC", Offset = "0x82EEEC")]
		private LocalNotificationEvents _003ClocalNotificationEvents_003Ek__BackingField;

		[Token(Token = "0x40016CE")]
		[FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EEFC", Offset = "0x82EEFC")]
		private LocalNotifications _003ClocalNotifications_003Ek__BackingField;

		[Token(Token = "0x40016CF")]
		[FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EF0C", Offset = "0x82EF0C")]
		private NetworkStatusCentre _003CnetworkStatus_003Ek__BackingField;

		[Token(Token = "0x40016D0")]
		[FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EF1C", Offset = "0x82EF1C")]
		private Localizations _003ClocalizationController_003Ek__BackingField;

		[Token(Token = "0x40016D1")]
		[FieldOffset(Offset = "0x118")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EF2C", Offset = "0x82EF2C")]
		private AIDController _003Caid_003Ek__BackingField;

		[Token(Token = "0x40016D2")]
		[FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EF3C", Offset = "0x82EF3C")]
		private UserProfiler _003CuserProfiler_003Ek__BackingField;

		[Token(Token = "0x40016D3")]
		[FieldOffset(Offset = "0x128")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EF4C", Offset = "0x82EF4C")]
		private PurchaseProfiler _003CpurchaseProfiler_003Ek__BackingField;

		[Token(Token = "0x40016D4")]
		[FieldOffset(Offset = "0x130")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EF5C", Offset = "0x82EF5C")]
		private GooglePlayFileController _003CgooglePlayController_003Ek__BackingField;

		[Token(Token = "0x40016D5")]
		[FieldOffset(Offset = "0x138")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EF6C", Offset = "0x82EF6C")]
		private SalesRecordController _003CsalesRecords_003Ek__BackingField;

		[Token(Token = "0x40016D6")]
		[FieldOffset(Offset = "0x140")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EF7C", Offset = "0x82EF7C")]
		private ItemController _003CitemsController_003Ek__BackingField;

		[Token(Token = "0x40016D7")]
		[FieldOffset(Offset = "0x148")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EF8C", Offset = "0x82EF8C")]
		private Inbox _003CinboxController_003Ek__BackingField;

		[Token(Token = "0x40016D8")]
		[FieldOffset(Offset = "0x150")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EF9C", Offset = "0x82EF9C")]
		private PlatformInbox _003CplatformInbox_003Ek__BackingField;

		[Token(Token = "0x40016D9")]
		[FieldOffset(Offset = "0x158")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EFAC", Offset = "0x82EFAC")]
		private TeamsController _003Cm_teams_003Ek__BackingField;

		[Token(Token = "0x40016DA")]
		[FieldOffset(Offset = "0x160")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EFBC", Offset = "0x82EFBC")]
		private UserProfileFields _003Cm_userProfileFields_003Ek__BackingField;

		[Token(Token = "0x40016DB")]
		[FieldOffset(Offset = "0x168")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EFCC", Offset = "0x82EFCC")]
		private GameSettings _003Cm_gameSettings_003Ek__BackingField;

		[Token(Token = "0x40016DC")]
		[FieldOffset(Offset = "0x170")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EFDC", Offset = "0x82EFDC")]
		private SignalsAndStorageController _003Cm_signalsAndStorageController_003Ek__BackingField;

		[Token(Token = "0x40016DD")]
		[FieldOffset(Offset = "0x178")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EFEC", Offset = "0x82EFEC")]
		private VIPTiers _003Cm_vip_003Ek__BackingField;

		[Token(Token = "0x40016DE")]
		[FieldOffset(Offset = "0x180")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82EFFC", Offset = "0x82EFFC")]
		private AlertEvents _003Cm_alertEvents_003Ek__BackingField;

		[Token(Token = "0x40016DF")]
		[FieldOffset(Offset = "0x188")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82F00C", Offset = "0x82F00C")]
		private LeaderboardController _003CleaderboardController_003Ek__BackingField;

		[Token(Token = "0x40016E0")]
		[FieldOffset(Offset = "0x190")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82F01C", Offset = "0x82F01C")]
		private MetricsController _003Cm_metricsController_003Ek__BackingField;

		[Token(Token = "0x40016E1")]
		[FieldOffset(Offset = "0x198")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82F02C", Offset = "0x82F02C")]
		private PurchaseItems _003Cm_purchaseItems_003Ek__BackingField;

		[Token(Token = "0x40016E2")]
		[FieldOffset(Offset = "0x1A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82F03C", Offset = "0x82F03C")]
		private Sales _003Cm_sales_003Ek__BackingField;

		[Token(Token = "0x40016E3")]
		[FieldOffset(Offset = "0x1A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82F04C", Offset = "0x82F04C")]
		private DynamicOffers _003Cm_dynamicOffers_003Ek__BackingField;

		[Token(Token = "0x40016E4")]
		[FieldOffset(Offset = "0x1B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82F05C", Offset = "0x82F05C")]
		private DynamicOfferSets _003Cm_offerSets_003Ek__BackingField;

		[Token(Token = "0x40016E5")]
		[FieldOffset(Offset = "0x1B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82F06C", Offset = "0x82F06C")]
		private LTOs _003Cm_ltos_003Ek__BackingField;

		[Token(Token = "0x40016E6")]
		[FieldOffset(Offset = "0x1C0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82F07C", Offset = "0x82F07C")]
		private TSOs _003Cm_tsos_003Ek__BackingField;

		[Token(Token = "0x40016E7")]
		[FieldOffset(Offset = "0x1C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82F08C", Offset = "0x82F08C")]
		private GameTriggers _003Cm_gameTriggers_003Ek__BackingField;

		[Token(Token = "0x40016E8")]
		[FieldOffset(Offset = "0x1D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82F09C", Offset = "0x82F09C")]
		private CasualDataCacheController _003CcasualDataCacheController_003Ek__BackingField;

		[Token(Token = "0x40016E9")]
		[FieldOffset(Offset = "0x1D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82F0AC", Offset = "0x82F0AC")]
		private CasualDataStoreController _003CdataStoreController_003Ek__BackingField;

		[Token(Token = "0x17000607")]
		public CasualEnvironment environment
		{
			[Token(Token = "0x6002488")]
			[Address(RVA = "0xA26A58", Offset = "0xA26A58", VA = "0xA26A58", Slot = "16")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8397A4", Offset = "0x8397A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002489")]
			[Address(RVA = "0xA2EC34", Offset = "0xA2EC34", VA = "0xA2EC34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8397B4", Offset = "0x8397B4")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000608")]
		public UkenTimeController timeController
		{
			[Token(Token = "0x600248A")]
			[Address(RVA = "0xA203F8", Offset = "0xA203F8", VA = "0xA203F8", Slot = "17")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8397C4", Offset = "0x8397C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600248B")]
			[Address(RVA = "0xA2EC3C", Offset = "0xA2EC3C", VA = "0xA2EC3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8397D4", Offset = "0x8397D4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000609")]
		public UkenPaymentProvider paymentProvider
		{
			[Token(Token = "0x600248C")]
			[Address(RVA = "0xA2EC44", Offset = "0xA2EC44", VA = "0xA2EC44", Slot = "18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8397E4", Offset = "0x8397E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600248D")]
			[Address(RVA = "0xA2EC4C", Offset = "0xA2EC4C", VA = "0xA2EC4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8397F4", Offset = "0x8397F4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700060A")]
		public CasualAnalog analogController
		{
			[Token(Token = "0x600248E")]
			[Address(RVA = "0xA23178", Offset = "0xA23178", VA = "0xA23178", Slot = "19")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839804", Offset = "0x839804")]
			get
			{
				return null;
			}
			[Token(Token = "0x600248F")]
			[Address(RVA = "0xA2EC54", Offset = "0xA2EC54", VA = "0xA2EC54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839814", Offset = "0x839814")]
			private set
			{
			}
		}

		[Token(Token = "0x1700060B")]
		public CasualSceneManager sceneManager
		{
			[Token(Token = "0x6002490")]
			[Address(RVA = "0xA2ADC0", Offset = "0xA2ADC0", VA = "0xA2ADC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839824", Offset = "0x839824")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002491")]
			[Address(RVA = "0xA2EC5C", Offset = "0xA2EC5C", VA = "0xA2EC5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839834", Offset = "0x839834")]
			private set
			{
			}
		}

		[Token(Token = "0x1700060C")]
		public UkenAnim ukenAnim
		{
			[Token(Token = "0x6002492")]
			[Address(RVA = "0xA2EC64", Offset = "0xA2EC64", VA = "0xA2EC64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839844", Offset = "0x839844")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002493")]
			[Address(RVA = "0xA2EC6C", Offset = "0xA2EC6C", VA = "0xA2EC6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839854", Offset = "0x839854")]
			private set
			{
			}
		}

		[Token(Token = "0x1700060D")]
		public AdsController adController
		{
			[Token(Token = "0x6002494")]
			[Address(RVA = "0xA2EC74", Offset = "0xA2EC74", VA = "0xA2EC74", Slot = "20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839864", Offset = "0x839864")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002495")]
			[Address(RVA = "0xA2EC7C", Offset = "0xA2EC7C", VA = "0xA2EC7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839874", Offset = "0x839874")]
			private set
			{
			}
		}

		[Token(Token = "0x1700060E")]
		public UkenWebController ukenWebController
		{
			[Token(Token = "0x6002496")]
			[Address(RVA = "0xA2EC84", Offset = "0xA2EC84", VA = "0xA2EC84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839884", Offset = "0x839884")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002497")]
			[Address(RVA = "0xA2EC8C", Offset = "0xA2EC8C", VA = "0xA2EC8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839894", Offset = "0x839894")]
			private set
			{
			}
		}

		[Token(Token = "0x1700060F")]
		public NotificationsController notificationsController
		{
			[Token(Token = "0x6002498")]
			[Address(RVA = "0xA2EC94", Offset = "0xA2EC94", VA = "0xA2EC94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8398A4", Offset = "0x8398A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002499")]
			[Address(RVA = "0xA2EC9C", Offset = "0xA2EC9C", VA = "0xA2EC9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8398B4", Offset = "0x8398B4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000610")]
		public UkenAuth authenticator
		{
			[Token(Token = "0x600249A")]
			[Address(RVA = "0xA2ECA4", Offset = "0xA2ECA4", VA = "0xA2ECA4", Slot = "21")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8398C4", Offset = "0x8398C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600249B")]
			[Address(RVA = "0xA2ECAC", Offset = "0xA2ECAC", VA = "0xA2ECAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8398D4", Offset = "0x8398D4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000611")]
		public CasualFacebook facebookController
		{
			[Token(Token = "0x600249C")]
			[Address(RVA = "0xA2ECB4", Offset = "0xA2ECB4", VA = "0xA2ECB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8398E4", Offset = "0x8398E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600249D")]
			[Address(RVA = "0xA2ECBC", Offset = "0xA2ECBC", VA = "0xA2ECBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8398F4", Offset = "0x8398F4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000612")]
		public JingotController jingot
		{
			[Token(Token = "0x600249E")]
			[Address(RVA = "0xA2ECC4", Offset = "0xA2ECC4", VA = "0xA2ECC4", Slot = "22")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839904", Offset = "0x839904")]
			get
			{
				return null;
			}
			[Token(Token = "0x600249F")]
			[Address(RVA = "0xA2ECCC", Offset = "0xA2ECCC", VA = "0xA2ECCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839914", Offset = "0x839914")]
			private set
			{
			}
		}

		[Token(Token = "0x17000613")]
		public InventoryController inventoryController
		{
			[Token(Token = "0x60024A0")]
			[Address(RVA = "0xA202CC", Offset = "0xA202CC", VA = "0xA202CC", Slot = "23")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839924", Offset = "0x839924")]
			get
			{
				return null;
			}
			[Token(Token = "0x60024A1")]
			[Address(RVA = "0xA2ECD4", Offset = "0xA2ECD4", VA = "0xA2ECD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839934", Offset = "0x839934")]
			private set
			{
			}
		}

		[Token(Token = "0x17000614")]
		public Alerts alerts
		{
			[Token(Token = "0x60024A2")]
			[Address(RVA = "0xA24B08", Offset = "0xA24B08", VA = "0xA24B08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839944", Offset = "0x839944")]
			get
			{
				return null;
			}
			[Token(Token = "0x60024A3")]
			[Address(RVA = "0xA2ECDC", Offset = "0xA2ECDC", VA = "0xA2ECDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839954", Offset = "0x839954")]
			private set
			{
			}
		}

		[Token(Token = "0x17000615")]
		public Features features
		{
			[Token(Token = "0x60024A4")]
			[Address(RVA = "0xA22F18", Offset = "0xA22F18", VA = "0xA22F18", Slot = "24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839964", Offset = "0x839964")]
			get
			{
				return null;
			}
			[Token(Token = "0x60024A5")]
			[Address(RVA = "0xA2ECE4", Offset = "0xA2ECE4", VA = "0xA2ECE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839974", Offset = "0x839974")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000616")]
		public UserAnalyticsController userAnalyticsController
		{
			[Token(Token = "0x60024A6")]
			[Address(RVA = "0xA2ECEC", Offset = "0xA2ECEC", VA = "0xA2ECEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839984", Offset = "0x839984")]
			get
			{
				return null;
			}
			[Token(Token = "0x60024A7")]
			[Address(RVA = "0xA2ECF4", Offset = "0xA2ECF4", VA = "0xA2ECF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839994", Offset = "0x839994")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000617")]
		public UserSegments userSegments
		{
			[Token(Token = "0x60024A8")]
			[Address(RVA = "0xA24AF8", Offset = "0xA24AF8", VA = "0xA24AF8", Slot = "25")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8399A4", Offset = "0x8399A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60024A9")]
			[Address(RVA = "0xA2ECFC", Offset = "0xA2ECFC", VA = "0xA2ECFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8399B4", Offset = "0x8399B4")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000618")]
		public ScoreboardController scoreboards
		{
			[Token(Token = "0x60024AA")]
			[Address(RVA = "0xA2ED04", Offset = "0xA2ED04", VA = "0xA2ED04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8399C4", Offset = "0x8399C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60024AB")]
			[Address(RVA = "0xA2ED0C", Offset = "0xA2ED0C", VA = "0xA2ED0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8399D4", Offset = "0x8399D4")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000619")]
		public ScoreboardEventBusController scoreboardEventController
		{
			[Token(Token = "0x60024AC")]
			[Address(RVA = "0xA2ED14", Offset = "0xA2ED14", VA = "0xA2ED14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8399E4", Offset = "0x8399E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60024AD")]
			[Address(RVA = "0xA2ED1C", Offset = "0xA2ED1C", VA = "0xA2ED1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8399F4", Offset = "0x8399F4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700061A")]
		public RewardGroupsController rewardGroupsController
		{
			[Token(Token = "0x60024AE")]
			[Address(RVA = "0xA2ED24", Offset = "0xA2ED24", VA = "0xA2ED24", Slot = "26")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839A04", Offset = "0x839A04")]
			get
			{
				return null;
			}
			[Token(Token = "0x60024AF")]
			[Address(RVA = "0xA2ED2C", Offset = "0xA2ED2C", VA = "0xA2ED2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839A14", Offset = "0x839A14")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700061B")]
		public EventTickets eventTickets
		{
			[Token(Token = "0x60024B0")]
			[Address(RVA = "0xA2ED34", Offset = "0xA2ED34", VA = "0xA2ED34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839A24", Offset = "0x839A24")]
			get
			{
				return null;
			}
			[Token(Token = "0x60024B1")]
			[Address(RVA = "0xA2ED3C", Offset = "0xA2ED3C", VA = "0xA2ED3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839A34", Offset = "0x839A34")]
			private set
			{
			}
		}

		[Token(Token = "0x1700061C")]
		public LocalNotificationEvents localNotificationEvents
		{
			[Token(Token = "0x60024B2")]
			[Address(RVA = "0xA2ED44", Offset = "0xA2ED44", VA = "0xA2ED44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839A44", Offset = "0x839A44")]
			get
			{
				return null;
			}
			[Token(Token = "0x60024B3")]
			[Address(RVA = "0xA2ED4C", Offset = "0xA2ED4C", VA = "0xA2ED4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839A54", Offset = "0x839A54")]
			private set
			{
			}
		}

		[Token(Token = "0x1700061D")]
		public LocalNotifications localNotifications
		{
			[Token(Token = "0x60024B4")]
			[Address(RVA = "0xA2ED54", Offset = "0xA2ED54", VA = "0xA2ED54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839A64", Offset = "0x839A64")]
			get
			{
				return null;
			}
			[Token(Token = "0x60024B5")]
			[Address(RVA = "0xA2ED5C", Offset = "0xA2ED5C", VA = "0xA2ED5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839A74", Offset = "0x839A74")]
			private set
			{
			}
		}

		[Token(Token = "0x1700061E")]
		public NetworkStatusCentre networkStatus
		{
			[Token(Token = "0x60024B6")]
			[Address(RVA = "0xA2ED64", Offset = "0xA2ED64", VA = "0xA2ED64", Slot = "27")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839A84", Offset = "0x839A84")]
			get
			{
				return null;
			}
			[Token(Token = "0x60024B7")]
			[Address(RVA = "0xA2ED6C", Offset = "0xA2ED6C", VA = "0xA2ED6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839A94", Offset = "0x839A94")]
			private set
			{
			}
		}

		[Token(Token = "0x1700061F")]
		public Localizations localizationController
		{
			[Token(Token = "0x60024B8")]
			[Address(RVA = "0xA2ED74", Offset = "0xA2ED74", VA = "0xA2ED74", Slot = "28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839AA4", Offset = "0x839AA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60024B9")]
			[Address(RVA = "0xA2ED7C", Offset = "0xA2ED7C", VA = "0xA2ED7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839AB4", Offset = "0x839AB4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000620")]
		public AIDController aid
		{
			[Token(Token = "0x60024BA")]
			[Address(RVA = "0xA2ED84", Offset = "0xA2ED84", VA = "0xA2ED84", Slot = "29")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839AC4", Offset = "0x839AC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60024BB")]
			[Address(RVA = "0xA2ED8C", Offset = "0xA2ED8C", VA = "0xA2ED8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839AD4", Offset = "0x839AD4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000621")]
		public UserProfiler userProfiler
		{
			[Token(Token = "0x60024BC")]
			[Address(RVA = "0xA24B00", Offset = "0xA24B00", VA = "0xA24B00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839AE4", Offset = "0x839AE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60024BD")]
			[Address(RVA = "0xA2ED94", Offset = "0xA2ED94", VA = "0xA2ED94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839AF4", Offset = "0x839AF4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000622")]
		public PurchaseProfiler purchaseProfiler
		{
			[Token(Token = "0x60024BE")]
			[Address(RVA = "0xA2ED9C", Offset = "0xA2ED9C", VA = "0xA2ED9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839B04", Offset = "0x839B04")]
			get
			{
				return null;
			}
			[Token(Token = "0x60024BF")]
			[Address(RVA = "0xA2EDA4", Offset = "0xA2EDA4", VA = "0xA2EDA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839B14", Offset = "0x839B14")]
			private set
			{
			}
		}

		[Token(Token = "0x17000623")]
		public GooglePlayFileController googlePlayController
		{
			[Token(Token = "0x60024C0")]
			[Address(RVA = "0xA2EDAC", Offset = "0xA2EDAC", VA = "0xA2EDAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839B24", Offset = "0x839B24")]
			get
			{
				return null;
			}
			[Token(Token = "0x60024C1")]
			[Address(RVA = "0xA2EDB4", Offset = "0xA2EDB4", VA = "0xA2EDB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839B34", Offset = "0x839B34")]
			private set
			{
			}
		}

		[Token(Token = "0x17000624")]
		public SalesRecordController salesRecords
		{
			[Token(Token = "0x60024C2")]
			[Address(RVA = "0xA2EDBC", Offset = "0xA2EDBC", VA = "0xA2EDBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839B44", Offset = "0x839B44")]
			get
			{
				return null;
			}
			[Token(Token = "0x60024C3")]
			[Address(RVA = "0xA2EDC4", Offset = "0xA2EDC4", VA = "0xA2EDC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839B54", Offset = "0x839B54")]
			private set
			{
			}
		}

		[Token(Token = "0x17000625")]
		public ItemController itemsController
		{
			[Token(Token = "0x60024C4")]
			[Address(RVA = "0xA2EDCC", Offset = "0xA2EDCC", VA = "0xA2EDCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839B64", Offset = "0x839B64")]
			get
			{
				return null;
			}
			[Token(Token = "0x60024C5")]
			[Address(RVA = "0xA2EDD4", Offset = "0xA2EDD4", VA = "0xA2EDD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839B74", Offset = "0x839B74")]
			private set
			{
			}
		}

		[Token(Token = "0x17000626")]
		public Inbox inboxController
		{
			[Token(Token = "0x60024C6")]
			[Address(RVA = "0xA2EDDC", Offset = "0xA2EDDC", VA = "0xA2EDDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839B84", Offset = "0x839B84")]
			get
			{
				return null;
			}
			[Token(Token = "0x60024C7")]
			[Address(RVA = "0xA2EDE4", Offset = "0xA2EDE4", VA = "0xA2EDE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839B94", Offset = "0x839B94")]
			private set
			{
			}
		}

		[Token(Token = "0x17000627")]
		public PlatformInbox platformInbox
		{
			[Token(Token = "0x60024C8")]
			[Address(RVA = "0xA2EDEC", Offset = "0xA2EDEC", VA = "0xA2EDEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839BA4", Offset = "0x839BA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60024C9")]
			[Address(RVA = "0xA2EDF4", Offset = "0xA2EDF4", VA = "0xA2EDF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839BB4", Offset = "0x839BB4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000628")]
		public TeamsController m_teams
		{
			[Token(Token = "0x60024CA")]
			[Address(RVA = "0xA2EDFC", Offset = "0xA2EDFC", VA = "0xA2EDFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839BC4", Offset = "0x839BC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60024CB")]
			[Address(RVA = "0xA2EE04", Offset = "0xA2EE04", VA = "0xA2EE04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839BD4", Offset = "0x839BD4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000629")]
		public UserProfileFields m_userProfileFields
		{
			[Token(Token = "0x60024CC")]
			[Address(RVA = "0xA2EE0C", Offset = "0xA2EE0C", VA = "0xA2EE0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839BE4", Offset = "0x839BE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60024CD")]
			[Address(RVA = "0xA2EE14", Offset = "0xA2EE14", VA = "0xA2EE14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839BF4", Offset = "0x839BF4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700062A")]
		public GameSettings m_gameSettings
		{
			[Token(Token = "0x60024CE")]
			[Address(RVA = "0xA2EE1C", Offset = "0xA2EE1C", VA = "0xA2EE1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839C04", Offset = "0x839C04")]
			get
			{
				return null;
			}
			[Token(Token = "0x60024CF")]
			[Address(RVA = "0xA2EE24", Offset = "0xA2EE24", VA = "0xA2EE24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839C14", Offset = "0x839C14")]
			private set
			{
			}
		}

		[Token(Token = "0x1700062B")]
		public SignalsAndStorageController m_signalsAndStorageController
		{
			[Token(Token = "0x60024D0")]
			[Address(RVA = "0xA2EE2C", Offset = "0xA2EE2C", VA = "0xA2EE2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839C24", Offset = "0x839C24")]
			get
			{
				return null;
			}
			[Token(Token = "0x60024D1")]
			[Address(RVA = "0xA2EE34", Offset = "0xA2EE34", VA = "0xA2EE34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839C34", Offset = "0x839C34")]
			private set
			{
			}
		}

		[Token(Token = "0x1700062C")]
		public VIPTiers m_vip
		{
			[Token(Token = "0x60024D2")]
			[Address(RVA = "0xA2EE3C", Offset = "0xA2EE3C", VA = "0xA2EE3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839C44", Offset = "0x839C44")]
			get
			{
				return null;
			}
			[Token(Token = "0x60024D3")]
			[Address(RVA = "0xA2EE44", Offset = "0xA2EE44", VA = "0xA2EE44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839C54", Offset = "0x839C54")]
			private set
			{
			}
		}

		[Token(Token = "0x1700062D")]
		public AlertEvents m_alertEvents
		{
			[Token(Token = "0x60024D4")]
			[Address(RVA = "0xA2EE4C", Offset = "0xA2EE4C", VA = "0xA2EE4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839C64", Offset = "0x839C64")]
			get
			{
				return null;
			}
			[Token(Token = "0x60024D5")]
			[Address(RVA = "0xA2EE54", Offset = "0xA2EE54", VA = "0xA2EE54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839C74", Offset = "0x839C74")]
			private set
			{
			}
		}

		[Token(Token = "0x1700062E")]
		public LeaderboardController leaderboardController
		{
			[Token(Token = "0x60024D6")]
			[Address(RVA = "0xA2EE5C", Offset = "0xA2EE5C", VA = "0xA2EE5C", Slot = "30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839C84", Offset = "0x839C84")]
			get
			{
				return null;
			}
			[Token(Token = "0x60024D7")]
			[Address(RVA = "0xA2EE64", Offset = "0xA2EE64", VA = "0xA2EE64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839C94", Offset = "0x839C94")]
			private set
			{
			}
		}

		[Token(Token = "0x1700062F")]
		public MetricsController m_metricsController
		{
			[Token(Token = "0x60024D8")]
			[Address(RVA = "0xA2EE6C", Offset = "0xA2EE6C", VA = "0xA2EE6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839CA4", Offset = "0x839CA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60024D9")]
			[Address(RVA = "0xA2EE74", Offset = "0xA2EE74", VA = "0xA2EE74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839CB4", Offset = "0x839CB4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000630")]
		public PurchaseItems m_purchaseItems
		{
			[Token(Token = "0x60024DA")]
			[Address(RVA = "0xA2EE7C", Offset = "0xA2EE7C", VA = "0xA2EE7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839CC4", Offset = "0x839CC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60024DB")]
			[Address(RVA = "0xA2EE84", Offset = "0xA2EE84", VA = "0xA2EE84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839CD4", Offset = "0x839CD4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000631")]
		public Sales m_sales
		{
			[Token(Token = "0x60024DC")]
			[Address(RVA = "0xA2EE8C", Offset = "0xA2EE8C", VA = "0xA2EE8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839CE4", Offset = "0x839CE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60024DD")]
			[Address(RVA = "0xA2EE94", Offset = "0xA2EE94", VA = "0xA2EE94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839CF4", Offset = "0x839CF4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000632")]
		public DynamicOffers m_dynamicOffers
		{
			[Token(Token = "0x60024DE")]
			[Address(RVA = "0xA2EE9C", Offset = "0xA2EE9C", VA = "0xA2EE9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839D04", Offset = "0x839D04")]
			get
			{
				return null;
			}
			[Token(Token = "0x60024DF")]
			[Address(RVA = "0xA2EEA4", Offset = "0xA2EEA4", VA = "0xA2EEA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839D14", Offset = "0x839D14")]
			private set
			{
			}
		}

		[Token(Token = "0x17000633")]
		public DynamicOfferSets m_offerSets
		{
			[Token(Token = "0x60024E0")]
			[Address(RVA = "0xA2EEAC", Offset = "0xA2EEAC", VA = "0xA2EEAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839D24", Offset = "0x839D24")]
			get
			{
				return null;
			}
			[Token(Token = "0x60024E1")]
			[Address(RVA = "0xA2EEB4", Offset = "0xA2EEB4", VA = "0xA2EEB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839D34", Offset = "0x839D34")]
			private set
			{
			}
		}

		[Token(Token = "0x17000634")]
		public LTOs m_ltos
		{
			[Token(Token = "0x60024E2")]
			[Address(RVA = "0xA2EEBC", Offset = "0xA2EEBC", VA = "0xA2EEBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839D44", Offset = "0x839D44")]
			get
			{
				return null;
			}
			[Token(Token = "0x60024E3")]
			[Address(RVA = "0xA2EEC4", Offset = "0xA2EEC4", VA = "0xA2EEC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839D54", Offset = "0x839D54")]
			private set
			{
			}
		}

		[Token(Token = "0x17000635")]
		public TSOs m_tsos
		{
			[Token(Token = "0x60024E4")]
			[Address(RVA = "0xA2EECC", Offset = "0xA2EECC", VA = "0xA2EECC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839D64", Offset = "0x839D64")]
			get
			{
				return null;
			}
			[Token(Token = "0x60024E5")]
			[Address(RVA = "0xA2EED4", Offset = "0xA2EED4", VA = "0xA2EED4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839D74", Offset = "0x839D74")]
			private set
			{
			}
		}

		[Token(Token = "0x17000636")]
		public GameTriggers m_gameTriggers
		{
			[Token(Token = "0x60024E6")]
			[Address(RVA = "0xA2EEDC", Offset = "0xA2EEDC", VA = "0xA2EEDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839D84", Offset = "0x839D84")]
			get
			{
				return null;
			}
			[Token(Token = "0x60024E7")]
			[Address(RVA = "0xA2EEE4", Offset = "0xA2EEE4", VA = "0xA2EEE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839D94", Offset = "0x839D94")]
			private set
			{
			}
		}

		[Token(Token = "0x17000637")]
		public CasualDataCacheController casualDataCacheController
		{
			[Token(Token = "0x60024E8")]
			[Address(RVA = "0xA2EEEC", Offset = "0xA2EEEC", VA = "0xA2EEEC", Slot = "31")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839DA4", Offset = "0x839DA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60024E9")]
			[Address(RVA = "0xA2EEF4", Offset = "0xA2EEF4", VA = "0xA2EEF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839DB4", Offset = "0x839DB4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000638")]
		public StoreModel storeModel
		{
			[Token(Token = "0x60024EA")]
			[Address(RVA = "0xA2EEFC", Offset = "0xA2EEFC", VA = "0xA2EEFC", Slot = "32")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000639")]
		protected CasualDataStoreController dataStoreController
		{
			[Token(Token = "0x60024EB")]
			[Address(RVA = "0xA2EF2C", Offset = "0xA2EF2C", VA = "0xA2EF2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839DC4", Offset = "0x839DC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60024EC")]
			[Address(RVA = "0xA2EF34", Offset = "0xA2EF34", VA = "0xA2EF34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839DD4", Offset = "0x839DD4")]
			private set
			{
			}
		}

		[Token(Token = "0x6002487")]
		[Address(RVA = "0xA20144", Offset = "0xA20144", VA = "0xA20144")]
		public static CasualGame Get()
		{
			return null;
		}

		[Token(Token = "0x60024ED")]
		[Address(RVA = "0xA2EF3C", Offset = "0xA2EF3C", VA = "0xA2EF3C")]
		public CasualDataStoreModel CasualData()
		{
			return null;
		}

		[Token(Token = "0x60024EE")]
		[Address(RVA = "0xA2EFD8", Offset = "0xA2EFD8", VA = "0xA2EFD8", Slot = "6")]
		protected override void RegisterController(UkenController controller)
		{
		}

		[Token(Token = "0x60024EF")]
		[Address(RVA = "0xA2F0FC", Offset = "0xA2F0FC", VA = "0xA2F0FC", Slot = "33")]
		public virtual bool LoadContent()
		{
			return default(bool);
		}

		[Token(Token = "0x60024F0")]
		[Address(RVA = "0xA2F134", Offset = "0xA2F134", VA = "0xA2F134", Slot = "34")]
		public virtual string GameName()
		{
			return null;
		}

		[Token(Token = "0x60024F1")]
		[Address(RVA = "0xA2F17C", Offset = "0xA2F17C", VA = "0xA2F17C", Slot = "4")]
		public override void Create()
		{
		}

		[Token(Token = "0x60024F2")]
		[Address(RVA = "0xA30470", Offset = "0xA30470", VA = "0xA30470", Slot = "35")]
		public virtual ItemController CreateItemController()
		{
			return null;
		}

		[Token(Token = "0x60024F3")]
		[Address(RVA = "0xA304D8", Offset = "0xA304D8", VA = "0xA304D8", Slot = "36")]
		public virtual Inbox CreateInbox()
		{
			return null;
		}

		[Token(Token = "0x60024F4")]
		[Address(RVA = "0xA305BC", Offset = "0xA305BC", VA = "0xA305BC", Slot = "37")]
		public virtual CasualEnvironment CreateEnvironment()
		{
			return null;
		}

		[Token(Token = "0x60024F5")]
		[Address(RVA = "0xA30640", Offset = "0xA30640", VA = "0xA30640", Slot = "38")]
		public virtual string GetHothCredentialPath()
		{
			return null;
		}

		[Token(Token = "0x60024F6")]
		[Address(RVA = "0xA306B4", Offset = "0xA306B4", VA = "0xA306B4", Slot = "39")]
		public virtual void SetupAdProvider(string newProvider)
		{
		}

		[Token(Token = "0x60024F7")]
		[Address(RVA = "0xA3075C", Offset = "0xA3075C", VA = "0xA3075C", Slot = "40")]
		protected virtual void QueryForFacebookToUserIdMap(List<string> facebookIds, Action<bool, Dictionary<string, string>> onComplete)
		{
		}

		[Token(Token = "0x60024F8")]
		[Address(RVA = "0xA307E8", Offset = "0xA307E8", VA = "0xA307E8", Slot = "41")]
		public virtual float GetTotalPurchaseScale(string itemName)
		{
			return default(float);
		}

		[Token(Token = "0x60024F9")]
		public abstract UkenPaymentProvider CreatePaymentProvider();

		[Token(Token = "0x60024FA")]
		public abstract UkenPaymentValidator CreatePaymentValidator();

		[Token(Token = "0x60024FB")]
		public abstract bool IsNewUser();

		[Token(Token = "0x60024FC")]
		public abstract NotificationManager CreateLocalNotificationManager();

		[Token(Token = "0x60024FD")]
		public abstract void SaveScoreboardData(ScoreboardSaveData dataToSave);

		[Token(Token = "0x60024FE")]
		public abstract ScoreboardSaveData LoadScoreboardData();

		[Token(Token = "0x60024FF")]
		[Address(RVA = "0xA30834", Offset = "0xA30834", VA = "0xA30834", Slot = "48")]
		public virtual void SaveLeagueData(LeagueSavedData data)
		{
		}

		[Token(Token = "0x6002500")]
		[Address(RVA = "0xA30838", Offset = "0xA30838", VA = "0xA30838", Slot = "49")]
		public virtual LeagueSavedData LoadLeagueData()
		{
			return null;
		}

		[Token(Token = "0x6002501")]
		[Address(RVA = "0xA30840", Offset = "0xA30840", VA = "0xA30840", Slot = "50")]
		public virtual string GetScoreboardUserData()
		{
			return null;
		}

		[Token(Token = "0x6002502")]
		public abstract string SoftCurrencyName();

		[Token(Token = "0x6002503")]
		public abstract string HardCurrencyName();

		[Token(Token = "0x6002504")]
		[Address(RVA = "0xA30888", Offset = "0xA30888", VA = "0xA30888", Slot = "53")]
		public virtual bool IsFacebookConnected()
		{
			return default(bool);
		}

		[Token(Token = "0x6002505")]
		[Address(RVA = "0xA30890", Offset = "0xA30890", VA = "0xA30890", Slot = "54")]
		public virtual void ResetFacebookCredentials()
		{
		}

		[Token(Token = "0x6002506")]
		[Address(RVA = "0xA30894", Offset = "0xA30894", VA = "0xA30894", Slot = "55")]
		public virtual RuntimeContext CreateAnalogContext()
		{
			return null;
		}

		[Token(Token = "0x6002507")]
		[Address(RVA = "0xA30A24", Offset = "0xA30A24", VA = "0xA30A24", Slot = "56")]
		public virtual string GetUserID()
		{
			return null;
		}

		[Token(Token = "0x6002508")]
		[Address(RVA = "0xA30A54", Offset = "0xA30A54", VA = "0xA30A54", Slot = "57")]
		public virtual bool CanAwardItem(string itemReference)
		{
			return default(bool);
		}

		[Token(Token = "0x6002509")]
		[Address(RVA = "0xA30A5C", Offset = "0xA30A5C", VA = "0xA30A5C", Slot = "58")]
		public virtual string GetVersion()
		{
			return null;
		}

		[Token(Token = "0x600250A")]
		[Address(RVA = "0xA30A64", Offset = "0xA30A64", VA = "0xA30A64", Slot = "59")]
		public virtual string GetPlatform()
		{
			return null;
		}

		[Token(Token = "0x600250B")]
		[Address(RVA = "0xA30AC4", Offset = "0xA30AC4", VA = "0xA30AC4", Slot = "60")]
		public virtual string GetImageForItem(string inventoryItem)
		{
			return null;
		}

		[Token(Token = "0x600250C")]
		[Address(RVA = "0xA30B0C", Offset = "0xA30B0C", VA = "0xA30B0C", Slot = "61")]
		public virtual bool ShowDynamicOffer(DynamicOfferSet offerSet, Action<bool> onPurchaseComplete)
		{
			return default(bool);
		}

		[Token(Token = "0x600250D")]
		[Address(RVA = "0xA30B14", Offset = "0xA30B14", VA = "0xA30B14", Slot = "62")]
		public virtual CasualDataStoreController CreateDataStoreController()
		{
			return null;
		}

		[Token(Token = "0x600250E")]
		[Address(RVA = "0xA30BF4", Offset = "0xA30BF4", VA = "0xA30BF4", Slot = "63")]
		public virtual InventoryController CreateInventory()
		{
			return null;
		}

		[Token(Token = "0x600250F")]
		[Address(RVA = "0xA30D3C", Offset = "0xA30D3C", VA = "0xA30D3C", Slot = "64")]
		public virtual EventTickets CreateEventTicketsController()
		{
			return null;
		}

		[Token(Token = "0x6002510")]
		[Address(RVA = "0xA30DA4", Offset = "0xA30DA4", VA = "0xA30DA4")]
		public string GetEntityID(JingotEntityType entityType)
		{
			return null;
		}

		[Token(Token = "0x6002511")]
		[Address(RVA = "0xA30DB4", Offset = "0xA30DB4", VA = "0xA30DB4", Slot = "65")]
		public virtual string GetEntityCreatedAt(JingotEntityType entityType)
		{
			return null;
		}

		[Token(Token = "0x6002512")]
		[Address(RVA = "0xA30DFC", Offset = "0xA30DFC", VA = "0xA30DFC")]
		public void WebSend(WebRequest request)
		{
		}

		[Token(Token = "0x6002513")]
		[Address(RVA = "0xA311E0", Offset = "0xA311E0", VA = "0xA311E0", Slot = "66")]
		public virtual UserProfiler CreateUserProfiler()
		{
			return null;
		}

		[Token(Token = "0x6002514")]
		[Address(RVA = "0xA31244", Offset = "0xA31244", VA = "0xA31244", Slot = "67")]
		public virtual PurchaseProfiler CreatePurchaseProfiler()
		{
			return null;
		}

		[Token(Token = "0x6002515")]
		[Address(RVA = "0xA3124C", Offset = "0xA3124C", VA = "0xA3124C", Slot = "68")]
		public virtual ScoreboardEventBusController CreateScoreboardEventBusController()
		{
			return null;
		}

		[Token(Token = "0x6002516")]
		[Address(RVA = "0xA312A8", Offset = "0xA312A8", VA = "0xA312A8", Slot = "69")]
		public virtual DateTime GetCurrentTime()
		{
			return default(DateTime);
		}

		[Token(Token = "0x6002517")]
		[Address(RVA = "0xA312D8", Offset = "0xA312D8", VA = "0xA312D8", Slot = "70")]
		public virtual bool IsOnlineAndTimeValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6002518")]
		[Address(RVA = "0xA31308", Offset = "0xA31308", VA = "0xA31308", Slot = "5")]
		protected override bool IsOnline()
		{
			return default(bool);
		}

		[Token(Token = "0x6002519")]
		[Address(RVA = "0xA31338", Offset = "0xA31338", VA = "0xA31338")]
		protected void IssueNetworkStatusPing()
		{
		}

		[Token(Token = "0x600251A")]
		[Address(RVA = "0xA31370", Offset = "0xA31370", VA = "0xA31370", Slot = "71")]
		public virtual bool CanShowInterstitials()
		{
			return default(bool);
		}

		[Token(Token = "0x600251B")]
		[Address(RVA = "0xA31378", Offset = "0xA31378", VA = "0xA31378", Slot = "72")]
		protected virtual UkenWebConfig GetWebConfig()
		{
			return null;
		}

		[Token(Token = "0x600251C")]
		[Address(RVA = "0xA31460", Offset = "0xA31460", VA = "0xA31460", Slot = "73")]
		protected virtual CasualSceneManager CreateSceneManager()
		{
			return null;
		}

		[Token(Token = "0x600251D")]
		[Address(RVA = "0xA314BC", Offset = "0xA314BC", VA = "0xA314BC", Slot = "74")]
		public virtual void Login(Action onLoginComplete)
		{
		}

		[Token(Token = "0x600251E")]
		[Address(RVA = "0xA31618", Offset = "0xA31618", VA = "0xA31618", Slot = "75")]
		public virtual List<LoadingEvent> GetLoadingEvents()
		{
			return null;
		}

		[Token(Token = "0x600251F")]
		[Address(RVA = "0xA3190C", Offset = "0xA3190C", VA = "0xA3190C", Slot = "76")]
		public virtual void UpdateRemoteData()
		{
		}

		[Token(Token = "0x6002520")]
		[Address(RVA = "0xA31B30", Offset = "0xA31B30", VA = "0xA31B30")]
		public void QueryJingot(Action<bool> onComplete)
		{
		}

		[Token(Token = "0x6002521")]
		[Address(RVA = "0xA31C14", Offset = "0xA31C14", VA = "0xA31C14", Slot = "77")]
		protected virtual void LogABAssignments()
		{
		}

		[Token(Token = "0x6002522")]
		[Address(RVA = "0xA31C64", Offset = "0xA31C64", VA = "0xA31C64")]
		public void QueryUserAnalytics(Action<bool> onComplete)
		{
		}

		[Token(Token = "0x6002523")]
		[Address(RVA = "0xA31D50", Offset = "0xA31D50", VA = "0xA31D50", Slot = "78")]
		public virtual void QueryInbox(Action<bool> onComplete)
		{
		}

		[Token(Token = "0x6002524")]
		[Address(RVA = "0xA31E18", Offset = "0xA31E18", VA = "0xA31E18", Slot = "79")]
		public virtual void QueryReferenceData(Action<bool> onComplete)
		{
		}

		[Token(Token = "0x6002525")]
		[Address(RVA = "0xA31EE4", Offset = "0xA31EE4", VA = "0xA31EE4", Slot = "80")]
		public virtual void LoadScoreboardSaveData(Action<bool> onComplete)
		{
		}

		[Token(Token = "0x6002526")]
		[Address(RVA = "0xA31F68", Offset = "0xA31F68", VA = "0xA31F68", Slot = "81")]
		public virtual void QueryInventory(Action<bool> onComplete)
		{
		}

		[Token(Token = "0x6002527")]
		[Address(RVA = "0xA3208C", Offset = "0xA3208C", VA = "0xA3208C", Slot = "82")]
		public virtual void QueryIAPData(Action<bool> onComplete)
		{
		}

		[Token(Token = "0x6002528")]
		[Address(RVA = "0xA321A4", Offset = "0xA321A4", VA = "0xA321A4")]
		public string GetAdjustAdid()
		{
			return null;
		}

		[Token(Token = "0x6002529")]
		[Address(RVA = "0xA3226C", Offset = "0xA3226C", VA = "0xA3226C")]
		public void ReportAttribution()
		{
		}

		[Token(Token = "0x600252A")]
		[Address(RVA = "0xA3248C", Offset = "0xA3248C", VA = "0xA3248C", Slot = "83")]
		public virtual void OnLoadComplete(bool success)
		{
		}

		[Token(Token = "0x600252B")]
		[Address(RVA = "0xA324D4", Offset = "0xA324D4", VA = "0xA324D4")]
		private void CheckForEscapeKey()
		{
		}

		[Token(Token = "0x600252C")]
		[Address(RVA = "0xA325B0", Offset = "0xA325B0", VA = "0xA325B0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x839DE4", Offset = "0x839DE4")]
		public void Transaction(RewardGroup rewards, string event_name, string source_sink)
		{
		}

		[Token(Token = "0x600252D")]
		[Address(RVA = "0xA325E0", Offset = "0xA325E0", VA = "0xA325E0", Slot = "84")]
		public virtual void Transaction(RewardGroup rewardGroups, string event_name, string source_sink, out List<FinalizedReward> finalizedRewards)
		{
		}

		[Token(Token = "0x600252E")]
		[Address(RVA = "0xA32D94", Offset = "0xA32D94", VA = "0xA32D94")]
		public string GetUserRegion()
		{
			return null;
		}

		[Token(Token = "0x600252F")]
		[Address(RVA = "0xA32EA0", Offset = "0xA32EA0", VA = "0xA32EA0", Slot = "85")]
		public virtual bool IsGameReady()
		{
			return default(bool);
		}

		[Token(Token = "0x6002530")]
		[Address(RVA = "0xA32ED0", Offset = "0xA32ED0", VA = "0xA32ED0", Slot = "11")]
		protected override bool UpdateGame(float fDeltaTime)
		{
			return default(bool);
		}

		[Token(Token = "0x6002531")]
		[Address(RVA = "0xA32F04", Offset = "0xA32F04", VA = "0xA32F04", Slot = "12")]
		public override void Cleanup()
		{
		}

		[Token(Token = "0x6002532")]
		[Address(RVA = "0xA32F3C", Offset = "0xA32F3C", VA = "0xA32F3C", Slot = "86")]
		public virtual string GetInventoryItemName(string reference, long quantity)
		{
			return null;
		}

		[Token(Token = "0x6002533")]
		[Address(RVA = "0xA32F44", Offset = "0xA32F44", VA = "0xA32F44", Slot = "87")]
		public virtual Dictionary<string, string> GetAltValueDrivers()
		{
			return null;
		}

		[Token(Token = "0x6002534")]
		[Address(RVA = "0xA32F74", Offset = "0xA32F74", VA = "0xA32F74", Slot = "88")]
		public virtual bool IsSignedIn()
		{
			return default(bool);
		}

		[Token(Token = "0x6002535")]
		[Address(RVA = "0xA33030", Offset = "0xA33030", VA = "0xA33030", Slot = "8")]
		protected override void OnGamePaused(bool paused)
		{
		}

		[Token(Token = "0x6002536")]
		[Address(RVA = "0xA33050", Offset = "0xA33050", VA = "0xA33050", Slot = "89")]
		public virtual void GoToLogoutScreen()
		{
		}

		[Token(Token = "0x6002537")]
		[Address(RVA = "0xA33054", Offset = "0xA33054", VA = "0xA33054", Slot = "90")]
		public virtual void DeleteAllUserData()
		{
		}

		[Token(Token = "0x6002538")]
		[Address(RVA = "0xA33188", Offset = "0xA33188", VA = "0xA33188")]
		protected CasualGame()
		{
		}
	}
}
