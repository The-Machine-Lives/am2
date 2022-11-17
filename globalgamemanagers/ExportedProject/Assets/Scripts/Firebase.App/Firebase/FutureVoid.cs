using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Firebase
{
	[Token(Token = "0x2000012")]
	internal class FutureVoid : FutureBase
	{
		[Token(Token = "0x2000013")]
		public delegate void Action();

		[Token(Token = "0x2000014")]
		internal delegate void SWIG_CompletionDelegate(int index);

		[Token(Token = "0x2000015")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80D0E0", Offset = "0x80D0E0")]
		private sealed class _003CGetTask_003Ec__AnonStorey0
		{
			[Token(Token = "0x4000045")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal FutureVoid fu;

			[Token(Token = "0x4000046")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal TaskCompletionSource<int> tcs;

			[Token(Token = "0x6000093")]
			[Address(RVA = "0x179F420", Offset = "0x179F420", VA = "0x179F420")]
			public _003CGetTask_003Ec__AnonStorey0()
			{
			}

			[Token(Token = "0x6000094")]
			[Address(RVA = "0x179FD48", Offset = "0x179FD48", VA = "0x179FD48")]
			internal void _003C_003Em__0()
			{
			}
		}

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private HandleRef swigCPtr;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<int, Action> Callbacks;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int CallbackIndex;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static object CallbackLock;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private IntPtr callbackData;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private SWIG_CompletionDelegate SWIG_CompletionCB;

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x1796DD8", Offset = "0x1796DD8", VA = "0x1796DD8")]
		internal FutureVoid(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x179F1D4", Offset = "0x179F1D4", VA = "0x179F1D4", Slot = "1")]
		~FutureVoid()
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x179F248", Offset = "0x179F248", VA = "0x179F248", Slot = "5")]
		public override void Dispose()
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x1796E8C", Offset = "0x1796E8C", VA = "0x1796E8C")]
		public static Task GetTask(FutureVoid fu)
		{
			return null;
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x179F654", Offset = "0x179F654", VA = "0x179F654")]
		private void ThrowIfDisposed()
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x179F438", Offset = "0x179F438", VA = "0x179F438")]
		public void SetOnCompletionCallback(Action userCompletionCallback)
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x179F3EC", Offset = "0x179F3EC", VA = "0x179F3EC")]
		private void SetCompletionData(IntPtr data)
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x179F034", Offset = "0x179F034", VA = "0x179F034")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x80D92C", Offset = "0x80D92C")]
		private static void SWIG_CompletionDispatcher(int key)
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x179F704", Offset = "0x179F704", VA = "0x179F704")]
		internal IntPtr SWIG_OnCompletion(SWIG_CompletionDelegate cs_callback, int cs_key)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x179F7F4", Offset = "0x179F7F4", VA = "0x179F7F4")]
		public void SWIG_FreeCompletionData(IntPtr data)
		{
		}
	}
}
