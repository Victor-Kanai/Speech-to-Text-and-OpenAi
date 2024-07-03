using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OpenAI;
using TMPro;

public class GptManager : MonoBehaviour
{
    private OpenAIApi openAI = new OpenAIApi(); 
    private List<ChatMessage> messages = new List<ChatMessage>();

    [SerializeField] TextMeshProUGUI textAi;
    
    public async void AskGpt(string question)
    {
        ChatMessage newMessage = new ChatMessage();

        newMessage.Content = question;
        newMessage.Role = "user";
        messages.Add(newMessage);

        CreateChatCompletionRequest request = new CreateChatCompletionRequest();
        request.Messages = messages;

        request.Model = "gpt-3.5-turbo";

        var response = await openAI.CreateChatCompletion(request);

        if(response.Choices != null && response.Choices.Count > 0)
        {
            var chatRespose = response.Choices[0].Message;

            messages.Add(chatRespose);

            textAi.text = chatRespose.Content;
        }
    }
}
