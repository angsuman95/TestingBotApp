using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingBotApp
{
    [Serializable]
    public class TestBotDialog : IDialogFlow
    {
        private StartOptions startOptions;
        private IEnumerable<string> EOptions = Lists.Options;

        public async Task StartAsync(IDialogContext context)
        {
            context.Wait(WelcomeAsync);
        }

        public async Task WelcomeAsync(IDialogContext context, IAwaitable<Message> argument)
        {
            Message message = await argument;
            //await context.PostAsync(message.Text);

            //PromptDialog.Choice(
            //    context: context,
            //    resume: AlreadyNewAsync,
            //    options: Enum.GetValues(typeof(StartOptions)).Cast<StartOptions>().ToArray(),
            //    prompt: "Welcome to VAM Insurance Bot!!",
            //    retry: "I didn't understand. Please try again.");
            PromptDialog.Choice(
                context: context,
                resume: AlreadyNewAsync,
                options: EOptions,
                prompt: "Welcome to VAM Insurance Bot!!",
                retry: "I didn't understand. Please try again.");
        }

        public async Task AlreadyNewAsync(IDialogContext context, IAwaitable<string> argument)
        {
            string startOptions  = await argument;

            if (startOptions.Equals(StartOptions.Already))
            {
                await context.PostAsync("Enter your Policy Number: ");
                context.Wait(WelcomeAsync);
            }
            else
            {
                await context.PostAsync("Please visit out website www.abcde.com or call on XXXXX for more details." + "\n\n" + "Thank You!!" + "\n\n" + "Have a nice day!");
                context.Wait(WelcomeAsync);
            }
        }

        //public async Task PolicyNumberAsync(IDialogContext context, IAwaitable<object> result)
        //{
        //    throw new NotImplementedException();
        //}

        public enum StartOptions
        {
            Already,
            New
        }
    }
}
