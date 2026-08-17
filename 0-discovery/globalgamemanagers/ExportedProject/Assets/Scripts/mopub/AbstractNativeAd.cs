using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000002")]
public abstract class AbstractNativeAd : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x18")]
	public string AdUnitId;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x812BA8", Offset = "0x812BA8")]
	public Text Title;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x28")]
	public Text Text;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x30")]
	public Text CallToAction;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x812BE0", Offset = "0x812BE0")]
	public Renderer MainImage;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x40")]
	public Renderer IconImage;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x48")]
	public Renderer PrivacyInformationIconImage;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1755048", Offset = "0x1755048", VA = "0x1755048")]
	protected AbstractNativeAd()
	{
	}
}
