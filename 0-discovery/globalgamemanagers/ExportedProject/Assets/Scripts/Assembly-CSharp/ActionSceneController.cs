using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;

[Token(Token = "0x200006B")]
public abstract class ActionSceneController
{
	[Token(Token = "0x4000170")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x821998", Offset = "0x821998")]
	private bool _003CcanUseAbilities_003Ek__BackingField;

	[Token(Token = "0x4000171")]
	[FieldOffset(Offset = "0x11")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8219A8", Offset = "0x8219A8")]
	private readonly bool _003CcanUseNextAbilities_003Ek__BackingField;

	[Token(Token = "0x4000172")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8219B8", Offset = "0x8219B8")]
	private IActionScene _003Cscene_003Ek__BackingField;

	[Token(Token = "0x4000173")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8219C8", Offset = "0x8219C8")]
	private PlayerActorController _003Cm_playerController_003Ek__BackingField;

	[Token(Token = "0x4000174")]
	[FieldOffset(Offset = "0x28")]
	protected bool m_calledFinalizedRun;

	[Token(Token = "0x4000175")]
	[FieldOffset(Offset = "0x30")]
	protected ActionController m_actionController;

	[Token(Token = "0x4000176")]
	[FieldOffset(Offset = "0x38")]
	protected CasualAnalog m_analogController;

	[Token(Token = "0x4000177")]
	[FieldOffset(Offset = "0x40")]
	private ZoneController m_zoneController;

	[Token(Token = "0x4000178")]
	[FieldOffset(Offset = "0x48")]
	private AM2InventoryController m_inventoryController;

	[Token(Token = "0x4000179")]
	[FieldOffset(Offset = "0x50")]
	private Localizations m_localizationController;

	[Token(Token = "0x17000012")]
	public virtual bool canUseAbilities
	{
		[Token(Token = "0x6000193")]
		[Address(RVA = "0xACE30C", Offset = "0xACE30C", VA = "0xACE30C", Slot = "4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83383C", Offset = "0x83383C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000194")]
		[Address(RVA = "0xACE314", Offset = "0xACE314", VA = "0xACE314", Slot = "5")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83384C", Offset = "0x83384C")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000013")]
	public virtual bool canUseNextAbilities
	{
		[Token(Token = "0x6000195")]
		[Address(RVA = "0xACE320", Offset = "0xACE320", VA = "0xACE320", Slot = "6")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83385C", Offset = "0x83385C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000014")]
	public IActionScene scene
	{
		[Token(Token = "0x6000196")]
		[Address(RVA = "0xACE328", Offset = "0xACE328", VA = "0xACE328")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83386C", Offset = "0x83386C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000197")]
		[Address(RVA = "0xACE330", Offset = "0xACE330", VA = "0xACE330")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83387C", Offset = "0x83387C")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000015")]
	protected PlayerActorController m_playerController
	{
		[Token(Token = "0x6000198")]
		[Address(RVA = "0xACE338", Offset = "0xACE338", VA = "0xACE338")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83388C", Offset = "0x83388C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000199")]
		[Address(RVA = "0xACE340", Offset = "0xACE340", VA = "0xACE340")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83389C", Offset = "0x83389C")]
		private set
		{
		}
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0xACE348", Offset = "0xACE348", VA = "0xACE348")]
	public ActionSceneController(IActionScene inScene, PlayerActorController inPlayerController)
	{
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0xACE630", Offset = "0xACE630", VA = "0xACE630")]
	public void InitializeSelfTarget()
	{
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0xACE94C", Offset = "0xACE94C", VA = "0xACE94C", Slot = "7")]
	public virtual ActionSceneController GetActiveActionController()
	{
		return null;
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0xACE950", Offset = "0xACE950", VA = "0xACE950", Slot = "8")]
	public virtual bool TryGoToNextSubScene()
	{
		return default(bool);
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0xACE958", Offset = "0xACE958", VA = "0xACE958", Slot = "9")]
	public virtual void Update(float deltaTime)
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0xACE9B0", Offset = "0xACE9B0", VA = "0xACE9B0")]
	protected bool IsPlayerAlive()
	{
		return default(bool);
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0xACEAA8", Offset = "0xACEAA8", VA = "0xACEAA8")]
	public EActionSceneType GetSceneType()
	{
		return default(EActionSceneType);
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0xACEB5C", Offset = "0xACEB5C", VA = "0xACEB5C", Slot = "10")]
	public virtual string GetLogSceneItem()
	{
		return null;
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0xACE664", Offset = "0xACE664", VA = "0xACE664")]
	private void OnSceneStart()
	{
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0xACE9E0", Offset = "0xACE9E0", VA = "0xACE9E0")]
	private void LogPlayerDeath()
	{
	}
}
