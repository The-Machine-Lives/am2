using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000146")]
public class BIDynamicImage : Image
{
	[Token(Token = "0x4000817")]
	[FieldOffset(Offset = "0xE0")]
	public string resourcePath;

	[Token(Token = "0x4000818")]
	[FieldOffset(Offset = "0xE8")]
	public Sprite baseSprite;

	[Token(Token = "0x4000819")]
	[FieldOffset(Offset = "0xF0")]
	private bool loaded;

	[Token(Token = "0x400081A")]
	[FieldOffset(Offset = "0xF1")]
	public bool envelopeParent;

	[Token(Token = "0x600091D")]
	[Address(RVA = "0xA3F39C", Offset = "0xA3F39C", VA = "0xA3F39C", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600091E")]
	[Address(RVA = "0xA3F3A0", Offset = "0xA3F3A0", VA = "0xA3F3A0", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600091F")]
	[Address(RVA = "0xA3F3A8", Offset = "0xA3F3A8", VA = "0xA3F3A8")]
	public string GetResourceName()
	{
		return null;
	}

	[Token(Token = "0x6000920")]
	[Address(RVA = "0xA3F468", Offset = "0xA3F468", VA = "0xA3F468")]
	private void SizeSprite(bool autoResize)
	{
	}

	[Token(Token = "0x6000921")]
	[Address(RVA = "0xA3F62C", Offset = "0xA3F62C", VA = "0xA3F62C")]
	public void SetBaseSprite(string path, bool ignoreTheme = false, bool autoResize = false)
	{
	}

	[Token(Token = "0x6000922")]
	[Address(RVA = "0xA3F6A0", Offset = "0xA3F6A0", VA = "0xA3F6A0")]
	public BIDynamicImage()
	{
	}
}
