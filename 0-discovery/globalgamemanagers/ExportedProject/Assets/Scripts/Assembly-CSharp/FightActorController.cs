using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;

[Token(Token = "0x2000086")]
public class FightActorController : EventQueueable<FightActorEvent>
{
	[Token(Token = "0x200060B")]
	public enum Stat
	{
		[Token(Token = "0x4001D6B")]
		DamagePercent = 0,
		[Token(Token = "0x4001D6C")]
		SpeedPercent = 1,
		[Token(Token = "0x4001D6D")]
		DefencePercent = 2,
		[Token(Token = "0x4001D6E")]
		AccuracyPercent = 3,
		[Token(Token = "0x4001D6F")]
		DodgePercent = 4,
		[Token(Token = "0x4001D70")]
		HP = 5,
		[Token(Token = "0x4001D71")]
		MaxHP = 6
	}

	[Token(Token = "0x200060C")]
	protected class BuffState : IBuffState
	{
		[Token(Token = "0x4001D72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x832E50", Offset = "0x832E50")]
		private Buff _003Cbuff_003Ek__BackingField;

		[Token(Token = "0x4001D73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x832E60", Offset = "0x832E60")]
		private double _003CremainingTimeInSeconds_003Ek__BackingField;

		[Token(Token = "0x4001D74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x832E70", Offset = "0x832E70")]
		private int _003CremainingTimeInSceneCount_003Ek__BackingField;

		[Token(Token = "0x4001D75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x832E80", Offset = "0x832E80")]
		private double _003CremainingOvertimeAbilityTimeInSeconds_003Ek__BackingField;

		[Token(Token = "0x4001D76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x832E90", Offset = "0x832E90")]
		private bool _003CisAlive_003Ek__BackingField;

		[Token(Token = "0x4001D77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x832EA0", Offset = "0x832EA0")]
		private long _003Cstacks_003Ek__BackingField;

		[Token(Token = "0x4001D78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x832EB0", Offset = "0x832EB0")]
		private long _003Clevel_003Ek__BackingField;

		[Token(Token = "0x170007C6")]
		public Buff buff
		{
			[Token(Token = "0x6002CA1")]
			[Address(RVA = "0x9CC2B8", Offset = "0x9CC2B8", VA = "0x9CC2B8", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AE0C", Offset = "0x83AE0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CA2")]
			[Address(RVA = "0x9CD91C", Offset = "0x9CD91C", VA = "0x9CD91C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AE1C", Offset = "0x83AE1C")]
			set
			{
			}
		}

		[Token(Token = "0x170007C7")]
		public double remainingTimeInSeconds
		{
			[Token(Token = "0x6002CA3")]
			[Address(RVA = "0x9CD64C", Offset = "0x9CD64C", VA = "0x9CD64C", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AE2C", Offset = "0x83AE2C")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6002CA4")]
			[Address(RVA = "0x9CD654", Offset = "0x9CD654", VA = "0x9CD654")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AE3C", Offset = "0x83AE3C")]
			set
			{
			}
		}

		[Token(Token = "0x170007C8")]
		public int remainingTimeInSceneCount
		{
			[Token(Token = "0x6002CA5")]
			[Address(RVA = "0x9CD65C", Offset = "0x9CD65C", VA = "0x9CD65C", Slot = "6")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AE4C", Offset = "0x83AE4C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6002CA6")]
			[Address(RVA = "0x9CD664", Offset = "0x9CD664", VA = "0x9CD664")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AE5C", Offset = "0x83AE5C")]
			set
			{
			}
		}

		[Token(Token = "0x170007C9")]
		public double remainingOvertimeAbilityTimeInSeconds
		{
			[Token(Token = "0x6002CA7")]
			[Address(RVA = "0x9CCED8", Offset = "0x9CCED8", VA = "0x9CCED8", Slot = "7")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AE6C", Offset = "0x83AE6C")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6002CA8")]
			[Address(RVA = "0x9CCEE0", Offset = "0x9CCEE0", VA = "0x9CCEE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AE7C", Offset = "0x83AE7C")]
			set
			{
			}
		}

		[Token(Token = "0x170007CA")]
		public bool isAlive
		{
			[Token(Token = "0x6002CA9")]
			[Address(RVA = "0x9CD924", Offset = "0x9CD924", VA = "0x9CD924", Slot = "8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AE8C", Offset = "0x83AE8C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002CAA")]
			[Address(RVA = "0x9CD7EC", Offset = "0x9CD7EC", VA = "0x9CD7EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AE9C", Offset = "0x83AE9C")]
			set
			{
			}
		}

		[Token(Token = "0x170007CB")]
		public long stacks
		{
			[Token(Token = "0x6002CAB")]
			[Address(RVA = "0x9CD92C", Offset = "0x9CD92C", VA = "0x9CD92C", Slot = "11")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AEAC", Offset = "0x83AEAC")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6002CAC")]
			[Address(RVA = "0x9CD934", Offset = "0x9CD934", VA = "0x9CD934")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AEBC", Offset = "0x83AEBC")]
			set
			{
			}
		}

		[Token(Token = "0x170007CC")]
		public long level
		{
			[Token(Token = "0x6002CAD")]
			[Address(RVA = "0x9CC2C0", Offset = "0x9CC2C0", VA = "0x9CC2C0", Slot = "12")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AECC", Offset = "0x83AECC")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6002CAE")]
			[Address(RVA = "0x9CD93C", Offset = "0x9CD93C", VA = "0x9CD93C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AEDC", Offset = "0x83AEDC")]
			set
			{
			}
		}

		[Token(Token = "0x170007CD")]
		public float durationInSeconds
		{
			[Token(Token = "0x6002CAF")]
			[Address(RVA = "0x9CD7B4", Offset = "0x9CD7B4", VA = "0x9CD7B4", Slot = "9")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170007CE")]
		public int durationInSceneCount
		{
			[Token(Token = "0x6002CB0")]
			[Address(RVA = "0x9CD77C", Offset = "0x9CD77C", VA = "0x9CD77C", Slot = "10")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6002CB1")]
		[Address(RVA = "0x9CD944", Offset = "0x9CD944", VA = "0x9CD944")]
		public BuffState(Buff inBuff, long inLevel)
		{
		}

		[Token(Token = "0x6002CB2")]
		[Address(RVA = "0x9CD98C", Offset = "0x9CD98C", VA = "0x9CD98C")]
		public void ApplyStack(long inLevel)
		{
		}
	}

	[Token(Token = "0x200060D")]
	protected class FightActorState : IFightActorState
	{
		[Token(Token = "0x4001D79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x832EC0", Offset = "0x832EC0")]
		private Dictionary<StatModifierKey, long> _003Cstate_003Ek__BackingField;

		[Token(Token = "0x4001D7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x832ED0", Offset = "0x832ED0")]
		private Dictionary<string, BuffState> _003CcurrentBuffs_003Ek__BackingField;

		[Token(Token = "0x4001D7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x832EE0", Offset = "0x832EE0")]
		private bool _003CisAlive_003Ek__BackingField;

		[Token(Token = "0x4001D7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x832EF0", Offset = "0x832EF0")]
		private bool _003CisStunned_003Ek__BackingField;

		[Token(Token = "0x4001D7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x832F00", Offset = "0x832F00")]
		private double _003CcastTime_003Ek__BackingField;

		[Token(Token = "0x4001D7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x832F10", Offset = "0x832F10")]
		private string _003ChealthTypeKey_003Ek__BackingField;

		[Token(Token = "0x4001D7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x832F20", Offset = "0x832F20")]
		private HealthType _003ChealthType_003Ek__BackingField;

		[Token(Token = "0x4001D80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private WeakReference<FightActorController> m_friendlyTarget;

		[Token(Token = "0x4001D81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private WeakReference<FightActorController> m_enemyTarget;

		[Token(Token = "0x170007CF")]
		public Dictionary<StatModifierKey, long> state
		{
			[Token(Token = "0x6002CB3")]
			[Address(RVA = "0x9CDACC", Offset = "0x9CDACC", VA = "0x9CDACC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AEEC", Offset = "0x83AEEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CB4")]
			[Address(RVA = "0x9CDAD4", Offset = "0x9CDAD4", VA = "0x9CDAD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AEFC", Offset = "0x83AEFC")]
			set
			{
			}
		}

		[Token(Token = "0x170007D0")]
		public Dictionary<string, BuffState> currentBuffs
		{
			[Token(Token = "0x6002CB5")]
			[Address(RVA = "0x9CBBF0", Offset = "0x9CBBF0", VA = "0x9CBBF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AF0C", Offset = "0x83AF0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CB6")]
			[Address(RVA = "0x9CDADC", Offset = "0x9CDADC", VA = "0x9CDADC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AF1C", Offset = "0x83AF1C")]
			set
			{
			}
		}

		[Token(Token = "0x170007D1")]
		public bool isAlive
		{
			[Token(Token = "0x6002CB7")]
			[Address(RVA = "0x9CC788", Offset = "0x9CC788", VA = "0x9CC788", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AF2C", Offset = "0x83AF2C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002CB8")]
			[Address(RVA = "0x9CC554", Offset = "0x9CC554", VA = "0x9CC554")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AF3C", Offset = "0x83AF3C")]
			set
			{
			}
		}

		[Token(Token = "0x170007D2")]
		public bool isStunned
		{
			[Token(Token = "0x6002CB9")]
			[Address(RVA = "0x9CBBDC", Offset = "0x9CBBDC", VA = "0x9CBBDC", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AF4C", Offset = "0x83AF4C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002CBA")]
			[Address(RVA = "0x9CBBE4", Offset = "0x9CBBE4", VA = "0x9CBBE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AF5C", Offset = "0x83AF5C")]
			set
			{
			}
		}

		[Token(Token = "0x170007D3")]
		public long maxHealth
		{
			[Token(Token = "0x6002CBB")]
			[Address(RVA = "0x9CDAE4", Offset = "0x9CDAE4", VA = "0x9CDAE4", Slot = "9")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6002CBC")]
			[Address(RVA = "0x9CDB80", Offset = "0x9CDB80", VA = "0x9CDB80")]
			set
			{
			}
		}

		[Token(Token = "0x170007D4")]
		public double castTime
		{
			[Token(Token = "0x6002CBD")]
			[Address(RVA = "0x9CDCE8", Offset = "0x9CDCE8", VA = "0x9CDCE8", Slot = "7")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AF6C", Offset = "0x83AF6C")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6002CBE")]
			[Address(RVA = "0x9CDCF0", Offset = "0x9CDCF0", VA = "0x9CDCF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AF7C", Offset = "0x83AF7C")]
			set
			{
			}
		}

		[Token(Token = "0x170007D5")]
		public long currentBuffsCount
		{
			[Token(Token = "0x6002CBF")]
			[Address(RVA = "0x9CDCF8", Offset = "0x9CDCF8", VA = "0x9CDCF8", Slot = "12")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170007D6")]
		public long currentHealth
		{
			[Token(Token = "0x6002CC0")]
			[Address(RVA = "0x9CC2C8", Offset = "0x9CC2C8", VA = "0x9CC2C8", Slot = "8")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170007D7")]
		public string healthTypeKey
		{
			[Token(Token = "0x6002CC1")]
			[Address(RVA = "0x9CC8E0", Offset = "0x9CC8E0", VA = "0x9CC8E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AF8C", Offset = "0x83AF8C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CC2")]
			[Address(RVA = "0x9CDD60", Offset = "0x9CDD60", VA = "0x9CDD60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AF9C", Offset = "0x83AF9C")]
			private set
			{
			}
		}

		[Token(Token = "0x170007D8")]
		public HealthType healthType
		{
			[Token(Token = "0x6002CC3")]
			[Address(RVA = "0x9CAB90", Offset = "0x9CAB90", VA = "0x9CAB90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AFAC", Offset = "0x83AFAC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CC4")]
			[Address(RVA = "0x9CDD68", Offset = "0x9CDD68", VA = "0x9CDD68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AFBC", Offset = "0x83AFBC")]
			private set
			{
			}
		}

		[Token(Token = "0x170007D9")]
		public FightActorController friendlyTarget
		{
			[Token(Token = "0x6002CC5")]
			[Address(RVA = "0x9CC8E8", Offset = "0x9CC8E8", VA = "0x9CC8E8", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007DA")]
		public FightActorController enemyTarget
		{
			[Token(Token = "0x6002CC6")]
			[Address(RVA = "0x9CC8F0", Offset = "0x9CC8F0", VA = "0x9CC8F0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002CC7")]
		[Address(RVA = "0x9CDDE4", Offset = "0x9CDDE4", VA = "0x9CDDE4")]
		public void InitializeAsMonster(FightActorController fightActorController, Monster monster)
		{
		}

		[Token(Token = "0x6002CC8")]
		[Address(RVA = "0x9CE044", Offset = "0x9CE044", VA = "0x9CE044")]
		protected BuffState CreateBuffStateFromBuff(Buff buff, long level)
		{
			return null;
		}

		[Token(Token = "0x6002CC9")]
		[Address(RVA = "0x9CE0C8", Offset = "0x9CE0C8", VA = "0x9CE0C8")]
		public void InitializeAsPlayer(long inHealth, long inMaxHealth)
		{
		}

		[Token(Token = "0x6002CCA")]
		[Address(RVA = "0x9CE198", Offset = "0x9CE198", VA = "0x9CE198", Slot = "13")]
		public List<IBuffState> GetAllBuffsAsList()
		{
			return null;
		}

		[Token(Token = "0x6002CCB")]
		[Address(RVA = "0x9CB600", Offset = "0x9CB600", VA = "0x9CB600", Slot = "6")]
		public long GetStateForKey(StatModifierKey key)
		{
			return default(long);
		}

		[Token(Token = "0x6002CCC")]
		[Address(RVA = "0x9CB9D0", Offset = "0x9CB9D0", VA = "0x9CB9D0")]
		public void ApplyBuff(FightActorController fightActorController, Buff buff, long level)
		{
		}

		[Token(Token = "0x6002CCD")]
		[Address(RVA = "0x9CD0D0", Offset = "0x9CD0D0", VA = "0x9CD0D0")]
		public void RemoveBuff(KeyValuePair<string, BuffState> buffPair)
		{
		}

		[Token(Token = "0x6002CCE")]
		[Address(RVA = "0x9CE8F4", Offset = "0x9CE8F4", VA = "0x9CE8F4")]
		private void HandleCure(FightActorController fightActorController, Buff buff)
		{
		}

		[Token(Token = "0x6002CCF")]
		[Address(RVA = "0x9CE5B0", Offset = "0x9CE5B0", VA = "0x9CE5B0")]
		private void AddStatusEffects(FightActorController fightActorController, Buff buff, long level, long stacks)
		{
		}

		[Token(Token = "0x6002CD0")]
		[Address(RVA = "0x9CE31C", Offset = "0x9CE31C", VA = "0x9CE31C")]
		private void RemoveStatusEffects(Buff buff, long level, long stacks)
		{
		}

		[Token(Token = "0x6002CD1")]
		[Address(RVA = "0x9CC170", Offset = "0x9CC170", VA = "0x9CC170")]
		public long DiffHealth(long diff)
		{
			return default(long);
		}

		[Token(Token = "0x6002CD2")]
		[Address(RVA = "0x9CC610", Offset = "0x9CC610", VA = "0x9CC610")]
		public void SetFriendlyTarget(FightActorController target)
		{
		}

		[Token(Token = "0x6002CD3")]
		[Address(RVA = "0x9CC66C", Offset = "0x9CC66C", VA = "0x9CC66C")]
		public void SetEnemyTarget(FightActorController target)
		{
		}

		[Token(Token = "0x6002CD4")]
		[Address(RVA = "0x9CEE08", Offset = "0x9CEE08", VA = "0x9CEE08")]
		private WeakReference<FightActorController> CreateWeakReferenecToTarget(FightActorController target)
		{
			return null;
		}

		[Token(Token = "0x6002CD5")]
		[Address(RVA = "0x9CDD70", Offset = "0x9CDD70", VA = "0x9CDD70")]
		private FightActorController GetTargetFromWeakReference(WeakReference<FightActorController> weakReference)
		{
			return null;
		}

		[Token(Token = "0x6002CD6")]
		[Address(RVA = "0x9CAD5C", Offset = "0x9CAD5C", VA = "0x9CAD5C")]
		public FightActorState()
		{
		}
	}

	[Token(Token = "0x40001F9")]
	private const float c_minStunDuration = 0.034f;

	[Token(Token = "0x40001FA")]
	public const float c_minMultiplier = 0.01f;

	[Token(Token = "0x40001FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly Stat[] c_untypedStats;

	[Token(Token = "0x40001FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly StatModifierKey c_HPKey;

	[Token(Token = "0x40001FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly StatModifierKey c_maxHPKey;

	[Token(Token = "0x40001FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected FightActorState m_actorState;

	[Token(Token = "0x40001FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821C78", Offset = "0x821C78")]
	private List<AbilityController> _003CabilityControllers_003Ek__BackingField;

	[Token(Token = "0x4000200")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private AbilitiesController m_abilitiesController;

	[Token(Token = "0x17000047")]
	public IFightActorState actorState
	{
		[Token(Token = "0x600025B")]
		[Address(RVA = "0x9CAB1C", Offset = "0x9CAB1C", VA = "0x9CAB1C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000048")]
	public bool IsHealthBarReversed
	{
		[Token(Token = "0x600025C")]
		[Address(RVA = "0x9CAB24", Offset = "0x9CAB24", VA = "0x9CAB24")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000049")]
	public List<AbilityController> abilityControllers
	{
		[Token(Token = "0x600025D")]
		[Address(RVA = "0x9CAB98", Offset = "0x9CAB98", VA = "0x9CAB98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x833AFC", Offset = "0x833AFC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x9CABA0", Offset = "0x9CABA0", VA = "0x9CABA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x833B0C", Offset = "0x833B0C")]
		protected set
		{
		}
	}

	[Token(Token = "0x600025F")]
	[Address(RVA = "0x9CABA8", Offset = "0x9CABA8", VA = "0x9CABA8")]
	public static float ClampedMultiplier(float multiplier)
	{
		return default(float);
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0x9CAC20", Offset = "0x9CAC20", VA = "0x9CAC20")]
	public FightActorController()
	{
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0x9CADFC", Offset = "0x9CADFC", VA = "0x9CADFC")]
	protected void RegisterAbilityController(AbilityController abilityController)
	{
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0x9CAE6C", Offset = "0x9CAE6C", VA = "0x9CAE6C")]
	public string GetDeadText()
	{
		return null;
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0x9CAF04", Offset = "0x9CAF04", VA = "0x9CAF04")]
	public float GetSpeedMultiplier(List<Tag> types)
	{
		return default(float);
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0x9CB134", Offset = "0x9CB134", VA = "0x9CB134")]
	public float GetDefenceMultiplier(Tag dmgType)
	{
		return default(float);
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0x9CB1E0", Offset = "0x9CB1E0", VA = "0x9CB1E0")]
	public float GetDamageMultiplier(Tag dmgType)
	{
		return default(float);
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0x9CB28C", Offset = "0x9CB28C", VA = "0x9CB28C")]
	public float GetAccuracyPercent(Ability ability, long abilityLevel, List<Tag> types)
	{
		return default(float);
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0x9CB4C0", Offset = "0x9CB4C0", VA = "0x9CB4C0")]
	public float GetDodgePercent(List<Tag> types)
	{
		return default(float);
	}

	[Token(Token = "0x6000268")]
	[Address(RVA = "0x9CB070", Offset = "0x9CB070", VA = "0x9CB070")]
	public float GetStatMultiplier(Stat stat, [Optional] Tag type)
	{
		return default(float);
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0x9CB410", Offset = "0x9CB410", VA = "0x9CB410")]
	public float GetStatPercentChange(Stat stat, [Optional] Tag type)
	{
		return default(float);
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0x9CB698", Offset = "0x9CB698", VA = "0x9CB698")]
	public void Interrupt(bool showInterruptMessage = true)
	{
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0x9CB76C", Offset = "0x9CB76C", VA = "0x9CB76C", Slot = "5")]
	public virtual void ApplyBuff(Buff buff, long level)
	{
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0x9CBBF8", Offset = "0x9CBBF8", VA = "0x9CBBF8", Slot = "6")]
	public virtual void DiffHealth(long diff, float multiplier, FightActorController sourceActorController, BISoundEvents.EventKey dealDamageSoundEventOverride, bool isReflectedDamage = false, bool interrupt = false)
	{
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0x9CC364", Offset = "0x9CC364", VA = "0x9CC364", Slot = "7")]
	protected virtual void KillActor()
	{
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0x9CC560", Offset = "0x9CC560", VA = "0x9CC560", Slot = "8")]
	protected virtual void AddDeathEvent()
	{
	}

	[Token(Token = "0x600026F")]
	[Address(RVA = "0x9CC5D8", Offset = "0x9CC5D8", VA = "0x9CC5D8")]
	public void SetFriendlyTarget(FightActorController target)
	{
	}

	[Token(Token = "0x6000270")]
	[Address(RVA = "0x9CC634", Offset = "0x9CC634", VA = "0x9CC634")]
	public void SetEnemyTarget(FightActorController target)
	{
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0x9CC690", Offset = "0x9CC690", VA = "0x9CC690")]
	public bool CanAffectWithEffect(IAbilityEffect effect)
	{
		return default(bool);
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0x9CC868", Offset = "0x9CC868", VA = "0x9CC868")]
	public bool CanAffectWithHealthType(string healthType)
	{
		return default(bool);
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0x9CC790", Offset = "0x9CC790", VA = "0x9CC790")]
	public bool CanAffectWithOneOfTheseHealthType(List<string> healthTypes)
	{
		return default(bool);
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0x9CC058", Offset = "0x9CC058", VA = "0x9CC058")]
	private void UseAbilityHook(string abilityName)
	{
	}

	[Token(Token = "0x6000275")]
	[Address(RVA = "0x9CC8F8", Offset = "0x9CC8F8", VA = "0x9CC8F8", Slot = "9")]
	public virtual bool Update(float deltaTime)
	{
		return default(bool);
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0x9CD398", Offset = "0x9CD398", VA = "0x9CD398")]
	public void SceneUpdate()
	{
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0x9CD568", Offset = "0x9CD568", VA = "0x9CD568")]
	private void DecrementBuffRemainingTime(KeyValuePair<string, BuffState> buffPair, float? deltaTime)
	{
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0x9CD66C", Offset = "0x9CD66C", VA = "0x9CD66C")]
	private bool CheckBuffExpiry(KeyValuePair<string, BuffState> buffPair)
	{
		return default(bool);
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0x9CCEE8", Offset = "0x9CCEE8", VA = "0x9CCEE8")]
	private List<KeyValuePair<string, BuffState>> GetBuffsToRemove([Optional] float? deltaTime)
	{
		return null;
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0x9CD1D0", Offset = "0x9CD1D0", VA = "0x9CD1D0")]
	private void UpdateStunStatus()
	{
	}
}
