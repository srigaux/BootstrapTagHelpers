namespace BootstrapTagHelpers.Grid {
    using Microsoft.AspNet.Razor.TagHelpers;

    [OutputElementHint("div")]
    public class Lg2TagHelper : SizedColTagHelper {
        protected override int Size => 2;
        protected override string Type => "lg";
    }
}