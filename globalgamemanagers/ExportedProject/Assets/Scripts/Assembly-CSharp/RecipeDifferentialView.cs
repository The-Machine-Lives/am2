using System;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using Uken.Framework.Casual.View;
using UnityEngine;

[Token(Token = "0x2000103")]
public class RecipeDifferentialView : MonoBehaviour
{
	[Token(Token = "0x40005F9")]
	[FieldOffset(Offset = "0x18")]
	protected RecipeDifferentialController m_recipeDifferentialController;

	[Token(Token = "0x40005FA")]
	[FieldOffset(Offset = "0x20")]
	protected Localizations m_localizationController;

	[Token(Token = "0x40005FB")]
	[FieldOffset(Offset = "0x28")]
	protected CasualViewController m_parentViewController;

	[Token(Token = "0x40005FC")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	protected AM2Image m_differentialIcon;

	[Token(Token = "0x40005FD")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	protected InfoPopupButton m_infoPopupButton;

	[Token(Token = "0x40005FE")]
	[FieldOffset(Offset = "0x40")]
	private Recipe m_recipe;

	[Token(Token = "0x40005FF")]
	[FieldOffset(Offset = "0x48")]
	private Gradient m_gradient;

	[Token(Token = "0x60006E1")]
	[Address(RVA = "0x9EE1FC", Offset = "0x9EE1FC", VA = "0x9EE1FC")]
	private static Gradient ConstructGradient()
	{
		return null;
	}

	[Token(Token = "0x60006E2")]
	[Address(RVA = "0x9EE428", Offset = "0x9EE428", VA = "0x9EE428")]
	public void Initialize(CasualViewController viewController, Recipe recipe)
	{
	}

	[Token(Token = "0x60006E3")]
	[Address(RVA = "0x9EE654", Offset = "0x9EE654", VA = "0x9EE654")]
	public ValueTuple<string, string> GeneratePopupContents()
	{
		return default(ValueTuple<string, string>);
	}

	[Token(Token = "0x60006E4")]
	[Address(RVA = "0x9EEC3C", Offset = "0x9EEC3C", VA = "0x9EEC3C")]
	private void Update()
	{
	}

	[Token(Token = "0x60006E5")]
	[Address(RVA = "0x9EEC40", Offset = "0x9EEC40", VA = "0x9EEC40")]
	private void UpdateDifferentialIcon()
	{
	}

	[Token(Token = "0x60006E6")]
	[Address(RVA = "0x9EED70", Offset = "0x9EED70", VA = "0x9EED70")]
	private Color DifferentialIconColour(double relativeGrowthRate)
	{
		return default(Color);
	}

	[Token(Token = "0x60006E7")]
	[Address(RVA = "0x9EE744", Offset = "0x9EE744", VA = "0x9EE744")]
	private string GeneratePopupBody(string title)
	{
		return null;
	}

	[Token(Token = "0x60006E8")]
	[Address(RVA = "0x9EEDC0", Offset = "0x9EEDC0", VA = "0x9EEDC0")]
	public RecipeDifferentialView()
	{
	}
}
