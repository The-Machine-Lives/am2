using Il2CppDummyDll;
using Uken.Library.Web;
using UnityEngine;
using UnityEngine.UI;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000561")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x8201C0", Offset = "0x8201C0")]
	public class BaseProductView : MonoBehaviour
	{
		[Token(Token = "0x2000855")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x821518", Offset = "0x821518")]
		private sealed class _003C_003Ec__DisplayClass4_0
		{
			[Token(Token = "0x40023EF")]
			[FieldOffset(Offset = "0x10")]
			public Image image;

			[Token(Token = "0x6003381")]
			[Address(RVA = "0xA260AC", Offset = "0xA260AC", VA = "0xA260AC")]
			public _003C_003Ec__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6003382")]
			[Address(RVA = "0xA260BC", Offset = "0xA260BC", VA = "0xA260BC")]
			internal void _003CSetImageFromCache_003Eb__0(bool success, Sprite sprite)
			{
			}
		}

		[Token(Token = "0x4001994")]
		[FieldOffset(Offset = "0x18")]
		public Image itemImage;

		[Token(Token = "0x4001995")]
		[FieldOffset(Offset = "0x20")]
		protected Product m_product;

		[Token(Token = "0x4001996")]
		[FieldOffset(Offset = "0x28")]
		protected UkenImageCacher m_imageCacher;

		[Token(Token = "0x6002928")]
		[Address(RVA = "0xA25E68", Offset = "0xA25E68", VA = "0xA25E68", Slot = "4")]
		public virtual void Initialize(Product product, UkenImageCacher imageCacher)
		{
		}

		[Token(Token = "0x6002929")]
		[Address(RVA = "0xA25F9C", Offset = "0xA25F9C", VA = "0xA25F9C")]
		protected void SetImageFromCache(string url, Image image)
		{
		}

		[Token(Token = "0x600292A")]
		[Address(RVA = "0xA260B4", Offset = "0xA260B4", VA = "0xA260B4")]
		public BaseProductView()
		{
		}
	}
}
