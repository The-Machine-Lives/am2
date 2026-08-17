using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x2000265")]
	internal abstract class BaseReferenceHolder : IDisposable
	{
		[Token(Token = "0x4000D19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<HandleRef, BaseReferenceHolder> _refs;

		[Token(Token = "0x4000D1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandleRef mSelfPointer;

		[Token(Token = "0x600120C")]
		[Address(RVA = "0xC726DC", Offset = "0xC726DC", VA = "0xC726DC")]
		protected bool IsDisposed()
		{
			return default(bool);
		}

		[Token(Token = "0x600120D")]
		[Address(RVA = "0xC71A40", Offset = "0xC71A40", VA = "0xC71A40")]
		protected HandleRef SelfPtr()
		{
			return default(HandleRef);
		}

		[Token(Token = "0x600120E")]
		[Address(RVA = "0xC71980", Offset = "0xC71980", VA = "0xC71980")]
		public BaseReferenceHolder(IntPtr pointer)
		{
		}

		[Token(Token = "0x600120F")]
		protected abstract void CallDispose(HandleRef selfPointer);

		[Token(Token = "0x6001210")]
		[Address(RVA = "0xC7274C", Offset = "0xC7274C", VA = "0xC7274C", Slot = "1")]
		~BaseReferenceHolder()
		{
		}

		[Token(Token = "0x6001211")]
		[Address(RVA = "0xC62734", Offset = "0xC62734", VA = "0xC62734", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6001212")]
		[Address(RVA = "0xC72908", Offset = "0xC72908", VA = "0xC72908")]
		internal IntPtr AsPointer()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6001213")]
		[Address(RVA = "0xC727C4", Offset = "0xC727C4", VA = "0xC727C4")]
		private void Dispose(bool fromFinalizer)
		{
		}

		[Token(Token = "0x6001214")]
		[Address(RVA = "0xC6B278", Offset = "0xC6B278", VA = "0xC6B278")]
		internal void ReferToMe()
		{
		}

		[Token(Token = "0x6001215")]
		[Address(RVA = "0xC6D348", Offset = "0xC6D348", VA = "0xC6D348")]
		internal void ForgetMe()
		{
		}
	}
}
