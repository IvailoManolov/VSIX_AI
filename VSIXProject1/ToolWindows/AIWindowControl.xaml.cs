using System.Windows;
using System.Windows.Controls;

namespace VSIXProject1
{
    public partial class AIWindowControl : UserControl
    {
        public AIWindowControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            VS.Commands.ExecuteAsync(PackageGuids.VSIXProject1, PackageIds.OpenAIWindow).FireAndForget();

        }

        private void RadioButton_Checked()
        {

        }
    }
}
