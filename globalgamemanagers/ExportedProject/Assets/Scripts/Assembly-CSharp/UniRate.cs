using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001DD")]
public class UniRate : MonoBehaviour
{
	[Token(Token = "0x2000653")]
	public delegate void OnUniRateFaildDelegate(Error error);

	[Token(Token = "0x2000654")]
	public delegate void OnDetectAppUpdatedDelegate();

	[Token(Token = "0x2000655")]
	public delegate bool ShouldUniRatePromptForRatingDelegate();

	[Token(Token = "0x2000656")]
	public delegate void OnPromptedForRatingDelegate();

	[Token(Token = "0x2000657")]
	public delegate void OnUserAttemptToRateDelegate();

	[Token(Token = "0x2000658")]
	public delegate void OnUserDeclinedToRateDelegate();

	[Token(Token = "0x2000659")]
	public delegate void OnUserWantReminderToRateDelegate();

	[Token(Token = "0x200065A")]
	public delegate bool ShouldUniRateOpenRatePageDelegate();

	[Token(Token = "0x200065B")]
	public enum Error
	{
		[Token(Token = "0x4001F72")]
		BundleIdDoesNotMatchAppStore = 0,
		[Token(Token = "0x4001F73")]
		AppNotFoundOnAppStore = 1,
		[Token(Token = "0x4001F74")]
		NotTheLatestVersion = 2,
		[Token(Token = "0x4001F75")]
		NetworkError = 3
	}

	[Token(Token = "0x200065C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820578", Offset = "0x820578")]
	private sealed class _003CCheckForConnectivityInBackground_003Ed__145 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001F76")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001F77")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001F78")]
		[FieldOffset(Offset = "0x20")]
		public UniRate _003C_003E4__this;

		[Token(Token = "0x4001F79")]
		[FieldOffset(Offset = "0x28")]
		public bool showPrompt;

		[Token(Token = "0x4001F7A")]
		[FieldOffset(Offset = "0x29")]
		private bool _003CerrorHappened_003E5__2;

		[Token(Token = "0x4001F7B")]
		[FieldOffset(Offset = "0x30")]
		private WWW _003Cwww_003E5__3;

		[Token(Token = "0x170007ED")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002D96")]
			[Address(RVA = "0xAA3858", Offset = "0xAA3858", VA = "0xAA3858", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007EE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002D98")]
			[Address(RVA = "0xAA38C8", Offset = "0xAA38C8", VA = "0xAA38C8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002D93")]
		[Address(RVA = "0xAA2F9C", Offset = "0xAA2F9C", VA = "0xAA2F9C")]
		[DebuggerHidden]
		public _003CCheckForConnectivityInBackground_003Ed__145(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002D94")]
		[Address(RVA = "0xAA2FC8", Offset = "0xAA2FC8", VA = "0xAA2FC8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002D95")]
		[Address(RVA = "0xAA2FCC", Offset = "0xAA2FCC", VA = "0xAA2FCC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002D97")]
		[Address(RVA = "0xAA3860", Offset = "0xAA3860", VA = "0xAA3860", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4000AE2")]
	[FieldOffset(Offset = "0x58")]
	public int appStoreID;

	[Token(Token = "0x4000AE3")]
	[FieldOffset(Offset = "0x60")]
	public string marketPackageName;

	[Token(Token = "0x4000AE4")]
	[FieldOffset(Offset = "0x68")]
	public UniRateMarketType marketType;

	[Token(Token = "0x4000AE5")]
	[FieldOffset(Offset = "0x70")]
	public string appStoreCountry;

	[Token(Token = "0x4000AE6")]
	[FieldOffset(Offset = "0x78")]
	public string applicationName;

	[Token(Token = "0x4000AE7")]
	[FieldOffset(Offset = "0x80")]
	public string applicationVersion;

	[Token(Token = "0x4000AE8")]
	[FieldOffset(Offset = "0x88")]
	public string applicationBundleID;

	[Token(Token = "0x4000AE9")]
	[FieldOffset(Offset = "0x90")]
	public int usesUntilPrompt;

	[Token(Token = "0x4000AEA")]
	[FieldOffset(Offset = "0x94")]
	public int eventsUntilPrompt;

	[Token(Token = "0x4000AEB")]
	[FieldOffset(Offset = "0x98")]
	public float daysUntilPrompt;

	[Token(Token = "0x4000AEC")]
	[FieldOffset(Offset = "0x9C")]
	public float usesPerWeekForPrompt;

	[Token(Token = "0x4000AED")]
	[FieldOffset(Offset = "0xA0")]
	public float remindPeriod;

	[Token(Token = "0x4000AEE")]
	[FieldOffset(Offset = "0xA8")]
	public string messageTitle;

	[Token(Token = "0x4000AEF")]
	[FieldOffset(Offset = "0xB0")]
	public string message;

	[Token(Token = "0x4000AF0")]
	[FieldOffset(Offset = "0xB8")]
	public string cancelButtonLabel;

	[Token(Token = "0x4000AF1")]
	[FieldOffset(Offset = "0xC0")]
	public string remindButtonLabel;

	[Token(Token = "0x4000AF2")]
	[FieldOffset(Offset = "0xC8")]
	public string rateButtonLabel;

	[Token(Token = "0x4000AF3")]
	[FieldOffset(Offset = "0xD0")]
	public bool onlyPromptIfLatestVersion;

	[Token(Token = "0x4000AF4")]
	[FieldOffset(Offset = "0xD1")]
	public bool promptAgainForEachNewVersion;

	[Token(Token = "0x4000AF5")]
	[FieldOffset(Offset = "0xD2")]
	public bool promptAtLaunch;

	[Token(Token = "0x4000AF6")]
	[FieldOffset(Offset = "0xD3")]
	public bool autoLocalization;

	[Token(Token = "0x4000AF7")]
	[FieldOffset(Offset = "0xD4")]
	public bool previewMode;

	[Token(Token = "0x4000AF8")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private string _ratingIOSURL;

	[Token(Token = "0x4000AF9")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private string _ratingAndroidURL;

	[Token(Token = "0x4000AFA")]
	private const string kUniRateRatedVersionKey = "UniRateRatedVersionChecked";

	[Token(Token = "0x4000AFB")]
	private const string kUniRateDeclinedVersionKey = "UniRateDeclinedVersion";

	[Token(Token = "0x4000AFC")]
	private const string kUniRateLastRemindedKey = "UniRateLastReminded";

	[Token(Token = "0x4000AFD")]
	private const string kUniRateLastVersionUsedKey = "UniRateLastVersionUsed";

	[Token(Token = "0x4000AFE")]
	private const string kUniRateFirstUsedKey = "UniRateFirstUsed";

	[Token(Token = "0x4000AFF")]
	private const string kUniRateUseCountKey = "UniRateUseCount";

	[Token(Token = "0x4000B00")]
	private const string kUniRateEventCountKey = "UniRateEventCount";

	[Token(Token = "0x4000B01")]
	private const string kUniRateAppLookupURLFormat = "http://itunes.apple.com/{0}lookup";

	[Token(Token = "0x4000B02")]
	private const string kUniRateiOSAppStoreURLFormat = "itms-apps://itunes.apple.com/WebObjects/MZStore.woa/wa/viewContentsUserReviews?type=Purple+Software&id=";

	[Token(Token = "0x4000B03")]
	private const string kUniRateiOS7AppStoreURLFormat = "itms-apps://itunes.apple.com/app/id";

	[Token(Token = "0x4000B04")]
	private const string kUniRateAndroidMarketURLFormat = "market://details?id=";

	[Token(Token = "0x4000B05")]
	private const string kUniRateAmazonAppstoreURLFormat = "amzn://apps/android?p=";

	[Token(Token = "0x4000B06")]
	private const string kDefaultTitle = "Rate {0}";

	[Token(Token = "0x4000B07")]
	private const string kDefaultMessage = "If you enjoy {0}, would you mind taking a moment to rate it? It will not take more than a minute. Thanks for your support!";

	[Token(Token = "0x4000B08")]
	private const string kDefaultCancelBtnTitle = "No, thanks";

	[Token(Token = "0x4000B09")]
	private const string kDefaultRateBtnTitle = "Rate it now";

	[Token(Token = "0x4000B0A")]
	private const string kDefaultRemindBtnTitle = "Remind me later";

	[Token(Token = "0x4000B0B")]
	private const float SECONDS_IN_A_DAY = 86400f;

	[Token(Token = "0x4000B0C")]
	private const float SECONDS_IN_A_WEEK = 604800f;

	[Token(Token = "0x4000B0D")]
	[FieldOffset(Offset = "0xE8")]
	private bool _currentChecking;

	[Token(Token = "0x4000B0E")]
	[FieldOffset(Offset = "0xE9")]
	private bool _promptShowing;

	[Token(Token = "0x4000B0F")]
	[FieldOffset(Offset = "0xEA")]
	private bool _isReady;

	[Token(Token = "0x4000B10")]
	[FieldOffset(Offset = "0xF0")]
	private Dictionary<string, object> _localizationDic;

	[Token(Token = "0x4000B11")]
	[FieldOffset(Offset = "0x0")]
	private static UniRate _instance;

	[Token(Token = "0x1700018A")]
	public string MessageTitle
	{
		[Token(Token = "0x6000CB3")]
		[Address(RVA = "0xB4BE68", Offset = "0xB4BE68", VA = "0xB4BE68")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700018B")]
	public string Message
	{
		[Token(Token = "0x6000CB4")]
		[Address(RVA = "0xB4BFA0", Offset = "0xB4BFA0", VA = "0xB4BFA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700018C")]
	public string CancelButtonLabel
	{
		[Token(Token = "0x6000CB5")]
		[Address(RVA = "0xB4C0D8", Offset = "0xB4C0D8", VA = "0xB4C0D8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700018D")]
	public string RemindButtonLabel
	{
		[Token(Token = "0x6000CB6")]
		[Address(RVA = "0xB4C204", Offset = "0xB4C204", VA = "0xB4C204")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700018E")]
	public string RateButtonLabel
	{
		[Token(Token = "0x6000CB7")]
		[Address(RVA = "0xB4C330", Offset = "0xB4C330", VA = "0xB4C330")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700018F")]
	public string RatingIOSURL
	{
		[Token(Token = "0x6000CB8")]
		[Address(RVA = "0xB4C45C", Offset = "0xB4C45C", VA = "0xB4C45C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000190")]
	public string RatingAndroidURL
	{
		[Token(Token = "0x6000CB9")]
		[Address(RVA = "0xB4C608", Offset = "0xB4C608", VA = "0xB4C608")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000191")]
	public DateTime firstUsed
	{
		[Token(Token = "0x6000CBA")]
		[Address(RVA = "0xB4C6A0", Offset = "0xB4C6A0", VA = "0xB4C6A0")]
		get
		{
			return default(DateTime);
		}
		[Token(Token = "0x6000CBB")]
		[Address(RVA = "0xB4C6EC", Offset = "0xB4C6EC", VA = "0xB4C6EC")]
		set
		{
		}
	}

	[Token(Token = "0x17000192")]
	public DateTime lastReminded
	{
		[Token(Token = "0x6000CBC")]
		[Address(RVA = "0xB4C748", Offset = "0xB4C748", VA = "0xB4C748")]
		get
		{
			return default(DateTime);
		}
		[Token(Token = "0x6000CBD")]
		[Address(RVA = "0xB4C794", Offset = "0xB4C794", VA = "0xB4C794")]
		set
		{
		}
	}

	[Token(Token = "0x17000193")]
	public int usesCount
	{
		[Token(Token = "0x6000CBE")]
		[Address(RVA = "0xB4C7F0", Offset = "0xB4C7F0", VA = "0xB4C7F0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000CBF")]
		[Address(RVA = "0xB4C83C", Offset = "0xB4C83C", VA = "0xB4C83C")]
		set
		{
		}
	}

	[Token(Token = "0x17000194")]
	public int eventCount
	{
		[Token(Token = "0x6000CC0")]
		[Address(RVA = "0xB4C898", Offset = "0xB4C898", VA = "0xB4C898")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000CC1")]
		[Address(RVA = "0xB4C8E4", Offset = "0xB4C8E4", VA = "0xB4C8E4")]
		set
		{
		}
	}

	[Token(Token = "0x17000195")]
	public float usesPerWeek
	{
		[Token(Token = "0x6000CC2")]
		[Address(RVA = "0xB4C940", Offset = "0xB4C940", VA = "0xB4C940")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000196")]
	public bool declinedThisVersion
	{
		[Token(Token = "0x6000CC3")]
		[Address(RVA = "0xB4C9FC", Offset = "0xB4C9FC", VA = "0xB4C9FC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000CC4")]
		[Address(RVA = "0xB4CA78", Offset = "0xB4CA78", VA = "0xB4CA78")]
		set
		{
		}
	}

	[Token(Token = "0x17000197")]
	public bool declinedAnyVersion
	{
		[Token(Token = "0x6000CC5")]
		[Address(RVA = "0xB4CAF4", Offset = "0xB4CAF4", VA = "0xB4CAF4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000198")]
	public bool ratedThisVersion
	{
		[Token(Token = "0x6000CC6")]
		[Address(RVA = "0xB4CB54", Offset = "0xB4CB54", VA = "0xB4CB54")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000CC7")]
		[Address(RVA = "0xB4CBAC", Offset = "0xB4CBAC", VA = "0xB4CBAC")]
		set
		{
		}
	}

	[Token(Token = "0x17000199")]
	public bool ratedAnyVersion
	{
		[Token(Token = "0x6000CC8")]
		[Address(RVA = "0xB4CC08", Offset = "0xB4CC08", VA = "0xB4CC08")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700019A")]
	public float usedDays
	{
		[Token(Token = "0x6000CC9")]
		[Address(RVA = "0xB4CC68", Offset = "0xB4CC68", VA = "0xB4CC68")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700019B")]
	public bool waitingByRemindLater
	{
		[Token(Token = "0x6000CCA")]
		[Address(RVA = "0xB4CD08", Offset = "0xB4CD08", VA = "0xB4CD08")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700019C")]
	public float leftRemindDays
	{
		[Token(Token = "0x6000CCB")]
		[Address(RVA = "0xB4CD84", Offset = "0xB4CD84", VA = "0xB4CD84")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700019D")]
	private Dictionary<string, object> localizationDic
	{
		[Token(Token = "0x6000CCC")]
		[Address(RVA = "0xB4CE3C", Offset = "0xB4CE3C", VA = "0xB4CE3C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700019E")]
	public static UniRate Instance
	{
		[Token(Token = "0x6000CCD")]
		[Address(RVA = "0xB4CFBC", Offset = "0xB4CFBC", VA = "0xB4CFBC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700019F")]
	private float iOSVersion
	{
		[Token(Token = "0x6000CE4")]
		[Address(RVA = "0xB4C55C", Offset = "0xB4C55C", VA = "0xB4C55C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x14000003")]
	public event OnUniRateFaildDelegate OnUniRateFaild
	{
		[Token(Token = "0x6000CA3")]
		[Address(RVA = "0xB4AFA8", Offset = "0xB4AFA8", VA = "0xB4AFA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x834B3C", Offset = "0x834B3C")]
		add
		{
		}
		[Token(Token = "0x6000CA4")]
		[Address(RVA = "0xB4B094", Offset = "0xB4B094", VA = "0xB4B094")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x834B4C", Offset = "0x834B4C")]
		remove
		{
		}
	}

	[Token(Token = "0x14000004")]
	public event OnDetectAppUpdatedDelegate OnDetectAppUpdated
	{
		[Token(Token = "0x6000CA5")]
		[Address(RVA = "0xB4B180", Offset = "0xB4B180", VA = "0xB4B180")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x834B5C", Offset = "0x834B5C")]
		add
		{
		}
		[Token(Token = "0x6000CA6")]
		[Address(RVA = "0xB4B26C", Offset = "0xB4B26C", VA = "0xB4B26C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x834B6C", Offset = "0x834B6C")]
		remove
		{
		}
	}

	[Token(Token = "0x14000005")]
	public event ShouldUniRatePromptForRatingDelegate ShouldUniRatePromptForRating
	{
		[Token(Token = "0x6000CA7")]
		[Address(RVA = "0xB4B358", Offset = "0xB4B358", VA = "0xB4B358")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x834B7C", Offset = "0x834B7C")]
		add
		{
		}
		[Token(Token = "0x6000CA8")]
		[Address(RVA = "0xB4B444", Offset = "0xB4B444", VA = "0xB4B444")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x834B8C", Offset = "0x834B8C")]
		remove
		{
		}
	}

	[Token(Token = "0x14000006")]
	public event OnPromptedForRatingDelegate OnPromptedForRating
	{
		[Token(Token = "0x6000CA9")]
		[Address(RVA = "0xB4B530", Offset = "0xB4B530", VA = "0xB4B530")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x834B9C", Offset = "0x834B9C")]
		add
		{
		}
		[Token(Token = "0x6000CAA")]
		[Address(RVA = "0xB4B61C", Offset = "0xB4B61C", VA = "0xB4B61C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x834BAC", Offset = "0x834BAC")]
		remove
		{
		}
	}

	[Token(Token = "0x14000007")]
	public event OnUserAttemptToRateDelegate OnUserAttemptToRate
	{
		[Token(Token = "0x6000CAB")]
		[Address(RVA = "0xB4B708", Offset = "0xB4B708", VA = "0xB4B708")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x834BBC", Offset = "0x834BBC")]
		add
		{
		}
		[Token(Token = "0x6000CAC")]
		[Address(RVA = "0xB4B7F4", Offset = "0xB4B7F4", VA = "0xB4B7F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x834BCC", Offset = "0x834BCC")]
		remove
		{
		}
	}

	[Token(Token = "0x14000008")]
	public event OnUserDeclinedToRateDelegate OnUserDeclinedToRate
	{
		[Token(Token = "0x6000CAD")]
		[Address(RVA = "0xB4B8E0", Offset = "0xB4B8E0", VA = "0xB4B8E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x834BDC", Offset = "0x834BDC")]
		add
		{
		}
		[Token(Token = "0x6000CAE")]
		[Address(RVA = "0xB4B9CC", Offset = "0xB4B9CC", VA = "0xB4B9CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x834BEC", Offset = "0x834BEC")]
		remove
		{
		}
	}

	[Token(Token = "0x14000009")]
	public event OnUserWantReminderToRateDelegate OnUserWantReminderToRate
	{
		[Token(Token = "0x6000CAF")]
		[Address(RVA = "0xB4BAB8", Offset = "0xB4BAB8", VA = "0xB4BAB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x834BFC", Offset = "0x834BFC")]
		add
		{
		}
		[Token(Token = "0x6000CB0")]
		[Address(RVA = "0xB4BBA4", Offset = "0xB4BBA4", VA = "0xB4BBA4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x834C0C", Offset = "0x834C0C")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000A")]
	public event ShouldUniRateOpenRatePageDelegate ShouldUniRateOpenRatePage
	{
		[Token(Token = "0x6000CB1")]
		[Address(RVA = "0xB4BC90", Offset = "0xB4BC90", VA = "0xB4BC90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x834C1C", Offset = "0x834C1C")]
		add
		{
		}
		[Token(Token = "0x6000CB2")]
		[Address(RVA = "0xB4BD7C", Offset = "0xB4BD7C", VA = "0xB4BD7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x834C2C", Offset = "0x834C2C")]
		remove
		{
		}
	}

	[Token(Token = "0x6000CCE")]
	[Address(RVA = "0xB4D2A8", Offset = "0xB4D2A8", VA = "0xB4D2A8")]
	public bool ShouldPromptForRating()
	{
		return default(bool);
	}

	[Token(Token = "0x6000CCF")]
	[Address(RVA = "0xB4D628", Offset = "0xB4D628", VA = "0xB4D628")]
	public void PromptIfNetworkAvailable()
	{
	}

	[Token(Token = "0x6000CD0")]
	[Address(RVA = "0xB4D650", Offset = "0xB4D650", VA = "0xB4D650")]
	public void RateIfNetworkAvailable()
	{
	}

	[Token(Token = "0x6000CD1")]
	[Address(RVA = "0xB4D660", Offset = "0xB4D660", VA = "0xB4D660")]
	public void ShowPrompt()
	{
	}

	[Token(Token = "0x6000CD2")]
	[Address(RVA = "0xB4D730", Offset = "0xB4D730", VA = "0xB4D730")]
	public void OpenRatePage()
	{
	}

	[Token(Token = "0x6000CD3")]
	[Address(RVA = "0xB4D7B0", Offset = "0xB4D7B0", VA = "0xB4D7B0")]
	public void LogEvent(bool withPrompt)
	{
	}

	[Token(Token = "0x6000CD4")]
	[Address(RVA = "0xB4D81C", Offset = "0xB4D81C", VA = "0xB4D81C")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000CD5")]
	[Address(RVA = "0xB4DAA8", Offset = "0xB4DAA8", VA = "0xB4DAA8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000CD6")]
	[Address(RVA = "0xB4D920", Offset = "0xB4D920", VA = "0xB4D920")]
	private void Init()
	{
	}

	[Token(Token = "0x6000CD7")]
	[Address(RVA = "0xB4DB18", Offset = "0xB4DB18", VA = "0xB4DB18")]
	private void UniRateLauched()
	{
	}

	[Token(Token = "0x6000CD8")]
	[Address(RVA = "0xB4DCF0", Offset = "0xB4DCF0", VA = "0xB4DCF0")]
	public void TryPromptForRating()
	{
	}

	[Token(Token = "0x6000CD9")]
	[Address(RVA = "0xB4DC5C", Offset = "0xB4DC5C", VA = "0xB4DC5C")]
	private bool IsSameVersion()
	{
		return default(bool);
	}

	[Token(Token = "0x6000CDA")]
	[Address(RVA = "0xB4DD40", Offset = "0xB4DD40", VA = "0xB4DD40")]
	private void OnApplicationPause(bool pauseStatus)
	{
	}

	[Token(Token = "0x6000CDB")]
	[Address(RVA = "0xB4DCD8", Offset = "0xB4DCD8", VA = "0xB4DCD8")]
	private void IncreaseUseCount()
	{
	}

	[Token(Token = "0x6000CDC")]
	[Address(RVA = "0xB4D804", Offset = "0xB4D804", VA = "0xB4D804")]
	private void IncreaseEventCount()
	{
	}

	[Token(Token = "0x6000CDD")]
	[Address(RVA = "0xB4D638", Offset = "0xB4D638", VA = "0xB4D638")]
	private void CheckAndReadyToRate(bool showPrompt)
	{
	}

	[Token(Token = "0x6000CDE")]
	[Address(RVA = "0xB4DF14", Offset = "0xB4DF14", VA = "0xB4DF14")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x834C3C", Offset = "0x834C3C")]
	private IEnumerator CheckForConnectivityInBackground(bool showPrompt)
	{
		return null;
	}

	[Token(Token = "0x6000CDF")]
	[Address(RVA = "0xB4DE38", Offset = "0xB4DE38", VA = "0xB4DE38")]
	private void ReadyToPrompt()
	{
	}

	[Token(Token = "0x6000CE0")]
	[Address(RVA = "0xB4DFB0", Offset = "0xB4DFB0", VA = "0xB4DFB0")]
	private void UniRateFailWithError(Error error)
	{
	}

	[Token(Token = "0x6000CE1")]
	[Address(RVA = "0xB4DFC4", Offset = "0xB4DFC4", VA = "0xB4DFC4")]
	private void UniRateUserDeclinedPrompt()
	{
	}

	[Token(Token = "0x6000CE2")]
	[Address(RVA = "0xB4E040", Offset = "0xB4E040", VA = "0xB4E040")]
	private void UniRateUserWantRemind()
	{
	}

	[Token(Token = "0x6000CE3")]
	[Address(RVA = "0xB4E0E0", Offset = "0xB4E0E0", VA = "0xB4E0E0")]
	private void UniRateUserWantToRate()
	{
	}

	[Token(Token = "0x6000CE5")]
	[Address(RVA = "0xB4BEA8", Offset = "0xB4BEA8", VA = "0xB4BEA8")]
	private string GetLocalizedMessageTitle()
	{
		return null;
	}

	[Token(Token = "0x6000CE6")]
	[Address(RVA = "0xB4BFE0", Offset = "0xB4BFE0", VA = "0xB4BFE0")]
	private string GetLocalizedMessage()
	{
		return null;
	}

	[Token(Token = "0x6000CE7")]
	[Address(RVA = "0xB4C118", Offset = "0xB4C118", VA = "0xB4C118")]
	private string GetLocalizedCancelButtonLabel()
	{
		return null;
	}

	[Token(Token = "0x6000CE8")]
	[Address(RVA = "0xB4C244", Offset = "0xB4C244", VA = "0xB4C244")]
	private string GetLocalizedRemindButtonLabel()
	{
		return null;
	}

	[Token(Token = "0x6000CE9")]
	[Address(RVA = "0xB4C370", Offset = "0xB4C370", VA = "0xB4C370")]
	private string GetLocalizedRateButtonLabel()
	{
		return null;
	}

	[Token(Token = "0x6000CEA")]
	[Address(RVA = "0xB4E17C", Offset = "0xB4E17C", VA = "0xB4E17C")]
	private string GetContentForLanguageAndKey(string lang, string key)
	{
		return null;
	}

	[Token(Token = "0x6000CEB")]
	[Address(RVA = "0xB4E2E0", Offset = "0xB4E2E0", VA = "0xB4E2E0")]
	public UniRate()
	{
	}
}
