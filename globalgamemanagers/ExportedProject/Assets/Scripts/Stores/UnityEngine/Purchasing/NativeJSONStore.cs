using System.Collections.ObjectModel;
using Il2CppDummyDll;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	[Token(Token = "0x2000008")]
	internal class NativeJSONStore : AbstractStore, IUnityCallback
	{
		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x10")]
		protected IStoreCallback unity;

		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x18")]
		private INativeStore store;

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x17843C4", Offset = "0x17843C4", VA = "0x17843C4")]
		public NativeJSONStore()
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x17844F4", Offset = "0x17844F4", VA = "0x17844F4")]
		public void SetNativeStore(INativeStore native)
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x1787BAC", Offset = "0x1787BAC", VA = "0x1787BAC", Slot = "8")]
		public override void Initialize(IStoreCallback callback)
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x1787BB4", Offset = "0x1787BB4", VA = "0x1787BB4", Slot = "9")]
		public override void RetrieveProducts(ReadOnlyCollection<ProductDefinition> products)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x1787C84", Offset = "0x1787C84", VA = "0x1787C84", Slot = "10")]
		public override void Purchase(ProductDefinition product, string developerPayload)
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x1787D60", Offset = "0x1787D60", VA = "0x1787D60", Slot = "11")]
		public override void FinishTransaction(ProductDefinition product, string transactionId)
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x1784CC0", Offset = "0x1784CC0", VA = "0x1784CC0", Slot = "12")]
		public void OnSetupFailed(string reason)
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x17845CC", Offset = "0x17845CC", VA = "0x17845CC", Slot = "16")]
		public virtual void OnProductsRetrieved(string json)
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x1784E10", Offset = "0x1784E10", VA = "0x1784E10", Slot = "14")]
		public void OnPurchaseSucceeded(string id, string receipt, string transactionID)
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x1784EF0", Offset = "0x1784EF0", VA = "0x1784EF0", Slot = "15")]
		public void OnPurchaseFailed(string json)
		{
		}
	}
}
