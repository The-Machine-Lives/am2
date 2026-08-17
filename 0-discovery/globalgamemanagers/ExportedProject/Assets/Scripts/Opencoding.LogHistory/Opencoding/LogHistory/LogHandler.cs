using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Opencoding.LogHistory
{
	[Token(Token = "0x2000002")]
	public static class LogHandler
	{
		[Serializable]
		[Token(Token = "0x2000003")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x811D10", Offset = "0x811D10")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4000002")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x6000005")]
			[Address(RVA = "0x180A430", Offset = "0x180A430", VA = "0x180A430")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6000006")]
			[Address(RVA = "0x180A438", Offset = "0x180A438", VA = "0x180A438")]
			internal void _003C_002Ecctor_003Eb__3_0(string _003Cp0_003E, string _003Cp1_003E, LogType _003Cp2_003E)
			{
			}
		}

		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x0")]
		private static Application.LogCallback callbacks;

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x180A270", Offset = "0x180A270", VA = "0x180A270")]
		public static void RegisterLogCallback(Application.LogCallback callback)
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x180A31C", Offset = "0x180A31C", VA = "0x180A31C")]
		public static void UnRegisterLogCallback(Application.LogCallback callback)
		{
		}
	}
}
