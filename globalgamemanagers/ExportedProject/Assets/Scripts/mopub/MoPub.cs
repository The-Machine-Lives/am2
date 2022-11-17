using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2000019")]
public abstract class MoPub : MoPubBase
{
	[Token(Token = "0x200001A")]
	public enum AdPosition
	{
		[Token(Token = "0x4000022")]
		TopLeft = 0,
		[Token(Token = "0x4000023")]
		TopCenter = 1,
		[Token(Token = "0x4000024")]
		TopRight = 2,
		[Token(Token = "0x4000025")]
		Centered = 3,
		[Token(Token = "0x4000026")]
		BottomLeft = 4,
		[Token(Token = "0x4000027")]
		BottomCenter = 5,
		[Token(Token = "0x4000028")]
		BottomRight = 6
	}

	[Token(Token = "0x200001B")]
	public static class Consent
	{
		[Token(Token = "0x200001C")]
		public enum Status
		{
			[Token(Token = "0x400002A")]
			Unknown = 0,
			[Token(Token = "0x400002B")]
			Denied = 1,
			[Token(Token = "0x400002C")]
			DoNotTrack = 2,
			[Token(Token = "0x400002D")]
			PotentialWhitelist = 3,
			[Token(Token = "0x400002E")]
			Consented = 4
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x1757364", Offset = "0x1757364", VA = "0x1757364")]
		public static Status FromString(string status)
		{
			return default(Status);
		}
	}

	[Token(Token = "0x200001D")]
	public enum MaxAdSize
	{
		[Token(Token = "0x4000030")]
		Width300Height50 = 0,
		[Token(Token = "0x4000031")]
		Width300Height250 = 1,
		[Token(Token = "0x4000032")]
		Width320Height50 = 2,
		[Token(Token = "0x4000033")]
		Width336Height280 = 3,
		[Token(Token = "0x4000034")]
		Width468Height60 = 4,
		[Token(Token = "0x4000035")]
		Width728Height90 = 5,
		[Token(Token = "0x4000036")]
		Width970Height90 = 6,
		[Token(Token = "0x4000037")]
		Width970Height250 = 7,
		[Token(Token = "0x4000038")]
		ScreenWidthHeight50 = 8,
		[Token(Token = "0x4000039")]
		ScreenWidthHeight90 = 9,
		[Token(Token = "0x400003A")]
		ScreenWidthHeight250 = 10,
		[Token(Token = "0x400003B")]
		ScreenWidthHeight280 = 11
	}

	[Token(Token = "0x200001E")]
	public enum LogLevel
	{
		[Token(Token = "0x400003D")]
		Debug = 20,
		[Token(Token = "0x400003E")]
		Info = 30,
		[Token(Token = "0x400003F")]
		None = 70
	}

	[Token(Token = "0x200001F")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x812B40", Offset = "0x812B40")]
	public class SdkConfiguration
	{
		[Serializable]
		[Token(Token = "0x2000020")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x812B78", Offset = "0x812B78")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4000044")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4000045")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<MediatedNetwork, bool> _003C_003E9__8_0;

			[Token(Token = "0x4000046")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<MediatedNetwork, bool> _003C_003E9__8_1;

			[Token(Token = "0x4000047")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<MediatedNetwork, string> _003C_003E9__8_2;

			[Token(Token = "0x4000048")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<MediatedNetwork, bool> _003C_003E9__10_0;

			[Token(Token = "0x4000049")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Func<MediatedNetwork, bool> _003C_003E9__10_1;

			[Token(Token = "0x400004A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static Func<MediatedNetwork, string> _003C_003E9__10_2;

			[Token(Token = "0x400004B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static Func<MediatedNetwork, Dictionary<string, string>> _003C_003E9__10_3;

			[Token(Token = "0x400004C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public static Func<MediatedNetwork, bool> _003C_003E9__12_0;

			[Token(Token = "0x400004D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public static Func<MediatedNetwork, bool> _003C_003E9__12_1;

			[Token(Token = "0x400004E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public static Func<MediatedNetwork, string> _003C_003E9__12_2;

			[Token(Token = "0x400004F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public static Func<MediatedNetwork, Dictionary<string, object>> _003C_003E9__12_3;

			[Token(Token = "0x4000050")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public static Func<MediatedNetwork, bool> _003C_003E9__14_0;

			[Token(Token = "0x4000051")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public static Func<MediatedNetwork, bool> _003C_003E9__14_1;

			[Token(Token = "0x4000052")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public static Func<MediatedNetwork, string> _003C_003E9__14_2;

			[Token(Token = "0x4000053")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public static Func<MediatedNetwork, Dictionary<string, string>> _003C_003E9__14_3;

			[Token(Token = "0x600007B")]
			[Address(RVA = "0x1758CB4", Offset = "0x1758CB4", VA = "0x1758CB4")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x600007C")]
			[Address(RVA = "0x1758CBC", Offset = "0x1758CBC", VA = "0x1758CBC")]
			internal bool _003Cget_AdditionalNetworksString_003Eb__8_0(MediatedNetwork n)
			{
				return default(bool);
			}

			[Token(Token = "0x600007D")]
			[Address(RVA = "0x1758D44", Offset = "0x1758D44", VA = "0x1758D44")]
			internal bool _003Cget_AdditionalNetworksString_003Eb__8_1(MediatedNetwork n)
			{
				return default(bool);
			}

			[Token(Token = "0x600007E")]
			[Address(RVA = "0x1758D88", Offset = "0x1758D88", VA = "0x1758D88")]
			internal string _003Cget_AdditionalNetworksString_003Eb__8_2(MediatedNetwork n)
			{
				return null;
			}

			[Token(Token = "0x600007F")]
			[Address(RVA = "0x1758DB4", Offset = "0x1758DB4", VA = "0x1758DB4")]
			internal bool _003Cget_NetworkConfigurationsJson_003Eb__10_0(MediatedNetwork n)
			{
				return default(bool);
			}

			[Token(Token = "0x6000080")]
			[Address(RVA = "0x1758DF0", Offset = "0x1758DF0", VA = "0x1758DF0")]
			internal bool _003Cget_NetworkConfigurationsJson_003Eb__10_1(MediatedNetwork n)
			{
				return default(bool);
			}

			[Token(Token = "0x6000081")]
			[Address(RVA = "0x1758E2C", Offset = "0x1758E2C", VA = "0x1758E2C")]
			internal string _003Cget_NetworkConfigurationsJson_003Eb__10_2(MediatedNetwork n)
			{
				return null;
			}

			[Token(Token = "0x6000082")]
			[Address(RVA = "0x1758E58", Offset = "0x1758E58", VA = "0x1758E58")]
			internal Dictionary<string, string> _003Cget_NetworkConfigurationsJson_003Eb__10_3(MediatedNetwork n)
			{
				return null;
			}

			[Token(Token = "0x6000083")]
			[Address(RVA = "0x1758E84", Offset = "0x1758E84", VA = "0x1758E84")]
			internal bool _003Cget_MediationSettingsJson_003Eb__12_0(MediatedNetwork n)
			{
				return default(bool);
			}

			[Token(Token = "0x6000084")]
			[Address(RVA = "0x1758EC0", Offset = "0x1758EC0", VA = "0x1758EC0")]
			internal bool _003Cget_MediationSettingsJson_003Eb__12_1(MediatedNetwork n)
			{
				return default(bool);
			}

			[Token(Token = "0x6000085")]
			[Address(RVA = "0x1758F04", Offset = "0x1758F04", VA = "0x1758F04")]
			internal string _003Cget_MediationSettingsJson_003Eb__12_2(MediatedNetwork n)
			{
				return null;
			}

			[Token(Token = "0x6000086")]
			[Address(RVA = "0x1758F30", Offset = "0x1758F30", VA = "0x1758F30")]
			internal Dictionary<string, object> _003Cget_MediationSettingsJson_003Eb__12_3(MediatedNetwork n)
			{
				return null;
			}

			[Token(Token = "0x6000087")]
			[Address(RVA = "0x1758F5C", Offset = "0x1758F5C", VA = "0x1758F5C")]
			internal bool _003Cget_MoPubRequestOptionsJson_003Eb__14_0(MediatedNetwork n)
			{
				return default(bool);
			}

			[Token(Token = "0x6000088")]
			[Address(RVA = "0x1758F98", Offset = "0x1758F98", VA = "0x1758F98")]
			internal bool _003Cget_MoPubRequestOptionsJson_003Eb__14_1(MediatedNetwork n)
			{
				return default(bool);
			}

			[Token(Token = "0x6000089")]
			[Address(RVA = "0x1758FD4", Offset = "0x1758FD4", VA = "0x1758FD4")]
			internal string _003Cget_MoPubRequestOptionsJson_003Eb__14_2(MediatedNetwork n)
			{
				return null;
			}

			[Token(Token = "0x600008A")]
			[Address(RVA = "0x1759000", Offset = "0x1759000", VA = "0x1759000")]
			internal Dictionary<string, string> _003Cget_MoPubRequestOptionsJson_003Eb__14_3(MediatedNetwork n)
			{
				return null;
			}
		}

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string AdUnitId;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MediatedNetwork[] MediatedNetworks;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool AllowLegitimateInterest;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private LogLevel _logLevel;

		[Token(Token = "0x1700001C")]
		public LogLevel LogLevel
		{
			[Token(Token = "0x6000073")]
			[Address(RVA = "0x1755850", Offset = "0x1755850", VA = "0x1755850")]
			get
			{
				return default(LogLevel);
			}
			[Token(Token = "0x6000074")]
			[Address(RVA = "0x17580D8", Offset = "0x17580D8", VA = "0x17580D8")]
			set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public string AdditionalNetworksString
		{
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x17580E0", Offset = "0x17580E0", VA = "0x17580E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001E")]
		public string NetworkConfigurationsJson
		{
			[Token(Token = "0x6000076")]
			[Address(RVA = "0x175836C", Offset = "0x175836C", VA = "0x175836C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		public string MediationSettingsJson
		{
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x1758660", Offset = "0x1758660", VA = "0x1758660")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000020")]
		public string MoPubRequestOptionsJson
		{
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x1758954", Offset = "0x1758954", VA = "0x1758954")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x1758C48", Offset = "0x1758C48", VA = "0x1758C48")]
		public SdkConfiguration()
		{
		}
	}

	[Token(Token = "0x2000021")]
	public class LocalMediationSetting : Dictionary<string, object>
	{
		[Serializable]
		[Token(Token = "0x2000022")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x812B88", Offset = "0x812B88")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4000055")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4000056")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<LocalMediationSetting, bool> _003C_003E9__7_0;

			[Token(Token = "0x4000057")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<LocalMediationSetting, string> _003C_003E9__7_1;

			[Token(Token = "0x4000058")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<LocalMediationSetting, LocalMediationSetting> _003C_003E9__7_2;

			[Token(Token = "0x600008E")]
			[Address(RVA = "0x1757FE8", Offset = "0x1757FE8", VA = "0x1757FE8")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x600008F")]
			[Address(RVA = "0x1757FF0", Offset = "0x1757FF0", VA = "0x1757FF0")]
			internal bool _003CToJson_003Eb__7_0(LocalMediationSetting n)
			{
				return default(bool);
			}

			[Token(Token = "0x6000090")]
			[Address(RVA = "0x1758020", Offset = "0x1758020", VA = "0x1758020")]
			internal string _003CToJson_003Eb__7_1(LocalMediationSetting n)
			{
				return null;
			}

			[Token(Token = "0x6000091")]
			[Address(RVA = "0x175804C", Offset = "0x175804C", VA = "0x175804C")]
			internal LocalMediationSetting _003CToJson_003Eb__7_2(LocalMediationSetting n)
			{
				return null;
			}
		}

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x812CA0", Offset = "0x812CA0")]
		private string _003CMediationSettingsClassName_003Ek__BackingField;

		[Token(Token = "0x17000021")]
		public string MediationSettingsClassName
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x1757D2C", Offset = "0x1757D2C", VA = "0x1757D2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x813198", Offset = "0x813198")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x1757D34", Offset = "0x1757D34", VA = "0x1757D34")]
		public static string ToJson(IEnumerable<LocalMediationSetting> localMediationSettings)
		{
			return null;
		}
	}

	[Token(Token = "0x2000023")]
	public class SupportedNetwork : MediatedNetwork
	{
		[Token(Token = "0x2000024")]
		public class AdMob : SupportedNetwork
		{
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x1759274", Offset = "0x1759274", VA = "0x1759274")]
			public AdMob()
			{
			}
		}

		[Token(Token = "0x2000025")]
		public class AppLovin : SupportedNetwork
		{
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x17592C4", Offset = "0x17592C4", VA = "0x17592C4")]
			public AppLovin()
			{
			}
		}

		[Token(Token = "0x2000026")]
		public class Facebook : SupportedNetwork
		{
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x1759314", Offset = "0x1759314", VA = "0x1759314")]
			public Facebook()
			{
			}
		}

		[Token(Token = "0x2000027")]
		public class IronSource : SupportedNetwork
		{
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x1759364", Offset = "0x1759364", VA = "0x1759364")]
			public IronSource()
			{
			}
		}

		[Token(Token = "0x2000028")]
		public class Mintegral : SupportedNetwork
		{
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x17593B4", Offset = "0x17593B4", VA = "0x17593B4")]
			public Mintegral()
			{
			}
		}

		[Token(Token = "0x2000029")]
		public class Tapjoy : SupportedNetwork
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x1759404", Offset = "0x1759404", VA = "0x1759404")]
			public Tapjoy()
			{
			}
		}

		[Token(Token = "0x200002A")]
		public class Unity : SupportedNetwork
		{
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x1759454", Offset = "0x1759454", VA = "0x1759454")]
			public Unity()
			{
			}
		}

		[Token(Token = "0x200002B")]
		public class Vungle : SupportedNetwork
		{
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x17594A4", Offset = "0x17594A4", VA = "0x17594A4")]
			public Vungle()
			{
			}
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x175902C", Offset = "0x175902C", VA = "0x175902C")]
		protected SupportedNetwork(string adVendor)
		{
		}
	}

	[Token(Token = "0x200002C")]
	public struct Reward
	{
		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string Label;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int Amount;

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x8B61F0", Offset = "0x8B61F0", VA = "0x8B61F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Token(Token = "0x200002D")]
	public struct ImpressionData
	{
		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string AppVersion;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string AdUnitId;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string AdUnitName;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string AdUnitFormat;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string ImpressionId;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string Currency;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public double? PublisherRevenue;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string AdGroupId;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string AdGroupName;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string AdGroupType;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int? AdGroupPriority;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string Country;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public string Precision;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string NetworkName;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public string NetworkPlacementId;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public string JsonRepresentation;

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x175759C", Offset = "0x175759C", VA = "0x175759C")]
		public static ImpressionData FromJson(string json)
		{
			return default(ImpressionData);
		}
	}

	[Token(Token = "0x200002E")]
	private static class AdUnitManager
	{
		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, MoPubAdUnit> AdUnits;

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x1756E34", Offset = "0x1756E34", VA = "0x1756E34")]
		public static void InitAdUnits(string[] adUnitIds, string adType)
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1756194", Offset = "0x1756194", VA = "0x1756194")]
		public static MoPubAdUnit GetAdUnit(string adUnitId)
		{
			return null;
		}
	}

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool _validInit;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static LogLevel CachedLogLevel;

	[Token(Token = "0x17000016")]
	public static bool IsSdkInitialized
	{
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x1755E38", Offset = "0x1755E38", VA = "0x1755E38")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000017")]
	public static bool CanCollectPersonalInfo
	{
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1756774", Offset = "0x1756774", VA = "0x1756774")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000018")]
	public static Consent.Status CurrentConsentStatus
	{
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x17567DC", Offset = "0x17567DC", VA = "0x17567DC")]
		get
		{
			return default(Consent.Status);
		}
	}

	[Token(Token = "0x17000019")]
	public static bool ShouldShowConsentDialog
	{
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x1756844", Offset = "0x1756844", VA = "0x1756844")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001A")]
	public static bool IsConsentDialogReady
	{
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x1756CE0", Offset = "0x1756CE0", VA = "0x1756CE0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001B")]
	public static bool? IsGdprApplicable
	{
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x1756AC4", Offset = "0x1756AC4", VA = "0x1756AC4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x175511C", Offset = "0x175511C", VA = "0x175511C")]
	public static void InitializeSdk(SdkConfiguration sdkConfiguration)
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x1755864", Offset = "0x1755864", VA = "0x1755864")]
	public static void LoadBannerPluginsForAdUnits(string[] adUnitIds)
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x1755AEC", Offset = "0x1755AEC", VA = "0x1755AEC")]
	public static void LoadInterstitialPluginsForAdUnits(string[] adUnitIds)
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x1755B5C", Offset = "0x1755B5C", VA = "0x1755B5C")]
	public static void LoadRewardedVideoPluginsForAdUnits(string[] adUnitIds)
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x1755BCC", Offset = "0x1755BCC", VA = "0x1755BCC")]
	public static void EnableLocationSupport(bool shouldUseLocation)
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x1755D7C", Offset = "0x1755D7C", VA = "0x1755D7C")]
	public static void ReportApplicationOpen([Optional] string iTunesAppId)
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x1755EA0", Offset = "0x1755EA0", VA = "0x1755EA0")]
	public static void RequestBanner(string adUnitId, AdPosition position, MaxAdSize maxAdSize = MaxAdSize.Width320Height50)
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x17562B8", Offset = "0x17562B8", VA = "0x17562B8")]
	public static void ShowBanner(string adUnitId, bool shouldShow)
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x17563A4", Offset = "0x17563A4", VA = "0x17563A4")]
	public static void RequestInterstitialAd(string adUnitId, string keywords = "", string userDataKeywords = "")
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x1756494", Offset = "0x1756494", VA = "0x1756494")]
	public static void ShowInterstitialAd(string adUnitId)
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x175656C", Offset = "0x175656C", VA = "0x175656C")]
	public static void RequestRewardedVideo(string adUnitId, [Optional] List<LocalMediationSetting> mediationSettings, [Optional] string keywords, [Optional] string userDataKeywords, double latitude = 99999.0, double longitude = 99999.0, [Optional] string customerId)
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x175668C", Offset = "0x175668C", VA = "0x175668C")]
	public static void ShowRewardedVideo(string adUnitId, [Optional] string customData)
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x17568AC", Offset = "0x17568AC", VA = "0x17568AC")]
	public static void LoadConsentDialog()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x1756D4C", Offset = "0x1756D4C", VA = "0x1756D4C")]
	public static void ShowConsentDialog()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x17558D4", Offset = "0x17558D4", VA = "0x17558D4")]
	private static void LoadPluginsForAdUnits(string[] adUnitIds, [Optional] string adType)
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x175576C", Offset = "0x175576C", VA = "0x175576C")]
	private static void ValidateAdUnitForSdkInit(string adUnitId)
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x1755C88", Offset = "0x1755C88", VA = "0x1755C88")]
	private static void ValidateInit([Optional] string message)
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x1756F68", Offset = "0x1756F68", VA = "0x1756F68")]
	private static void ReportAdUnitNotFound(string adUnitId)
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x1756FF0", Offset = "0x1756FF0", VA = "0x1756FF0")]
	static MoPub()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x1756FF4", Offset = "0x1756FF4", VA = "0x1756FF4")]
	private static void InitManager()
	{
	}
}
