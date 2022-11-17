using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Inventory;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000DE")]
public class SettingsPageView : ConstructionPageView
{
	[Token(Token = "0x2000628")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820448", Offset = "0x820448")]
	private sealed class _003CUpdateGameLastSavedText_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001E52")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001E53")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001E54")]
		[FieldOffset(Offset = "0x20")]
		public SettingsPageView _003C_003E4__this;

		[Token(Token = "0x170007DD")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002D0F")]
			[Address(RVA = "0xA03620", Offset = "0xA03620", VA = "0xA03620", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007DE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002D11")]
			[Address(RVA = "0xA03690", Offset = "0xA03690", VA = "0xA03690", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002D0C")]
		[Address(RVA = "0xA019D8", Offset = "0xA019D8", VA = "0xA019D8")]
		[DebuggerHidden]
		public _003CUpdateGameLastSavedText_003Ed__56(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002D0D")]
		[Address(RVA = "0xA03438", Offset = "0xA03438", VA = "0xA03438", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002D0E")]
		[Address(RVA = "0xA0343C", Offset = "0xA0343C", VA = "0xA0343C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002D10")]
		[Address(RVA = "0xA03628", Offset = "0xA03628", VA = "0xA03628", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4000469")]
	private const int c_maxNameLength = 20;

	[Token(Token = "0x400046A")]
	private const bool c_allowCrashButtons = false;

	[Token(Token = "0x400046B")]
	private const float c_updateInfoInterval = 0.5f;

	[Token(Token = "0x400046C")]
	private const string c_gameCreditsReference = "game_credits";

	[Token(Token = "0x400046D")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject m_fpsDisplay;

	[Token(Token = "0x400046E")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Toggle m_showFPSButton;

	[Token(Token = "0x400046F")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private AM2Text m_showFPSLabel;

	[Token(Token = "0x4000470")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private AM2Button m_fps15Button;

	[Token(Token = "0x4000471")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private AM2Button m_fps30Button;

	[Token(Token = "0x4000472")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private AM2Button m_fps60Button;

	[Token(Token = "0x4000473")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private AM2Button m_fpsVSyncButton;

	[Token(Token = "0x4000474")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private AM2Button m_feedbackButton;

	[Token(Token = "0x4000475")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private GameObject m_betaUserContainer;

	[Token(Token = "0x4000476")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private AM2Text m_userIDText;

	[Token(Token = "0x4000477")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private GameObject m_confirmDeleteUserViewTemplate;

	[Token(Token = "0x4000478")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private AM2Text m_nativeAuthTitle;

	[Token(Token = "0x4000479")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private GameObject m_nativeAuthPanel;

	[Token(Token = "0x400047A")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private AM2Button m_appleAuthLoginButton;

	[Token(Token = "0x400047B")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private AM2Button m_nativeAuthLoginButton;

	[Token(Token = "0x400047C")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private AM2Button m_nativeAuthLogoutButton;

	[Token(Token = "0x400047D")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private AM2Button m_copyUserIDButton;

	[Token(Token = "0x400047E")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private Toggle m_musicToggle;

	[Token(Token = "0x400047F")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private AM2Text m_musicLabel;

	[Token(Token = "0x4000480")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private Toggle m_sfxToggle;

	[Token(Token = "0x4000481")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private AM2Text m_sfxLabel;

	[Token(Token = "0x4000482")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private AM2Button m_saveInventoryButton;

	[Token(Token = "0x4000483")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	private AM2Button m_deleteUserButton;

	[Token(Token = "0x4000484")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	private AM2Text m_appVersionText;

	[Token(Token = "0x4000485")]
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	private GameObject m_stagingOnlyElements;

	[Token(Token = "0x4000486")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	private AdsItemView m_adViewController;

	[Token(Token = "0x4000487")]
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	private AM2Text m_serverSyncInfoText;

	[Token(Token = "0x4000488")]
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	private AM2Text m_lastServerSaveText;

	[Token(Token = "0x4000489")]
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	private ColorSchemeView m_colorSchemeView;

	[Token(Token = "0x400048A")]
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	private InputField m_userNameInput;

	[Token(Token = "0x400048B")]
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	private Censor m_censor;

	[Token(Token = "0x400048C")]
	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	private AM2Button m_creditsButton;

	[Token(Token = "0x400048D")]
	[FieldOffset(Offset = "0x138")]
	private float m_timeUntilInfoUpdate;

	[Token(Token = "0x400048E")]
	[FieldOffset(Offset = "0x140")]
	private string m_authName;

	[Token(Token = "0x400048F")]
	[FieldOffset(Offset = "0x148")]
	private bool m_previousNetworkStatus;

	[Token(Token = "0x4000490")]
	[FieldOffset(Offset = "0x14C")]
	private float m_nextAllowedSaveTime;

	[Token(Token = "0x4000491")]
	[FieldOffset(Offset = "0x150")]
	private OkPopup deleteUserPopup;

	[Token(Token = "0x4000492")]
	[FieldOffset(Offset = "0x158")]
	private UkenAuth m_authenticator;

	[Token(Token = "0x4000493")]
	[FieldOffset(Offset = "0x160")]
	private Localizations m_localizationController;

	[Token(Token = "0x4000494")]
	[FieldOffset(Offset = "0x168")]
	private AM2SoundController m_BISoundController;

	[Token(Token = "0x4000495")]
	[FieldOffset(Offset = "0x170")]
	private NetworkStatusCentre m_networkStatusCentre;

	[Token(Token = "0x4000496")]
	[FieldOffset(Offset = "0x178")]
	private InventoryController m_inventoryController;

	[Token(Token = "0x4000497")]
	[FieldOffset(Offset = "0x180")]
	private Credits m_gameCredits;

	[Token(Token = "0x4000498")]
	[FieldOffset(Offset = "0x188")]
	private IAM2Game m_game;

	[Token(Token = "0x4000499")]
	[FieldOffset(Offset = "0x190")]
	private Dictionary<int, AM2Button> m_allFPSButtons;

	[Token(Token = "0x60005C6")]
	[Address(RVA = "0x9FFA2C", Offset = "0x9FFA2C", VA = "0x9FFA2C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60005C7")]
	[Address(RVA = "0xA00A30", Offset = "0xA00A30", VA = "0xA00A30")]
	protected void RefreshPanelVisibility()
	{
	}

	[Token(Token = "0x60005C8")]
	[Address(RVA = "0xA00DC0", Offset = "0xA00DC0", VA = "0xA00DC0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60005C9")]
	[Address(RVA = "0xA00C1C", Offset = "0xA00C1C", VA = "0xA00C1C")]
	protected void RefreshNativeAuthPanelVisibility()
	{
	}

	[Token(Token = "0x60005CA")]
	[Address(RVA = "0xA00D10", Offset = "0xA00D10", VA = "0xA00D10")]
	protected void RefreshInventoryPanelVisibility()
	{
	}

	[Token(Token = "0x60005CB")]
	[Address(RVA = "0xA00E14", Offset = "0xA00E14", VA = "0xA00E14", Slot = "4")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60005CC")]
	[Address(RVA = "0xA01768", Offset = "0xA01768", VA = "0xA01768")]
	protected void Update()
	{
	}

	[Token(Token = "0x60005CD")]
	[Address(RVA = "0xA01964", Offset = "0xA01964", VA = "0xA01964")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x833ECC", Offset = "0x833ECC")]
	private IEnumerator UpdateGameLastSavedText()
	{
		return null;
	}

	[Token(Token = "0x60005CE")]
	[Address(RVA = "0xA01A04", Offset = "0xA01A04", VA = "0xA01A04")]
	private void OnCopyUserID()
	{
	}

	[Token(Token = "0x60005CF")]
	[Address(RVA = "0xA01BBC", Offset = "0xA01BBC", VA = "0xA01BBC")]
	private void NativeLoginButton()
	{
	}

	[Token(Token = "0x60005D0")]
	[Address(RVA = "0xA01CDC", Offset = "0xA01CDC", VA = "0xA01CDC")]
	private void OnNativeLoginComplete(AuthenticationStatus status, LinkResult linkResult)
	{
	}

	[Token(Token = "0x60005D1")]
	[Address(RVA = "0xA01EF0", Offset = "0xA01EF0", VA = "0xA01EF0")]
	private void LogoutButtonPressed()
	{
	}

	[Token(Token = "0x60005D2")]
	[Address(RVA = "0xA02070", Offset = "0xA02070", VA = "0xA02070")]
	private void LogoutConfirmed()
	{
	}

	[Token(Token = "0x60005D3")]
	[Address(RVA = "0xA02168", Offset = "0xA02168", VA = "0xA02168")]
	private void OnLogoutComplete(LogoutResult result)
	{
	}

	[Token(Token = "0x60005D4")]
	[Address(RVA = "0xA02220", Offset = "0xA02220", VA = "0xA02220")]
	private void OnToggleMusic(bool selected)
	{
	}

	[Token(Token = "0x60005D5")]
	[Address(RVA = "0xA00908", Offset = "0xA00908", VA = "0xA00908")]
	private void UpdateMusicUI(bool on)
	{
	}

	[Token(Token = "0x60005D6")]
	[Address(RVA = "0xA022A4", Offset = "0xA022A4", VA = "0xA022A4")]
	private void OnToggleSfx(bool selected)
	{
	}

	[Token(Token = "0x60005D7")]
	[Address(RVA = "0xA0099C", Offset = "0xA0099C", VA = "0xA0099C")]
	private void UpdateSfxUI(bool on)
	{
	}

	[Token(Token = "0x60005D8")]
	[Address(RVA = "0xA02328", Offset = "0xA02328", VA = "0xA02328")]
	private void OnToggleShowFPS(bool selected)
	{
	}

	[Token(Token = "0x60005D9")]
	[Address(RVA = "0xA023E0", Offset = "0xA023E0", VA = "0xA023E0")]
	private void OnFPS15Changed()
	{
	}

	[Token(Token = "0x60005DA")]
	[Address(RVA = "0xA02444", Offset = "0xA02444", VA = "0xA02444")]
	private void OnFPS30Changed()
	{
	}

	[Token(Token = "0x60005DB")]
	[Address(RVA = "0xA02474", Offset = "0xA02474", VA = "0xA02474")]
	private void OnFPS60Changed()
	{
	}

	[Token(Token = "0x60005DC")]
	[Address(RVA = "0xA024A4", Offset = "0xA024A4", VA = "0xA024A4")]
	private void OnFPSVsyncChanged()
	{
	}

	[Token(Token = "0x60005DD")]
	[Address(RVA = "0xA02410", Offset = "0xA02410", VA = "0xA02410")]
	private void OnFrameRateChanged(int frameRate)
	{
	}

	[Token(Token = "0x60005DE")]
	[Address(RVA = "0xA024D4", Offset = "0xA024D4", VA = "0xA024D4")]
	private void OnUserNameChanged(string text)
	{
	}

	[Token(Token = "0x60005DF")]
	[Address(RVA = "0xA0269C", Offset = "0xA0269C", VA = "0xA0269C")]
	private string FilterProfanity(string text)
	{
		return null;
	}

	[Token(Token = "0x60005E0")]
	[Address(RVA = "0xA00A54", Offset = "0xA00A54", VA = "0xA00A54")]
	private void RefreshFPSButtons(int frameRate)
	{
	}

	[Token(Token = "0x60005E1")]
	[Address(RVA = "0xA02760", Offset = "0xA02760", VA = "0xA02760")]
	private void OnSaveInventoryButtonCicked()
	{
	}

	[Token(Token = "0x60005E2")]
	[Address(RVA = "0xA02944", Offset = "0xA02944", VA = "0xA02944")]
	private void OnClickFeedbackButton()
	{
	}

	[Token(Token = "0x60005E3")]
	[Address(RVA = "0xA02A3C", Offset = "0xA02A3C", VA = "0xA02A3C")]
	private void OnCreditsButtonClicked()
	{
	}

	[Token(Token = "0x60005E4")]
	[Address(RVA = "0xA02B08", Offset = "0xA02B08", VA = "0xA02B08")]
	private void OnTryDeleteUser()
	{
	}

	[Token(Token = "0x60005E5")]
	[Address(RVA = "0xA02D40", Offset = "0xA02D40", VA = "0xA02D40")]
	private void ConfirmDeleteUser()
	{
	}

	[Token(Token = "0x60005E6")]
	[Address(RVA = "0xA03030", Offset = "0xA03030", VA = "0xA03030")]
	private void OnScrubComplete(bool success)
	{
	}

	[Token(Token = "0x60005E7")]
	[Address(RVA = "0xA03158", Offset = "0xA03158", VA = "0xA03158")]
	private void OnConfirmScrubComplete()
	{
	}

	[Token(Token = "0x60005E8")]
	[Address(RVA = "0xA03210", Offset = "0xA03210", VA = "0xA03210")]
	public SettingsPageView()
	{
	}

	[Token(Token = "0x60005E9")]
	[Address(RVA = "0xA03270", Offset = "0xA03270", VA = "0xA03270")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x833F30", Offset = "0x833F30")]
	private void _003COnSaveInventoryButtonCicked_003Eb__76_0(bool success)
	{
	}
}
