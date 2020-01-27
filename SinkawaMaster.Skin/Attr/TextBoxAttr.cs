using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace SinkawaMaster.Skin.Attr
{
    public class TextBoxAttr : TextBox
    {

        public static readonly DependencyProperty MaxlenDependency =
            DependencyProperty.Register("Maxlen", typeof(int), typeof(TextBoxAttr), new PropertyMetadata(""));

        public int Maxlen
        {
            get { return (int)GetValue(MaxlenDependency); }
            set { SetValue(MaxlenDependency, value); }
        }


    }
}
