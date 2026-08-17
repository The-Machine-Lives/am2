using AM2;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Framework.Casual.View;
using Uken.Library.Observe;
using UnityEngine;

[Token(Token = "0x20000FB")]
public class ProfileHeaderView : MonoBehaviour, IUkenObserver<ProfileChangedMessage>
{
	[Token(Token = "0x40005C4")]
	private const string c_profileHeaderCickEventName = "profile_header_click";

	[Token(Token = "0x40005C5")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject m_contents;

	[Token(Token = "0x40005C6")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AM2Button m_openProfilePageButton;

	[Token(Token = "0x40005C7")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject m_profilePageTemplate;

	[Token(Token = "0x40005C8")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AM2Text m_playerText;

	[Token(Token = "0x40005C9")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private BadgeSwapper m_badgeSwapper;

	[Token(Token = "0x40005CA")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private TitleSwapper m_titleSwapper;

	[Token(Token = "0x40005CB")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private BadgeBumperSwapper m_bumperSwapper;

	[Token(Token = "0x40005CC")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GameObject m_redDotNotification;

	[Token(Token = "0x40005CD")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x823A54", Offset = "0x823A54")]
	private bool _003CisViewActive_003Ek__BackingField;

	[Token(Token = "0x40005CE")]
	[FieldOffset(Offset = "0x59")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x823A64", Offset = "0x823A64")]
	private bool _003CjustUnlocked_003Ek__BackingField;

	[Token(Token = "0x40005CF")]
	[FieldOffset(Offset = "0x60")]
	private ProfilePageView m_currentProfilePageView;

	[Token(Token = "0x40005D0")]
	[FieldOffset(Offset = "0x68")]
	private UIAlertController m_uiAlertController;

	[Token(Token = "0x40005D1")]
	[FieldOffset(Offset = "0x70")]
	private CasualViewController m_viewController;

	[Token(Token = "0x40005D2")]
	[FieldOffset(Offset = "0x78")]
	private FTUEController m_ftueController;

	[Token(Token = "0x40005D3")]
	[FieldOffset(Offset = "0x80")]
	private CasualAnalog m_casualAnalogController;

	[Token(Token = "0x40005D4")]
	[FieldOffset(Offset = "0x88")]
	private UkenUnsubscriber<ProfileChangedMessage> m_profileSignalHandle;

	[Token(Token = "0x170000DE")]
	public bool isViewActive
	{
		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x9E2678", Offset = "0x9E2678", VA = "0x9E2678")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834010", Offset = "0x834010")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x9E2680", Offset = "0x9E2680", VA = "0x9E2680")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834020", Offset = "0x834020")]
		private set
		{
		}
	}

	[Token(Token = "0x170000DF")]
	public bool justUnlocked
	{
		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x9E268C", Offset = "0x9E268C", VA = "0x9E268C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834030", Offset = "0x834030")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x9E2694", Offset = "0x9E2694", VA = "0x9E2694")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834040", Offset = "0x834040")]
		set
		{
		}
	}

	[Token(Token = "0x60006AF")]
	[Address(RVA = "0x9E26A0", Offset = "0x9E26A0", VA = "0x9E26A0")]
	protected void Start()
	{
	}

	[Token(Token = "0x60006B0")]
	[Address(RVA = "0x9E2750", Offset = "0x9E2750", VA = "0x9E2750")]
	protected void OnDestroy()
	{
	}

	[Token(Token = "0x60006B1")]
	[Address(RVA = "0x9E2820", Offset = "0x9E2820", VA = "0x9E2820")]
	public void Initialize(CasualViewController viewController)
	{
	}

	[Token(Token = "0x60006B2")]
	[Address(RVA = "0x9E2E30", Offset = "0x9E2E30", VA = "0x9E2E30")]
	protected void OpenProfilePage()
	{
	}

	[Token(Token = "0x60006B3")]
	[Address(RVA = "0x9E32A8", Offset = "0x9E32A8", VA = "0x9E32A8", Slot = "4")]
	private void Uken_002ELibrary_002EObserve_002EIUkenObserver_003CProfileChangedMessage_003E_002EOnEmit(ProfileChangedMessage message)
	{
	}

	[Token(Token = "0x60006B4")]
	[Address(RVA = "0x9E2DE4", Offset = "0x9E2DE4", VA = "0x9E2DE4")]
	public void SetViewActive()
	{
	}

	[Token(Token = "0x60006B5")]
	[Address(RVA = "0x9E34B0", Offset = "0x9E34B0", VA = "0x9E34B0")]
	public void RefreshRedDotNotification(bool shouldShow)
	{
	}

	[Token(Token = "0x60006B6")]
	[Address(RVA = "0x9E34E8", Offset = "0x9E34E8", VA = "0x9E34E8")]
	public ProfileHeaderView()
	{
	}
}
