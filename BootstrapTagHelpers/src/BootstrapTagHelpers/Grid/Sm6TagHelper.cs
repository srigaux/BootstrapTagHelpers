namespace BootstrapTagHelpers.Grid {
    using Microsoft.AspNetCore.Razor.TagHelpers;

    [OutputElementHint("div")]
    public class Sm6TagHelper : SizedColTagHelper {
        protected override int Size => 6;
        protected override string Type => "sm";
    }
}