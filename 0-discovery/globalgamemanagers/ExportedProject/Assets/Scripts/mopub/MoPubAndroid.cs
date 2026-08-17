using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000005")]
internal class MoPubAndroid : MoPubPlatformApi
{
	[Token(Token = "0x2000006")]
	public enum LocationAwareness
	{
		[Token(Token = "0x400000E")]
		TRUNCATED = 0,
		[Token(Token = "0x400000F")]
		DISABLED = 1,
		[Token(Token = "0x4000010")]
		NORMAL = 2
	}

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly AndroidJavaClass PluginClass;

	[Token(Token = "0x17000001")]
	internal override bool IsSdkInitialized
	{
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x175A11C", Offset = "0x175A11C", VA = "0x175A11C", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000002")]
	internal override bool CanCollectPersonalInfo
	{
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x175A1C4", Offset = "0x175A1C4", VA = "0x175A1C4", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000003")]
	internal override MoPub.Consent.Status CurrentConsentStatus
	{
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x175A26C", Offset = "0x175A26C", VA = "0x175A26C", Slot = "11")]
		get
		{
			return default(MoPub.Consent.Status);
		}
	}

	[Token(Token = "0x17000004")]
	internal override bool ShouldShowConsentDialog
	{
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x175A318", Offset = "0x175A318", VA = "0x175A318", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000005")]
	internal override bool IsConsentDialogReady
	{
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x175A460", Offset = "0x175A460", VA = "0x175A460", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000006")]
	internal override bool? IsGdprApplicable
	{
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x175A5A8", Offset = "0x175A5A8", VA = "0x175A5A8", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x17598AC", Offset = "0x17598AC", VA = "0x17598AC", Slot = "4")]
	internal override void InitializeSdk(MoPub.SdkConfiguration sdkConfiguration)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1759BFC", Offset = "0x1759BFC", VA = "0x1759BFC", Slot = "5")]
	internal override void EnableLocationSupport(bool shouldUseLocation)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1759D84", Offset = "0x1759D84", VA = "0x1759D84", Slot = "6")]
	internal override void SetEngineInformation(string engineName, string engineVersion)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1759ED4", Offset = "0x1759ED4", VA = "0x1759ED4", Slot = "7")]
	internal override void ReportApplicationOpen([Optional] string iTunesAppId)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x1759F74", Offset = "0x1759F74", VA = "0x1759F74", Slot = "8")]
	internal override void OnApplicationPause(bool paused)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x175A3C0", Offset = "0x175A3C0", VA = "0x175A3C0", Slot = "13")]
	internal override void LoadConsentDialog()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x175A508", Offset = "0x175A508", VA = "0x175A508", Slot = "15")]
	internal override void ShowConsentDialog()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x175A698", Offset = "0x175A698", VA = "0x175A698")]
	public MoPubAndroid()
	{
	}
}
