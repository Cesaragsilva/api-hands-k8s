# Dicas

# Como rodar?
 - Execute o Docker compose dentro do repositório /src. Ex: docker-compose up -d
 - O Projeto está disponível em: http://localhost:5000/swagger e com um path de healthcheck http://localhost:5000/hc
 - O Portainer está disponível em: http://localhost:9000 (Configure seu usuário e senha)

# Links de Apoio
- [LogLevel](https://docs.microsoft.com/pt-br/aspnet/core/fundamentals/logging/?view=aspnetcore-6.0)
- [Tweelve Factor App](https://12factor.net/pt_br/)
- [OpenShift Developer sandbox](https://www.redhat.com/en/technologies/cloud-computing/openshift/try-it?extIdCarryOver=true&sc_cid=7013a000002pdO4AAI)

# ComandosDocker
- docker version - exibe a versão do docker.
- docker run NOME_DA_IMAGEM - cria um container com a respectiva imagem passada como parâmetro.
- docker run -d - Executa o processo em background
- docker run -d -P NOME_DA_IMAGEM - Executa o processo em background e libera Portas externas aleatorias do Container(Para acessar no computador local)
- docker run -d -P -name "NOMEContainer" NOME_DA_IMAGEM Executa o processo em background e libera Portas externas aleatorias do Container(Para acessar no computador - local) atribuindo o nome do container
- docker run -d -p 12345(Porta) -name "NOMEContainer" NOME_DA_IMAGEM Executa o processo em background e libera a Porta 12345 do Container(Para acessar no computador - local) atribuindo o nome do container
- docker run -d -p 12345(Porta) -e AUTHOR="Douglas Q" -name "NOMEContainer" NOME_DA_IMAGEM Executa o processo em background e libera a Porta 12345 do Container(Para - acessar no computador local) atribuindo uma varivel de ambiente chamada AUTHOR com o valor DOUGLAS Q e o nome do container
- docker port IDCONTAINER - Mosta o mapeamento das portas do Container
- docker ps - Exibe o Conteiner Ativos
- docker container ls - Exibe o Conteiner Ativos
- docker ps -a - Exibe os conteiners Ativos e Inativos
- docker run -it NOMFE_DA_IMAGE - Permite trabalhar dentro do Container
- exit - Permite Sair de "Dentro" Conteiner
- docker start -a -i ID_CONTEINER - Start no Container e já atacha o terminal do conteiner startado
- docker stop IDCONTAINER - Para o Container em 10 segundos (Default)
- docker stop -t 0 IDCONTAINER - Para o container em X tempo (0 é o tempo em segundos)
- docker rm idconteiner -Deleta conteiner 
- docker rmi IdImagem - Deleta a imagem
- docker container prune - Limpa todos os Containers Inativos
- docker run -v "CAMINHO_VOLUME" NOME_DA_IMAGEM - cria um volume no respectivo caminho do container.
- docker inspect ID_CONTAINER - retorna diversas informações sobre o container.
- hostname -i - mostra o ip atribuído ao container pelo docker (funciona apenas dentro do container).
- docker network create --driver bridge NOME_DA_REDE - cria uma rede especificando o driver desejado.
- docker run -it --name NOME_CONTAINER --network NOME_DA_REDE NOME_IMAGEM - cria um container especificando seu nome e qual rede deverá ser usada.
- docker run -d -p 6379:6379 --name redis_alpine --restart always redis:5.0.3-alpine - Inicia o container automaticamente quando o docker for reiniciado
- docker exec -i -t nginx-container /bin/bash - Acessa o terminal de um container que já está rodando.. docker exec -i -t "ID ou nome do container"
- docker rm $(docker ps -a -q) - remove todos os containers inativos
- docker rmi $(docker images ps -a -q) - remove todas as imagens inativas
 
