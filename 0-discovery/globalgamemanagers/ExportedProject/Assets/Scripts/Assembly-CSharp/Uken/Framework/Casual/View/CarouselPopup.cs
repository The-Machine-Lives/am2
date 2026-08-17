using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Uken.Framework.Casual.View
{
	[Token(Token = "0x200057F")]
	public class CarouselPopup : PopupView
	{
		[Token(Token = "0x4001A2E")]
		[FieldOffset(Offset = "0x0")]
		public static string CarouselPopupPrefab;

		[Token(Token = "0x4001A2F")]
		[FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x832AD8", Offset = "0x832AD8")]
		public Image m_carouselImage;

		[Token(Token = "0x4001A30")]
		[FieldOffset(Offset = "0x98")]
		public GameObject m_nextButton;

		[Token(Token = "0x4001A31")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject m_prevButton;

		[Token(Token = "0x4001A32")]
		[FieldOffset(Offset = "0xA8")]
		public Transform m_dotContainer;

		[Token(Token = "0x4001A33")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject m_activeDot;

		[Token(Token = "0x4001A34")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject m_inactiveDotTemplate;

		[Token(Token = "0x4001A35")]
		[FieldOffset(Offset = "0xC0")]
		private List<Sprite> m_items;

		[Token(Token = "0x4001A36")]
		[FieldOffset(Offset = "0xC8")]
		private List<GameObject> m_dots;

		[Token(Token = "0x4001A37")]
		[FieldOffset(Offset = "0xD0")]
		private int m_currentIndex;

		[Token(Token = "0x6002A28")]
		[Address(RVA = "0xAA1544", Offset = "0xAA1544", VA = "0xAA1544")]
		public static CarouselPopup Create(CasualViewController controller, Transform parentContainer, string imagePath)
		{
			return null;
		}

		[Token(Token = "0x6002A29")]
		[Address(RVA = "0xAA1750", Offset = "0xAA1750", VA = "0xAA1750")]
		public static CarouselPopup Create(CasualViewController controller, Transform parentContainer, List<string> imagePaths)
		{
			return null;
		}

		[Token(Token = "0x6002A2A")]
		[Address(RVA = "0xAA16A4", Offset = "0xAA16A4", VA = "0xAA16A4")]
		public void Setup(List<string> items)
		{
		}

		[Token(Token = "0x6002A2B")]
		[Address(RVA = "0xAA1868", Offset = "0xAA1868", VA = "0xAA1868")]
		private void LoadImages(List<string> images, Action onComplete)
		{
		}

		[Token(Token = "0x6002A2C")]
		[Address(RVA = "0xAA19D4", Offset = "0xAA19D4", VA = "0xAA19D4")]
		private void OnAllImagesLoaded()
		{
		}

		[Token(Token = "0x6002A2D")]
		[Address(RVA = "0xAA1CE4", Offset = "0xAA1CE4", VA = "0xAA1CE4")]
		private void SetCarousel(int index)
		{
		}

		[Token(Token = "0x6002A2E")]
		[Address(RVA = "0xAA1F40", Offset = "0xAA1F40", VA = "0xAA1F40")]
		private void SetItem(Sprite item, int index)
		{
		}

		[Token(Token = "0x6002A2F")]
		[Address(RVA = "0xAA1FF0", Offset = "0xAA1FF0", VA = "0xAA1FF0")]
		public void GoToNext()
		{
		}

		[Token(Token = "0x6002A30")]
		[Address(RVA = "0xAA2078", Offset = "0xAA2078", VA = "0xAA2078")]
		public void GoToPrev()
		{
		}

		[Token(Token = "0x6002A31")]
		[Address(RVA = "0xAA20F0", Offset = "0xAA20F0", VA = "0xAA20F0")]
		public CarouselPopup()
		{
		}

		[Token(Token = "0x6002A33")]
		[Address(RVA = "0xAA2154", Offset = "0xAA2154", VA = "0xAA2154")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83A63C", Offset = "0x83A63C")]
		private void _003CSetup_003Eb__12_0()
		{
		}
	}
}
