using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Firebase.Crashlytics
{
	[Token(Token = "0x200000B")]
	public class FirebaseCrashlyticsFrame : IDisposable
	{
		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandleRef swigCPtr;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool swigCMemOwn;

		[Token(Token = "0x17000003")]
		public string library
		{
			[Token(Token = "0x6000067")]
			[Address(RVA = "0x17A8538", Offset = "0x17A8538", VA = "0x17A8538")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000066")]
			[Address(RVA = "0x17A1F30", Offset = "0x17A1F30", VA = "0x17A1F30")]
			set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public string symbol
		{
			[Token(Token = "0x6000069")]
			[Address(RVA = "0x17A8618", Offset = "0x17A8618", VA = "0x17A8618")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000068")]
			[Address(RVA = "0x17A2014", Offset = "0x17A2014", VA = "0x17A2014")]
			set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public string fileName
		{
			[Token(Token = "0x600006B")]
			[Address(RVA = "0x17A86F8", Offset = "0x17A86F8", VA = "0x17A86F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600006A")]
			[Address(RVA = "0x17A20F8", Offset = "0x17A20F8", VA = "0x17A20F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public string lineNumber
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x17A87D8", Offset = "0x17A87D8", VA = "0x17A87D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600006C")]
			[Address(RVA = "0x17A21DC", Offset = "0x17A21DC", VA = "0x17A21DC")]
			set
			{
			}
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x17A8264", Offset = "0x17A8264", VA = "0x17A8264")]
		internal FirebaseCrashlyticsFrame(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x17A1E58", Offset = "0x17A1E58", VA = "0x17A1E58")]
		public FirebaseCrashlyticsFrame()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x17A82C8", Offset = "0x17A82C8", VA = "0x17A82C8")]
		internal static HandleRef getCPtr(FirebaseCrashlyticsFrame obj)
		{
			return default(HandleRef);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x17A8338", Offset = "0x17A8338", VA = "0x17A8338", Slot = "1")]
		~FirebaseCrashlyticsFrame()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x17A83B4", Offset = "0x17A83B4", VA = "0x17A83B4", Slot = "5")]
		public virtual void Dispose()
		{
		}
	}
}
