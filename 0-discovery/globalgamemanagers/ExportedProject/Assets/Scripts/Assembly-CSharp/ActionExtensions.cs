using System;
using Il2CppDummyDll;

[Token(Token = "0x2000210")]
public static class ActionExtensions
{
	[Serializable]
	[Token(Token = "0x200066C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820668", Offset = "0x820668")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001FB0")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001FB1")]
		[FieldOffset(Offset = "0x8")]
		public static Action _003C_003E9__6_0;

		[Token(Token = "0x6002DC1")]
		[Address(RVA = "0xACE300", Offset = "0xACE300", VA = "0xACE300")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002DC2")]
		[Address(RVA = "0xACE308", Offset = "0xACE308", VA = "0xACE308")]
		internal void _003CEmpty_003Eb__6_0()
		{
		}
	}

	[Token(Token = "0x6000DFA")]
	[Address(RVA = "0xACE1A8", Offset = "0xACE1A8", VA = "0xACE1A8")]
	public static bool SafeInvoke(this Action action)
	{
		return default(bool);
	}

	[Token(Token = "0x6000DFB")]
	public static bool SafeInvoke<T>(this Action<T> action, T parameter)
	{
		return default(bool);
	}

	[Token(Token = "0x6000DFC")]
	public static bool SafeInvoke<T1, T2>(this Action<T1, T2> action, T1 parameter1, T2 parameter2)
	{
		return default(bool);
	}

	[Token(Token = "0x6000DFD")]
	public static bool SafeInvoke<T1, T2, T3>(this Action<T1, T2, T3> action, T1 parameter1, T2 parameter2, T3 parameter3)
	{
		return default(bool);
	}

	[Token(Token = "0x6000DFE")]
	[Address(RVA = "0xACE1C8", Offset = "0xACE1C8", VA = "0xACE1C8")]
	public static void UnsubscribeAll(this Action action)
	{
	}

	[Token(Token = "0x6000DFF")]
	public static void UnsubscribeAll<T>(this Action<T> action)
	{
	}

	[Token(Token = "0x6000E00")]
	[Address(RVA = "0xACE1CC", Offset = "0xACE1CC", VA = "0xACE1CC")]
	public static Action Empty()
	{
		return null;
	}
}
