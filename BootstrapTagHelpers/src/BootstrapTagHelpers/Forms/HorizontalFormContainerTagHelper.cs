using BootstrapTagHelpers.Extensions;
using Microsoft.AspNet.Razor.TagHelpers;

namespace BootstrapTagHelpers.Forms {
    public abstract class HorizontalFormContainerTagHelper : BootstrapTagHelper {
        public int? WidthXs { get; set; }

        public int? WidthSm { get; set; }

        public int? WidthMd { get; set; }

        public int? WidthLg { get; set; }

        [HtmlAttributeNotBound]
        public FormTagHelper FormContext { get; set; }


        [HtmlAttributeNotBound]
        public FormGroupTagHelper FormGroupContext { get; set; }

        [HtmlAttributeNotBound]
        [HtmlAttributeMinimizable]
        public bool? SetOffset { get; set; }


        public override void Init(TagHelperContext context) {
            base.Init(context);
            FormContext = context.GetFormContext();
            FormGroupContext = context.GetFormGroupContext();
            if (FormContext != null)
                context.SetFormContext(new FormTagHelper {
                    LabelWidthLg = FormContext.LabelWidthLg,
                    LabelWidthMd = FormContext.LabelWidthMd,
                    LabelWidthSm = FormContext.LabelWidthSm,
                    LabelWidthXs = FormContext.LabelWidthXs,
                    FormGroupSize = FormContext.FormGroupSize,
                    Horizontal = false,
                    Inline = FormContext.Inline,
                    ControlSize = FormContext.ControlSize,
                    LabelsSrOnly = FormContext.LabelsSrOnly
                });
            if (FormGroupContext != null)
                context.SetFormGroupContext(new FormGroupTagHelper {
                    FormContext = context.GetFormContext(),
                    Size = FormGroupContext.Size,
                    ControlSize = FormGroupContext.ControlSize,
                    HasFeedback = FormGroupContext.HasFeedback,
                    HasLabel = FormGroupContext.HasLabel,
                    LabelWidthLg = FormGroupContext.LabelWidthLg,
                    LabelWidthMd = FormGroupContext.LabelWidthMd,
                    LabelWidthXs = FormGroupContext.LabelWidthXs,
                    LabelWidthSm = FormGroupContext.LabelWidthSm,
                    ValidationContext = FormGroupContext.ValidationContext
                });
        }

        protected override void BootstrapProcess(TagHelperContext context, TagHelperOutput output) {
            output.TagName = "div";
            if (FormContext?.Horizontal ?? true) {
                if ((WidthLg ?? 0) > 0) {
                    output.AddCssClass("col-lg-" + WidthLg);
                    if (SetOffset ?? false)
                        output.AddCssClass("col-lg-offset-" + (12 - WidthLg));
                }
                if ((WidthMd ?? 0) > 0) {
                    output.AddCssClass("col-md-" + WidthMd);
                    if (SetOffset ?? false)
                        output.AddCssClass("col-md-offset-" + (12 - WidthMd));
                }
                if ((WidthSm ?? 0) > 0) {
                    output.AddCssClass("col-sm-" + WidthSm);
                    if (SetOffset ?? false)
                        output.AddCssClass("col-sm-offset-" + (12 - WidthSm));
                }
                if ((WidthXs ?? 0) > 0) {
                    output.AddCssClass("col-xs-" + WidthXs);
                    if (SetOffset ?? false)
                        output.AddCssClass("col-xs-offset-" + (12 - WidthXs));
                }
            }
        }
    }
}