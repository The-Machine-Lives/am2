using AM2.ReferenceData;
using Il2CppDummyDll;

[Token(Token = "0x2000079")]
public class AbilityEffectController
{
	[Token(Token = "0x2000609")]
	protected class AbilityEffectState
	{
		[Token(Token = "0x4001D63")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x832DE0", Offset = "0x832DE0")]
		private float _003CremainingChannelTimeInSeconds_003Ek__BackingField;

		[Token(Token = "0x4001D64")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x832DF0", Offset = "0x832DF0")]
		private float _003CremainingChannelTickTimeInSeconds_003Ek__BackingField;

		[Token(Token = "0x170007BF")]
		public float remainingChannelTimeInSeconds
		{
			[Token(Token = "0x6002C90")]
			[Address(RVA = "0xACBDD8", Offset = "0xACBDD8", VA = "0xACBDD8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AD2C", Offset = "0x83AD2C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6002C91")]
			[Address(RVA = "0xACBDE0", Offset = "0xACBDE0", VA = "0xACBDE0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AD3C", Offset = "0x83AD3C")]
			set
			{
			}
		}

		[Token(Token = "0x170007C0")]
		public float remainingChannelTickTimeInSeconds
		{
			[Token(Token = "0x6002C92")]
			[Address(RVA = "0xACBDE8", Offset = "0xACBDE8", VA = "0xACBDE8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AD4C", Offset = "0x83AD4C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6002C93")]
			[Address(RVA = "0xACBDF0", Offset = "0xACBDF0", VA = "0xACBDF0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AD5C", Offset = "0x83AD5C")]
			set
			{
			}
		}

		[Token(Token = "0x6002C94")]
		[Address(RVA = "0xACBDD0", Offset = "0xACBDD0", VA = "0xACBDD0")]
		public AbilityEffectState()
		{
		}
	}

	[Token(Token = "0x40001D3")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x821B78", Offset = "0x821B78")]
	private IAbilityEffect _003Ceffect_003Ek__BackingField;

	[Token(Token = "0x40001D4")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x821B88", Offset = "0x821B88")]
	private long _003Clevel_003Ek__BackingField;

	[Token(Token = "0x40001D5")]
	[FieldOffset(Offset = "0x20")]
	protected AbilityEffectState m_state;

	[Token(Token = "0x17000029")]
	public IAbilityEffect effect
	{
		[Token(Token = "0x6000210")]
		[Address(RVA = "0xACB988", Offset = "0xACB988", VA = "0xACB988")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8339AC", Offset = "0x8339AC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000211")]
		[Address(RVA = "0xACBD00", Offset = "0xACBD00", VA = "0xACBD00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8339BC", Offset = "0x8339BC")]
		private set
		{
		}
	}

	[Token(Token = "0x1700002A")]
	public long level
	{
		[Token(Token = "0x6000212")]
		[Address(RVA = "0xACBD08", Offset = "0xACBD08", VA = "0xACBD08")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8339CC", Offset = "0x8339CC")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000213")]
		[Address(RVA = "0xACBD10", Offset = "0xACBD10", VA = "0xACBD10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8339DC", Offset = "0x8339DC")]
		private set
		{
		}
	}

	[Token(Token = "0x1700002B")]
	public bool isChannelEffect
	{
		[Token(Token = "0x6000214")]
		[Address(RVA = "0xACBBB4", Offset = "0xACBBB4", VA = "0xACBBB4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700002C")]
	public float channelTickIntervalInSeconds
	{
		[Token(Token = "0x6000215")]
		[Address(RVA = "0xACBD18", Offset = "0xACBD18", VA = "0xACBD18")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0xAC9C4C", Offset = "0xAC9C4C", VA = "0xAC9C4C")]
	public AbilityEffectController(IAbilityEffect inEffect, long inLevel)
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0xACABA8", Offset = "0xACABA8", VA = "0xACABA8")]
	public void Update(float deltaTime, FightActorController target, FightActorController selfController)
	{
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0xACBC68", Offset = "0xACBC68", VA = "0xACBC68")]
	public void StartChannelingEffect(float channelTimeInSeconds)
	{
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0xACB074", Offset = "0xACB074", VA = "0xACB074")]
	public void InterruptChanneling()
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0xACBDF8", Offset = "0xACBDF8", VA = "0xACBDF8")]
	private void ResetChannelTicks()
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0xACB990", Offset = "0xACB990", VA = "0xACB990")]
	public void ExecuteAbilityEffect(FightActorController target, FightActorController selfController)
	{
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0xACBED4", Offset = "0xACBED4", VA = "0xACBED4")]
	private void ExecuteDiffHealth(DiffHealth diffHealth, FightActorController target, FightActorController selfController)
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0xACC3C0", Offset = "0xACC3C0", VA = "0xACC3C0")]
	private void ExecuteBuff(Buff buff, FightActorController target, FightActorController selfController)
	{
	}
}
