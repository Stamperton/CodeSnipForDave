using System;

public class Class1
{


    private void ReadChat()
    {
        //Message with Chat Message
        //@badge-info=;badges=bits/1;client-nonce=a9cbd830d6f7a82c85cf7635503acdfe;color=;display-name=stream_quest;emotes=;flags=;id=f1242a98-8b32-4b3a-a37b-eb00a4b320eb;mod=0;room-id=467851035;subscriber=0;tmi-sent-ts=1609338128008;turbo=0;user-id=617701625;user-type= :stream_quest!stream_quest@stream_quest.tmi.twitch.tv PRIVMSG #richardstampdev :testplz

        //Message with bits
        //@badge-info=;badges=bits/1;bits=1;color=;display-name=stream_quest;emotes=;flags=;id=2ad08bf1-76fe-4b56-806d-3a0b7cefc9f1;mod=0;room-id=467851035;subscriber=0;tmi-sent-ts=1609338163358;turbo=0;user-id=617701625;user-type= :stream_quest!stream_quest@stream_quest.tmi.twitch.tv PRIVMSG #richardstampdev :Cheer1

        if (twitchClient.Available > 0)
        {
            var message = reader.ReadLine();

            Debug.Log(message);

            if (message.Contains("PRIVMSG"))
            {
                var splitPoint = message.IndexOf("!", 1);
                var chatName = message.Substring(0, splitPoint);
                chatName = chatName.Substring(1);

                splitPoint = message.IndexOf(":", 1);
                message = message.Substring(splitPoint + 1);

                //timerRunning = true;

                GetChatInputs(message);
                //Debug.Log(message);
            }

            if (message.Contains(";bits="))
            {
                Debug.LogError("BITS!");

                //TODO Parse String Not Like an Idiot

            }
        }
    }

}
