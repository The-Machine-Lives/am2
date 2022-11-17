using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Uniject;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	[Token(Token = "0x2000014")]
	internal class AppleStoreImpl : NativeJSONStore, IAppleExtensions, IAppleConfiguration, IStoreExtension, IStoreConfiguration
	{
		[Token(Token = "0x2000015")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81865C", Offset = "0x81865C")]
		private sealed class _003CMessageCallback_003Ec__AnonStorey0
		{
			[Token(Token = "0x400001B")]
			[FieldOffset(Offset = "0x10")]
			internal string subject;

			[Token(Token = "0x400001C")]
			[FieldOffset(Offset = "0x18")]
			internal string payload;

			[Token(Token = "0x400001D")]
			[FieldOffset(Offset = "0x20")]
			internal string receipt;

			[Token(Token = "0x400001E")]
			[FieldOffset(Offset = "0x28")]
			internal string transactionId;

			[Token(Token = "0x6000039")]
			[Address(RVA = "0x1784918", Offset = "0x1784918", VA = "0x1784918")]
			public _003CMessageCallback_003Ec__AnonStorey0()
			{
			}

			[Token(Token = "0x600003A")]
			[Address(RVA = "0x1784FC4", Offset = "0x1784FC4", VA = "0x1784FC4")]
			internal void _003C_003Em__0()
			{
			}
		}

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x20")]
		private Action<Product> m_DeferredCallback;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x28")]
		private Action m_RefreshReceiptError;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x30")]
		private Action<string> m_RefreshReceiptSuccess;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x38")]
		private Action<bool> m_RestoreCallback;

		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x40")]
		private INativeAppleStore m_Native;

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x0")]
		private static IUtil util;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x8")]
		private static AppleStoreImpl instance;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8186CC", Offset = "0x8186CC")]
		private static UnityPurchasingCallback _003C_003Ef__mg_0024cache0;

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8186DC", Offset = "0x8186DC")]
		private static Dictionary<string, int> _003C_003Ef__switch_0024map0;

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x178434C", Offset = "0x178434C", VA = "0x178434C")]
		public AppleStoreImpl(IUtil util)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x17843CC", Offset = "0x17843CC", VA = "0x17843CC")]
		public void SetNativeStore(INativeAppleStore apple)
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x17844FC", Offset = "0x17844FC", VA = "0x17844FC", Slot = "16")]
		public override void OnProductsRetrieved(string json)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x17846A0", Offset = "0x17846A0", VA = "0x17846A0")]
		public void OnPurchaseDeferred(string productId)
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x17847C4", Offset = "0x17847C4", VA = "0x17847C4")]
		public void OnTransactionsRestoredSuccess()
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x1784828", Offset = "0x1784828", VA = "0x1784828")]
		public void OnTransactionsRestoredFail(string error)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x178488C", Offset = "0x178488C", VA = "0x178488C")]
		public void OnAppReceiptRetrieved(string receipt)
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x1784904", Offset = "0x1784904", VA = "0x1784904")]
		public void OnAppReceiptRefreshedFailed()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x17841D0", Offset = "0x17841D0", VA = "0x17841D0")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x818858", Offset = "0x818858")]
		private static void MessageCallback(string subject, string payload, string receipt, string transactionId)
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x1784920", Offset = "0x1784920", VA = "0x1784920")]
		private void ProcessMessage(string subject, string payload, string receipt, string transactionId)
		{
		}
	}
}
