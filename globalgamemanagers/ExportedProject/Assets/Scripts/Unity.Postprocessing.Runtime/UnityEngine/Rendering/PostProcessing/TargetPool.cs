using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Token(Token = "0x2000064")]
	internal class TargetPool
	{
		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<int> m_Pool;

		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0x18")]
		private int m_Current;

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x1233F04", Offset = "0x1233F04", VA = "0x1233F04")]
		internal TargetPool()
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x1233F90", Offset = "0x1233F90", VA = "0x1233F90")]
		internal int Get()
		{
			return default(int);
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x1233FC0", Offset = "0x1233FC0", VA = "0x1233FC0")]
		private int Get(int i)
		{
			return default(int);
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x1234110", Offset = "0x1234110", VA = "0x1234110")]
		internal void Reset()
		{
		}
	}
}
