using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2000014")]
internal abstract class MoPubPlatformApi
{
	[Token(Token = "0x17000010")]
	internal abstract bool IsSdkInitialized
	{
		[Token(Token = "0x6000046")]
		get;
	}

	[Token(Token = "0x17000011")]
	internal abstract bool CanCollectPersonalInfo
	{
		[Token(Token = "0x6000047")]
		get;
	}

	[Token(Token = "0x17000012")]
	internal abstract MoPub.Consent.Status CurrentConsentStatus
	{
		[Token(Token = "0x6000048")]
		get;
	}

	[Token(Token = "0x17000013")]
	internal abstract bool ShouldShowConsentDialog
	{
		[Token(Token = "0x6000049")]
		get;
	}

	[Token(Token = "0x17000014")]
	internal abstract bool IsConsentDialogReady
	{
		[Token(Token = "0x600004B")]
		get;
	}

	[Token(Token = "0x17000015")]
	internal abstract bool? IsGdprApplicable
	{
		[Token(Token = "0x600004D")]
		get;
	}

	[Token(Token = "0x6000041")]
	internal abstract void InitializeSdk(MoPub.SdkConfiguration sdkConfiguration);

	[Token(Token = "0x6000042")]
	internal abstract void EnableLocationSupport(bool shouldUseLocation);

	[Token(Token = "0x6000043")]
	internal abstract void SetEngineInformation(string engineName, string engineVersion);

	[Token(Token = "0x6000044")]
	internal abstract void ReportApplicationOpen([Optional] string iTunesAppId);

	[Token(Token = "0x6000045")]
	internal abstract void OnApplicationPause(bool paused);

	[Token(Token = "0x600004A")]
	internal abstract void LoadConsentDialog();

	[Token(Token = "0x600004C")]
	internal abstract void ShowConsentDialog();

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x175A6A0", Offset = "0x175A6A0", VA = "0x175A6A0")]
	protected MoPubPlatformApi()
	{
	}
}
