//Windows Formsの場合の実装例

/*
// 必要な名前空間を追加
using System.Windows.Forms;
using System.Reflection; // GetCustomAttribute<T> メソッドを使用するために必要

namespace UIHelper.Attributes
{
	public static class ControlExtensions
	{
		// このメソッドは、指定されたコントロールコレクション内の各コントロールに対して、
		// モデルのプロパティに設定されたTooltipとPlaceholder属性を適用します。
		public static void ApplyAttributes<TModel>(this Control.ControlCollection controls, TModel model)
		{
			foreach (Control control in controls)
			{
				// コントロールの名前からモデルのプロパティを見つける
				var propertyInfo = model.GetType().GetProperty(control.Name);
				if (propertyInfo != null)
				{
					// Tooltip属性を適用
					var tooltipAttr = propertyInfo.GetCustomAttribute<TooltipAttribute>();
					if (tooltipAttr != null && control is TextBox)
					{
						var toolTip = new ToolTip();
						toolTip.SetToolTip(control as TextBox, tooltipAttr.Tooltip);
					}

					// Placeholder属性を適用
					var placeholderAttr = propertyInfo.GetCustomAttribute<PlaceholderAttribute>();
					if (placeholderAttr != null && control is TextBox)
					{
						(control as TextBox).PlaceholderText = placeholderAttr.Placeholder;
					}
				}
			}
		}
	}
}
