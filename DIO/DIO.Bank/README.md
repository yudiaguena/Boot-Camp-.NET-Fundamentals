Projeto realizado para o bootcamp .NET fundamentals.<br>
Como usar: Após clonar, navegue até a pasta pelo terminal e digite "dotnet run", será exibido a tela inicial:<br>
![inicio](https://user-images.githubusercontent.com/61215352/119287775-908a7a80-bc1d-11eb-9aab-c535276c7651.jpg)

A seta vermelha indica o menu para criar uma conta, digite 2 para começar a criar uma conta, siga os passos que irão aparecer,<br>
após criado a conta, você poderá digitar 1 como indicado na seta azul para listar as contas criadas ou testar as outras opções.<br>
![meio](https://user-images.githubusercontent.com/61215352/119287784-94b69800-bc1d-11eb-99c6-2b2ff1953638.jpg)

Foi implementado o método verificar() para sacar, depositar ou transferir, que retorna para o menu iniciar ao verificar que não existe a conta solicitada, evitando que o programa DIO.BANK apresentasse "System.ArgumentOutOfRangeException" e finalizasse o programa.
