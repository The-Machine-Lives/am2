using Il2CppDummyDll;
using Uken.Framework.Casual;
using UnityEngine;

[Token(Token = "0x200007B")]
public class AIFightActorView : FightActorView
{
	[Token(Token = "0x40001DC")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	protected AM2Text m_castingText;

	[Token(Token = "0x40001DD")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	protected ProgressBar m_castingBar;

	[Token(Token = "0x40001DE")]
	[FieldOffset(Offset = "0xB8")]
	protected AbilityController m_abilityController;

	[Token(Token = "0x40001DF")]
	[FieldOffset(Offset = "0xC0")]
	private Localizations m_localizationController;

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x9A68F8", Offset = "0x9A68F8", VA = "0x9A68F8", Slot = "4")]
	public override void InitializeAsAI(AIActorController controller)
	{
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0x9A6A0C", Offset = "0x9A6A0C", VA = "0x9A6A0C", Slot = "9")]
	protected override void OnDeath(DeathActorEvent deathEvent)
	{
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x9A6A9C", Offset = "0x9A6A9C", VA = "0x9A6A9C", Slot = "5")]
	protected override void Update()
	{
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x9A6AC4", Offset = "0x9A6AC4", VA = "0x9A6AC4")]
	protected void UpdateAbility()
	{
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0x9A6D40", Offset = "0x9A6D40", VA = "0x9A6D40")]
	private void OnAbilityEvent(EAbilityEvent abilityEvent)
	{
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0x9A6F18", Offset = "0x9A6F18", VA = "0x9A6F18")]
	public AIFightActorView()
	{
	}
}
