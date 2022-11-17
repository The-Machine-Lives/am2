using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Firebase.Crashlytics
{
	[Token(Token = "0x200000A")]
	internal class FirebaseCrashlyticsInternal : IDisposable
	{
		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandleRef swigCPtr;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool swigCMemOwn;

		[Token(Token = "0x17000002")]
		internal bool IsDisposed
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x17A1544", Offset = "0x17A1544", VA = "0x17A1544")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x17A88B8", Offset = "0x17A88B8", VA = "0x17A88B8")]
		internal FirebaseCrashlyticsInternal(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x17A891C", Offset = "0x17A891C", VA = "0x17A891C")]
		internal static HandleRef getCPtr(FirebaseCrashlyticsInternal obj)
		{
			return default(HandleRef);
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x17A898C", Offset = "0x17A898C", VA = "0x17A898C", Slot = "1")]
		~FirebaseCrashlyticsInternal()
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x17A8A08", Offset = "0x17A8A08", VA = "0x17A8A08", Slot = "5")]
		public virtual void Dispose()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x17A1078", Offset = "0x17A1078", VA = "0x17A1078")]
		internal static FirebaseCrashlyticsInternal GetInstance(FirebaseApp app, out InitResult init_result_out)
		{
			return null;
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x17A8B20", Offset = "0x17A8B20", VA = "0x17A8B20")]
		internal static FirebaseCrashlyticsInternal GetInstance(FirebaseApp app)
		{
			return null;
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x17A2684", Offset = "0x17A2684", VA = "0x17A2684")]
		public void Log(string message)
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x17A2A90", Offset = "0x17A2A90", VA = "0x17A2A90")]
		public void SetCustomKey(string key, string value)
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x17A2BC4", Offset = "0x17A2BC4", VA = "0x17A2BC4")]
		public void SetUserId(string id)
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x17A27F8", Offset = "0x17A27F8", VA = "0x17A27F8")]
		public void LogException(string name, string reason, StackFrames frames)
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x17A255C", Offset = "0x17A255C", VA = "0x17A255C")]
		public bool IsCrashlyticsCollectionEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x17A2954", Offset = "0x17A2954", VA = "0x17A2954")]
		public void SetCrashlyticsCollectionEnabled(bool enabled)
		{
		}
	}
}
