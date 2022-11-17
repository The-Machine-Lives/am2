using Il2CppDummyDll;
using UnityEngine.SceneManagement;

namespace Facebook.Unity.Editor
{
	[Token(Token = "0x2000073")]
	internal class EditorFacebookGameObject : FacebookGameObject
	{
		[Token(Token = "0x6000266")]
		[Address(RVA = "0xCD6E9C", Offset = "0xCD6E9C", VA = "0xCD6E9C", Slot = "10")]
		protected override void OnAwake()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0xCD6EA0", Offset = "0xCD6EA0", VA = "0xCD6EA0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0xCD6F1C", Offset = "0xCD6F1C", VA = "0xCD6F1C")]
		private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0xCD6F20", Offset = "0xCD6F20", VA = "0xCD6F20")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0xCD6F9C", Offset = "0xCD6F9C", VA = "0xCD6F9C")]
		public void onPurchaseCompleteHandler(object data)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0xCD6FA4", Offset = "0xCD6FA4", VA = "0xCD6FA4")]
		public EditorFacebookGameObject()
		{
		}
	}
}
