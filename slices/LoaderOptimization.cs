public enum LoaderOptimization // TypeDefIndex: 1017
{
	// Fields
	public int value__; // 0x0
	public const LoaderOptimization NotSpecified = 0;
	public const LoaderOptimization SingleDomain = 1;
	public const LoaderOptimization MultiDomain = 2;
	public const LoaderOptimization MultiDomainHost = 3;
	[ObsoleteAttribute] // RVA: 0x42B1C8 Offset: 0x42B1C8 VA: 0x42B1C8
	public const LoaderOptimization DomainMask = 3;
	[ObsoleteAttribute] // RVA: 0x42B1D8 Offset: 0x42B1D8 VA: 0x42B1D8
	public const LoaderOptimization DisallowBindings = 4;
}
