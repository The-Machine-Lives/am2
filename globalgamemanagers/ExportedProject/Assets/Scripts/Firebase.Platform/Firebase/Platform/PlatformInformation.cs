using System;
using Il2CppDummyDll;

namespace Firebase.Platform
{
	[Token(Token = "0x2000008")]
	internal static class PlatformInformation
	{
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x0")]
		private static string runtimeVersion;

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x80793C", Offset = "0x80793C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80793C", Offset = "0x80793C")]
		private static float _003CRealtimeSinceStartupSafe_003Ek__BackingField;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x807978", Offset = "0x807978")]
		private static Func<string> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x807988", Offset = "0x807988")]
		private static Func<string> _003C_003Ef__am_0024cache1;

		[Token(Token = "0x1700000B")]
		internal static bool IsAndroid
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x17D1FD4", Offset = "0x17D1FD4", VA = "0x17D1FD4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000C")]
		internal static bool IsIOS
		{
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x17D1FF4", Offset = "0x17D1FF4", VA = "0x17D1FF4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000D")]
		internal static string DefaultConfigLocation
		{
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x17D2014", Offset = "0x17D2014", VA = "0x17D2014")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000E")]
		internal static float RealtimeSinceStartup
		{
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x17D1ED8", Offset = "0x17D1ED8", VA = "0x17D1ED8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700000F")]
		internal static float RealtimeSinceStartupSafe
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x17D1EE0", Offset = "0x17D1EE0", VA = "0x17D1EE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x807BD0", Offset = "0x807BD0")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		internal static string RuntimeName
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x17D20E0", Offset = "0x17D20E0", VA = "0x17D20E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		internal static string RuntimeVersion
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x17D2128", Offset = "0x17D2128", VA = "0x17D2128")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x17D2218", Offset = "0x17D2218", VA = "0x17D2218")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x807BE0", Offset = "0x807BE0")]
		private static string _003Cget_DefaultConfigLocation_003Em__0()
		{
			return null;
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x17D2220", Offset = "0x17D2220", VA = "0x17D2220")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x807BF0", Offset = "0x807BF0")]
		private static string _003Cget_RuntimeVersion_003Em__1()
		{
			return null;
		}
	}
}
