using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Token(Token = "0x200005E")]
	internal static class MeshUtilities
	{
		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<PrimitiveType, Mesh> s_Primitives;

		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<Type, PrimitiveType> s_ColliderPrimitives;

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xD83718", Offset = "0xD83718", VA = "0xD83718")]
		static MeshUtilities()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xD83898", Offset = "0xD83898", VA = "0xD83898")]
		internal static Mesh GetColliderMesh(Collider collider)
		{
			return null;
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xD83AB8", Offset = "0xD83AB8", VA = "0xD83AB8")]
		internal static Mesh GetPrimitive(PrimitiveType primitiveType)
		{
			return null;
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xD83BBC", Offset = "0xD83BBC", VA = "0xD83BBC")]
		private static Mesh GetBuiltinMesh(PrimitiveType primitiveType)
		{
			return null;
		}
	}
}
