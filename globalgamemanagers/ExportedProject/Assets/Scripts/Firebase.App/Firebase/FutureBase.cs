using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Firebase
{
	[Token(Token = "0x2000016")]
	internal class FutureBase : IDisposable
	{
		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandleRef swigCPtr;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool swigCMemOwn;

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x179EB48", Offset = "0x179EB48", VA = "0x179EB48")]
		internal FutureBase(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x179EBAC", Offset = "0x179EBAC", VA = "0x179EBAC", Slot = "1")]
		~FutureBase()
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x179EC28", Offset = "0x179EC28", VA = "0x179EC28", Slot = "5")]
		public virtual void Dispose()
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x179EDAC", Offset = "0x179EDAC", VA = "0x179EDAC")]
		public FutureStatus status()
		{
			return default(FutureStatus);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x179EE84", Offset = "0x179EE84", VA = "0x179EE84")]
		public int error()
		{
			return default(int);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x179EF5C", Offset = "0x179EF5C", VA = "0x179EF5C")]
		public string error_message()
		{
			return null;
		}
	}
}
