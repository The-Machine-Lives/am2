using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Firebase.Analytics
{
	[Token(Token = "0x200000A")]
	public sealed class Parameter : IDisposable
	{
		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandleRef swigCPtr;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool swigCMemOwn;

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x17FF420", Offset = "0x17FF420", VA = "0x17FF420")]
		internal Parameter(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x17FF484", Offset = "0x17FF484", VA = "0x17FF484")]
		public Parameter(string parameterName, string parameterValue)
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x17FF574", Offset = "0x17FF574", VA = "0x17FF574")]
		public Parameter(string parameterName, long parameterValue)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x17FC5E0", Offset = "0x17FC5E0", VA = "0x17FC5E0")]
		internal static HandleRef getCPtr(Parameter obj)
		{
			return default(HandleRef);
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x17FF664", Offset = "0x17FF664", VA = "0x17FF664", Slot = "1")]
		~Parameter()
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x17FF6D8", Offset = "0x17FF6D8", VA = "0x17FF6D8", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
