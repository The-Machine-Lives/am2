using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x2000268")]
	internal class EventManager
	{
		[Token(Token = "0x2000707")]
		internal class FetchResponse : BaseReferenceHolder
		{
			[Token(Token = "0x6002FB6")]
			[Address(RVA = "0xC73D94", Offset = "0xC73D94", VA = "0xC73D94")]
			internal FetchResponse(IntPtr selfPointer)
			{
			}

			[Token(Token = "0x6002FB7")]
			[Address(RVA = "0xC73E08", Offset = "0xC73E08", VA = "0xC73E08")]
			internal CommonErrorStatus.ResponseStatus ResponseStatus()
			{
				return default(CommonErrorStatus.ResponseStatus);
			}

			[Token(Token = "0x6002FB8")]
			[Address(RVA = "0xC73E20", Offset = "0xC73E20", VA = "0xC73E20")]
			internal bool RequestSucceeded()
			{
				return default(bool);
			}

			[Token(Token = "0x6002FB9")]
			[Address(RVA = "0xC73E44", Offset = "0xC73E44", VA = "0xC73E44")]
			internal NativeEvent Data()
			{
				return null;
			}

			[Token(Token = "0x6002FBA")]
			[Address(RVA = "0xC73EDC", Offset = "0xC73EDC", VA = "0xC73EDC", Slot = "5")]
			protected override void CallDispose(HandleRef selfPointer)
			{
			}

			[Token(Token = "0x6002FBB")]
			[Address(RVA = "0xC73EEC", Offset = "0xC73EEC", VA = "0xC73EEC")]
			internal static FetchResponse FromPointer(IntPtr pointer)
			{
				return null;
			}
		}

		[Token(Token = "0x2000708")]
		internal class FetchAllResponse : BaseReferenceHolder
		{
			[Serializable]
			[Token(Token = "0x2000897")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8217C8", Offset = "0x8217C8")]
			private sealed class _003C_003Ec
			{
				[Token(Token = "0x400247F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public static readonly _003C_003Ec _003C_003E9;

				[Token(Token = "0x4002480")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public static Func<IntPtr, NativeEvent> _003C_003E9__2_1;

				[Token(Token = "0x60033EE")]
				[Address(RVA = "0xC73CB8", Offset = "0xC73CB8", VA = "0xC73CB8")]
				public _003C_003Ec()
				{
				}

				[Token(Token = "0x60033EF")]
				[Address(RVA = "0xC73CC0", Offset = "0xC73CC0", VA = "0xC73CC0")]
				internal NativeEvent _003CData_003Eb__2_1(IntPtr ptr)
				{
					return null;
				}
			}

			[Token(Token = "0x6002FBC")]
			[Address(RVA = "0xC73958", Offset = "0xC73958", VA = "0xC73958")]
			internal FetchAllResponse(IntPtr selfPointer)
			{
			}

			[Token(Token = "0x6002FBD")]
			[Address(RVA = "0xC739CC", Offset = "0xC739CC", VA = "0xC739CC")]
			internal CommonErrorStatus.ResponseStatus ResponseStatus()
			{
				return default(CommonErrorStatus.ResponseStatus);
			}

			[Token(Token = "0x6002FBE")]
			[Address(RVA = "0xC739E4", Offset = "0xC739E4", VA = "0xC739E4")]
			internal List<NativeEvent> Data()
			{
				return null;
			}

			[Token(Token = "0x6002FBF")]
			[Address(RVA = "0xC73B54", Offset = "0xC73B54", VA = "0xC73B54")]
			internal bool RequestSucceeded()
			{
				return default(bool);
			}

			[Token(Token = "0x6002FC0")]
			[Address(RVA = "0xC73B78", Offset = "0xC73B78", VA = "0xC73B78", Slot = "5")]
			protected override void CallDispose(HandleRef selfPointer)
			{
			}

			[Token(Token = "0x6002FC1")]
			[Address(RVA = "0xC73B88", Offset = "0xC73B88", VA = "0xC73B88")]
			internal static FetchAllResponse FromPointer(IntPtr pointer)
			{
				return null;
			}

			[Token(Token = "0x6002FC2")]
			[Address(RVA = "0xC73C24", Offset = "0xC73C24", VA = "0xC73C24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83B67C", Offset = "0x83B67C")]
			private UIntPtr _003CData_003Eb__2_0(IntPtr[] out_arg, UIntPtr out_size)
			{
				return default(UIntPtr);
			}
		}

		[Token(Token = "0x4000D1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly GameServices mServices;

		[Token(Token = "0x600122A")]
		[Address(RVA = "0xC7363C", Offset = "0xC7363C", VA = "0xC7363C")]
		internal EventManager(GameServices services)
		{
		}

		[Token(Token = "0x600122B")]
		[Address(RVA = "0xC736AC", Offset = "0xC736AC", VA = "0xC736AC")]
		internal void FetchAll(Types.DataSource source, Action<FetchAllResponse> callback)
		{
		}

		[Token(Token = "0x600122C")]
		[Address(RVA = "0xC73534", Offset = "0xC73534", VA = "0xC73534")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x835E90", Offset = "0x835E90")]
		internal static void InternalFetchAllCallback(IntPtr response, IntPtr data)
		{
		}

		[Token(Token = "0x600122D")]
		[Address(RVA = "0xC737D4", Offset = "0xC737D4", VA = "0xC737D4")]
		internal void Fetch(Types.DataSource source, string eventId, Action<FetchResponse> callback)
		{
		}

		[Token(Token = "0x600122E")]
		[Address(RVA = "0xC735B8", Offset = "0xC735B8", VA = "0xC735B8")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x835EF4", Offset = "0x835EF4")]
		internal static void InternalFetchCallback(IntPtr response, IntPtr data)
		{
		}

		[Token(Token = "0x600122F")]
		[Address(RVA = "0xC7390C", Offset = "0xC7390C", VA = "0xC7390C")]
		internal void Increment(string eventId, uint steps)
		{
		}
	}
}
