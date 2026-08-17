using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;

namespace Opencoding.CommandHandlerSystem
{
	[Token(Token = "0x2000007")]
	public class ParamInfo
	{
		[Token(Token = "0x2000008")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81851C", Offset = "0x81851C")]
		private sealed class _003C_003Ec__DisplayClass7_0
		{
			[Token(Token = "0x4000020")]
			[FieldOffset(Offset = "0x10")]
			public string parameterValue;

			[Token(Token = "0x4000021")]
			[FieldOffset(Offset = "0x18")]
			public List<string> options;

			[Token(Token = "0x6000028")]
			[Address(RVA = "0x17E4CA8", Offset = "0x17E4CA8", VA = "0x17E4CA8")]
			public _003C_003Ec__DisplayClass7_0()
			{
			}

			[Token(Token = "0x6000029")]
			[Address(RVA = "0x17E4EFC", Offset = "0x17E4EFC", VA = "0x17E4EFC")]
			internal bool _003CGetParameterPossibleValues_003Eb__0(string x)
			{
				return default(bool);
			}

			[Token(Token = "0x600002A")]
			[Address(RVA = "0x17E4F38", Offset = "0x17E4F38", VA = "0x17E4F38")]
			internal bool _003CGetParameterPossibleValues_003Eb__1(string x)
			{
				return default(bool);
			}

			[Token(Token = "0x600002B")]
			[Address(RVA = "0x17E4F80", Offset = "0x17E4F80", VA = "0x17E4F80")]
			internal bool _003CGetParameterPossibleValues_003Eb__2(string x)
			{
				return default(bool);
			}

			[Token(Token = "0x600002C")]
			[Address(RVA = "0x17E4FFC", Offset = "0x17E4FFC", VA = "0x17E4FFC")]
			internal bool _003CGetParameterPossibleValues_003Eb__3(string x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x18")]
		public bool IsOptional;

		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x20")]
		public Type Type;

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x28")]
		public object DefaultValue;

		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x30")]
		public MethodInfo AutoCompleteMethod;

		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x38")]
		public string[] AutoCompleteOptions;

		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x40")]
		public bool IsParamArray;

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x17E4930", Offset = "0x17E4930", VA = "0x17E4930")]
		public List<string> GetParameterPossibleValues(string parameterValue)
		{
			return null;
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x17E4EF4", Offset = "0x17E4EF4", VA = "0x17E4EF4")]
		public ParamInfo()
		{
		}
	}
}
