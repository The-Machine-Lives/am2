using System.Collections.Generic;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;

[Token(Token = "0x200006E")]
public class FightSceneController : ActionSceneController
{
	[Token(Token = "0x400018B")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x821A28", Offset = "0x821A28")]
	private bool _003CenemiesThreatening_003Ek__BackingField;

	[Token(Token = "0x400018C")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x821A38", Offset = "0x821A38")]
	private List<AIActorController> _003CenemyControllers_003Ek__BackingField;

	[Token(Token = "0x400018D")]
	[FieldOffset(Offset = "0x68")]
	private ZoneController m_zoneController;

	[Token(Token = "0x1700001D")]
	public bool enemiesThreatening
	{
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x9D1F34", Offset = "0x9D1F34", VA = "0x9D1F34")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83394C", Offset = "0x83394C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x9D1F3C", Offset = "0x9D1F3C", VA = "0x9D1F3C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83395C", Offset = "0x83395C")]
		private set
		{
		}
	}

	[Token(Token = "0x1700001E")]
	public List<AIActorController> enemyControllers
	{
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x9D1F48", Offset = "0x9D1F48", VA = "0x9D1F48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83396C", Offset = "0x83396C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x9D1F50", Offset = "0x9D1F50", VA = "0x9D1F50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83397C", Offset = "0x83397C")]
		protected set
		{
		}
	}

	[Token(Token = "0x1700001F")]
	public override bool canUseNextAbilities
	{
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x9D1F58", Offset = "0x9D1F58", VA = "0x9D1F58", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x9D1F68", Offset = "0x9D1F68", VA = "0x9D1F68")]
	public FightSceneController(IActionScene inScene, PlayerActorController inPlayerController)
	{
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x9D223C", Offset = "0x9D223C", VA = "0x9D223C")]
	public void InitializeTargets()
	{
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x9D2434", Offset = "0x9D2434", VA = "0x9D2434")]
	private void ApplyStartingScenePassiveEffects()
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x9D2998", Offset = "0x9D2998", VA = "0x9D2998", Slot = "9")]
	public override void Update(float deltaTime)
	{
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x9D2AD0", Offset = "0x9D2AD0", VA = "0x9D2AD0", Slot = "10")]
	public override string GetLogSceneItem()
	{
		return null;
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x9D25FC", Offset = "0x9D25FC", VA = "0x9D25FC")]
	private void OnSceneStart()
	{
	}
}
