namespace BootstrapTagHelpers.Grid {
    using Microsoft.AspNet.Razor.TagHelpers;

    [OutputElementHint("div")]
    public class Xs3TagHelper : SizedColTagHelper {
        protected override int Size => 3;
        protected override string Type => "xs";
    }
}