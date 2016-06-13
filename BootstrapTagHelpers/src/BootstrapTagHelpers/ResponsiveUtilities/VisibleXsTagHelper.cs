using BootstrapTagHelpers.Extensions;

namespace BootstrapTagHelpers.ResponsiveUtilities {
    using Microsoft.AspNetCore.Razor.TagHelpers;

    [OutputElementHint("div")]
    public class VisibleXsTagHelper : BootstrapTagHelper {
        [HtmlAttributeName(VisibleLgTagHelper.DisplayModeAttributeName)]
        public BootstrapResponsiveUtilitiesDisplayMode DisplayMode { get; set; } =
            BootstrapResponsiveUtilitiesDisplayMode.Block;

        protected override void BootstrapProcess(TagHelperContext context, TagHelperOutput output) {
            output.TagName = DisplayMode == BootstrapResponsiveUtilitiesDisplayMode.Inline ? "span" : "div";
            output.AddCssClass("visible-xs-" + DisplayMode.GetDescription());
        }
    }
}