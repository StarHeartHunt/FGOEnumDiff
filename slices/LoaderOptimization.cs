public enum LoaderOptimization // TypeDefIndex: 1017
{
	// Fields
	public int value__; // 0x0
	public const LoaderOptimization NotSpecified = 0;
	public const LoaderOptimization SingleDomain = 1;
	public const LoaderOptimization MultiDomain = 2;
	public const LoaderOptimization MultiDomainHost = 3;
	[ObsoleteAttribute] // RVA: 0x42E6AC Offset: 0x42E6AC VA: 0x42E6AC
	public const LoaderOptimization DomainMask = 3;
	[ObsoleteAttribute] // RVA: 0x42E6BC Offset: 0x42E6BC VA: 0x42E6BC
	public const LoaderOptimization DisallowBindings = 4;
}
