using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;

namespace TestingBotApp
{
    public interface IDialogFlow : IDialog<object>
    {
        Task WelcomeAsync(IDialogContext context, IAwaitable<Message> argument);
        Task AlreadyNewAsync(IDialogContext context, IAwaitable<TestBotDialog.StartOptions> argument);
        //Task PolicyNumberAsync(IDialogContext context, IAwaitable<Message> argument);
        //Task AuthenicateClientAsync(IDialogContext context, IAwaitable<Message> argument);
        //Task ViewRenewFileClaimAsync(IDialogContext context, IAwaitable<Message> argument);
        //Task RenewAsync(IDialogContext context, IAwaitable<Message> argument);
        //Task RepeatAsync(IDialogContext context, IAwaitable<Message> argument);
        //Task DamageOrTheftAsync(IDialogContext context, IAwaitable<Message> argument);
        //Task TheftAsync(IDialogContext context, IAwaitable<Message> argument);
        //Task StoreTheftPicsAsync(IDialogContext context, IAwaitable<Message> argument);
        //Task DamageAsync(IDialogContext context, IAwaitable<Message> argument);
        //Task StoreDamagePicsAsync(IDialogContext context, IAwaitable<Message> argument);
    }
}