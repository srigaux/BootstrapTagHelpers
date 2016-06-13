namespace BootstrapTagHelpers.Grid {
    using Microsoft.AspNetCore.Razor.TagHelpers;

    [OutputElementHint("div")]
    public class Md9TagHelper : SizedColTagHelper {
        protected override int Size => 9;
        protected override string Type => "md";
    }
}