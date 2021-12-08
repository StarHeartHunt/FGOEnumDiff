public enum LoaderOptimization // TypeDefIndex: 1007
{
	// Fields
	public int value__; // 0x0
	public const LoaderOptimization NotSpecified = 0;
	public const LoaderOptimization SingleDomain = 1;
	public const LoaderOptimization MultiDomain = 2;
	public const LoaderOptimization MultiDomainHost = 3;
	[ObsoleteAttribute] // RVA: 0x47262C Offset: 0x47262C VA: 0x47262C
	public const LoaderOptimization DomainMask = 3;
	[ObsoleteAttribute] // RVA: 0x47263C Offset: 0x47263C VA: 0x47263C
	public const LoaderOptimization DisallowBindings = 4;
}
