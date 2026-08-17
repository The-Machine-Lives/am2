using Assets.AltUnityTester.AltUnityDriver.UnityStruct;
using Il2CppDummyDll;

[Token(Token = "0x2000016")]
public class AltUnityGetScreenshot : AltUnityCommandReturningAltElement
{
	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0x38")]
	private int id;

	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0x3C")]
	private AltUnityColor color;

	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x4C")]
	private float width;

	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x50")]
	private AltUnityVector2 size;

	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x58")]
	private AltUnityVector2 coordinates;

	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x60")]
	private int option;

	[Token(Token = "0x600007D")]
	[Address(RVA = "0xADEB24", Offset = "0xADEB24", VA = "0xADEB24")]
	public AltUnityGetScreenshot(SocketSettings socketSettings, AltUnityVector2 size)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0xADECBC", Offset = "0xADECBC", VA = "0xADECBC")]
	public AltUnityGetScreenshot(SocketSettings socketSettings, int id, AltUnityColor color, float width, AltUnityVector2 size)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0xADEE50", Offset = "0xADEE50", VA = "0xADEE50")]
	public AltUnityGetScreenshot(SocketSettings socketSettings, AltUnityVector2 coordinates, AltUnityColor color, float width, AltUnityVector2 size)
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0xADEEF0", Offset = "0xADEEF0", VA = "0xADEEF0")]
	public AltUnityTextureInformation Execute(out AltUnityObject selectedObject)
	{
		return default(AltUnityTextureInformation);
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0xADEB7C", Offset = "0xADEB7C", VA = "0xADEB7C")]
	public AltUnityTextureInformation Execute()
	{
		return default(AltUnityTextureInformation);
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0xAE106C", Offset = "0xAE106C", VA = "0xAE106C")]
	private AltUnityTextureInformation GetSimpleScreenshot()
	{
		return default(AltUnityTextureInformation);
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0xAE0440", Offset = "0xAE0440", VA = "0xAE0440")]
	private AltUnityTextureInformation GetHighlightObjectScreenshot()
	{
		return default(AltUnityTextureInformation);
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0xAE0A18", Offset = "0xAE0A18", VA = "0xAE0A18")]
	private AltUnityTextureInformation GetHighlightObjectFromCoordinatesScreenshot(out AltUnityObject selectedObject)
	{
		return default(AltUnityTextureInformation);
	}
}
