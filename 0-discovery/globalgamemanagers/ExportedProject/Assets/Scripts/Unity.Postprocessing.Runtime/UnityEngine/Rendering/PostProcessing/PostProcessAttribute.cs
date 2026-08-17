using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Token(Token = "0x2000006")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x818CE4", Offset = "0x818CE4")]
	public sealed class PostProcessAttribute : Attribute
	{
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x10")]
		public readonly Type renderer;

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x18")]
		public readonly PostProcessEvent eventType;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x20")]
		public readonly string menuItem;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x28")]
		public readonly bool allowInSceneView;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x29")]
		internal readonly bool builtinEffect;

		[Token(Token = "0x6000005")]
		[Address(RVA = "0xD88A60", Offset = "0xD88A60", VA = "0xD88A60")]
		public PostProcessAttribute(Type renderer, PostProcessEvent eventType, string menuItem, bool allowInSceneView = true)
		{
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0xD88ABC", Offset = "0xD88ABC", VA = "0xD88ABC")]
		internal PostProcessAttribute(Type renderer, string menuItem, bool allowInSceneView = true)
		{
		}
	}
}
