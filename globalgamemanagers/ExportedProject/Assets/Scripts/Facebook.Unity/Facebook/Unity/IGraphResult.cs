using Il2CppDummyDll;
using UnityEngine;

namespace Facebook.Unity
{
	[Token(Token = "0x2000031")]
	public interface IGraphResult : IResult
	{
		[Token(Token = "0x1700004B")]
		Texture2D Texture
		{
			[Token(Token = "0x600012C")]
			get;
		}
	}
}
