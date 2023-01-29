using System;
using System.CodeDom;
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

namespace VSIXProject1.MVVM.View
{
    /// <summary>
    /// Interaction logic for DocumentingView.xaml
    /// </summary>
    public partial class DocumentingView : UserControl
    {
        public DocumentingView()
        {
            InitializeComponent();
        }
        private void TextBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effects = DragDropEffects.Copy;
        }
        private void TextBox_Drop(object sender, DragEventArgs e)
        {
            TextRange textRange = new TextRange(CodeBox.Document.ContentStart, CodeBox.Document.ContentEnd);
        }
    }
}
