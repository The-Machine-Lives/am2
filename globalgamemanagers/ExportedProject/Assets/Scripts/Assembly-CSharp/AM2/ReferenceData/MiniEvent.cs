using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200035E")]
	public class MiniEvent : RuntimeData<RDMiniEvent>, IItemModel, IInfoText
	{
		[Token(Token = "0x4001069")]
		public const string c_expiredTag = "expired";

		[Token(Token = "0x400106A")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82A014", Offset = "0x82A014")]
		private List<Upgradable> _003Cupgradables_003Ek__BackingField;

		[Token(Token = "0x17000456")]
		public string readableItemName
		{
			[Token(Token = "0x6001A8F")]
			[Address(RVA = "0x9B5DF0", Offset = "0x9B5DF0", VA = "0x9B5DF0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000457")]
		public string description
		{
			[Token(Token = "0x6001A90")]
			[Address(RVA = "0x9B5E1C", Offset = "0x9B5E1C", VA = "0x9B5E1C", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000458")]
		public string researchInfoText
		{
			[Token(Token = "0x6001A91")]
			[Address(RVA = "0x9B5E48", Offset = "0x9B5E48", VA = "0x9B5E48", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000459")]
		public string infoImageSource
		{
			[Token(Token = "0x6001A92")]
			[Address(RVA = "0x9B5E90", Offset = "0x9B5E90", VA = "0x9B5E90", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700045A")]
		public uint duration
		{
			[Token(Token = "0x6001A93")]
			[Address(RVA = "0x9B5ED8", Offset = "0x9B5ED8", VA = "0x9B5ED8")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x1700045B")]
		public List<Upgradable> upgradables
		{
			[Token(Token = "0x6001A94")]
			[Address(RVA = "0x9B5F04", Offset = "0x9B5F04", VA = "0x9B5F04")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837FA0", Offset = "0x837FA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A95")]
			[Address(RVA = "0x9B5F0C", Offset = "0x9B5F0C", VA = "0x9B5F0C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x837FB0", Offset = "0x837FB0")]
			private set
			{
			}
		}

		[Token(Token = "0x6001A96")]
		[Address(RVA = "0x9B5F14", Offset = "0x9B5F14", VA = "0x9B5F14")]
		public MiniEvent()
		{
		}

		[Token(Token = "0x6001A97")]
		[Address(RVA = "0x9B5F64", Offset = "0x9B5F64", VA = "0x9B5F64", Slot = "4")]
		public override void Initialize(RDMiniEvent referenceData)
		{
		}
	}
}
