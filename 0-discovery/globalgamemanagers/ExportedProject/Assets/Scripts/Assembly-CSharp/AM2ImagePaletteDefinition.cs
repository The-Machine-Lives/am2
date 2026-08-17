using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
[Token(Token = "0x2000157")]
public class AM2ImagePaletteDefinition
{
	[Token(Token = "0x400086E")]
	[FieldOffset(Offset = "0x10")]
	public AM2PaletteDatabase.AM2ImagePalettes name;

	[Token(Token = "0x400086F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public Sprite sprite;

	[Token(Token = "0x4000870")]
	[FieldOffset(Offset = "0x20")]
	public Image.Type displayType;

	[Token(Token = "0x4000871")]
	[FieldOffset(Offset = "0x24")]
	public bool fillCenter;

	[Token(Token = "0x4000872")]
	[FieldOffset(Offset = "0x25")]
	public bool preserveAspect;

	[Token(Token = "0x4000873")]
	[FieldOffset(Offset = "0x26")]
	public bool enabled;

	[Token(Token = "0x6000974")]
	[Address(RVA = "0x981BC0", Offset = "0x981BC0", VA = "0x981BC0")]
	public AM2ImagePaletteDefinition()
	{
	}
}
