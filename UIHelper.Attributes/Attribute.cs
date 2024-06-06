namespace UIHelper.Attributes
{
	[AttributeUsage(AttributeTargets.Property)]
	public class TooltipAttribute : Attribute
	{
		public string Tooltip { get; }

		public TooltipAttribute(string tooltip) => Tooltip = tooltip;
	}

	[AttributeUsage(AttributeTargets.Property)]
	public class PlaceholderAttribute : Attribute
	{
		public string Placeholder { get; }

		public PlaceholderAttribute(string placeholder) => Placeholder = placeholder;
	}
}
