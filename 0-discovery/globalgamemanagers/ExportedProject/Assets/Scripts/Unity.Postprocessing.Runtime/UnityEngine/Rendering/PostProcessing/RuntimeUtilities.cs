using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Token(Token = "0x2000061")]
	public static class RuntimeUtilities
	{
		[Token(Token = "0x2000089")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8195DC", Offset = "0x8195DC")]
		private sealed class _003CGetAllSceneObjects_003Ed__80<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : Component
		{
			[Token(Token = "0x40002F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int _003C_003E1__state;

			[Token(Token = "0x40002F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private T _003C_003E2__current;

			[Token(Token = "0x40002F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int _003C_003El__initialThreadId;

			[Token(Token = "0x40002F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Queue<Transform> _003Cqueue_003E5__2;

			[Token(Token = "0x40002F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private GameObject[] _003C_003E7__wrap2;

			[Token(Token = "0x40002F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int _003C_003E7__wrap3;

			[Token(Token = "0x40002F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private IEnumerator _003C_003E7__wrap4;

			[Token(Token = "0x1700004A")]
			private T System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002ECurrent
			{
				[Token(Token = "0x600024B")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700004B")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600024D")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000247")]
			[DebuggerHidden]
			public _003CGetAllSceneObjects_003Ed__80(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000248")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000249")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600024A")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x600024C")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x600024E")]
			[DebuggerHidden]
			private IEnumerator<T> System_002ECollections_002EGeneric_002EIEnumerable_003CT_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600024F")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[Serializable]
		[Token(Token = "0x200008A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8195EC", Offset = "0x8195EC")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40002F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40002F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Assembly, IEnumerable<Type>> _003C_003E9__87_0;

			[Token(Token = "0x6000251")]
			[Address(RVA = "0x122ED5C", Offset = "0x122ED5C", VA = "0x122ED5C")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6000252")]
			[Address(RVA = "0x122ED64", Offset = "0x122ED64", VA = "0x122ED64")]
			internal IEnumerable<Type> _003CGetAllAssemblyTypes_003Eb__87_0(Assembly t)
			{
				return null;
			}
		}

		[Serializable]
		[Token(Token = "0x200008B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8195FC", Offset = "0x8195FC")]
		private sealed class _003C_003Ec__88<T>
		{
			[Token(Token = "0x40002FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec__88<T> _003C_003E9;

			[Token(Token = "0x40002FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Func<Type, bool> _003C_003E9__88_0;

			[Token(Token = "0x6000254")]
			public _003C_003Ec__88()
			{
			}

			[Token(Token = "0x6000255")]
			internal bool _003CGetAllTypesDerivedFrom_003Eb__88_0(Type t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Texture2D m_WhiteTexture;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Texture3D m_WhiteTexture3D;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Texture2D m_BlackTexture;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Texture3D m_BlackTexture3D;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static Texture2D m_TransparentTexture;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static Texture3D m_TransparentTexture3D;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static Dictionary<int, Texture2D> m_LutStrips;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static PostProcessResources s_Resources;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static Mesh s_FullscreenTriangle;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static Material s_CopyStdMaterial;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static Material s_CopyStdFromDoubleWideMaterial;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static Material s_CopyMaterial;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static Material s_CopyFromTexArrayMaterial;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static PropertySheet s_CopySheet;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static PropertySheet s_CopyFromTexArraySheet;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static IEnumerable<Type> m_AssemblyTypes;

		[Token(Token = "0x1700002D")]
		public static Texture2D whiteTexture
		{
			[Token(Token = "0x60001D0")]
			[Address(RVA = "0x122A504", Offset = "0x122A504", VA = "0x122A504")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		public static Texture3D whiteTexture3D
		{
			[Token(Token = "0x60001D1")]
			[Address(RVA = "0x122A6C4", Offset = "0x122A6C4", VA = "0x122A6C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		public static Texture2D blackTexture
		{
			[Token(Token = "0x60001D2")]
			[Address(RVA = "0x122A8BC", Offset = "0x122A8BC", VA = "0x122A8BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		public static Texture3D blackTexture3D
		{
			[Token(Token = "0x60001D3")]
			[Address(RVA = "0x122AA78", Offset = "0x122AA78", VA = "0x122AA78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		public static Texture2D transparentTexture
		{
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x122AC70", Offset = "0x122AC70", VA = "0x122AC70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		public static Texture3D transparentTexture3D
		{
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x122AE2C", Offset = "0x122AE2C", VA = "0x122AE2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public static Mesh fullscreenTriangle
		{
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x122B4C4", Offset = "0x122B4C4", VA = "0x122B4C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public static Material copyStdMaterial
		{
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x122B7DC", Offset = "0x122B7DC", VA = "0x122B7DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		public static Material copyStdFromDoubleWideMaterial
		{
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x122B978", Offset = "0x122B978", VA = "0x122B978")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		public static Material copyMaterial
		{
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x122BB14", Offset = "0x122BB14", VA = "0x122BB14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		public static Material copyFromTexArrayMaterial
		{
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x122BCB0", Offset = "0x122BCB0", VA = "0x122BCB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		public static PropertySheet copySheet
		{
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x122BE4C", Offset = "0x122BE4C", VA = "0x122BE4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		public static PropertySheet copyFromTexArraySheet
		{
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x122BF28", Offset = "0x122BF28", VA = "0x122BF28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		public static bool scriptableRenderPipelineActive
		{
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x122DD3C", Offset = "0x122DD3C", VA = "0x122DD3C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003B")]
		public static bool supportsDeferredShading
		{
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x122DDB4", Offset = "0x122DDB4", VA = "0x122DDB4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003C")]
		public static bool supportsDepthNormals
		{
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x122DE34", Offset = "0x122DE34", VA = "0x122DE34")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003D")]
		public static bool isSinglePassStereoEnabled
		{
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x122DEB4", Offset = "0x122DEB4", VA = "0x122DEB4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003E")]
		public static bool isVREnabled
		{
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x122DF0C", Offset = "0x122DF0C", VA = "0x122DF0C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003F")]
		public static bool isAndroidOpenGL
		{
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x122DF14", Offset = "0x122DF14", VA = "0x122DF14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000040")]
		public static RenderTextureFormat defaultHDRRenderTextureFormat
		{
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x122DF4C", Offset = "0x122DF4C", VA = "0x122DF4C")]
			get
			{
				return default(RenderTextureFormat);
			}
		}

		[Token(Token = "0x17000041")]
		public static bool isLinearColorSpace
		{
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x122E0A0", Offset = "0x122E0A0", VA = "0x122E0A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x122B024", Offset = "0x122B024", VA = "0x122B024")]
		public static Texture2D GetLutStrip(int size)
		{
			return null;
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x122C004", Offset = "0x122C004", VA = "0x122C004")]
		internal static void UpdateResources(PostProcessResources resources)
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x122C0E0", Offset = "0x122C0E0", VA = "0x122C0E0")]
		public static void SetRenderTargetWithLoadStoreAction(this CommandBuffer cmd, RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction)
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x122C15C", Offset = "0x122C15C", VA = "0x122C15C")]
		public static void SetRenderTargetWithLoadStoreAction(this CommandBuffer cmd, RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x122C21C", Offset = "0x122C21C", VA = "0x122C21C")]
		public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, bool clear = false, [Optional] Rect? viewport)
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x122C51C", Offset = "0x122C51C", VA = "0x122C51C")]
		public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, RenderBufferLoadAction loadAction, [Optional] Rect? viewport)
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x122C85C", Offset = "0x122C85C", VA = "0x122C85C")]
		public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = false, [Optional] Rect? viewport)
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x122CA50", Offset = "0x122CA50", VA = "0x122CA50")]
		public static void BlitFullscreenTriangleFromDoubleWide(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material, int pass, int eye)
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x122CD18", Offset = "0x122CD18", VA = "0x122CD18")]
		public static void BlitFullscreenTriangleToDoubleWide(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, int eye)
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x122CF14", Offset = "0x122CF14", VA = "0x122CF14")]
		public static void BlitFullscreenTriangleFromTexArray(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = false, int depthSlice = -1)
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x122D1A4", Offset = "0x122D1A4", VA = "0x122D1A4")]
		public static void BlitFullscreenTriangleToTexArray(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = false, int depthSlice = -1)
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x122D430", Offset = "0x122D430", VA = "0x122D430")]
		public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, RenderTargetIdentifier depth, PropertySheet propertySheet, int pass, bool clear = false, [Optional] Rect? viewport)
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x122D7E4", Offset = "0x122D7E4", VA = "0x122D7E4")]
		public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier[] destinations, RenderTargetIdentifier depth, PropertySheet propertySheet, int pass, bool clear = false, [Optional] Rect? viewport)
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x122DAA4", Offset = "0x122DAA4", VA = "0x122DAA4")]
		public static void BuiltinBlit(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination)
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x122CBEC", Offset = "0x122CBEC", VA = "0x122CBEC")]
		public static void BuiltinBlit(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material mat, int pass = 0)
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x122DBB8", Offset = "0x122DBB8", VA = "0x122DBB8")]
		public static void CopyTexture(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination)
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x122E064", Offset = "0x122E064", VA = "0x122E064")]
		public static bool isFloatingPointFormat(RenderTextureFormat format)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x1225A98", Offset = "0x1225A98", VA = "0x1225A98")]
		public static void Destroy(Object obj)
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x122E0C0", Offset = "0x122E0C0", VA = "0x122E0C0")]
		public static bool IsResolvedDepthAvailable(Camera camera)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x122E134", Offset = "0x122E134", VA = "0x122E134")]
		public static void DestroyProfile(PostProcessProfile profile, bool destroyEffects)
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x122E2B0", Offset = "0x122E2B0", VA = "0x122E2B0")]
		public static void DestroyVolume(PostProcessVolume volume, bool destroyProfile, bool destroyGameObject = false)
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x122E3D0", Offset = "0x122E3D0", VA = "0x122E3D0")]
		public static bool IsPostProcessingActive(PostProcessLayer layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x122E468", Offset = "0x122E468", VA = "0x122E468")]
		public static bool IsTemporalAntialiasingActive(PostProcessLayer layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60001FC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x81C5E8", Offset = "0x81C5E8")]
		public static IEnumerable<T> GetAllSceneObjects<T>() where T : Component
		{
			return null;
		}

		[Token(Token = "0x60001FD")]
		public static void CreateIfNull<T>(ref T obj) where T : class, new()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x122E50C", Offset = "0x122E50C", VA = "0x122E50C")]
		public static float Exp2(float x)
		{
			return default(float);
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x122E580", Offset = "0x122E580", VA = "0x122E580")]
		public static Matrix4x4 GetJitteredPerspectiveProjectionMatrix(Camera camera, Vector2 offset)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x122E7BC", Offset = "0x122E7BC", VA = "0x122E7BC")]
		public static Matrix4x4 GetJitteredOrthographicProjectionMatrix(Camera camera, Vector2 offset)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x122E96C", Offset = "0x122E96C", VA = "0x122E96C")]
		public static Matrix4x4 GenerateJitteredProjectionMatrixFromOriginal(PostProcessRenderContext context, Matrix4x4 origProj, Vector2 jitter)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x122EAE0", Offset = "0x122EAE0", VA = "0x122EAE0")]
		public static IEnumerable<Type> GetAllAssemblyTypes()
		{
			return null;
		}

		[Token(Token = "0x6000203")]
		public static IEnumerable<Type> GetAllTypesDerivedFrom<T>()
		{
			return null;
		}

		[Token(Token = "0x6000204")]
		public static T GetAttribute<T>(this Type type) where T : Attribute
		{
			return null;
		}

		[Token(Token = "0x6000205")]
		public static Attribute[] GetMemberAttributes<TType, TValue>(Expression<Func<TType, TValue>> expr)
		{
			return null;
		}

		[Token(Token = "0x6000206")]
		public static string GetFieldPath<TType, TValue>(Expression<Func<TType, TValue>> expr)
		{
			return null;
		}
	}
}
