using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;

[Token(Token = "0x200007A")]
public class AIActorController : FightActorController
{
	[Token(Token = "0x200060A")]
	protected class AIActorState
	{
		[Token(Token = "0x4001D65")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x832E00", Offset = "0x832E00")]
		private AbilityGroup _003CcurrentAbilityGroup_003Ek__BackingField;

		[Token(Token = "0x4001D66")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x832E10", Offset = "0x832E10")]
		private Ability _003CcurrentAbility_003Ek__BackingField;

		[Token(Token = "0x4001D67")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x832E20", Offset = "0x832E20")]
		private int _003CnextAbilityIndex_003Ek__BackingField;

		[Token(Token = "0x4001D68")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x832E30", Offset = "0x832E30")]
		private long _003Clevel_003Ek__BackingField;

		[Token(Token = "0x4001D69")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x832E40", Offset = "0x832E40")]
		private bool _003Crewarded_003Ek__BackingField;

		[Token(Token = "0x170007C1")]
		public AbilityGroup currentAbilityGroup
		{
			[Token(Token = "0x6002C95")]
			[Address(RVA = "0x9A64B8", Offset = "0x9A64B8", VA = "0x9A64B8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AD6C", Offset = "0x83AD6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002C96")]
			[Address(RVA = "0x9A68F0", Offset = "0x9A68F0", VA = "0x9A68F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AD7C", Offset = "0x83AD7C")]
			private set
			{
			}
		}

		[Token(Token = "0x170007C2")]
		public Ability currentAbility
		{
			[Token(Token = "0x6002C97")]
			[Address(RVA = "0x9A65EC", Offset = "0x9A65EC", VA = "0x9A65EC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AD8C", Offset = "0x83AD8C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002C98")]
			[Address(RVA = "0x9A65E4", Offset = "0x9A65E4", VA = "0x9A65E4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83AD9C", Offset = "0x83AD9C")]
			set
			{
			}
		}

		[Token(Token = "0x170007C3")]
		public int nextAbilityIndex
		{
			[Token(Token = "0x6002C99")]
			[Address(RVA = "0x9A64C0", Offset = "0x9A64C0", VA = "0x9A64C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83ADAC", Offset = "0x83ADAC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6002C9A")]
			[Address(RVA = "0x9A65F4", Offset = "0x9A65F4", VA = "0x9A65F4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83ADBC", Offset = "0x83ADBC")]
			set
			{
			}
		}

		[Token(Token = "0x170007C4")]
		public long level
		{
			[Token(Token = "0x6002C9B")]
			[Address(RVA = "0x9A60F4", Offset = "0x9A60F4", VA = "0x9A60F4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83ADCC", Offset = "0x83ADCC")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6002C9C")]
			[Address(RVA = "0x9A6080", Offset = "0x9A6080", VA = "0x9A6080")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83ADDC", Offset = "0x83ADDC")]
			set
			{
			}
		}

		[Token(Token = "0x170007C5")]
		public bool rewarded
		{
			[Token(Token = "0x6002C9D")]
			[Address(RVA = "0x9A667C", Offset = "0x9A667C", VA = "0x9A667C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83ADEC", Offset = "0x83ADEC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002C9E")]
			[Address(RVA = "0x9A6684", Offset = "0x9A6684", VA = "0x9A6684")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x83ADFC", Offset = "0x83ADFC")]
			set
			{
			}
		}

		[Token(Token = "0x6002C9F")]
		[Address(RVA = "0x9A6164", Offset = "0x9A6164", VA = "0x9A6164")]
		public void SetAbilityGroup(AbilityGroup abilityGroup)
		{
		}

		[Token(Token = "0x6002CA0")]
		[Address(RVA = "0x9A604C", Offset = "0x9A604C", VA = "0x9A604C")]
		public AIActorState()
		{
		}
	}

	[Token(Token = "0x40001D6")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x821B98", Offset = "0x821B98")]
	private Monster _003Cmonster_003Ek__BackingField;

	[Token(Token = "0x40001D7")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x821BA8", Offset = "0x821BA8")]
	private AbilityController _003CabilityController_003Ek__BackingField;

	[Token(Token = "0x40001D8")]
	[FieldOffset(Offset = "0x48")]
	protected AIActorState m_aiState;

	[Token(Token = "0x40001D9")]
	[FieldOffset(Offset = "0x50")]
	private ZoneController m_zoneController;

	[Token(Token = "0x40001DA")]
	[FieldOffset(Offset = "0x58")]
	private ActionController m_actionController;

	[Token(Token = "0x40001DB")]
	[FieldOffset(Offset = "0x60")]
	private Localizations m_localizationController;

	[Token(Token = "0x1700002D")]
	public Monster monster
	{
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x9A5CD0", Offset = "0x9A5CD0", VA = "0x9A5CD0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8339EC", Offset = "0x8339EC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x9A5CD8", Offset = "0x9A5CD8", VA = "0x9A5CD8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8339FC", Offset = "0x8339FC")]
		protected set
		{
		}
	}

	[Token(Token = "0x1700002E")]
	public AbilityController abilityController
	{
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x9A5CE0", Offset = "0x9A5CE0", VA = "0x9A5CE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833A0C", Offset = "0x833A0C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000221")]
		[Address(RVA = "0x9A5CE8", Offset = "0x9A5CE8", VA = "0x9A5CE8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x833A1C", Offset = "0x833A1C")]
		private set
		{
		}
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x9A5CF0", Offset = "0x9A5CF0", VA = "0x9A5CF0")]
	public AIActorController(Monster inMonster)
	{
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x9A6170", Offset = "0x9A6170", VA = "0x9A6170")]
	public bool IsThreat()
	{
		return default(bool);
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x9A620C", Offset = "0x9A620C", VA = "0x9A620C")]
	public void SelectAndUseNextAbility()
	{
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x9A65FC", Offset = "0x9A65FC", VA = "0x9A65FC", Slot = "7")]
	protected override void KillActor()
	{
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x9A6690", Offset = "0x9A6690", VA = "0x9A6690", Slot = "8")]
	protected override void AddDeathEvent()
	{
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x9A675C", Offset = "0x9A675C", VA = "0x9A675C", Slot = "9")]
	public override bool Update(float deltaTime)
	{
		return default(bool);
	}
}
