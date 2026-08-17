using Il2CppDummyDll;

[Token(Token = "0x20000B1")]
public class ShakeAnimData : AnimData
{
	[Token(Token = "0x6000457")]
	[Address(RVA = "0xA03698", Offset = "0xA03698", VA = "0xA03698")]
	public ShakeAnimData(float inSpeed = 1500f, float inInitDistance = 300f, float inDistance = 300f)
	{
	}

	[Token(Token = "0x6000458")]
	[Address(RVA = "0xA036A0", Offset = "0xA036A0", VA = "0xA036A0", Slot = "4")]
	public override float CalculateData(AnimData animData)
	{
		return default(float);
	}
}
