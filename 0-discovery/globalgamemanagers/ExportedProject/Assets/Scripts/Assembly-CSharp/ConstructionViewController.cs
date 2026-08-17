using System.Collections.Generic;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.Observe;
using UnityEngine;

[Token(Token = "0x20000C8")]
public class ConstructionViewController : BICasualViewController, IUkenObserver<string>
{
	[Token(Token = "0x4000344")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private PowerPageView m_powerPageView;

	[Token(Token = "0x4000345")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private PowerButton m_powerButton;

	[Token(Token = "0x4000346")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private PowerView m_powerView;

	[Token(Token = "0x4000347")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private PowerTap m_powerTap;

	[Token(Token = "0x4000348")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private ConstructionTabController m_mainTabController;

	[Token(Token = "0x4000349")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private Transform m_constructionViewTransform;

	[Token(Token = "0x400034A")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private Transform m_zoneViewTransform;

	[Token(Token = "0x400034B")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private GameObject m_zoneViewTemplate;

	[Token(Token = "0x400034C")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private GameObject m_leaderboardResultViewTemplate;

	[Token(Token = "0x400034D")]
	[FieldOffset(Offset = "0xC0")]
	protected AM2Game m_game;

	[Token(Token = "0x400034E")]
	[FieldOffset(Offset = "0xC8")]
	private UkenUnsubscriber<string> m_signalHandle;

	[Token(Token = "0x400034F")]
	[FieldOffset(Offset = "0xD0")]
	private Queue<string> m_notificationsQueue;

	[Token(Token = "0x4000350")]
	[FieldOffset(Offset = "0xD8")]
	private OkPopup m_currentOkPopup;

	[Token(Token = "0x4000351")]
	[FieldOffset(Offset = "0xE0")]
	private MachineSounds m_idleSounds;

	[Token(Token = "0x4000352")]
	[FieldOffset(Offset = "0xE8")]
	private AM2MessageController m_am2MessageController;

	[Token(Token = "0x4000353")]
	[FieldOffset(Offset = "0xF0")]
	private GlobalLeaderboardController m_globalLeaderboardController;

	[Token(Token = "0x60004D2")]
	[Address(RVA = "0x9BF31C", Offset = "0x9BF31C", VA = "0x9BF31C", Slot = "4")]
	public override void Initialize(CasualSceneController parentController)
	{
	}

	[Token(Token = "0x60004D3")]
	[Address(RVA = "0x9BF7F8", Offset = "0x9BF7F8", VA = "0x9BF7F8", Slot = "5")]
	public override bool HandleBackButtonPress()
	{
		return default(bool);
	}

	[Token(Token = "0x60004D4")]
	[Address(RVA = "0x9BF5C4", Offset = "0x9BF5C4", VA = "0x9BF5C4")]
	public void ShowAnnouncement()
	{
	}

	[Token(Token = "0x60004D5")]
	[Address(RVA = "0x9BEF58", Offset = "0x9BEF58", VA = "0x9BEF58")]
	public void ShowNotification(string message)
	{
	}

	[Token(Token = "0x60004D6")]
	[Address(RVA = "0x9BF890", Offset = "0x9BF890", VA = "0x9BF890")]
	private void DequeueNotification()
	{
	}

	[Token(Token = "0x60004D7")]
	[Address(RVA = "0x9BFA40", Offset = "0x9BFA40", VA = "0x9BFA40", Slot = "7")]
	protected override void Update()
	{
	}

	[Token(Token = "0x60004D8")]
	[Address(RVA = "0x9BFC2C", Offset = "0x9BFC2C", VA = "0x9BFC2C")]
	public void GoToTab(EUnlockType tabType)
	{
	}

	[Token(Token = "0x60004D9")]
	[Address(RVA = "0x9BF9EC", Offset = "0x9BF9EC", VA = "0x9BF9EC")]
	protected bool IsInActionPhase()
	{
		return default(bool);
	}

	[Token(Token = "0x60004DA")]
	[Address(RVA = "0x9BFC60", Offset = "0x9BFC60", VA = "0x9BFC60")]
	public void GoToAction()
	{
	}

	[Token(Token = "0x60004DB")]
	[Address(RVA = "0x9BFD70", Offset = "0x9BFD70", VA = "0x9BFD70")]
	public void GoBackToConstructionFromAction()
	{
	}

	[Token(Token = "0x60004DC")]
	[Address(RVA = "0x9BFDE8", Offset = "0x9BFDE8", VA = "0x9BFDE8", Slot = "8")]
	public void OnEmit(string value)
	{
	}

	[Token(Token = "0x60004DD")]
	[Address(RVA = "0x9BFDEC", Offset = "0x9BFDEC", VA = "0x9BFDEC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60004DE")]
	[Address(RVA = "0x9BFE48", Offset = "0x9BFE48", VA = "0x9BFE48")]
	public void ShowUpgradeEffect(float toNextThreshold, bool isBonus)
	{
	}

	[Token(Token = "0x60004DF")]
	[Address(RVA = "0x9BFA8C", Offset = "0x9BFA8C", VA = "0x9BFA8C")]
	private void ShowLeaderboardResultPopup()
	{
	}

	[Token(Token = "0x60004E0")]
	[Address(RVA = "0x9BFEF0", Offset = "0x9BFEF0", VA = "0x9BFEF0")]
	public ConstructionViewController()
	{
	}
}
