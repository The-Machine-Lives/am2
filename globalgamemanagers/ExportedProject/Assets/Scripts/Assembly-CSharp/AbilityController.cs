using System;
using System.Collections.Generic;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Library.UkenTime;

[Token(Token = "0x2000078")]
public class AbilityController
{
	[Token(Token = "0x2000607")]
	protected enum EHitResult
	{
		[Token(Token = "0x4001D52")]
		Missed = 0,
		[Token(Token = "0x4001D53")]
		Dodged = 1,
		[Token(Token = "0x4001D54")]
		Hit = 2
	}

	[Token(Token = "0x2000608")]
	protected class AbilityState : EventQueueable<EAbilityEvent>, IAbilityState
	{
		[Token(Token = "0x4001D55")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x832D20", Offset = "0x832D20")]
		private long _003CmaxAmmoCount_003Ek__BackingField;

		[Token(Token = "0x4001D56")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x832D30", Offset = "0x832D30")]
		private float _003CremainingCastTimeInSeconds_003Ek__BackingField;

		[Token(Token = "0x4001D57")]
		[FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x832D40", Offset = "0x832D40")]
		private float _003CremainingCooldownTimeInSeconds_003Ek__BackingField;

		[Token(Token = "0x4001D58")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x832D50", Offset = "0x832D50")]
		private long _003CpreviousAmmoCount_003Ek__BackingField;

		[Token(Token = "0x4001D59")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x832D60", Offset = "0x832D60")]
		private float _003CremainingChannelTimeInSeconds_003Ek__BackingField;

		[Token(Token = "0x4001D5A")]
		[FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x832D70", Offset = "0x832D70")]
		private float _003CchannelTimeInSeconds_003Ek__BackingField;

		[Token(Token = "0x4001D5B")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x832D80", Offset = "0x832D80")]
		private EAbilityState _003CcooldownState_003Ek__BackingField;

		[Token(Token = "0x4001D5C")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x832D90", Offset = "0x832D90")]
		private readonly long _003Clevel_003Ek__BackingField;

		[Token(Token = "0x4001D5D")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x832DA0", Offset = "0x832DA0")]
		private readonly bool _003CisUser_003Ek__BackingField;

		[Token(Token = "0x4001D5E")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x832DB0", Offset = "0x832DB0")]
		private WeakReference<FightActorController> _003CselfController_003Ek__BackingField;

		[Token(Token = "0x4001D5F")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x832DC0", Offset = "0x832DC0")]
		private WeakReference<FightActorController> _003CfriendlyTarget_003Ek__BackingField;

		[Token(Token = "0x4001D60")]
		[FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x832DD0", Offset = "0x832DD0")]
		private WeakReference<FightActorController> _003CenemyTarget_003Ek__BackingField;

		[Token(Token = "0x4001D61")]
		[FieldOffset(Offset = "0x70")]
		private readonly Ability m_ability;

		[Token(Token = "0x4001D62")]
		[FieldOffset(Offset = "0x78")]
		private readonly AM2InventoryController m_inventoryController;

		[Token(Token = "0x170007B2")]
		public long maxAmmoCount
		{
			[Token(Token = "0x6002C72")]
			[Address(RVA = "0xACBCB0", Offset = "0xACBCB0", VA = "0xACBCB0", Slot = "7")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83ABCC", Offset = "0x83ABCC")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6002C73")]
			[Address(RVA = "0xAC9B38", Offset = "0xAC9B38", VA = "0xAC9B38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83ABDC", Offset = "0x83ABDC")]
			set
			{
			}
		}

		[Token(Token = "0x170007B3")]
		public float remainingCastTimeInSeconds
		{
			[Token(Token = "0x6002C74")]
			[Address(RVA = "0xAC9D48", Offset = "0xAC9D48", VA = "0xAC9D48", Slot = "8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83ABEC", Offset = "0x83ABEC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6002C75")]
			[Address(RVA = "0xACA17C", Offset = "0xACA17C", VA = "0xACA17C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83ABFC", Offset = "0x83ABFC")]
			set
			{
			}
		}

		[Token(Token = "0x170007B4")]
		public float remainingCooldownTimeInSeconds
		{
			[Token(Token = "0x6002C76")]
			[Address(RVA = "0xACA938", Offset = "0xACA938", VA = "0xACA938", Slot = "9")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AC0C", Offset = "0x83AC0C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6002C77")]
			[Address(RVA = "0xACA940", Offset = "0xACA940", VA = "0xACA940")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AC1C", Offset = "0x83AC1C")]
			set
			{
			}
		}

		[Token(Token = "0x170007B5")]
		public long previousAmmoCount
		{
			[Token(Token = "0x6002C78")]
			[Address(RVA = "0xACAB10", Offset = "0xACAB10", VA = "0xACAB10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AC2C", Offset = "0x83AC2C")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6002C79")]
			[Address(RVA = "0xACAB18", Offset = "0xACAB18", VA = "0xACAB18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AC3C", Offset = "0x83AC3C")]
			set
			{
			}
		}

		[Token(Token = "0x170007B6")]
		public float remainingChannelTimeInSeconds
		{
			[Token(Token = "0x6002C7A")]
			[Address(RVA = "0xAC9DA4", Offset = "0xAC9DA4", VA = "0xAC9DA4", Slot = "10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AC4C", Offset = "0x83AC4C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6002C7B")]
			[Address(RVA = "0xACAAC0", Offset = "0xACAAC0", VA = "0xACAAC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AC5C", Offset = "0x83AC5C")]
			set
			{
			}
		}

		[Token(Token = "0x170007B7")]
		public float channelTimeInSeconds
		{
			[Token(Token = "0x6002C7C")]
			[Address(RVA = "0xAC9DAC", Offset = "0xAC9DAC", VA = "0xAC9DAC", Slot = "11")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AC6C", Offset = "0x83AC6C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6002C7D")]
			[Address(RVA = "0xACBCB8", Offset = "0xACBCB8", VA = "0xACBCB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AC7C", Offset = "0x83AC7C")]
			set
			{
			}
		}

		[Token(Token = "0x170007B8")]
		public EAbilityState cooldownState
		{
			[Token(Token = "0x6002C7E")]
			[Address(RVA = "0xAC9F20", Offset = "0xAC9F20", VA = "0xAC9F20", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AC8C", Offset = "0x83AC8C")]
			get
			{
				return default(EAbilityState);
			}
			[Token(Token = "0x6002C7F")]
			[Address(RVA = "0xACBCC0", Offset = "0xACBCC0", VA = "0xACBCC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AC9C", Offset = "0x83AC9C")]
			private set
			{
			}
		}

		[Token(Token = "0x170007B9")]
		public long level
		{
			[Token(Token = "0x6002C80")]
			[Address(RVA = "0xAC9C44", Offset = "0xAC9C44", VA = "0xAC9C44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83ACAC", Offset = "0x83ACAC")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170007BA")]
		public bool isUser
		{
			[Token(Token = "0x6002C81")]
			[Address(RVA = "0xAC9B30", Offset = "0xAC9B30", VA = "0xAC9B30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83ACBC", Offset = "0x83ACBC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170007BB")]
		public WeakReference<FightActorController> selfController
		{
			[Token(Token = "0x6002C82")]
			[Address(RVA = "0xACBCA8", Offset = "0xACBCA8", VA = "0xACBCA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83ACCC", Offset = "0x83ACCC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002C83")]
			[Address(RVA = "0xAC9C3C", Offset = "0xAC9C3C", VA = "0xAC9C3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83ACDC", Offset = "0x83ACDC")]
			set
			{
			}
		}

		[Token(Token = "0x170007BC")]
		public WeakReference<FightActorController> friendlyTarget
		{
			[Token(Token = "0x6002C84")]
			[Address(RVA = "0xACA948", Offset = "0xACA948", VA = "0xACA948")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83ACEC", Offset = "0x83ACEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002C85")]
			[Address(RVA = "0xACA16C", Offset = "0xACA16C", VA = "0xACA16C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83ACFC", Offset = "0x83ACFC")]
			set
			{
			}
		}

		[Token(Token = "0x170007BD")]
		public WeakReference<FightActorController> enemyTarget
		{
			[Token(Token = "0x6002C86")]
			[Address(RVA = "0xACA9C4", Offset = "0xACA9C4", VA = "0xACA9C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AD0C", Offset = "0x83AD0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002C87")]
			[Address(RVA = "0xACA174", Offset = "0xACA174", VA = "0xACA174")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AD1C", Offset = "0x83AD1C")]
			set
			{
			}
		}

		[Token(Token = "0x170007BE")]
		public float cooldownInSeconds
		{
			[Token(Token = "0x6002C88")]
			[Address(RVA = "0xACBCC8", Offset = "0xACBCC8", VA = "0xACBCC8", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6002C89")]
		[Address(RVA = "0xAC9A9C", Offset = "0xAC9A9C", VA = "0xAC9A9C")]
		public AbilityState(Ability ability, AM2InventoryController inventoryController, bool inIsUser, long inLevel)
		{
		}

		[Token(Token = "0x6002C8A")]
		[Address(RVA = "0xACAEAC", Offset = "0xACAEAC", VA = "0xACAEAC")]
		public void OnInterruptCasting(bool showInterruptedMessage = true)
		{
		}

		[Token(Token = "0x6002C8B")]
		[Address(RVA = "0xACAF40", Offset = "0xACAF40", VA = "0xACAF40")]
		public void OnInterruptChanneling(bool showInterruptedMessage = true)
		{
		}

		[Token(Token = "0x6002C8C")]
		[Address(RVA = "0xACB66C", Offset = "0xACB66C", VA = "0xACB66C")]
		public void OnIneffective()
		{
		}

		[Token(Token = "0x6002C8D")]
		[Address(RVA = "0xACB6C0", Offset = "0xACB6C0", VA = "0xACB6C0")]
		public void OnNextCast()
		{
		}

		[Token(Token = "0x6002C8E")]
		[Address(RVA = "0xAC9BA4", Offset = "0xAC9BA4", VA = "0xAC9BA4")]
		public void SetCooldownState(EAbilityState state, bool setFlag)
		{
		}

		[Token(Token = "0x6002C8F")]
		[Address(RVA = "0xACB714", Offset = "0xACB714", VA = "0xACB714")]
		public void SetChannelTime(float channelTime)
		{
		}
	}

	[Token(Token = "0x40001C5")]
	public const float c_TEMP_RECOVERY_TIME = 0.25f;

	[Token(Token = "0x40001C6")]
	[FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821B68", Offset = "0x821B68")]
	private Ability _003Cability_003Ek__BackingField;

	[Token(Token = "0x40001C7")]
	[FieldOffset(Offset = "0x18")]
	protected AbilityState m_state;

	[Token(Token = "0x40001C8")]
	[FieldOffset(Offset = "0x20")]
	private List<AbilityEffectController> m_friendlyEffects;

	[Token(Token = "0x40001C9")]
	[FieldOffset(Offset = "0x28")]
	private List<AbilityEffectController> m_enemyEffects;

	[Token(Token = "0x40001CA")]
	[FieldOffset(Offset = "0x30")]
	private List<AbilityEffectController> m_startingZoneEffects;

	[Token(Token = "0x40001CB")]
	[FieldOffset(Offset = "0x38")]
	private List<AbilityEffectController> m_startingSceneEffects;

	[Token(Token = "0x40001CC")]
	[FieldOffset(Offset = "0x40")]
	private readonly AM2InventoryController m_inventoryController;

	[Token(Token = "0x40001CD")]
	[FieldOffset(Offset = "0x48")]
	private readonly UkenTimeController m_timeController;

	[Token(Token = "0x40001CE")]
	[FieldOffset(Offset = "0x50")]
	private readonly ZoneController m_zoneController;

	[Token(Token = "0x40001CF")]
	[FieldOffset(Offset = "0x58")]
	private readonly ConstructionController m_constructionController;

	[Token(Token = "0x40001D0")]
	[FieldOffset(Offset = "0x60")]
	private readonly RecipeController m_recipeController;

	[Token(Token = "0x40001D1")]
	public const string c_abilityNextRef = "ability_next";

	[Token(Token = "0x40001D2")]
	[FieldOffset(Offset = "0x68")]
	private AbilitiesController m_abilitiesController;

	[Token(Token = "0x17000027")]
	public Ability ability
	{
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xAC8FB8", Offset = "0xAC8FB8", VA = "0xAC8FB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83398C", Offset = "0x83398C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0xAC8FC0", Offset = "0xAC8FC0", VA = "0xAC8FC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83399C", Offset = "0x83399C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000028")]
	public IAbilityState state
	{
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xAC8FC8", Offset = "0xAC8FC8", VA = "0xAC8FC8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0xAC8FD0", Offset = "0xAC8FD0", VA = "0xAC8FD0")]
	public AbilityController(FightActorController controller, bool isUser, Ability inAbility, long level)
	{
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0xAC9440", Offset = "0xAC9440", VA = "0xAC9440")]
	public void InitializeWithAbility(Ability inAbility, FightActorController selfController, bool isUser, long level)
	{
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0xAC9CCC", Offset = "0xAC9CCC", VA = "0xAC9CCC")]
	public float GetCastingProgress()
	{
		return default(float);
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0xAC9D50", Offset = "0xAC9D50", VA = "0xAC9D50")]
	public float GetChannelingProgress()
	{
		return default(float);
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0xAC9B40", Offset = "0xAC9B40", VA = "0xAC9B40")]
	public long GetAmmoCount()
	{
		return default(long);
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0xAC9DB4", Offset = "0xAC9DB4", VA = "0xAC9DB4")]
	public void InterruptNextAbility()
	{
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0xAC9E84", Offset = "0xAC9E84", VA = "0xAC9E84")]
	public bool IsCastingNextAbility()
	{
		return default(bool);
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0xAC9F28", Offset = "0xAC9F28", VA = "0xAC9F28")]
	public bool UseAbility(FightActorController friendlyTarget, FightActorController enemyTarget, bool interruptSelf = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0xACA464", Offset = "0xACA464", VA = "0xACA464")]
	public void Update(float deltaTime)
	{
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0xACA9CC", Offset = "0xACA9CC", VA = "0xACA9CC")]
	private void UpdateAllEffects(float deltaTime, List<AbilityEffectController> effects, FightActorController target)
	{
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0xACAD54", Offset = "0xACAD54", VA = "0xACAD54")]
	public void OnActorKilled()
	{
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0xACAD5C", Offset = "0xACAD5C", VA = "0xACAD5C")]
	public void Interrupt(bool showInterruptMessage = true)
	{
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0xACAFB8", Offset = "0xACAFB8", VA = "0xACAFB8")]
	private void InterruptAbilityEffects(List<AbilityEffectController> effects)
	{
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0xACA184", Offset = "0xACA184", VA = "0xACA184")]
	private void CastAbility()
	{
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0xACB108", Offset = "0xACB108", VA = "0xACB108")]
	private EHitResult MissedOrDodged()
	{
		return default(EHitResult);
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0xACB368", Offset = "0xACB368", VA = "0xACB368")]
	private void OnCompletedCastAbility()
	{
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0xACB71C", Offset = "0xACB71C", VA = "0xACB71C")]
	private void UseAbilityHook(string abilityName)
	{
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0xACAAC8", Offset = "0xACAAC8", VA = "0xACAAC8")]
	private void OnCompleteChannel()
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0xACB0A8", Offset = "0xACB0A8", VA = "0xACB0A8")]
	private void SpendAmmo()
	{
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0xACAB20", Offset = "0xACAB20", VA = "0xACAB20")]
	public void RaiseAmmoChangedEvent()
	{
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0xACB83C", Offset = "0xACB83C", VA = "0xACB83C")]
	public void ExecutePassiveEffects(bool isZoneElseScene, FightActorController friendlyTarget, FightActorController enemyTarget)
	{
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0xACB474", Offset = "0xACB474", VA = "0xACB474")]
	private bool ExecuteAbilityEffects(List<AbilityEffectController> effectControllers, WeakReference<FightActorController> targetWeakRef)
	{
		return default(bool);
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0xAC9E58", Offset = "0xAC9E58", VA = "0xAC9E58")]
	private FightActorController GetSelfController()
	{
		return null;
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0xACA950", Offset = "0xACA950", VA = "0xACA950")]
	private FightActorController GetTargetFromWeakRef(WeakReference<FightActorController> targetWeakRef)
	{
		return null;
	}
}
