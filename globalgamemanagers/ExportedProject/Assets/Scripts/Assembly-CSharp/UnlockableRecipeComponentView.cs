using System.Collections.Generic;
using AM2;
using AM2.ReferenceData;
using Il2CppDummyDll;
using Uken.Framework.Casual;
using UnityEngine;

[Token(Token = "0x2000123")]
public class UnlockableRecipeComponentView : MonoBehaviour
{
	[Token(Token = "0x4000776")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject m_redDotNotification;

	[Token(Token = "0x4000777")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected EUnlockType m_upgradableType;

	[Token(Token = "0x4000778")]
	[FieldOffset(Offset = "0x28")]
	protected string m_unlockerRef;

	[Token(Token = "0x4000779")]
	[FieldOffset(Offset = "0x30")]
	protected FTUEController m_ftueController;

	[Token(Token = "0x400077A")]
	[FieldOffset(Offset = "0x38")]
	protected UIAlertController m_uiAlertController;

	[Token(Token = "0x170000FE")]
	public EUnlockType upgradableType
	{
		[Token(Token = "0x600086B")]
		[Address(RVA = "0xAB4168", Offset = "0xAB4168", VA = "0xAB4168")]
		get
		{
			return default(EUnlockType);
		}
	}

	[Token(Token = "0x600086C")]
	[Address(RVA = "0xAB4170", Offset = "0xAB4170", VA = "0xAB4170", Slot = "4")]
	public virtual void Initialize()
	{
	}

	[Token(Token = "0x600086D")]
	[Address(RVA = "0xAB42E0", Offset = "0xAB42E0", VA = "0xAB42E0")]
	public bool SetupLocked(string category)
	{
		return default(bool);
	}

	[Token(Token = "0x600086E")]
	[Address(RVA = "0xAB4364", Offset = "0xAB4364", VA = "0xAB4364")]
	public bool ViewIsActive()
	{
		return default(bool);
	}

	[Token(Token = "0x600086F")]
	[Address(RVA = "0xAB4398", Offset = "0xAB4398", VA = "0xAB4398", Slot = "5")]
	public virtual void SetViewActive(bool active)
	{
	}

	[Token(Token = "0x6000870")]
	[Address(RVA = "0xAB43D4", Offset = "0xAB43D4", VA = "0xAB43D4")]
	protected void ShowRedDotNotification(bool show)
	{
	}

	[Token(Token = "0x6000871")]
	[Address(RVA = "0xAB440C", Offset = "0xAB440C", VA = "0xAB440C", Slot = "6")]
	public virtual bool RefreshRedDotNotification(HashSet<string> untouchedUnlockers)
	{
		return default(bool);
	}

	[Token(Token = "0x6000872")]
	[Address(RVA = "0xAB4494", Offset = "0xAB4494", VA = "0xAB4494")]
	public void OnHidePage()
	{
	}

	[Token(Token = "0x6000873")]
	[Address(RVA = "0xAB44E4", Offset = "0xAB44E4", VA = "0xAB44E4")]
	protected void MarkViewed()
	{
	}

	[Token(Token = "0x6000874")]
	[Address(RVA = "0xAB4540", Offset = "0xAB4540", VA = "0xAB4540")]
	public UnlockableRecipeComponentView()
	{
	}
}
