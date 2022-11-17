using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200034E")]
	public class CodeButtonCombo : RuntimeData<RDCodeButtonCombo>
	{
		[Token(Token = "0x400100F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x829228", Offset = "0x829228")]
		private RewardGroup _003CrewardGroup_003Ek__BackingField;

		[Token(Token = "0x17000430")]
		public List<ECodeButtonIndex> buttonSequence
		{
			[Token(Token = "0x6001A29")]
			[Address(RVA = "0x9AEB60", Offset = "0x9AEB60", VA = "0x9AEB60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000431")]
		public RewardGroup rewardGroup
		{
			[Token(Token = "0x6001A2A")]
			[Address(RVA = "0x9AEB8C", Offset = "0x9AEB8C", VA = "0x9AEB8C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837DE0", Offset = "0x837DE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A2B")]
			[Address(RVA = "0x9AEB94", Offset = "0x9AEB94", VA = "0x9AEB94")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837DF0", Offset = "0x837DF0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000432")]
		public string acquireText
		{
			[Token(Token = "0x6001A2C")]
			[Address(RVA = "0x9AEB9C", Offset = "0x9AEB9C", VA = "0x9AEB9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001A2D")]
		[Address(RVA = "0x9AEBC8", Offset = "0x9AEBC8", VA = "0x9AEBC8")]
		public CodeButtonCombo()
		{
		}

		[Token(Token = "0x6001A2E")]
		[Address(RVA = "0x9AEC18", Offset = "0x9AEC18", VA = "0x9AEC18", Slot = "4")]
		public override void Initialize(RDCodeButtonCombo referenceData)
		{
		}
	}
}
