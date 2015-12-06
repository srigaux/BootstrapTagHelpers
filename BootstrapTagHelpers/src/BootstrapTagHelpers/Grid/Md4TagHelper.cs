namespace BootstrapTagHelpers.Grid {
    using Microsoft.AspNet.Razor.TagHelpers;

    [OutputElementHint("div")]
    public class Md4TagHelper : SizedColTagHelper {
        protected override int Size => 4;
        protected override string Type => "md";
    }
}