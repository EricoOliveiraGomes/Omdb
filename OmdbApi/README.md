# OmdbWorkerService
# OmdbWorkerService

    • Visão geral da solução.
    

    Api com um método GET simples que acesso os dados gravados previamente no arquivo de banco de dados do SQLite e retorna os dados em formato JSON 
    
    • Instruções exatas de como rodar o projeto.

    Na barra de ferramentas do Visual Studio 2026, clicar no botão com a seta para baixo, ao lado da seta verde, e selecionar a opçõ omde está escrito "IIS Express" 
    Quando abrir o navegador, colocar "Omdb" no final do endereço e dar enter

    • Decisões arquiteturais tomadas.

    Utilizei um modelo do visual studio para ter já uma estrutura base simples de uma API com apenas um método GET para trazer os dados do arquivo de banco de dados do SQLite.
    Também utilizei abordagem simples para consultar os dados no banco de dados.

    • O que você melhoraria se tivesse mais tempo.

    Faria a parte do docker. Não foi possível fazer essa parte pois está com algum problema que não carregava e não consegui identificar e resolver o problema a tempo
    Criaria métodos diversos para filtrar os dados oriundos do json gravado no banco
    Faria uma estrutura mais arrojada com entity framework 