using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AltPresenter
{
    /// <summary>
    /// Interaction logic for AltButton.xaml
    /// </summary>
    public partial class AltButton : Button
    {
        #region Fields
        private static readonly DependencyProperty CornerRadiusProperty;
        #endregion

        #region Constructors
        static AltButton()
        {
            CornerRadiusProperty = DependencyProperty.RegisterAttached(nameof(CornerRadius), 
                typeof(CornerRadius), typeof(AltButton), new FrameworkPropertyMetadata(new CornerRadius(0)));
        }
        public AltButton()
        {
            InitializeComponent();
        }
        #endregion

        #region Properties
        public CornerRadius CornerRadius { get => (CornerRadius)GetValue(CornerRadiusProperty); set { SetValue(CornerRadiusProperty, value); }}
        #endregion
    }
}
