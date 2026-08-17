using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x200036F")]
	public class Equipment : RuntimeData<RDEquipment>, IItemModel, IInfoText, IDustable
	{
		[Token(Token = "0x40010F3")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B73C", Offset = "0x82B73C")]
		private string _003CdustInputItem_003Ek__BackingField;

		[Token(Token = "0x40010F4")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82B74C", Offset = "0x82B74C")]
		private List<EquipmentEffect> _003Ceffects_003Ek__BackingField;

		[Token(Token = "0x40010F5")]
		[FieldOffset(Offset = "0x28")]
		private ConstructionController m_constructionController;

		[Token(Token = "0x170004C1")]
		public string readableName
		{
			[Token(Token = "0x6001B6B")]
			[Address(RVA = "0x9B1EA8", Offset = "0x9B1EA8", VA = "0x9B1EA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004C2")]
		public string readableItemName
		{
			[Token(Token = "0x6001B6C")]
			[Address(RVA = "0x9B1ED4", Offset = "0x9B1ED4", VA = "0x9B1ED4", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004C3")]
		public string description
		{
			[Token(Token = "0x6001B6D")]
			[Address(RVA = "0x9B1F00", Offset = "0x9B1F00", VA = "0x9B1F00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004C4")]
		public string researchInfoText
		{
			[Token(Token = "0x6001B6E")]
			[Address(RVA = "0x9B1F2C", Offset = "0x9B1F2C", VA = "0x9B1F2C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004C5")]
		public string infoImageSource
		{
			[Token(Token = "0x6001B6F")]
			[Address(RVA = "0x9B1F7C", Offset = "0x9B1F7C", VA = "0x9B1F7C", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004C6")]
		public string dustInputItem
		{
			[Token(Token = "0x6001B70")]
			[Address(RVA = "0x9B1FCC", Offset = "0x9B1FCC", VA = "0x9B1FCC", Slot = "10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838420", Offset = "0x838420")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B71")]
			[Address(RVA = "0x9B1FD4", Offset = "0x9B1FD4", VA = "0x9B1FD4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838430", Offset = "0x838430")]
			set
			{
			}
		}

		[Token(Token = "0x170004C7")]
		public long dustOutputAmount
		{
			[Token(Token = "0x6001B72")]
			[Address(RVA = "0x9B1FDC", Offset = "0x9B1FDC", VA = "0x9B1FDC", Slot = "11")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170004C8")]
		public List<EquipmentEffect> effects
		{
			[Token(Token = "0x6001B73")]
			[Address(RVA = "0x9B2008", Offset = "0x9B2008", VA = "0x9B2008")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838440", Offset = "0x838440")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B74")]
			[Address(RVA = "0x9B2010", Offset = "0x9B2010", VA = "0x9B2010")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838450", Offset = "0x838450")]
			private set
			{
			}
		}

		[Token(Token = "0x6001B75")]
		[Address(RVA = "0x9B2018", Offset = "0x9B2018", VA = "0x9B2018")]
		public Equipment()
		{
		}

		[Token(Token = "0x6001B76")]
		[Address(RVA = "0x9B2068", Offset = "0x9B2068", VA = "0x9B2068", Slot = "4")]
		public override void Initialize(RDEquipment referenceData)
		{
		}

		[Token(Token = "0x6001B77")]
		[Address(RVA = "0x9B223C", Offset = "0x9B223C", VA = "0x9B223C")]
		public List<EquipmentTrait> GenerateTraitsForNewItem()
		{
			return null;
		}

		[Token(Token = "0x6001B78")]
		[Address(RVA = "0x9B240C", Offset = "0x9B240C", VA = "0x9B240C", Slot = "12")]
		public bool Dust(long _)
		{
			return default(bool);
		}
	}
}
