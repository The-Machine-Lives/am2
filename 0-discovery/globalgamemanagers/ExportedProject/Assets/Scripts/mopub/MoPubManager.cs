using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000035")]
public class MoPubManager : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000036")]
	public class InitializedEvent : UnityEvent<string>
	{
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x17645CC", Offset = "0x17645CC", VA = "0x17645CC")]
		public InitializedEvent()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000037")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x812B98", Offset = "0x812B98")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x8")]
		public static Func<MoPubNetworkConfig, bool> _003C_003E9__92_0;

		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x10")]
		public static Func<MoPubNetworkConfig, MoPubBase.MediatedNetwork> _003C_003E9__92_1;

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x1764560", Offset = "0x1764560", VA = "0x1764560")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x1764568", Offset = "0x1764568", VA = "0x1764568")]
		internal bool _003Cget_SdkConfiguration_003Eb__92_0(MoPubNetworkConfig nc)
		{
			return default(bool);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x1764598", Offset = "0x1764598", VA = "0x1764598")]
		internal MoPubBase.MediatedNetwork _003Cget_SdkConfiguration_003Eb__92_1(MoPubNetworkConfig nc)
		{
			return null;
		}
	}

	[Token(Token = "0x400008F")]
	[FieldOffset(Offset = "0xD8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x812F08", Offset = "0x812F08")]
	private static MoPubManager _003CInstance_003Ek__BackingField;

	[Token(Token = "0x4000090")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x812F18", Offset = "0x812F18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812F18", Offset = "0x812F18")]
	public bool AutoInitializeOnStart;

	[Token(Token = "0x4000091")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812F78", Offset = "0x812F78")]
	public string itunesAppId;

	[Token(Token = "0x4000092")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812FB0", Offset = "0x812FB0")]
	public string AdUnitId;

	[Token(Token = "0x4000093")]
	[FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812FE8", Offset = "0x812FE8")]
	public bool LocationAware;

	[Token(Token = "0x4000094")]
	[FieldOffset(Offset = "0x31")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x813020", Offset = "0x813020")]
	public bool AllowLegitimateInterest;

	[Token(Token = "0x4000095")]
	[FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x813058", Offset = "0x813058")]
	public MoPub.LogLevel LogLevel;

	[Token(Token = "0x4000096")]
	[FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x813090", Offset = "0x813090")]
	public InitializedEvent Initialized;

	[Token(Token = "0x4000097")]
	[FieldOffset(Offset = "0xE0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8130C8", Offset = "0x8130C8")]
	private static MoPubPlatformApi _003CMoPubPlatformApi_003Ek__BackingField;

	[Token(Token = "0x4000098")]
	[FieldOffset(Offset = "0xE8")]
	private static bool consentDialogShown;

	[Token(Token = "0x17000028")]
	public static MoPubManager Instance
	{
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x1756B38", Offset = "0x1756B38", VA = "0x1756B38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x813508", Offset = "0x813508")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x1761344", Offset = "0x1761344", VA = "0x1761344")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x813518", Offset = "0x813518")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000029")]
	public MoPub.SdkConfiguration SdkConfiguration
	{
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x1761398", Offset = "0x1761398", VA = "0x1761398")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002A")]
	internal static MoPubPlatformApi MoPubPlatformApi
	{
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x1755800", Offset = "0x1755800", VA = "0x1755800")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x813528", Offset = "0x813528")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x1761600", Offset = "0x1761600", VA = "0x1761600")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x813538", Offset = "0x813538")]
		private set
		{
		}
	}

	[Token(Token = "0x14000001")]
	public static event Action<string> OnSdkInitializedEvent
	{
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x175BD2C", Offset = "0x175BD2C", VA = "0x175BD2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8131A8", Offset = "0x8131A8")]
		add
		{
		}
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x175C4A8", Offset = "0x175C4A8", VA = "0x175C4A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8131B8", Offset = "0x8131B8")]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	public static event Action<string, float> OnAdLoadedEvent
	{
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x175E944", Offset = "0x175E944", VA = "0x175E944")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8131C8", Offset = "0x8131C8")]
		add
		{
		}
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x175EA44", Offset = "0x175EA44", VA = "0x175EA44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8131D8", Offset = "0x8131D8")]
		remove
		{
		}
	}

	[Token(Token = "0x14000003")]
	public static event Action<string, string> OnAdFailedEvent
	{
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x175EB44", Offset = "0x175EB44", VA = "0x175EB44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8131E8", Offset = "0x8131E8")]
		add
		{
		}
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x175EC44", Offset = "0x175EC44", VA = "0x175EC44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8131F8", Offset = "0x8131F8")]
		remove
		{
		}
	}

	[Token(Token = "0x14000004")]
	public static event Action<string> OnAdClickedEvent
	{
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x175ED44", Offset = "0x175ED44", VA = "0x175ED44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x813208", Offset = "0x813208")]
		add
		{
		}
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x175EE44", Offset = "0x175EE44", VA = "0x175EE44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x813218", Offset = "0x813218")]
		remove
		{
		}
	}

	[Token(Token = "0x14000005")]
	public static event Action<string> OnAdExpandedEvent
	{
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x175EF44", Offset = "0x175EF44", VA = "0x175EF44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x813228", Offset = "0x813228")]
		add
		{
		}
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x175F044", Offset = "0x175F044", VA = "0x175F044")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x813238", Offset = "0x813238")]
		remove
		{
		}
	}

	[Token(Token = "0x14000006")]
	public static event Action<string> OnAdCollapsedEvent
	{
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x175F144", Offset = "0x175F144", VA = "0x175F144")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x813248", Offset = "0x813248")]
		add
		{
		}
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x175F244", Offset = "0x175F244", VA = "0x175F244")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x813258", Offset = "0x813258")]
		remove
		{
		}
	}

	[Token(Token = "0x14000007")]
	public static event Action<string> OnInterstitialLoadedEvent
	{
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x175F344", Offset = "0x175F344", VA = "0x175F344")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x813268", Offset = "0x813268")]
		add
		{
		}
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x175F444", Offset = "0x175F444", VA = "0x175F444")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x813278", Offset = "0x813278")]
		remove
		{
		}
	}

	[Token(Token = "0x14000008")]
	public static event Action<string, string> OnInterstitialFailedEvent
	{
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x175F544", Offset = "0x175F544", VA = "0x175F544")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x813288", Offset = "0x813288")]
		add
		{
		}
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x175F644", Offset = "0x175F644", VA = "0x175F644")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x813298", Offset = "0x813298")]
		remove
		{
		}
	}

	[Token(Token = "0x14000009")]
	public static event Action<string> OnInterstitialDismissedEvent
	{
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x175F744", Offset = "0x175F744", VA = "0x175F744")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8132A8", Offset = "0x8132A8")]
		add
		{
		}
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x175F844", Offset = "0x175F844", VA = "0x175F844")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8132B8", Offset = "0x8132B8")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000A")]
	public static event Action<string> OnInterstitialExpiredEvent
	{
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x175F944", Offset = "0x175F944", VA = "0x175F944")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8132C8", Offset = "0x8132C8")]
		add
		{
		}
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x175FA44", Offset = "0x175FA44", VA = "0x175FA44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8132D8", Offset = "0x8132D8")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000B")]
	public static event Action<string> OnInterstitialShownEvent
	{
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x175FB44", Offset = "0x175FB44", VA = "0x175FB44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8132E8", Offset = "0x8132E8")]
		add
		{
		}
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x175FC44", Offset = "0x175FC44", VA = "0x175FC44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8132F8", Offset = "0x8132F8")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000C")]
	public static event Action<string> OnInterstitialClickedEvent
	{
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x175FD44", Offset = "0x175FD44", VA = "0x175FD44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x813308", Offset = "0x813308")]
		add
		{
		}
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x175FE44", Offset = "0x175FE44", VA = "0x175FE44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x813318", Offset = "0x813318")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000D")]
	public static event Action<string> OnRewardedVideoLoadedEvent
	{
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x175FF44", Offset = "0x175FF44", VA = "0x175FF44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x813328", Offset = "0x813328")]
		add
		{
		}
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x1760044", Offset = "0x1760044", VA = "0x1760044")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x813338", Offset = "0x813338")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000E")]
	public static event Action<string, string> OnRewardedVideoFailedEvent
	{
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x1760144", Offset = "0x1760144", VA = "0x1760144")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x813348", Offset = "0x813348")]
		add
		{
		}
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x1760244", Offset = "0x1760244", VA = "0x1760244")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x813358", Offset = "0x813358")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000F")]
	public static event Action<string> OnRewardedVideoExpiredEvent
	{
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x1760344", Offset = "0x1760344", VA = "0x1760344")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x813368", Offset = "0x813368")]
		add
		{
		}
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x1760444", Offset = "0x1760444", VA = "0x1760444")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x813378", Offset = "0x813378")]
		remove
		{
		}
	}

	[Token(Token = "0x14000010")]
	public static event Action<string> OnRewardedVideoShownEvent
	{
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x1760544", Offset = "0x1760544", VA = "0x1760544")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x813388", Offset = "0x813388")]
		add
		{
		}
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x1760644", Offset = "0x1760644", VA = "0x1760644")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x813398", Offset = "0x813398")]
		remove
		{
		}
	}

	[Token(Token = "0x14000011")]
	public static event Action<string> OnRewardedVideoClickedEvent
	{
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x1760744", Offset = "0x1760744", VA = "0x1760744")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8133A8", Offset = "0x8133A8")]
		add
		{
		}
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x1760844", Offset = "0x1760844", VA = "0x1760844")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8133B8", Offset = "0x8133B8")]
		remove
		{
		}
	}

	[Token(Token = "0x14000012")]
	public static event Action<string, string> OnRewardedVideoFailedToPlayEvent
	{
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x1760944", Offset = "0x1760944", VA = "0x1760944")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8133C8", Offset = "0x8133C8")]
		add
		{
		}
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x1760A44", Offset = "0x1760A44", VA = "0x1760A44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8133D8", Offset = "0x8133D8")]
		remove
		{
		}
	}

	[Token(Token = "0x14000013")]
	public static event Action<string, string, float> OnRewardedVideoReceivedRewardEvent
	{
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x1760B44", Offset = "0x1760B44", VA = "0x1760B44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8133E8", Offset = "0x8133E8")]
		add
		{
		}
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x1760C44", Offset = "0x1760C44", VA = "0x1760C44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8133F8", Offset = "0x8133F8")]
		remove
		{
		}
	}

	[Token(Token = "0x14000014")]
	public static event Action<string> OnRewardedVideoClosedEvent
	{
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x1760D44", Offset = "0x1760D44", VA = "0x1760D44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x813408", Offset = "0x813408")]
		add
		{
		}
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x1760E44", Offset = "0x1760E44", VA = "0x1760E44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x813418", Offset = "0x813418")]
		remove
		{
		}
	}

	[Token(Token = "0x14000015")]
	public static event Action<string> OnRewardedVideoLeavingApplicationEvent
	{
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x1760F44", Offset = "0x1760F44", VA = "0x1760F44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x813428", Offset = "0x813428")]
		add
		{
		}
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x1761044", Offset = "0x1761044", VA = "0x1761044")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x813438", Offset = "0x813438")]
		remove
		{
		}
	}

	[Token(Token = "0x14000016")]
	public static event Action<MoPub.Consent.Status, MoPub.Consent.Status, bool> OnConsentStatusChangedEvent
	{
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x175B82C", Offset = "0x175B82C", VA = "0x175B82C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x813448", Offset = "0x813448")]
		add
		{
		}
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x175BFA8", Offset = "0x175BFA8", VA = "0x175BFA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x813458", Offset = "0x813458")]
		remove
		{
		}
	}

	[Token(Token = "0x14000017")]
	public static event Action OnConsentDialogLoadedEvent
	{
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x175B92C", Offset = "0x175B92C", VA = "0x175B92C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x813468", Offset = "0x813468")]
		add
		{
		}
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x175C0A8", Offset = "0x175C0A8", VA = "0x175C0A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x813478", Offset = "0x813478")]
		remove
		{
		}
	}

	[Token(Token = "0x14000018")]
	public static event Action<string> OnConsentDialogFailedEvent
	{
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x175BA2C", Offset = "0x175BA2C", VA = "0x175BA2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x813488", Offset = "0x813488")]
		add
		{
		}
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x175C1A8", Offset = "0x175C1A8", VA = "0x175C1A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x813498", Offset = "0x813498")]
		remove
		{
		}
	}

	[Token(Token = "0x14000019")]
	public static event Action OnConsentDialogShownEvent
	{
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x175BB2C", Offset = "0x175BB2C", VA = "0x175BB2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8134A8", Offset = "0x8134A8")]
		add
		{
		}
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x175C2A8", Offset = "0x175C2A8", VA = "0x175C2A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8134B8", Offset = "0x8134B8")]
		remove
		{
		}
	}

	[Token(Token = "0x1400001A")]
	public static event Action OnConsentDialogDismissedEvent
	{
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x175BC2C", Offset = "0x175BC2C", VA = "0x175BC2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8134C8", Offset = "0x8134C8")]
		add
		{
		}
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x175C3A8", Offset = "0x175C3A8", VA = "0x175C3A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8134D8", Offset = "0x8134D8")]
		remove
		{
		}
	}

	[Token(Token = "0x1400001B")]
	public static event Action<string, MoPub.ImpressionData> OnImpressionTrackedEvent
	{
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x1761144", Offset = "0x1761144", VA = "0x1761144")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8134E8", Offset = "0x8134E8")]
		add
		{
		}
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x1761244", Offset = "0x1761244", VA = "0x1761244")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8134F8", Offset = "0x8134F8")]
		remove
		{
		}
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x1761654", Offset = "0x1761654", VA = "0x1761654")]
	protected void fwdSdkInitialized(string adunitid)
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x17616D8", Offset = "0x17616D8", VA = "0x17616D8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x17619BC", Offset = "0x17619BC", VA = "0x17619BC")]
	private void Start()
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x1761AE0", Offset = "0x1761AE0", VA = "0x1761AE0")]
	private void OnApplicationPause(bool paused)
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x1761B50", Offset = "0x1761B50", VA = "0x1761B50")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x1761C70", Offset = "0x1761C70", VA = "0x1761C70")]
	public void EmitSdkInitializedEvent(string argsJson)
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x1762404", Offset = "0x1762404", VA = "0x1762404")]
	public void EmitConsentStatusChangedEvent(string argsJson)
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x1762730", Offset = "0x1762730", VA = "0x1762730")]
	public void EmitConsentDialogLoadedEvent()
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x1756B8C", Offset = "0x1756B8C", VA = "0x1756B8C")]
	public void EmitConsentDialogFailedEvent(string argsJson)
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x17627EC", Offset = "0x17627EC", VA = "0x17627EC")]
	public void EmitConsentDialogShownEvent()
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x17628A8", Offset = "0x17628A8", VA = "0x17628A8")]
	public static void EmitConsentDialogDismissedEvent()
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x1762964", Offset = "0x1762964", VA = "0x1762964")]
	public void EmitAdLoadedEvent(string argsJson)
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x1762CD8", Offset = "0x1762CD8", VA = "0x1762CD8")]
	public void EmitAdFailedEvent(string argsJson)
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x1762EA4", Offset = "0x1762EA4", VA = "0x1762EA4")]
	public void EmitAdClickedEvent(string argsJson)
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x1762FA4", Offset = "0x1762FA4", VA = "0x1762FA4")]
	public void EmitAdExpandedEvent(string argsJson)
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x17630A4", Offset = "0x17630A4", VA = "0x17630A4")]
	public void EmitAdCollapsedEvent(string argsJson)
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x17631A4", Offset = "0x17631A4", VA = "0x17631A4")]
	public void EmitInterstitialLoadedEvent(string argsJson)
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x17632A4", Offset = "0x17632A4", VA = "0x17632A4")]
	public void EmitInterstitialFailedEvent(string argsJson)
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x1763470", Offset = "0x1763470", VA = "0x1763470")]
	public void EmitInterstitialDismissedEvent(string argsJson)
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x1763570", Offset = "0x1763570", VA = "0x1763570")]
	public void EmitInterstitialDidExpireEvent(string argsJson)
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x1763670", Offset = "0x1763670", VA = "0x1763670")]
	public void EmitInterstitialShownEvent(string argsJson)
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x1763770", Offset = "0x1763770", VA = "0x1763770")]
	public void EmitInterstitialClickedEvent(string argsJson)
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x1763870", Offset = "0x1763870", VA = "0x1763870")]
	public void EmitRewardedVideoLoadedEvent(string argsJson)
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x1763970", Offset = "0x1763970", VA = "0x1763970")]
	public void EmitRewardedVideoFailedEvent(string argsJson)
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x1763B3C", Offset = "0x1763B3C", VA = "0x1763B3C")]
	public void EmitRewardedVideoExpiredEvent(string argsJson)
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x1763C3C", Offset = "0x1763C3C", VA = "0x1763C3C")]
	public void EmitRewardedVideoShownEvent(string argsJson)
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x1763D3C", Offset = "0x1763D3C", VA = "0x1763D3C")]
	public void EmitRewardedVideoClickedEvent(string argsJson)
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x1763E3C", Offset = "0x1763E3C", VA = "0x1763E3C")]
	public void EmitRewardedVideoFailedToPlayEvent(string argsJson)
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x1763F04", Offset = "0x1763F04", VA = "0x1763F04")]
	public void EmitRewardedVideoReceivedRewardEvent(string argsJson)
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x1764220", Offset = "0x1764220", VA = "0x1764220")]
	public void EmitRewardedVideoClosedEvent(string argsJson)
	{
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x1764320", Offset = "0x1764320", VA = "0x1764320")]
	public void EmitRewardedVideoLeavingApplicationEvent(string argsJson)
	{
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x17643C4", Offset = "0x17643C4", VA = "0x17643C4")]
	public void EmitImpressionTrackedEvent(string argsJson)
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x175A0B0", Offset = "0x175A0B0", VA = "0x175A0B0")]
	public static void EmitConsentDialogDismissedIfApplicable(bool applicationPaused)
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x17644EC", Offset = "0x17644EC", VA = "0x17644EC")]
	public MoPubManager()
	{
	}
}
