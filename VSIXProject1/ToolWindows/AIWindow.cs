using Microsoft.VisualStudio.Imaging;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace VSIXProject1
{
    public class AIWindow : BaseToolWindow<AIWindow>
    {
        public override string GetTitle(int toolWindowId) => "AIWindow";

        public override Type PaneType => typeof(Pane);

        public override Task<FrameworkElement> CreateAsync(int toolWindowId, CancellationToken cancellationToken)
        {
            return Task.FromResult<FrameworkElement>(new AIWindowControl());
        }

        [Guid("95ca2af7-2fc8-4a99-9ae0-1cd70ffc3e4f")]
        internal class Pane : ToolWindowPane
        {
            public Pane()
            {
                BitmapImageMoniker = KnownMonikers.ToolWindow;
            }
        }
    }
}
