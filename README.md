# Trabalhar com arquivos e diretórios em um aplicativo .NET

Projeto desenvolvido com objetivo de estudo. Guiado pelo roteiro de estudo em [docs.microsoft.com/learn](https://docs.microsoft.com).

## Objetivos de aprendizagem

- Trabalhar com diretórios.
- Criar e excluir arquivos.
- Fazer a leitura dos arquivos.
- Gravar em arquivos.
- Análise de dados nos arquivos.

## Pontos a considerar

- `Directory.EnumerateDirectories` e `Directory.EnumerateFiles` aceitam um parâmetro que habilita a especificação de um critério de pesquisa para os nomes a serem retornados e um parâmetro para percorrer recursivamente todos os diretórios filho.

- `System.Environment.SpecialFolder` é uma enumeração que habilita o acesso às pastas definidas pelo sistema, como a área de trabalho ou o perfil do usuário, multiplataforma, sem ter que memorizar o caminho exato em cada sistema operacional. 
