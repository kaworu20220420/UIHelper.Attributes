/*
// この部分は使用する側のプロジェクトに実装します。
using System.Reflection;

public class MyModel
{
	[UIHelper.Attributes.Tooltip("ここにヒントを入力")]
	[UIHelper.Attributes.Placeholder("ここにテキストを入力")]
	public string MyProperty { get; set; }
}

// この部分も使用する側のプロジェクトに実装します。
public class ControlInitializer
{
	private ToolTip toolTip1;
	private TextBox textBox1;

	public ControlInitializer(ToolTip toolTip, TextBox textBox)
	{
		toolTip1 = toolTip;
		textBox1 = textBox;
	}

	public void InitializeControls(MyModel model)
	{
		// プロパティの属性を取得
		var propertyInfo = model.GetType().GetProperty("MyProperty");
		var tooltipAttr = propertyInfo.GetCustomAttribute<UIHelper.Attributes.TooltipAttribute>();
		var placeholderAttr = propertyInfo.GetCustomAttribute<UIHelper.Attributes.PlaceholderAttribute>();

		// TooltipとPlaceholderを設定
		if (tooltipAttr != null)
		{
			toolTip1.SetToolTip(textBox1, tooltipAttr.Tooltip);
		}
		if (placeholderAttr != null)
		{
			textBox1.PlaceholderText = placeholderAttr.Placeholder;
		}
	}
}
*/