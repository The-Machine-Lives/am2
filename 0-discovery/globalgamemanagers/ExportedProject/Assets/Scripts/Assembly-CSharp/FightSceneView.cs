using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Framework.Casual.View;
using UnityEngine;

[Token(Token = "0x2000089")]
public class FightSceneView : ActionSceneView
{
	[Token(Token = "0x4000215")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private Transform m_monsterParent;

	[Token(Token = "0x4000216")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private GameObject m_monsterViewTemplate;

	[Token(Token = "0x4000217")]
	[FieldOffset(Offset = "0xC0")]
	private ActionController m_actionController;

	[Token(Token = "0x4000218")]
	[FieldOffset(Offset = "0xC8")]
	private FightSceneController m_sceneController;

	[Token(Token = "0x4000219")]
	[FieldOffset(Offset = "0xD0")]
	private CasualViewController m_viewController;

	[Token(Token = "0x400021A")]
	[FieldOffset(Offset = "0xD8")]
	private Localizations m_localizationController;

	[Token(Token = "0x6000295")]
	[Address(RVA = "0x9D2BA8", Offset = "0x9D2BA8", VA = "0x9D2BA8")]
	public void Initialize(CasualViewController viewController, FightSceneController sceneController, ZoneView zoneView)
	{
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0x9D2DB8", Offset = "0x9D2DB8", VA = "0x9D2DB8")]
	public FightActorView CreateFightActorViewForMonster(AIActorController controller)
	{
		return null;
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0x9D2E84", Offset = "0x9D2E84", VA = "0x9D2E84")]
	public FightActorView CreateFightActorViewForPlayer()
	{
		return null;
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0x9D2E8C", Offset = "0x9D2E8C", VA = "0x9D2E8C", Slot = "12")]
	protected override void OnNextButtonPressed()
	{
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0x9D3190", Offset = "0x9D3190", VA = "0x9D3190")]
	private bool CanKillEnemy(AIActorController aiActorController)
	{
		return default(bool);
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0x9D34B0", Offset = "0x9D34B0", VA = "0x9D34B0")]
	private void SkipFightingLivingEnemy()
	{
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0x9D34B8", Offset = "0x9D34B8", VA = "0x9D34B8", Slot = "13")]
	protected override bool ShouldActivateNextButton()
	{
		return default(bool);
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0x9D3504", Offset = "0x9D3504", VA = "0x9D3504")]
	public FightSceneView()
	{
	}
}
