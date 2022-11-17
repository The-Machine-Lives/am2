using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x200002F")]
public class MoPubConsent : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000030")]
	public class ConsentStatusChangedEvent : UnityEvent<MoPub.Consent.Status, MoPub.Consent.Status, bool>
	{
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x175C614", Offset = "0x175C614", VA = "0x175C614")]
		public ConsentStatusChangedEvent()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000031")]
	public class ConsentDialogLoadedEvent : UnityEvent
	{
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x175C604", Offset = "0x175C604", VA = "0x175C604")]
		public ConsentDialogLoadedEvent()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000032")]
	public class ConsentDialogFailedEvent : UnityEvent<string>
	{
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x175C5B4", Offset = "0x175C5B4", VA = "0x175C5B4")]
		public ConsentDialogFailedEvent()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000033")]
	public class ConsentDialogShownEvent : UnityEvent
	{
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x175C60C", Offset = "0x175C60C", VA = "0x175C60C")]
		public ConsentDialogShownEvent()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000034")]
	public class ConsentDialogDismissedEvent : UnityEvent
	{
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x175C5AC", Offset = "0x175C5AC", VA = "0x175C5AC")]
		public ConsentDialogDismissedEvent()
		{
		}
	}

	[Token(Token = "0x400006C")]
	public const string DefaultLocationAwarenessUsage = "Your location is used to provide more targeted advertising.";

	[Token(Token = "0x400006D")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812CB0", Offset = "0x812CB0")]
	public bool AutoShowConsentDialog;

	[Token(Token = "0x400006E")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x812CE8", Offset = "0x812CE8")]
	public string LocationAwarenessUsage;

	[Token(Token = "0x400006F")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x812D20", Offset = "0x812D20")]
	public ConsentStatusChangedEvent ConsentStatusChanged;

	[Token(Token = "0x4000070")]
	[FieldOffset(Offset = "0x30")]
	public ConsentDialogLoadedEvent ConsentDialogLoaded;

	[Token(Token = "0x4000071")]
	[FieldOffset(Offset = "0x38")]
	public ConsentDialogFailedEvent ConsentDialogFailed;

	[Token(Token = "0x4000072")]
	[FieldOffset(Offset = "0x40")]
	public ConsentDialogShownEvent ConsentDialogShown;

	[Token(Token = "0x4000073")]
	[FieldOffset(Offset = "0x48")]
	public ConsentDialogDismissedEvent ConsentDialogDismissed;

	[Token(Token = "0x17000022")]
	public static string LocationAwarenessUsageDescription
	{
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x175B06C", Offset = "0x175B06C", VA = "0x175B06C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000023")]
	public static bool? IsGdprApplicable
	{
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x175B1CC", Offset = "0x175B1CC", VA = "0x175B1CC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000024")]
	public static MoPub.Consent.Status CurrentConsentStatus
	{
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x175B230", Offset = "0x175B230", VA = "0x175B230")]
		get
		{
			return default(MoPub.Consent.Status);
		}
	}

	[Token(Token = "0x17000025")]
	public static bool CanCollectPersonalInfo
	{
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x175B28C", Offset = "0x175B28C", VA = "0x175B28C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000026")]
	public static bool ShouldShowConsentDialog
	{
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x175B2E8", Offset = "0x175B2E8", VA = "0x175B2E8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000027")]
	public static bool IsConsentDialogReady
	{
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x175B344", Offset = "0x175B344", VA = "0x175B344")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x175B01C", Offset = "0x175B01C", VA = "0x175B01C")]
	private void Reset()
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x175B3A0", Offset = "0x175B3A0", VA = "0x175B3A0")]
	public static void LoadConsentDialog()
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x175B3FC", Offset = "0x175B3FC", VA = "0x175B3FC")]
	public static void ShowConsentDialog()
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x175B458", Offset = "0x175B458", VA = "0x175B458")]
	private void fwdConsentStatusChanged(MoPub.Consent.Status oldConsent, MoPub.Consent.Status newConsent, bool canCollectPersonalInfo)
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x175B514", Offset = "0x175B514", VA = "0x175B514")]
	private void fwdConsentDialogLoaded()
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x175B544", Offset = "0x175B544", VA = "0x175B544")]
	private void fwdConsentDialogFailed(string error)
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x175B5D4", Offset = "0x175B5D4", VA = "0x175B5D4")]
	private void fwdConsentDialogShown()
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x175B5E8", Offset = "0x175B5E8", VA = "0x175B5E8")]
	private void fwdConsentDialogDismissed()
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x175B5FC", Offset = "0x175B5FC", VA = "0x175B5FC")]
	private void OnSdkInitialized(string adUnitId)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x175B4DC", Offset = "0x175B4DC", VA = "0x175B4DC")]
	private void ShowConsentDialogIfNeeded()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x175B600", Offset = "0x175B600", VA = "0x175B600")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x175BE28", Offset = "0x175BE28", VA = "0x175BE28")]
	private void Start()
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x175BE2C", Offset = "0x175BE2C", VA = "0x175BE2C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x175C5A4", Offset = "0x175C5A4", VA = "0x175C5A4")]
	public MoPubConsent()
	{
	}
}
