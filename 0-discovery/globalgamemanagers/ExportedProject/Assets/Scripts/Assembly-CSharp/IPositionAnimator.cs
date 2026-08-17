using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000169")]
public interface IPositionAnimator
{
	[Token(Token = "0x60009E7")]
	void SetPosition(Vector3 position);

	[Token(Token = "0x60009E8")]
	void SetRotation(Quaternion quaternion);

	[Token(Token = "0x60009E9")]
	void SetPositionAndRotation(Vector3 position, Quaternion rotation);

	[Token(Token = "0x60009EA")]
	void UpdatePosition();
}
