# Movidesk.LGPD
Serviço para controle de aceite dos termos de uso do pelo usuário do Movidesk.

Atualmente existem três endpoints: um para verificar se o usuário já aceitou os termos,
outro para salvar o aceite e outro para listar todos os usuários que aceitaram os termos 
e o histórico de aceites, pois é necessário aceitar novamente se o nome ou o código de 
referência do usuário mudarem.

FF para deixar esses endpoints acessíveis:
https://unleash.app.movidesk.com/#/features/strategies/use-lgpd

Documentação dos endpoints via swagger:
http://localhost:5001/swagger

Job do Jenkins para Deploy
https://deploy.movidesk.com/job/Movidesk.LGPD

Hosts
- Homologação: 
    - https://lgpd.app.movidesktest.com
- Produção: 
    - https://lgpd.app.movidesk.com
