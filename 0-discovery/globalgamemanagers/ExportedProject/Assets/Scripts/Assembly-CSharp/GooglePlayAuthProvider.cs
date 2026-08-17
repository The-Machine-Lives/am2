using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x20001FF")]
public class GooglePlayAuthProvider : NativeAuthProvider
{
	[Token(Token = "0x2000666")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820618", Offset = "0x820618")]
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		[Token(Token = "0x4001F97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GooglePlayAuthProvider _003C_003E4__this;

		[Token(Token = "0x4001F98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action<bool, string> callback;

		[Token(Token = "0x6002DB5")]
		[Address(RVA = "0x9D7344", Offset = "0x9D7344", VA = "0x9D7344")]
		public _003C_003Ec__DisplayClass10_0()
		{
		}

		[Token(Token = "0x6002DB6")]
		[Address(RVA = "0x9D766C", Offset = "0x9D766C", VA = "0x9D766C")]
		internal void _003CLogin_003Eb__0(bool success)
		{
		}
	}

	[Token(Token = "0x2000667")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820628", Offset = "0x820628")]
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		[Token(Token = "0x4001F99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GooglePlayAuthProvider _003C_003E4__this;

		[Token(Token = "0x4001F9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action<bool, string> callback;

		[Token(Token = "0x6002DB7")]
		[Address(RVA = "0x9D74D8", Offset = "0x9D74D8", VA = "0x9D74D8")]
		public _003C_003Ec__DisplayClass11_0()
		{
		}

		[Token(Token = "0x6002DB8")]
		[Address(RVA = "0x9D77A4", Offset = "0x9D77A4", VA = "0x9D77A4")]
		internal void _003CFetchAuth_003Eb__0(string newAuthCode)
		{
		}

		[Token(Token = "0x6002DB9")]
		[Address(RVA = "0x9D7864", Offset = "0x9D7864", VA = "0x9D7864")]
		internal void _003CFetchAuth_003Eb__1(bool pollsuccessful)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000668")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820638", Offset = "0x820638")]
	private struct _003CPollForGPGSAuth_003Ed__13 : IAsyncStateMachine
	{
		[Token(Token = "0x4001F9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4001F9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4001F9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float elapsedTimeInSeconds;

		[Token(Token = "0x4001F9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float timeoutDurationInSeconds;

		[Token(Token = "0x4001F9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<bool> callback;

		[Token(Token = "0x4001FA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GooglePlayAuthProvider _003C_003E4__this;

		[Token(Token = "0x4001FA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float _003CpollInterval_003E5__2;

		[Token(Token = "0x4001FA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x6002DBA")]
		[Address(RVA = "0x89BA44", Offset = "0x89BA44", VA = "0x89BA44", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6002DBB")]
		[Address(RVA = "0x89BA4C", Offset = "0x89BA4C", VA = "0x89BA4C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x4000B64")]
	private const float c_gpgsAuthTimeout = 8f;

	[Token(Token = "0x4000B65")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool m_initialized;

	[Token(Token = "0x4000B66")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
	private static bool m_authHasBeenFetchedBefore;

	[Token(Token = "0x4000B67")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82600C", Offset = "0x82600C")]
	private string _003CauthCode_003Ek__BackingField;

	[Token(Token = "0x170001A6")]
	public string authCode
	{
		[Token(Token = "0x6000D82")]
		[Address(RVA = "0x9D6DC0", Offset = "0x9D6DC0", VA = "0x9D6DC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x835110", Offset = "0x835110")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000D83")]
		[Address(RVA = "0x9D6DC8", Offset = "0x9D6DC8", VA = "0x9D6DC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x835120", Offset = "0x835120")]
		private set
		{
		}
	}

	[Token(Token = "0x170001A7")]
	public override bool isLoggedIn
	{
		[Token(Token = "0x6000D84")]
		[Address(RVA = "0x9D6DD0", Offset = "0x9D6DD0", VA = "0x9D6DD0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000D85")]
	[Address(RVA = "0x9D7004", Offset = "0x9D7004", VA = "0x9D7004")]
	public GooglePlayAuthProvider()
	{
	}

	[Token(Token = "0x6000D86")]
	[Address(RVA = "0x9D719C", Offset = "0x9D719C", VA = "0x9D719C", Slot = "4")]
	public override void Login(Action<bool, string> callback)
	{
	}

	[Token(Token = "0x6000D87")]
	[Address(RVA = "0x9D734C", Offset = "0x9D734C", VA = "0x9D734C")]
	public void FetchAuth(Action<bool, string> callback)
	{
	}

	[Token(Token = "0x6000D88")]
	[Address(RVA = "0x9D75BC", Offset = "0x9D75BC", VA = "0x9D75BC", Slot = "5")]
	public override void Logout()
	{
	}

	[Token(Token = "0x6000D89")]
	[Address(RVA = "0x9D74E0", Offset = "0x9D74E0", VA = "0x9D74E0")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x835130", Offset = "0x835130")]
	private void PollForGPGSAuth(Action<bool> callback, float timeoutDurationInSeconds, float elapsedTimeInSeconds = 0f)
	{
	}
}
