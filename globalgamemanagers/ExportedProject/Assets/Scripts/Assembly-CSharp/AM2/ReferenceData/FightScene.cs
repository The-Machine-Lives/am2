using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000341")]
	public class FightScene : ActionScene<RDFightScene>
	{
		[Token(Token = "0x4000FF2")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x828D70", Offset = "0x828D70")]
		private List<Monster> _003Cmonsters_003Ek__BackingField;

		[Token(Token = "0x4000FF3")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x828D80", Offset = "0x828D80")]
		private List<IAbilityEffect> _003CenemyStartEffects_003Ek__BackingField;

		[Token(Token = "0x1700041F")]
		public List<Monster> monsters
		{
			[Token(Token = "0x6001A01")]
			[Address(RVA = "0x9B2CF4", Offset = "0x9B2CF4", VA = "0x9B2CF4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837D80", Offset = "0x837D80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A02")]
			[Address(RVA = "0x9B2CFC", Offset = "0x9B2CFC", VA = "0x9B2CFC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837D90", Offset = "0x837D90")]
			private set
			{
			}
		}

		[Token(Token = "0x17000420")]
		public List<IAbilityEffect> enemyStartEffects
		{
			[Token(Token = "0x6001A03")]
			[Address(RVA = "0x9B2D04", Offset = "0x9B2D04", VA = "0x9B2D04")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837DA0", Offset = "0x837DA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A04")]
			[Address(RVA = "0x9B2D0C", Offset = "0x9B2D0C", VA = "0x9B2D0C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837DB0", Offset = "0x837DB0")]
			private set
			{
			}
		}

		[Token(Token = "0x6001A05")]
		[Address(RVA = "0x9B2D14", Offset = "0x9B2D14", VA = "0x9B2D14")]
		public FightScene()
		{
		}

		[Token(Token = "0x6001A06")]
		[Address(RVA = "0x9B2DA8", Offset = "0x9B2DA8", VA = "0x9B2DA8")]
		public void Setup(RuntimeDataCache<Monster, RDMonster> monstersCache, Dictionary<string, IAbilityEffect> allAbilityEffects)
		{
		}
	}
}
