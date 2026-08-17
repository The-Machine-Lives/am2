using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Facebook.Unity
{
	[Token(Token = "0x2000029")]
	internal class GraphResult : ResultBase, IGraphResult, IResult
	{
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8163D0", Offset = "0x8163D0")]
		private IList<object> _003CResultList_003Ek__BackingField;

		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8163E0", Offset = "0x8163E0")]
		private Texture2D _003CTexture_003Ek__BackingField;

		[Token(Token = "0x17000048")]
		private IList<object> ResultList
		{
			[Token(Token = "0x6000126")]
			[Address(RVA = "0xCE08FC", Offset = "0xCE08FC", VA = "0xCE08FC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816B50", Offset = "0x816B50")]
			set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public Texture2D Texture
		{
			[Token(Token = "0x6000127")]
			[Address(RVA = "0xCE0904", Offset = "0xCE0904", VA = "0xCE0904", Slot = "19")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816B60", Offset = "0x816B60")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000128")]
			[Address(RVA = "0xCE08F4", Offset = "0xCE08F4", VA = "0xCE08F4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816B70", Offset = "0x816B70")]
			private set
			{
			}
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xCC97D4", Offset = "0xCC97D4", VA = "0xCC97D4")]
		internal GraphResult(WWW result)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xCE07F4", Offset = "0xCE07F4", VA = "0xCE07F4")]
		private void Init(string rawResult)
		{
		}
	}
}
