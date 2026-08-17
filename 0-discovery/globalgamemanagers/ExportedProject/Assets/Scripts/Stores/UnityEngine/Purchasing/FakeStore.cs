using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Il2CppDummyDll;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	[Token(Token = "0x200001C")]
	internal class FakeStore : AbstractStore, IFakeExtensions, IStoreExtension
	{
		[Token(Token = "0x200001D")]
		protected enum DialogType
		{
			[Token(Token = "0x400002D")]
			Purchase = 0,
			[Token(Token = "0x400002E")]
			RetrieveProducts = 1
		}

		[Token(Token = "0x200001E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81866C", Offset = "0x81866C")]
		private sealed class _003CRetrieveProducts_003Ec__AnonStorey0
		{
			[Token(Token = "0x400002F")]
			[FieldOffset(Offset = "0x10")]
			internal List<ProductDescription> products;

			[Token(Token = "0x4000030")]
			[FieldOffset(Offset = "0x18")]
			internal FakeStore _0024this;

			[Token(Token = "0x6000044")]
			[Address(RVA = "0x178635C", Offset = "0x178635C", VA = "0x178635C")]
			public _003CRetrieveProducts_003Ec__AnonStorey0()
			{
			}

			[Token(Token = "0x6000045")]
			[Address(RVA = "0x17867B8", Offset = "0x17867B8", VA = "0x17867B8")]
			internal void _003C_003Em__0(bool allow, InitializationFailureReason failureReason)
			{
			}
		}

		[Token(Token = "0x200001F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81867C", Offset = "0x81867C")]
		private sealed class _003CPurchase_003Ec__AnonStorey1
		{
			[Token(Token = "0x4000031")]
			[FieldOffset(Offset = "0x10")]
			internal ProductDefinition product;

			[Token(Token = "0x4000032")]
			[FieldOffset(Offset = "0x18")]
			internal FakeStore _0024this;

			[Token(Token = "0x6000046")]
			[Address(RVA = "0x1786554", Offset = "0x1786554", VA = "0x1786554")]
			public _003CPurchase_003Ec__AnonStorey1()
			{
			}

			[Token(Token = "0x6000047")]
			[Address(RVA = "0x1786560", Offset = "0x1786560", VA = "0x1786560")]
			internal void _003C_003Em__0(bool allow, PurchaseFailureReason failureReason)
			{
			}
		}

		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x10")]
		private IStoreCallback m_Biller;

		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x18")]
		private List<string> m_PurchasedProducts;

		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x20")]
		public bool purchaseCalled;

		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x8186EC", Offset = "0x8186EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8186EC", Offset = "0x8186EC")]
		private string _003CunavailableProductId_003Ek__BackingField;

		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x30")]
		public FakeStoreUIMode UIMode;

		[Token(Token = "0x17000001")]
		public string unavailableProductId
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x1785E50", Offset = "0x1785E50", VA = "0x1785E50", Slot = "12")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8188BC", Offset = "0x8188BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x1785DDC", Offset = "0x1785DDC", VA = "0x1785DDC")]
		public FakeStore()
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x1785E58", Offset = "0x1785E58", VA = "0x1785E58", Slot = "8")]
		public override void Initialize(IStoreCallback biller)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x1785E60", Offset = "0x1785E60", VA = "0x1785E60", Slot = "9")]
		public override void RetrieveProducts(ReadOnlyCollection<ProductDefinition> productDefinitions)
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x1786364", Offset = "0x1786364", VA = "0x1786364", Slot = "10")]
		public override void Purchase(ProductDefinition product, string developerPayload)
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x178655C", Offset = "0x178655C", VA = "0x178655C", Slot = "11")]
		public override void FinishTransaction(ProductDefinition product, string transactionId)
		{
		}

		[Token(Token = "0x6000043")]
		protected virtual bool StartUI<T>(object model, DialogType dialogType, Action<bool, T> callback)
		{
			return default(bool);
		}
	}
}
