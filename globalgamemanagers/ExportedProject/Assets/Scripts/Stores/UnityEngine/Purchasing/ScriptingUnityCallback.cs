using Il2CppDummyDll;
using Uniject;

namespace UnityEngine.Purchasing
{
	[Token(Token = "0x2000009")]
	internal class ScriptingUnityCallback : IUnityCallback
	{
		[Token(Token = "0x200000A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81861C", Offset = "0x81861C")]
		private sealed class _003COnSetupFailed_003Ec__AnonStorey0
		{
			[Token(Token = "0x4000007")]
			[FieldOffset(Offset = "0x10")]
			internal string json;

			[Token(Token = "0x4000008")]
			[FieldOffset(Offset = "0x18")]
			internal ScriptingUnityCallback _0024this;

			[Token(Token = "0x6000024")]
			[Address(RVA = "0x17888B0", Offset = "0x17888B0", VA = "0x17888B0")]
			public _003COnSetupFailed_003Ec__AnonStorey0()
			{
			}

			[Token(Token = "0x6000025")]
			[Address(RVA = "0x1788F30", Offset = "0x1788F30", VA = "0x1788F30")]
			internal void _003C_003Em__0()
			{
			}
		}

		[Token(Token = "0x200000B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81862C", Offset = "0x81862C")]
		private sealed class _003COnProductsRetrieved_003Ec__AnonStorey1
		{
			[Token(Token = "0x4000009")]
			[FieldOffset(Offset = "0x10")]
			internal string json;

			[Token(Token = "0x400000A")]
			[FieldOffset(Offset = "0x18")]
			internal ScriptingUnityCallback _0024this;

			[Token(Token = "0x6000026")]
			[Address(RVA = "0x17889F0", Offset = "0x17889F0", VA = "0x17889F0")]
			public _003COnProductsRetrieved_003Ec__AnonStorey1()
			{
			}

			[Token(Token = "0x6000027")]
			[Address(RVA = "0x1788CAC", Offset = "0x1788CAC", VA = "0x1788CAC")]
			internal void _003C_003Em__0()
			{
			}
		}

		[Token(Token = "0x200000C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81863C", Offset = "0x81863C")]
		private sealed class _003COnPurchaseSucceeded_003Ec__AnonStorey2
		{
			[Token(Token = "0x400000B")]
			[FieldOffset(Offset = "0x10")]
			internal string id;

			[Token(Token = "0x400000C")]
			[FieldOffset(Offset = "0x18")]
			internal string receipt;

			[Token(Token = "0x400000D")]
			[FieldOffset(Offset = "0x20")]
			internal string transactionID;

			[Token(Token = "0x400000E")]
			[FieldOffset(Offset = "0x28")]
			internal ScriptingUnityCallback _0024this;

			[Token(Token = "0x6000028")]
			[Address(RVA = "0x1788B64", Offset = "0x1788B64", VA = "0x1788B64")]
			public _003COnPurchaseSucceeded_003Ec__AnonStorey2()
			{
			}

			[Token(Token = "0x6000029")]
			[Address(RVA = "0x1788E4C", Offset = "0x1788E4C", VA = "0x1788E4C")]
			internal void _003C_003Em__0()
			{
			}
		}

		[Token(Token = "0x200000D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81864C", Offset = "0x81864C")]
		private sealed class _003COnPurchaseFailed_003Ec__AnonStorey3
		{
			[Token(Token = "0x400000F")]
			[FieldOffset(Offset = "0x10")]
			internal string json;

			[Token(Token = "0x4000010")]
			[FieldOffset(Offset = "0x18")]
			internal ScriptingUnityCallback _0024this;

			[Token(Token = "0x600002A")]
			[Address(RVA = "0x1788CA4", Offset = "0x1788CA4", VA = "0x1788CA4")]
			public _003COnPurchaseFailed_003Ec__AnonStorey3()
			{
			}

			[Token(Token = "0x600002B")]
			[Address(RVA = "0x1788D7C", Offset = "0x1788D7C", VA = "0x1788D7C")]
			internal void _003C_003Em__0()
			{
			}
		}

		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x10")]
		private IUnityCallback forwardTo;

		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x18")]
		private IUtil util;

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x1788598", Offset = "0x1788598", VA = "0x1788598")]
		public ScriptingUnityCallback(IUnityCallback forwardTo, IUtil util)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x1788778", Offset = "0x1788778", VA = "0x1788778", Slot = "4")]
		public void OnSetupFailed(string json)
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x17888B8", Offset = "0x17888B8", VA = "0x17888B8", Slot = "5")]
		public void OnProductsRetrieved(string json)
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x17889F8", Offset = "0x17889F8", VA = "0x17889F8", Slot = "6")]
		public void OnPurchaseSucceeded(string id, string receipt, string transactionID)
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x1788B6C", Offset = "0x1788B6C", VA = "0x1788B6C", Slot = "7")]
		public void OnPurchaseFailed(string json)
		{
		}
	}
}
