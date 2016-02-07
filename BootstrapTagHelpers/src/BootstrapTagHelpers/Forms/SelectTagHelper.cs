namespace BootstrapTagHelpers.Forms {
    using BootstrapTagHelpers.Extensions;

    using Microsoft.AspNet.Razor.TagHelpers;

    public class SelectTagHelper : BootstrapTagHelper {
        protected override bool CopyAttributesIfBootstrapIsDisabled => true;

        [CopyToOutput]
        public string Id { get; set; }

        [HtmlAttributeName(AttributePrefix + "label")]
        public string Label { get; set; }

        [HtmlAttributeName(AttributePrefix + "help-text")]
        public string HelpText { get; set; }

        [HtmlAttributeNotBound]
        public FormTagHelper FormContext { get; set; }

        [HtmlAttributeNotBound]
        public FormGroupTagHelper FormGroupContext { get; set; }

        [HtmlAttributeName(AttributePrefix + "size")]
        public Size? Size { get; set; }

        public override void Init(TagHelperContext context) {
            base.Init(context);
            FormGroupContext = context.GetFormGroupContext();
            FormContext = context.GetFormContext();
            Size = Size ?? FormContext?.ControlSize;
        }

        protected override void BootstrapProcess(TagHelperContext context, TagHelperOutput output) {
            output.AddCssClass("form-control");
            if (FormGroupContext != null)
                FormGroupContext.WrapInDivForHorizontalForm(output, !string.IsNullOrEmpty(Label));
            else if (FormContext != null)
                FormContext.WrapInDivForHorizontalForm(output, !string.IsNullOrEmpty(Label));
            if (!string.IsNullOrEmpty(Label))
                output.PreElement.Prepend(LabelTagHelper.GenerateLabel(Label, FormContext));
            if (!string.IsNullOrEmpty(HelpText))
                output.PostElement.PrependHtml(HelpBlockTagHelper.GenerateHelpBlock(HelpText));
            if (Size != null && Size != BootstrapTagHelpers.Size.Default)
                output.AddCssClass("input-" + Size.Value.GetDescription());
        }
    }

}