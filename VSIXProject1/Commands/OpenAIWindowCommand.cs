using System.Linq;

namespace VSIXProject1
{
    [Command(PackageIds.OpenAIWindow)]
    internal sealed class OpenAIWindowCommand : BaseCommand<OpenAIWindowCommand>
    {
        protected override async Task ExecuteAsync(OleMenuCmdEventArgs e)
        {
            await AIWindow.ShowAsync();
        }
    }
}
