# Caminhos Dourado Backend

Para executar esse aplicação pode se utilizar o docker, bastando executar

```cli
docker compose up -d --build
```

para que o build seja feito e a aplicação seja subida em 

* [http](http://localhost:8000/swagger/index.html)
* [https](https://localhost:8001/swagger/index.html)

simultaneamente será subido o banco de dados MS SQL Server e quando a aplicação for executada o banco será automaticamente criado sem nenhum dado.

para parar a execução utilize

```cli 
docker compose down --volumes
```