

using System.Windows;
using System.Windows.Controls;

namespace SinkawaMaster.Provider.Skin.Attr
{
    public class TextBoxAttr : TextBox
    {

        public static readonly DependencyProperty MaxlenDependency =
            DependencyProperty.Register("Maxlen", typeof(int), typeof(TextBoxAttr), null);

        public int Maxlen
        {
            get { return (int)GetValue(MaxlenDependency); }
            set { SetValue(MaxlenDependency, value); }
        }


    }
}
