using System;
using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000378")]
	public class InboxMessage : RuntimeData<RDInboxMessage>, IItemModel, IInfoText
	{
		[Token(Token = "0x4001105")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82BA30", Offset = "0x82BA30")]
		private EventSchedule _003CeventSchedule_003Ek__BackingField;

		[Token(Token = "0x170004CB")]
		public string subject
		{
			[Token(Token = "0x6001B86")]
			[Address(RVA = "0x9B4DB8", Offset = "0x9B4DB8", VA = "0x9B4DB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004CC")]
		public string body
		{
			[Token(Token = "0x6001B87")]
			[Address(RVA = "0x9B4DE4", Offset = "0x9B4DE4", VA = "0x9B4DE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004CD")]
		public string rewardItemReference
		{
			[Token(Token = "0x6001B88")]
			[Address(RVA = "0x9B4E10", Offset = "0x9B4E10", VA = "0x9B4E10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004CE")]
		public long rewardAmount
		{
			[Token(Token = "0x6001B89")]
			[Address(RVA = "0x9B4E3C", Offset = "0x9B4E3C", VA = "0x9B4E3C")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170004CF")]
		public EventSchedule eventSchedule
		{
			[Token(Token = "0x6001B8A")]
			[Address(RVA = "0x9B4E68", Offset = "0x9B4E68", VA = "0x9B4E68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838460", Offset = "0x838460")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B8B")]
			[Address(RVA = "0x9B4E70", Offset = "0x9B4E70", VA = "0x9B4E70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x838470", Offset = "0x838470")]
			private set
			{
			}
		}

		[Token(Token = "0x170004D0")]
		public string readableItemName
		{
			[Token(Token = "0x6001B8C")]
			[Address(RVA = "0x9B4E78", Offset = "0x9B4E78", VA = "0x9B4E78", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004D1")]
		public string description
		{
			[Token(Token = "0x6001B8D")]
			[Address(RVA = "0x9B4EC0", Offset = "0x9B4EC0", VA = "0x9B4EC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004D2")]
		public string researchInfoText
		{
			[Token(Token = "0x6001B8E")]
			[Address(RVA = "0x9B4F08", Offset = "0x9B4F08", VA = "0x9B4F08", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004D3")]
		public string infoImageSource
		{
			[Token(Token = "0x6001B8F")]
			[Address(RVA = "0x9B4F50", Offset = "0x9B4F50", VA = "0x9B4F50", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001B90")]
		[Address(RVA = "0x9B4F98", Offset = "0x9B4F98", VA = "0x9B4F98", Slot = "4")]
		public override void Initialize(RDInboxMessage referenceData)
		{
		}

		[Token(Token = "0x6001B91")]
		[Address(RVA = "0x9B50F4", Offset = "0x9B50F4", VA = "0x9B50F4")]
		public DateTime GetExpirationDate()
		{
			return default(DateTime);
		}

		[Token(Token = "0x6001B92")]
		[Address(RVA = "0x9B5178", Offset = "0x9B5178", VA = "0x9B5178")]
		public bool IsActiveByTime()
		{
			return default(bool);
		}

		[Token(Token = "0x6001B93")]
		[Address(RVA = "0x9B5190", Offset = "0x9B5190", VA = "0x9B5190")]
		public int GetCurrentIteration()
		{
			return default(int);
		}

		[Token(Token = "0x6001B94")]
		[Address(RVA = "0x9B51A4", Offset = "0x9B51A4", VA = "0x9B51A4")]
		public InboxMessage()
		{
		}
	}
}
