// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
//
// Generated with Bot Builder V4 SDK Template for Visual Studio EchoBot v4.3.0

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using System;

namespace NotPatRichard.Bots
{
    public class EchoBot : ActivityHandler
    {
        //Bot Reply Message
        protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {
            //List of available pictures
            List<string> pics = new List<string>();
            pics.Add("https://validator.blob.core.windows.net/notpr/DXfFKYPVwAAQyKR.jpg");
            pics.Add("https://validator.blob.core.windows.net/notpr/DXiAkVaU0AAEn0i.jpg");
            pics.Add("https://validator.blob.core.windows.net/notpr/DXiVaJgU0AALjsU.jpg");
            pics.Add("https://validator.blob.core.windows.net/notpr/B1jCK0LCUAAOXTa.png");
            pics.Add("https://validator.blob.core.windows.net/notpr/B1swjNGIAAAjunG.png");
            pics.Add("https://validator.blob.core.windows.net/notpr/B1syv2TIUAAIxWo.jpg");
            pics.Add("https://validator.blob.core.windows.net/notpr/CQz4ng6WsAApwhJ.png");
            pics.Add("https://validator.blob.core.windows.net/notpr/CRx64_WWUAIoQV-.png");
            pics.Add("https://validator.blob.core.windows.net/notpr/CRxmXRkW0AA_3q3.png");
            pics.Add("https://validator.blob.core.windows.net/notpr/CS0jWkdWEAAnrcz.png");
            pics.Add("https://validator.blob.core.windows.net/notpr/CS0-yS1WoAAdHay.png");
            pics.Add("https://validator.blob.core.windows.net/notpr/CwrY1ITUAAA_VKX.jpg");
            pics.Add("https://validator.blob.core.windows.net/notpr/Cwsc9BLVIAABDjm.png");
            pics.Add("https://validator.blob.core.windows.net/notpr/CwwziSwUUAAEe6v.jpg");
            pics.Add("https://validator.blob.core.windows.net/notpr/DHR1iJEUQAARECD.jpg");
            pics.Add("https://validator.blob.core.windows.net/notpr/DHRnMdUWsAAOO8u.jpg");
            pics.Add("https://validator.blob.core.windows.net/notpr/DKqI5qMUIAEJy1_.jpg");
            pics.Add("https://validator.blob.core.windows.net/notpr/DXS8MxkU8AAF98G.jpg");
            pics.Add("https://validator.blob.core.windows.net/notpr/DXT6NhvUQAAtps3.jpg");
            pics.Add("https://validator.blob.core.windows.net/notpr/DXTbXPmUMAAAbSR.jpg");
            pics.Add("https://validator.blob.core.windows.net/notpr/DXTgzHAU8AAhw1c.jpg");
            pics.Add("https://validator.blob.core.windows.net/notpr/DXT-in1VoAAJo7X.jpg");
            pics.Add("https://validator.blob.core.windows.net/notpr/DXUjAw7UQAAr7LH.jpg");

            //Get Random Number
            Random random = new Random();
            int randomNumber = random.Next(0, 23);

            //Create Hero Card
            var card = new HeroCard
            {
                Title = "#NotPatRichard",
                Text = "Hi!  I'm working really hard on PowerShell scripts right now.  Here is a picture for you.",
                Images = new List<CardImage> { new CardImage(pics[randomNumber]) }
            };

            //Send Message
            await turnContext.SendActivityAsync(MessageFactory.Attachment(card.ToAttachment()), cancellationToken);
        }

        //Welcome Message
        protected override async Task OnMembersAddedAsync(IList<ChannelAccount> membersAdded, ITurnContext<IConversationUpdateActivity> turnContext, CancellationToken cancellationToken)
        {
            foreach (var member in membersAdded)
            {
                if (member.Id != turnContext.Activity.Recipient.Id)
                {
                    await turnContext.SendActivityAsync(MessageFactory.Text($"Welcome to the Not Pat Richard Bot!"), cancellationToken);
                }
            }
        }
    }
}
