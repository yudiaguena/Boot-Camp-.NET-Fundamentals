Projeto realizado para o bootcamp .NET fundamentals.<br>
Como usar: Após clonar, navegue até a pasta pelo terminal e digite "dotnet run", será exibido a tela inicial:<br>
![inicio](https://user-images.githubusercontent.com/61215352/119916085-3a2d7c80-bf3a-11eb-85c5-982659292270.jpg)


A seta vermelha indica o menu para criar uma conta, digite 2 para começar a criar uma conta, siga os passos que irão aparecer,<br>
após criado a conta, você poderá digitar 1 como indicado na seta azul para listar as contas criadas ou testar as outras opções.<br>
![meio](https://user-images.githubusercontent.com/61215352/119287784-94b69800-bc1d-11eb-99c6-2b2ff1953638.jpg)

A seta amarela nos mostra que ao digitar 20, que é uma conta que não foi criada, irá vir acompanhada da mensagem de que a conta não existe e que irá retornar ao menu inicial.

Foi implementado o método verificar() para sacar, depositar ou transferir, que retorna para o menu iniciar ao verificar que não existe a conta solicitada, evitando que o programa DIO.BANK apresentasse "System.ArgumentOutOfRangeException" e finalizasse o programa.
