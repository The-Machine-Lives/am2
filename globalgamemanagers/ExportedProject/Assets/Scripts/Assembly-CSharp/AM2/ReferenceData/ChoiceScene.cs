using System.Collections.Generic;
using Il2CppDummyDll;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200033E")]
	public class ChoiceScene : ActionScene<RDChoiceScene>
	{
		[Token(Token = "0x4000FEE")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x828C30", Offset = "0x828C30")]
		private List<Choice> _003Cchoices_003Ek__BackingField;

		[Token(Token = "0x4000FEF")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x828C40", Offset = "0x828C40")]
		private IAbilityEffect _003CexpirationEffect_003Ek__BackingField;

		[Token(Token = "0x1700041B")]
		public List<Choice> choices
		{
			[Token(Token = "0x60019F5")]
			[Address(RVA = "0x9AE76C", Offset = "0x9AE76C", VA = "0x9AE76C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837D40", Offset = "0x837D40")]
			get
			{
				return null;
			}
			[Token(Token = "0x60019F6")]
			[Address(RVA = "0x9AE774", Offset = "0x9AE774", VA = "0x9AE774")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837D50", Offset = "0x837D50")]
			private set
			{
			}
		}

		[Token(Token = "0x1700041C")]
		public IAbilityEffect expirationEffect
		{
			[Token(Token = "0x60019F7")]
			[Address(RVA = "0x9AE77C", Offset = "0x9AE77C", VA = "0x9AE77C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837D60", Offset = "0x837D60")]
			get
			{
				return null;
			}
			[Token(Token = "0x60019F8")]
			[Address(RVA = "0x9AE784", Offset = "0x9AE784", VA = "0x9AE784")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837D70", Offset = "0x837D70")]
			private set
			{
			}
		}

		[Token(Token = "0x1700041D")]
		public string text
		{
			[Token(Token = "0x60019F9")]
			[Address(RVA = "0x9AE78C", Offset = "0x9AE78C", VA = "0x9AE78C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700041E")]
		public double durationInSeconds
		{
			[Token(Token = "0x60019FA")]
			[Address(RVA = "0x9AE7B8", Offset = "0x9AE7B8", VA = "0x9AE7B8")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x60019FB")]
		[Address(RVA = "0x9AE7E4", Offset = "0x9AE7E4", VA = "0x9AE7E4")]
		public ChoiceScene()
		{
		}

		[Token(Token = "0x60019FC")]
		[Address(RVA = "0x9AE874", Offset = "0x9AE874", VA = "0x9AE874")]
		public void Setup(Dictionary<string, IAbilityEffect> allAbilityEffects)
		{
		}

		[Token(Token = "0x60019FD")]
		[Address(RVA = "0x9AEA7C", Offset = "0x9AEA7C", VA = "0x9AEA7C")]
		public bool IsBranchingSceneChoice()
		{
			return default(bool);
		}
	}
}
