using AM2.ReferenceData;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001A9")]
public class TitleConnectorItemView : MonoBehaviour
{
	[Token(Token = "0x40009F8")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public AM2Text m_text;

	[Token(Token = "0x40009F9")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82563C", Offset = "0x82563C")]
	private TitleConnector _003CtitleConnector_003Ek__BackingField;

	[Token(Token = "0x17000169")]
	public TitleConnector titleConnector
	{
		[Token(Token = "0x6000B96")]
		[Address(RVA = "0xA1384C", Offset = "0xA1384C", VA = "0xA1384C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8348B8", Offset = "0x8348B8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B97")]
		[Address(RVA = "0xA13854", Offset = "0xA13854", VA = "0xA13854")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8348C8", Offset = "0x8348C8")]
		private set
		{
		}
	}

	[Token(Token = "0x6000B98")]
	[Address(RVA = "0xA1385C", Offset = "0xA1385C", VA = "0xA1385C")]
	public void Initialize(TitleConnector inTitleConnector)
	{
	}

	[Token(Token = "0x6000B99")]
	[Address(RVA = "0xA138C4", Offset = "0xA138C4", VA = "0xA138C4")]
	public TitleConnectorItemView()
	{
	}
}
