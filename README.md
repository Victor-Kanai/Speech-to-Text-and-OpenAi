# Speech-to-Text-and-OpenAi

# *Eng:*

### Made for Unity
## Used Apis:
- [HuggingFaceApi](https://github.com/huggingface/unity-api) (Open Source): Speech to text recognition
- [OpenAi](https://github.com/srcnalt/OpenAI-Unity) (Depends on which model you use, Here are the [prices](https://openai.com/api/pricing/)): Chat Gpt

## How does it work?

First you need select your microphone with the `MicrophoneManager.cs`, after that you will record your speech  and when it stops recording it will automatically send it to the HuggingFace AI with the `SpeechManager.cs` and then your quenstios is sent to the ChatGpt via the `GptManager.cs`.

# *Pt/Br:*

### Feito para a Unity
## Apis utilizadas:
- [HuggingFaceApi](https://github.com/huggingface/unity-api) (Open Source): reconhecimento de voz e a transcreve
- [OpenAi](https://github.com/srcnalt/OpenAI-Unity) (depende do modelo que você irá utilizar, esta é a tabela de [preços](https://openai.com/api/pricing/)): Chat Gpt

## Como que funciona?

Primeiro tem que selecionar o microfone, com o `MicrophoneManager.cs`, depois grave a sua frase e automaticamente ao parar de gravar será enviada para a IA da HuggingFace com o `SpeechManager.cs` e por fim sua pergunta é enviada para o ChatGpt via `GptManager.cs`.
