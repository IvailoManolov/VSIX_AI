using System.Linq;

namespace VSIXProject1
{
    [Command(PackageIds.MyCommand)]
    internal sealed class MyCommand : BaseCommand<MyCommand>
    {
        protected override async Task ExecuteAsync(OleMenuCmdEventArgs e)
        {
            var docView = await VS.Documents.GetActiveDocumentViewAsync();

            var selection = docView?.TextView.Selection.SelectedSpans;
        }
    }
}
