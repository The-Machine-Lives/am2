using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200011F")]
public interface ISubTabItemView
{
	[Token(Token = "0x170000F7")]
	GameObject gameObject
	{
		[Token(Token = "0x600082A")]
		get;
	}

	[Token(Token = "0x170000F8")]
	Transform transform
	{
		[Token(Token = "0x600082B")]
		get;
	}

	[Token(Token = "0x6000829")]
	bool RefreshRedDotNotification(HashSet<string> untouchedUnlockers, HashSet<string> untouchedItemRefs);

	[Token(Token = "0x600082C")]
	void OnHidePage();

	[Token(Token = "0x600082D")]
	void Cleanup();
}
