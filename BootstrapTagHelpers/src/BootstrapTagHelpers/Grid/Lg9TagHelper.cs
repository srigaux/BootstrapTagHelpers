namespace BootstrapTagHelpers.Grid {
    using Microsoft.AspNet.Razor.TagHelpers;

    [OutputElementHint("div")]
    public class Lg9TagHelper : SizedColTagHelper {
        protected override int Size => 9;
        protected override string Type => "lg";
    }
}