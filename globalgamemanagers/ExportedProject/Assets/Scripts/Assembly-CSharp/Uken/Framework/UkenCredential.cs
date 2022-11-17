using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Framework
{
	[Serializable]
	[Token(Token = "0x200049C")]
	public class UkenCredential
	{
		[Token(Token = "0x400152C")]
		private const string ms_defaultFilePath = "/data/data/com.uken.x.am2/files";

		[Token(Token = "0x400152D")]
		[FieldOffset(Offset = "0x10")]
		public string Provider;

		[Token(Token = "0x400152E")]
		[FieldOffset(Offset = "0x18")]
		public string Identifier;

		[Token(Token = "0x400152F")]
		[FieldOffset(Offset = "0x20")]
		public string Token;

		[Token(Token = "0x4001530")]
		[FieldOffset(Offset = "0x28")]
		public string UserId;

		[Token(Token = "0x4001531")]
		[FieldOffset(Offset = "0x0")]
		private static string androidPath;

		[Token(Token = "0x60021E9")]
		[Address(RVA = "0xAEA818", Offset = "0xAEA818", VA = "0xAEA818")]
		public static UkenCredential Load()
		{
			return null;
		}

		[Token(Token = "0x60021EA")]
		[Address(RVA = "0xAEA898", Offset = "0xAEA898", VA = "0xAEA898")]
		public static UkenCredential LoadFromJson()
		{
			return null;
		}

		[Token(Token = "0x60021EB")]
		[Address(RVA = "0xAEA9E0", Offset = "0xAEA9E0", VA = "0xAEA9E0")]
		private static UkenCredential ParseJSON(Dictionary<string, object> node)
		{
			return null;
		}

		[Token(Token = "0x60021EC")]
		[Address(RVA = "0xAEABE8", Offset = "0xAEABE8", VA = "0xAEABE8")]
		public static UkenCredential LoadFromPlayerPrefs()
		{
			return null;
		}

		[Token(Token = "0x60021ED")]
		[Address(RVA = "0xAEAD14", Offset = "0xAEAD14", VA = "0xAEAD14")]
		public void Save()
		{
		}

		[Token(Token = "0x60021EE")]
		[Address(RVA = "0xAEAEC8", Offset = "0xAEAEC8", VA = "0xAEAEC8")]
		public void SaveToPlayerPrefs()
		{
		}

		[Token(Token = "0x60021EF")]
		[Address(RVA = "0xAEA970", Offset = "0xAEA970", VA = "0xAEA970")]
		public static string FilePath()
		{
			return null;
		}

		[Token(Token = "0x60021F0")]
		[Address(RVA = "0xAEAFC0", Offset = "0xAEAFC0", VA = "0xAEAFC0")]
		private static string PersistentPath()
		{
			return null;
		}

		[Token(Token = "0x60021F1")]
		[Address(RVA = "0xAEAF64", Offset = "0xAEAF64", VA = "0xAEAF64")]
		public static string PrivatePersistentPath()
		{
			return null;
		}

		[Token(Token = "0x60021F2")]
		[Address(RVA = "0xAEAFC8", Offset = "0xAEAFC8", VA = "0xAEAFC8")]
		private static string AndroidPersistentPath()
		{
			return null;
		}

		[Token(Token = "0x60021F3")]
		[Address(RVA = "0xAEA968", Offset = "0xAEA968", VA = "0xAEA968")]
		public UkenCredential()
		{
		}
	}
}
