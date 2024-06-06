//ASP.NET Core MVCでカスタム属性を使用してTooltipとPlaceholderを設定する例
/*
public class MyViewModel
{
    [Tooltip("ここにヒントを入力")]
    [Placeholder("ここにテキストを入力")]
    public string MyProperty { get; set; }
}

@model MyViewModel

@{
    var tooltip = Model.GetType().GetProperty(nameof(Model.MyProperty))
                     .GetCustomAttribute<TooltipAttribute>()?.Text;
    var placeholder = Model.GetType().GetProperty(nameof(Model.MyProperty))
                         .GetCustomAttribute<PlaceholderAttribute>()?.Text;
}

<input asp-for="MyProperty" title="@tooltip" placeholder="@placeholder" />

HTMLには標準のtooltip属性がないため、title属性を使用するか、JavaScriptやjQueryを使用してカスタムのツールチップを実装する。title属性を使用する場合の記述例。

HTML

<input type="text" name="password" title="@tooltip">

jQueryを使用した実装例。

$(document).ready(function(){
  $('input[name="username"]').tooltip({ content: "@tooltip" });
});
