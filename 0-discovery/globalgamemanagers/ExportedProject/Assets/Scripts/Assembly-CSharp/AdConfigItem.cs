using Il2CppDummyDll;
using Uken.Framework.Casual;

[Token(Token = "0x2000170")]
public class AdConfigItem : MetadataItem
{
	[Token(Token = "0x40008F1")]
	private const string c_adViews = "ad_views";

	[Token(Token = "0x6000A1F")]
	[Address(RVA = "0xACF20C", Offset = "0xACF20C", VA = "0xACF20C")]
	public int GetAdViews()
	{
		return default(int);
	}

	[Token(Token = "0x6000A20")]
	[Address(RVA = "0xACF264", Offset = "0xACF264", VA = "0xACF264")]
	public void IncrementAdViews()
	{
	}

	[Token(Token = "0x6000A21")]
	[Address(RVA = "0xACF2C8", Offset = "0xACF2C8", VA = "0xACF2C8")]
	public void ClearViews()
	{
	}

	[Token(Token = "0x6000A22")]
	[Address(RVA = "0xACF320", Offset = "0xACF320", VA = "0xACF320")]
	public AdConfigItem()
	{
	}
}
