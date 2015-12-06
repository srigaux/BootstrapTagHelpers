namespace BootstrapTagHelpers.ResponsiveUtilities {
    using Microsoft.AspNet.Razor.TagHelpers;

    [OutputElementHint("div")]
    public class VisibleMdTagHelper : BootstrapTagHelper {
        [HtmlAttributeName(VisibleLgTagHelper.DisplayModeAttributeName)]
        public BootstrapResponsiveUtilitiesDisplayMode DisplayMode { get; set; } =
            BootstrapResponsiveUtilitiesDisplayMode.Block;

        protected override void BootstrapProcess(TagHelperContext context, TagHelperOutput output) {
            output.TagName = DisplayMode == BootstrapResponsiveUtilitiesDisplayMode.Inline ? "span" : "div";
            output.AddCssClass("visible-md-" + DisplayMode.GetDescription());
        }
    }
}