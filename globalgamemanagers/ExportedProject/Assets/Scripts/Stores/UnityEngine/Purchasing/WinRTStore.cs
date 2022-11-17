using System;
using System.Collections.ObjectModel;
using Il2CppDummyDll;
using Uniject;
using UnityEngine.Purchasing.Default;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	[Token(Token = "0x2000030")]
	internal class WinRTStore : AbstractStore, IWindowsIAPCallback
	{
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x10")]
		private IWindowsIAP win8;

		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x18")]
		private IStoreCallback callback;

		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x20")]
		private IUtil util;

		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x28")]
		private ILogger logger;

		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x818828", Offset = "0x818828")]
		private static Func<ProductDefinition, bool> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x818838", Offset = "0x818838")]
		private static Func<ProductDefinition, WinProductDescription> _003C_003Ef__am_0024cache1;

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x1789CF8", Offset = "0x1789CF8", VA = "0x1789CF8")]
		public WinRTStore(IWindowsIAP win8, IUtil util, ILogger logger)
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x178B0D4", Offset = "0x178B0D4", VA = "0x178B0D4", Slot = "8")]
		public override void Initialize(IStoreCallback biller)
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x178B0DC", Offset = "0x178B0DC", VA = "0x178B0DC", Slot = "9")]
		public override void RetrieveProducts(ReadOnlyCollection<ProductDefinition> productDefs)
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x178B3E0", Offset = "0x178B3E0", VA = "0x178B3E0", Slot = "11")]
		public override void FinishTransaction(ProductDefinition product, string transactionId)
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x178B2A4", Offset = "0x178B2A4", VA = "0x178B2A4")]
		private void init(int delay)
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x178B4A8", Offset = "0x178B4A8", VA = "0x178B4A8", Slot = "10")]
		public override void Purchase(ProductDefinition product, string developerPayload)
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x178B58C", Offset = "0x178B58C", VA = "0x178B58C")]
		public void restoreTransactions(bool pausing)
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x178B668", Offset = "0x178B668", VA = "0x178B668")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8189DC", Offset = "0x8189DC")]
		private static bool _003CRetrieveProducts_003Em__0(ProductDefinition def)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x178B6A0", Offset = "0x178B6A0", VA = "0x178B6A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8189EC", Offset = "0x8189EC")]
		private static WinProductDescription _003CRetrieveProducts_003Em__1(ProductDefinition def)
		{
			return null;
		}
	}
}
