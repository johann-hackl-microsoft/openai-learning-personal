# openai-learning-personal

Personal learning of OpenAI stuff. But nothing to hide here, therefore a public repo.

## Deal with package error

- Command: `dotnet add package Microsoft.SemanticKernel --version 1.2.0`
- Error: `Unable to resolve 'Microsoft.SemanticKernel (>= 1.2.0)' for 'net8.0'.` 
- Mitigation: `dotnet nuget add source "https://api.nuget.org/v3/index.json" --name "nuget.org"`

## Environment variables

Core settings like Azure OpenAI endpoint etc. are configured as environment variables using VSCode settings "terminal.integrated.env.windows" in $USERNAME\AppData\Roaming\Code\User\settings.json.
