using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x200028B")]
	internal static class PInvokeUtilities
	{
		[Token(Token = "0x2000711")]
		internal delegate UIntPtr OutStringMethod([In][Out] byte[] out_bytes, UIntPtr out_size);

		[Token(Token = "0x2000712")]
		internal delegate UIntPtr OutMethod<T>([In][Out] T[] out_bytes, UIntPtr out_size);

		[Token(Token = "0x2000713")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820E48", Offset = "0x820E48")]
		private sealed class _003CToEnumerable_003Ed__9<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4002106")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int _003C_003E1__state;

			[Token(Token = "0x4002107")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private T _003C_003E2__current;

			[Token(Token = "0x4002108")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int _003C_003El__initialThreadId;

			[Token(Token = "0x4002109")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Func<UIntPtr, T> getElement;

			[Token(Token = "0x400210A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<UIntPtr, T> _003C_003E3__getElement;

			[Token(Token = "0x400210B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private UIntPtr size;

			[Token(Token = "0x400210C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public UIntPtr _003C_003E3__size;

			[Token(Token = "0x400210D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private ulong _003Ci_003E5__2;

			[Token(Token = "0x17000805")]
			private T System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002ECurrent
			{
				[Token(Token = "0x6002FEA")]
				[DebuggerHidden]
				get
				{
					return (T)null;
				}
			}

			[Token(Token = "0x17000806")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6002FEC")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6002FE7")]
			[DebuggerHidden]
			public _003CToEnumerable_003Ed__9(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6002FE8")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6002FE9")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6002FEB")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6002FED")]
			[DebuggerHidden]
			private IEnumerator<T> System_002ECollections_002EGeneric_002EIEnumerable_003CT_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6002FEE")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x4000D23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly DateTime UnixEpoch;

		[Token(Token = "0x6001382")]
		[Address(RVA = "0xE608F0", Offset = "0xE608F0", VA = "0xE608F0")]
		internal static HandleRef CheckNonNull(HandleRef reference)
		{
			return default(HandleRef);
		}

		[Token(Token = "0x6001383")]
		[Address(RVA = "0xE609AC", Offset = "0xE609AC", VA = "0xE609AC")]
		internal static bool IsNull(HandleRef reference)
		{
			return default(bool);
		}

		[Token(Token = "0x6001384")]
		[Address(RVA = "0xE5ECAC", Offset = "0xE5ECAC", VA = "0xE5ECAC")]
		internal static bool IsNull(IntPtr pointer)
		{
			return default(bool);
		}

		[Token(Token = "0x6001385")]
		[Address(RVA = "0xE5CC20", Offset = "0xE5CC20", VA = "0xE5CC20")]
		internal static DateTime FromMillisSinceUnixEpoch(long millisSinceEpoch)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6001386")]
		[Address(RVA = "0xE59F5C", Offset = "0xE59F5C", VA = "0xE59F5C")]
		internal static string OutParamsToString(OutStringMethod outStringMethod)
		{
			return null;
		}

		[Token(Token = "0x6001387")]
		internal static T[] OutParamsToArray<T>(OutMethod<T> outMethod)
		{
			return null;
		}

		[Token(Token = "0x6001388")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8367B4", Offset = "0x8367B4")]
		internal static IEnumerable<T> ToEnumerable<T>(UIntPtr size, Func<UIntPtr, T> getElement)
		{
			return null;
		}

		[Token(Token = "0x6001389")]
		internal static IEnumerator<T> ToEnumerator<T>(UIntPtr size, Func<UIntPtr, T> getElement)
		{
			return null;
		}

		[Token(Token = "0x600138A")]
		internal static UIntPtr ArrayToSizeT<T>(T[] array)
		{
			return default(UIntPtr);
		}

		[Token(Token = "0x600138B")]
		[Address(RVA = "0xE60EBC", Offset = "0xE60EBC", VA = "0xE60EBC")]
		internal static long ToMilliseconds(TimeSpan span)
		{
			return default(long);
		}
	}
}
