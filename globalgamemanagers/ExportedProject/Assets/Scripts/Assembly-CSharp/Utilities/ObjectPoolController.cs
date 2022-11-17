using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Uken.Core;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Utilities
{
	[Token(Token = "0x2000308")]
	public class ObjectPoolController : UkenController
	{
		[Token(Token = "0x4000E14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		private bool m_initialized;

		[Token(Token = "0x4000E15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Dictionary<GameObject, Pool> m_pools;

		[Token(Token = "0x4000E16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<GameObject, GameObject> m_activeObjectPoolReverseLookup;

		[Token(Token = "0x4000E17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform m_objectPoolDespawnedParent;

		[Token(Token = "0x60017C8")]
		[Address(RVA = "0xAB61D8", Offset = "0xAB61D8", VA = "0xAB61D8", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60017C9")]
		[Address(RVA = "0xAB62B4", Offset = "0xAB62B4", VA = "0xAB62B4")]
		public GameObject Spawn(GameObject prefab, Transform parent, bool reparentOnDespawn = false)
		{
			return null;
		}

		[Token(Token = "0x60017CA")]
		[Address(RVA = "0xAB6414", Offset = "0xAB6414", VA = "0xAB6414")]
		public GameObject Spawn(GameObject prefab, Transform parent, Vector3 pos, bool reparentOnDespawn = false)
		{
			return null;
		}

		[Token(Token = "0x60017CB")]
		[Address(RVA = "0xAB6540", Offset = "0xAB6540", VA = "0xAB6540")]
		public GameObject Spawn(GameObject prefab, Transform parent, Vector3 pos, Quaternion rot, bool reparentOnDespawn = false)
		{
			return null;
		}

		[Token(Token = "0x60017CC")]
		[Address(RVA = "0xAB63F8", Offset = "0xAB63F8", VA = "0xAB63F8")]
		public GameObject Spawn(GameObject prefab, Transform parent, Vector3 pos, Quaternion rot, Vector3 sca, bool reparentOnDespawn = false)
		{
			return null;
		}

		[Token(Token = "0x60017CD")]
		[Address(RVA = "0xAB67CC", Offset = "0xAB67CC", VA = "0xAB67CC")]
		public GameObject TrySpawnWithSizeLimit(GameObject prefab, Transform parent, Vector3 pos, int sizeLimit, bool reparentOnDespawn = false)
		{
			return null;
		}

		[Token(Token = "0x60017CE")]
		[Address(RVA = "0xAB68FC", Offset = "0xAB68FC", VA = "0xAB68FC")]
		public GameObject TrySpawnWithSizeLimit(GameObject prefab, Transform parent, Vector3 pos, Quaternion rot, int sizeLimit, bool reparentOnDespawn = false)
		{
			return null;
		}

		[Token(Token = "0x60017CF")]
		[Address(RVA = "0xAB6644", Offset = "0xAB6644", VA = "0xAB6644")]
		public GameObject TrySpawnWithSizeLimit(GameObject prefab, Transform parent, Vector3 pos, Quaternion rot, Vector3 sca, int sizeLimit, bool reparentOnDespawn = false)
		{
			return null;
		}

		[Token(Token = "0x60017D0")]
		public T Spawn<T>(GameObject prefab, Transform parent, bool reparentOnDespawn = false) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60017D1")]
		public T Spawn<T>(GameObject prefab, Transform parent, Vector3 pos, bool reparentOnDespawn = false) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60017D2")]
		public T Spawn<T>(GameObject prefab, Transform parent, Vector3 pos, Quaternion rot, bool reparentOnDespawn = false) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60017D3")]
		public T Spawn<T>(GameObject prefab, Transform parent, Vector3 pos, Quaternion rot, Vector3 sca, bool reparentOnDespawn = false) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60017D4")]
		public void Despawn<T>(List<T> objs) where T : MonoBehaviour
		{
		}

		[Token(Token = "0x60017D5")]
		[Address(RVA = "0xAB6F94", Offset = "0xAB6F94", VA = "0xAB6F94")]
		public void Despawn(List<GameObject> objs)
		{
		}

		[Token(Token = "0x60017D6")]
		[Address(RVA = "0xAB704C", Offset = "0xAB704C", VA = "0xAB704C")]
		public void Despawn(GameObject obj)
		{
		}

		[Token(Token = "0x60017D7")]
		[Address(RVA = "0xAB716C", Offset = "0xAB716C", VA = "0xAB716C")]
		public void DespawnPrefab(GameObject prefab, GameObject obj)
		{
		}

		[Token(Token = "0x60017D8")]
		[Address(RVA = "0xAB6A04", Offset = "0xAB6A04", VA = "0xAB6A04")]
		private void InitPool([Optional] GameObject prefab, int sizeLimit = -1, bool reparentOnDespawn = false)
		{
		}

		[Token(Token = "0x60017D9")]
		[Address(RVA = "0xAB7408", Offset = "0xAB7408", VA = "0xAB7408")]
		private void OnSceneLoaded(Scene scene, LoadSceneMode loadSceneMode)
		{
		}

		[Token(Token = "0x60017DA")]
		[Address(RVA = "0xAB74BC", Offset = "0xAB74BC", VA = "0xAB74BC")]
		private void OnSceneUnload(Scene scene)
		{
		}

		[Token(Token = "0x60017DB")]
		[Address(RVA = "0xAB7520", Offset = "0xAB7520", VA = "0xAB7520", Slot = "8")]
		public override void Cleanup()
		{
		}

		[Token(Token = "0x60017DC")]
		[Address(RVA = "0xAB75F0", Offset = "0xAB75F0", VA = "0xAB75F0")]
		public ObjectPoolController()
		{
		}
	}
}
