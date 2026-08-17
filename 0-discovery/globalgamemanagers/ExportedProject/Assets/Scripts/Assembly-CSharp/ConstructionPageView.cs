using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000D8")]
public class ConstructionPageView : MonoBehaviour
{
	[Token(Token = "0x40003E5")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected ConstructionViewController m_viewController;

	[Token(Token = "0x40003E6")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected GameObject m_page;

	[Token(Token = "0x40003E7")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	protected TabButton m_tabButton;

	[Token(Token = "0x40003E8")]
	[FieldOffset(Offset = "0x30")]
	protected bool m_shownPage;

	[Token(Token = "0x40003E9")]
	[FieldOffset(Offset = "0x34")]
	private BISoundEvents.EventKey m_ambientSoundKey;

	[Token(Token = "0x170000D5")]
	public ConstructionViewController parentController
	{
		[Token(Token = "0x600057F")]
		[Address(RVA = "0x9BDF14", Offset = "0x9BDF14", VA = "0x9BDF14")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000580")]
	[Address(RVA = "0x9BDF1C", Offset = "0x9BDF1C", VA = "0x9BDF1C", Slot = "4")]
	protected virtual void OnDestroy()
	{
	}

	[Token(Token = "0x6000581")]
	[Address(RVA = "0x9BDF24", Offset = "0x9BDF24", VA = "0x9BDF24", Slot = "5")]
	public virtual void OnTogglePageOn()
	{
	}

	[Token(Token = "0x6000582")]
	[Address(RVA = "0x9BDADC", Offset = "0x9BDADC", VA = "0x9BDADC", Slot = "6")]
	public virtual void OnTogglePageOff()
	{
	}

	[Token(Token = "0x6000583")]
	[Address(RVA = "0x9BDF98", Offset = "0x9BDF98", VA = "0x9BDF98")]
	public void SetAmbientSoundKey(BISoundEvents.EventKey ambientSoundkey)
	{
	}

	[Token(Token = "0x6000584")]
	[Address(RVA = "0x9BDE54", Offset = "0x9BDE54", VA = "0x9BDE54")]
	public void ShowRedDotNotification(bool show)
	{
	}

	[Token(Token = "0x6000585")]
	[Address(RVA = "0x9BDFC4", Offset = "0x9BDFC4", VA = "0x9BDFC4")]
	protected void ShowGreenDotNotification(bool show)
	{
	}

	[Token(Token = "0x6000586")]
	[Address(RVA = "0x9BDF04", Offset = "0x9BDF04", VA = "0x9BDF04")]
	public ConstructionPageView()
	{
	}
}
