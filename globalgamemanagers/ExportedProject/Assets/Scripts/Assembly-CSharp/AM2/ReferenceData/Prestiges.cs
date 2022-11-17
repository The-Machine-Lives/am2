using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200038A")]
	public class Prestiges : RuntimeData<RDPrestiges>, IItemModel, IInfoText
	{
		[Token(Token = "0x400114B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82CA44", Offset = "0x82CA44")]
		private Upgradable _003Cupgradable_003Ek__BackingField;

		[Token(Token = "0x170004F3")]
		public string readableItemName
		{
			[Token(Token = "0x6001BD5")]
			[Address(RVA = "0x9B92C0", Offset = "0x9B92C0", VA = "0x9B92C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004F4")]
		public string description
		{
			[Token(Token = "0x6001BD6")]
			[Address(RVA = "0x9B92F0", Offset = "0x9B92F0", VA = "0x9B92F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004F5")]
		public string researchInfoText
		{
			[Token(Token = "0x6001BD7")]
			[Address(RVA = "0x9B9320", Offset = "0x9B9320", VA = "0x9B9320", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004F6")]
		public string infoImageSource
		{
			[Token(Token = "0x6001BD8")]
			[Address(RVA = "0x9B9350", Offset = "0x9B9350", VA = "0x9B9350", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004F7")]
		public Upgradable upgradable
		{
			[Token(Token = "0x6001BD9")]
			[Address(RVA = "0x9B86C0", Offset = "0x9B86C0", VA = "0x9B86C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838500", Offset = "0x838500")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BDA")]
			[Address(RVA = "0x9B9380", Offset = "0x9B9380", VA = "0x9B9380")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838510", Offset = "0x838510")]
			private set
			{
			}
		}

		[Token(Token = "0x6001BDB")]
		[Address(RVA = "0x9B9388", Offset = "0x9B9388", VA = "0x9B9388")]
		public Prestiges()
		{
		}

		[Token(Token = "0x6001BDC")]
		[Address(RVA = "0x9B93D8", Offset = "0x9B93D8", VA = "0x9B93D8")]
		public void Setup(RuntimeDataCache<Upgradable, RDUpgradable> upgradableItem)
		{
		}
	}
}
