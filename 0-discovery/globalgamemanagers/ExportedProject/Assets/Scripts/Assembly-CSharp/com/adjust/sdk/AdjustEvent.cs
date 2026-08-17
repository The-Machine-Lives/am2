using System.Collections.Generic;
using Il2CppDummyDll;

namespace com.adjust.sdk
{
	[Token(Token = "0x200022A")]
	public class AdjustEvent
	{
		[Token(Token = "0x4000C45")]
		[FieldOffset(Offset = "0x10")]
		internal string currency;

		[Token(Token = "0x4000C46")]
		[FieldOffset(Offset = "0x18")]
		internal string eventToken;

		[Token(Token = "0x4000C47")]
		[FieldOffset(Offset = "0x20")]
		internal string callbackId;

		[Token(Token = "0x4000C48")]
		[FieldOffset(Offset = "0x28")]
		internal string transactionId;

		[Token(Token = "0x4000C49")]
		[FieldOffset(Offset = "0x30")]
		internal double? revenue;

		[Token(Token = "0x4000C4A")]
		[FieldOffset(Offset = "0x40")]
		internal List<string> partnerList;

		[Token(Token = "0x4000C4B")]
		[FieldOffset(Offset = "0x48")]
		internal List<string> callbackList;

		[Token(Token = "0x4000C4C")]
		[FieldOffset(Offset = "0x50")]
		internal string receipt;

		[Token(Token = "0x4000C4D")]
		[FieldOffset(Offset = "0x58")]
		internal bool isReceiptSet;

		[Token(Token = "0x6000F4D")]
		[Address(RVA = "0x17792F4", Offset = "0x17792F4", VA = "0x17792F4")]
		public AdjustEvent(string eventToken)
		{
		}

		[Token(Token = "0x6000F4E")]
		[Address(RVA = "0x1779324", Offset = "0x1779324", VA = "0x1779324")]
		public void setRevenue(double amount, string currency)
		{
		}

		[Token(Token = "0x6000F4F")]
		[Address(RVA = "0x17793AC", Offset = "0x17793AC", VA = "0x17793AC")]
		public void addCallbackParameter(string key, string value)
		{
		}

		[Token(Token = "0x6000F50")]
		[Address(RVA = "0x1779474", Offset = "0x1779474", VA = "0x1779474")]
		public void addPartnerParameter(string key, string value)
		{
		}

		[Token(Token = "0x6000F51")]
		[Address(RVA = "0x177953C", Offset = "0x177953C", VA = "0x177953C")]
		public void setTransactionId(string transactionId)
		{
		}

		[Token(Token = "0x6000F52")]
		[Address(RVA = "0x1779544", Offset = "0x1779544", VA = "0x1779544")]
		public void setCallbackId(string callbackId)
		{
		}

		[Token(Token = "0x6000F53")]
		[Address(RVA = "0x177954C", Offset = "0x177954C", VA = "0x177954C")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x8356DC", Offset = "0x8356DC")]
		public void setReceipt(string receipt, string transactionId)
		{
		}
	}
}
