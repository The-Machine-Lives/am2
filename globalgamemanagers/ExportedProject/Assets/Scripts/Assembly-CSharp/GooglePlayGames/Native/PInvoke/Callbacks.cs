using System;
using System.Collections;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x2000266")]
	internal static class Callbacks
	{
		[Token(Token = "0x20006FE")]
		internal delegate void ShowUICallbackInternal(CommonErrorStatus.UIStatus status, IntPtr data);

		[Token(Token = "0x20006FF")]
		internal enum Type
		{
			[Token(Token = "0x40020E7")]
			Permanent = 0,
			[Token(Token = "0x40020E8")]
			Temporary = 1
		}

		[Token(Token = "0x2000700")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820D98", Offset = "0x820D98")]
		private sealed class _003C_003Ec__DisplayClass2_0<T> where T : BaseReferenceHolder
		{
			[Token(Token = "0x40020E9")]
			[FieldOffset(Offset = "0x0")]
			public Func<IntPtr, T> conversionFunction;

			[Token(Token = "0x40020EA")]
			[FieldOffset(Offset = "0x0")]
			public Action<T> callback;

			[Token(Token = "0x6002FA7")]
			public _003C_003Ec__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6002FA8")]
			internal void _003CToIntPtr_003Eb__0(IntPtr result)
			{
			}
		}

		[Token(Token = "0x2000701")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820DA8", Offset = "0x820DA8")]
		private sealed class _003C_003Ec__DisplayClass3_0<T, P> where P : BaseReferenceHolder
		{
			[Token(Token = "0x40020EB")]
			[FieldOffset(Offset = "0x0")]
			public Func<IntPtr, P> conversionFunction;

			[Token(Token = "0x40020EC")]
			[FieldOffset(Offset = "0x0")]
			public Action<T, P> callback;

			[Token(Token = "0x6002FA9")]
			public _003C_003Ec__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6002FAA")]
			internal void _003CToIntPtr_003Eb__0(T param1, IntPtr param2)
			{
			}
		}

		[Token(Token = "0x2000702")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820DB8", Offset = "0x820DB8")]
		private sealed class _003C_003Ec__DisplayClass12_0<T>
		{
			[Token(Token = "0x40020ED")]
			[FieldOffset(Offset = "0x0")]
			public Action<T> toInvokeOnGameThread;

			[Token(Token = "0x6002FAB")]
			public _003C_003Ec__DisplayClass12_0()
			{
			}

			[Token(Token = "0x6002FAC")]
			internal void _003CAsOnGameThreadCallback_003Eb__0(T result)
			{
			}
		}

		[Token(Token = "0x2000703")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820DC8", Offset = "0x820DC8")]
		private sealed class _003C_003Ec__DisplayClass12_1<T>
		{
			[Token(Token = "0x40020EE")]
			[FieldOffset(Offset = "0x0")]
			public T result;

			[Token(Token = "0x40020EF")]
			[FieldOffset(Offset = "0x0")]
			public _003C_003Ec__DisplayClass12_0<T> CS_0024_003C_003E8__locals1;

			[Token(Token = "0x6002FAD")]
			public _003C_003Ec__DisplayClass12_1()
			{
			}

			[Token(Token = "0x6002FAE")]
			internal void _003CAsOnGameThreadCallback_003Eb__1()
			{
			}
		}

		[Token(Token = "0x2000704")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820DD8", Offset = "0x820DD8")]
		private sealed class _003C_003Ec__DisplayClass13_0<T1, T2>
		{
			[Token(Token = "0x40020F0")]
			[FieldOffset(Offset = "0x0")]
			public Action<T1, T2> toInvokeOnGameThread;

			[Token(Token = "0x6002FAF")]
			public _003C_003Ec__DisplayClass13_0()
			{
			}

			[Token(Token = "0x6002FB0")]
			internal void _003CAsOnGameThreadCallback_003Eb__0(T1 result1, T2 result2)
			{
			}
		}

		[Token(Token = "0x2000705")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820DE8", Offset = "0x820DE8")]
		private sealed class _003C_003Ec__DisplayClass13_1<T1, T2>
		{
			[Token(Token = "0x40020F1")]
			[FieldOffset(Offset = "0x0")]
			public T1 result1;

			[Token(Token = "0x40020F2")]
			[FieldOffset(Offset = "0x0")]
			public T2 result2;

			[Token(Token = "0x40020F3")]
			[FieldOffset(Offset = "0x0")]
			public _003C_003Ec__DisplayClass13_0<T1, T2> CS_0024_003C_003E8__locals1;

			[Token(Token = "0x6002FB1")]
			public _003C_003Ec__DisplayClass13_1()
			{
			}

			[Token(Token = "0x6002FB2")]
			internal void _003CAsOnGameThreadCallback_003Eb__1()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000706")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820DF8", Offset = "0x820DF8")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40020F4")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x6002FB4")]
			[Address(RVA = "0xC72D60", Offset = "0xC72D60", VA = "0xC72D60")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6002FB5")]
			[Address(RVA = "0xC72D68", Offset = "0xC72D68", VA = "0xC72D68")]
			internal void _003C_002Ecctor_003Eb__16_0(CommonErrorStatus.UIStatus status)
			{
			}
		}

		[Token(Token = "0x4000D1B")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly Action<CommonErrorStatus.UIStatus> NoopUICallback;

		[Token(Token = "0x6001217")]
		internal static IntPtr ToIntPtr<T>(Action<T> callback, Func<IntPtr, T> conversionFunction) where T : BaseReferenceHolder
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6001218")]
		internal static IntPtr ToIntPtr<T, P>(Action<T, P> callback, Func<IntPtr, P> conversionFunction) where P : BaseReferenceHolder
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6001219")]
		[Address(RVA = "0xC710DC", Offset = "0xC710DC", VA = "0xC710DC")]
		internal static IntPtr ToIntPtr(Delegate callback)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600121A")]
		internal static T IntPtrToTempCallback<T>(IntPtr handle) where T : class
		{
			return null;
		}

		[Token(Token = "0x600121B")]
		private static T IntPtrToCallback<T>(IntPtr handle, bool unpinHandle) where T : class
		{
			return null;
		}

		[Token(Token = "0x600121C")]
		internal static T IntPtrToPermanentCallback<T>(IntPtr handle) where T : class
		{
			return null;
		}

		[Token(Token = "0x600121D")]
		[Address(RVA = "0xC729A8", Offset = "0xC729A8", VA = "0xC729A8")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x835DC8", Offset = "0x835DC8")]
		internal static void InternalShowUICallback(CommonErrorStatus.UIStatus status, IntPtr data)
		{
		}

		[Token(Token = "0x600121E")]
		[Address(RVA = "0xC7127C", Offset = "0xC7127C", VA = "0xC7127C")]
		internal static void PerformInternalCallback(string callbackName, Type callbackType, IntPtr response, IntPtr userData)
		{
		}

		[Token(Token = "0x600121F")]
		internal static void PerformInternalCallback<T>(string callbackName, Type callbackType, T param1, IntPtr param2, IntPtr userData)
		{
		}

		[Token(Token = "0x6001220")]
		internal static Action<T> AsOnGameThreadCallback<T>(Action<T> toInvokeOnGameThread)
		{
			return null;
		}

		[Token(Token = "0x6001221")]
		internal static Action<T1, T2> AsOnGameThreadCallback<T1, T2>(Action<T1, T2> toInvokeOnGameThread)
		{
			return null;
		}

		[Token(Token = "0x6001222")]
		[Address(RVA = "0xC6B3BC", Offset = "0xC6B3BC", VA = "0xC6B3BC")]
		internal static void AsCoroutine(IEnumerator routine)
		{
		}

		[Token(Token = "0x6001223")]
		[Address(RVA = "0xC72B70", Offset = "0xC72B70", VA = "0xC72B70")]
		internal static byte[] IntPtrAndSizeToByteArray(IntPtr data, UIntPtr dataLength)
		{
			return null;
		}
	}
}
