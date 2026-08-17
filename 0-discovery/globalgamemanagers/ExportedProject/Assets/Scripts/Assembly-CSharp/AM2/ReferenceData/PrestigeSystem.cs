using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200038D")]
	public class PrestigeSystem : RuntimeData<RDPrestigeSystem>
	{
		[Token(Token = "0x4001150")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82CB4C", Offset = "0x82CB4C")]
		private string _003CprestigeSystemDescription_003Ek__BackingField;

		[Token(Token = "0x170004F8")]
		public string prestigeSystemDescription
		{
			[Token(Token = "0x6001BE0")]
			[Address(RVA = "0x9B905C", Offset = "0x9B905C", VA = "0x9B905C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838520", Offset = "0x838520")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BE1")]
			[Address(RVA = "0x9B9064", Offset = "0x9B9064", VA = "0x9B9064")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838530", Offset = "0x838530")]
			private set
			{
			}
		}

		[Token(Token = "0x170004F9")]
		public string prestigeTabUnlocker
		{
			[Token(Token = "0x6001BE2")]
			[Address(RVA = "0x9B906C", Offset = "0x9B906C", VA = "0x9B906C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004FA")]
		public string prestigeButtonUnlocker
		{
			[Token(Token = "0x6001BE3")]
			[Address(RVA = "0x9B9098", Offset = "0x9B9098", VA = "0x9B9098")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001BE4")]
		[Address(RVA = "0x9B90C4", Offset = "0x9B90C4", VA = "0x9B90C4")]
		public PrestigeSystem()
		{
		}

		[Token(Token = "0x6001BE5")]
		[Address(RVA = "0x9B912C", Offset = "0x9B912C", VA = "0x9B912C", Slot = "4")]
		public override void Initialize(RDPrestigeSystem referenceData)
		{
		}

		[Token(Token = "0x6001BE6")]
		[Address(RVA = "0x9B9194", Offset = "0x9B9194", VA = "0x9B9194")]
		private void AppendDescriptionEntriesAsNewLines()
		{
		}
	}
}
