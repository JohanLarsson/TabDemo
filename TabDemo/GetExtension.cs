namespace TabDemo
{
    using System;
    using System.ComponentModel;
    using System.Windows;
    using System.Windows.Markup;

    public class GetExtension : MarkupExtension
    {
        private static readonly DependencyObject DependencyObject = new DependencyObject();

        public GetExtension()
        {
        }

        public GetExtension(Type type)
        {
            this.Type = type;
        }

        private static bool IsInDesignMode => DesignerProperties.GetIsInDesignMode(DependencyObject);

        [ConstructorArgument("type")]
        public Type Type { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            if (this.Type is null ||
                IsInDesignMode)
            {
                return null;
            }

            return App.Kernel.Get(this.Type);
        }
    }
}