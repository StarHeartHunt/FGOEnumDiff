public enum MethodImplAttributes // TypeDefIndex: 559
{
	// Fields
	public int value__; // 0x0
	public const MethodImplAttributes CodeTypeMask = 3;
	public const MethodImplAttributes IL = 0;
	public const MethodImplAttributes Native = 1;
	public const MethodImplAttributes OPTIL = 2;
	public const MethodImplAttributes Runtime = 3;
	public const MethodImplAttributes ManagedMask = 4;
	public const MethodImplAttributes Unmanaged = 4;
	public const MethodImplAttributes Managed = 0;
	public const MethodImplAttributes ForwardRef = 16;
	public const MethodImplAttributes PreserveSig = 128;
	public const MethodImplAttributes InternalCall = 4096;
	public const MethodImplAttributes Synchronized = 32;
	public const MethodImplAttributes NoInlining = 8;
	[ComVisibleAttribute] // RVA: 0xA73648 Offset: 0xA73648 VA: 0xA73648
	public const MethodImplAttributes AggressiveInlining = 256;
	public const MethodImplAttributes NoOptimization = 64;
	public const MethodImplAttributes MaxMethodImplVal = 65535;
}
