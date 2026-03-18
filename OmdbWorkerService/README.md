# OmdbWorkerService

    • Visão geral da solução.

    Worker que rida em background a cada dois minutos e acessa a API do OMDB para randomicamente buscar filmes, séries e episódios, e salvar em um arquivo de banco de dados do SQLite. A limitação de rodar a
    cada dois minutos é     devido à versão free da API do OMDB suportar no máximo 1000 requisições por dia

    • Instruções exatas de como rodar o projeto.

    Clicar no botão com a seta verde que está escrito "OmdbWorkerService" 

    • Decisões arquiteturais tomadas.

    Utilizei um modelo do visual studio para ter já uma estrutura base de um worker que roda em background. O caminho do banco de dados e a uri da API do OMDB estão configurados no appsettings.json

    • O que você melhoraria se tivesse mais tempo.

    Faria a parte do docker. Não foi possível fazer essa parte pois está com algum problema que não carregava e não consegui identificar e resolver o problema a tempo