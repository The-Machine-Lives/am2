using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000326")]
	public class Choice : RuntimeData<RDChoice>
	{
		[Token(Token = "0x4000FA4")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8280D4", Offset = "0x8280D4")]
		private IAbilityEffect _003CchoiceEffect_003Ek__BackingField;

		[Token(Token = "0x4000FA5")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, IAbilityEffect> m_allAbilityEffects;

		[Token(Token = "0x170003E5")]
		public IAbilityEffect choiceEffect
		{
			[Token(Token = "0x6001982")]
			[Address(RVA = "0x9AE4A0", Offset = "0x9AE4A0", VA = "0x9AE4A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837C30", Offset = "0x837C30")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001983")]
			[Address(RVA = "0x9AE4A8", Offset = "0x9AE4A8", VA = "0x9AE4A8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837C40", Offset = "0x837C40")]
			private set
			{
			}
		}

		[Token(Token = "0x170003E6")]
		public string textChoice
		{
			[Token(Token = "0x6001984")]
			[Address(RVA = "0x9AE4B0", Offset = "0x9AE4B0", VA = "0x9AE4B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003E7")]
		public string requiredItemRef
		{
			[Token(Token = "0x6001985")]
			[Address(RVA = "0x9AE4DC", Offset = "0x9AE4DC", VA = "0x9AE4DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003E8")]
		public long requiredItemQuantity
		{
			[Token(Token = "0x6001986")]
			[Address(RVA = "0x9AE508", Offset = "0x9AE508", VA = "0x9AE508")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170003E9")]
		public bool isRequirementConsumed
		{
			[Token(Token = "0x6001987")]
			[Address(RVA = "0x9AE534", Offset = "0x9AE534", VA = "0x9AE534")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6001988")]
		[Address(RVA = "0x9AE560", Offset = "0x9AE560", VA = "0x9AE560")]
		public Choice()
		{
		}

		[Token(Token = "0x6001989")]
		[Address(RVA = "0x9AE5B0", Offset = "0x9AE5B0", VA = "0x9AE5B0", Slot = "4")]
		public override void Initialize(RDChoice referenceData)
		{
		}
	}
}
