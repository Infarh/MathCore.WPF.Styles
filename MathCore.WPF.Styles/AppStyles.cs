namespace MathCore.WPF.Styles;

public partial class AppStyles
{
    public AppStyles()
    {
        MergedDictionaries.Add(new ResourceDictionary { Source = new Uri("pack://application:,,,/MathCore.WPF.Styles;component/Styles/CheckBoxes/SwitcherCheckBox.xaml") });
        MergedDictionaries.Add(new ResourceDictionary { Source = new Uri("pack://application:,,,/MathCore.WPF.Styles;component/Styles/TextBoxes/TaggedTextBox.xaml") });
        MergedDictionaries.Add(new ResourceDictionary { Source = new Uri("pack://application:,,,/MathCore.WPF.Styles;component/Resources/EasingFunctions.xaml") });
        MergedDictionaries.Add(new ResourceDictionary { Source = new Uri("pack://application:,,,/MathCore.WPF.Styles;component/Resources/Colors/Brushes.xaml") });
    }
}