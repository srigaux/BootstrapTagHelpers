namespace BootstrapTagHelpers.Grid {
    using Microsoft.AspNetCore.Razor.TagHelpers;

    [OutputElementHint("div")]
    public class Md3TagHelper : SizedColTagHelper {
        protected override int Size => 3;
        protected override string Type => "md";
    }
}