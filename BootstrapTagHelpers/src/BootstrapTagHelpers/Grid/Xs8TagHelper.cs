namespace BootstrapTagHelpers.Grid {
    using Microsoft.AspNetCore.Razor.TagHelpers;

    [OutputElementHint("div")]
    public class Xs8TagHelper : SizedColTagHelper {
        protected override int Size => 8;
        protected override string Type => "xs";
    }
}