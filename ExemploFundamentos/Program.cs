using ExemploFundamentos.Common.Models;

//Instância da Classe Pessoa
Pessoa p = new Pessoa();

//Atribui o nome e idade para a pessoa
p.Nome = "Miguel";
p.Idade = 18;

//Faz a pessoa se apresentar
p.Apresentar();


Calculadora c = new Calculadora();
c.Somar(15, 10);

















// List<string> listaString = new List<string>();
// listaString.Add("SP");
// listaString.Add("BA");
// listaString.Add("MG");
// listaString.Add("RJ");

// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// listaString.Add("SC");

// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// listaString.Remove("MG");

// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

























// Console.WriteLine("Percorrendo lista com for");
// for(int contador = 0; contador < listaString.Count; contador++)
// {
//     Console.WriteLine($"Posição N {contador} - {listaString[contador]}");
// }

// Console.WriteLine("Percorrendo lista com foreach");
// int contadorForeach = 0;
// foreach(string item in listaString)
// {
//     Console.WriteLine($"Posição N {contadorForeach} - {item}");
//     contadorForeach++;
// }




























// int[] arrayInteiros = new int[3];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 74;
// arrayInteiros[2] = 50; 

// int[] arrayInteirosDobrados = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrados, arrayInteiros.Length);

// // Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// Console.WriteLine("Percorrendo array com for");
// for (int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição N {contador} - {arrayInteiros[contador]}");
// }



// int contadorForeach = 0;
// Console.WriteLine("Percorrendo array com foreach");
// foreach(int valor in arrayInteiros)
// {
//     Console.WriteLine($"Posição N {contadorForeach} - {valor}");
//     contadorForeach++;
// }







// Pessoa pessoa1 = new Pessoa();
// pessoa1.Nome = "Buta";
// pessoa1.Idade = 18;
// pessoa1.Apresentar();







// string? opcao;
// bool exibirMenu = true;

// while (exibirMenu){
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção");
//     Console.WriteLine("1 - Cadastrar Cliente");
//     Console.WriteLine("2 - Buscar Cliente");
//     Console.WriteLine("3 - Apagar Cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch (opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro do Cliente");
//             break;
//         case "2":
//             Console.WriteLine("Busca de Cliente");
//             break;
//         case "3":
//             Console.WriteLine("Apaga Cliente");
//             break;
//         case "4":
//             Console.WriteLine("Encerrar");
//             exibirMenu = false;
//             // Environment.Exit(0);
//             break;
//         default:
//             Console.WriteLine("Opção Inválida");
//             break;
//     }
// }

// Console.WriteLine("O programa se encerrou");












// int soma = 0, numero = 0;

// do {
//     Console.WriteLine("Digite um número (0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma +=numero;

// } while (numero != 0);

// Console.WriteLine($"Total da soma dos número digitados é: {soma}");


















// int numero = 5;
// int contador = 0;


// while (contador <= 10)
// {
//     Console.WriteLine($"{numero} * {contador} = {numero * contador}");
//     contador++;

//     if (contador == 6)
//     {
//         break;
//     }
// }



























// int numero = 5;

// for(int contador = 0; contador <= 10000; contador++)
// {
//     Console.WriteLine($"{numero} * {contador} = {numero * contador}");
// }











// Calculadora calc = new Calculadora(); 

// calc.Somar(10, 30);
// calc.Subtrair(10, 50);
// calc.Multiplicar(15, 45);
// calc.Dividir(2, 2);
// calc.Potencia(3, 3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
// int numeroIncremento = 10;
// calc.RaizQuadrada(9);



// Console.WriteLine(numeroIncremento);

// Console.WriteLine("Incrementando o 10");
// numeroIncremento++;

// Console.WriteLine(numeroIncremento);

// int numeroDecremento = 20;
// Console.WriteLine("Decrementando o 20");
// numeroDecremento--;

// Console.WriteLine(numeroDecremento);







// bool choveu = false;
// bool tarde = false;

// if (!choveu && !tarde)
// {
//     Console.WriteLine("Vou pedalar");
// }
// else
// {
//     Console.WriteLine("Vou pedalar outro dia");
// }















// bool presencaMinima = true;
// double media = 7.5;

// if (presencaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado");
// } 
// else
// {
//     Console.WriteLine("Reprovado");
// }











// bool maiorIdade = true;
// bool autorizacaoDoResponsavel = false;

// if (maiorIdade || autorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada Liberada");
// } 
// else 
// {
//     Console.WriteLine("Entrada não libeerada");
// }












// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// switch(letra) 
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;
//     default:
//         Console.WriteLine("Não é uma vogal");
//         break;
// }












// //em estoque
// int quantidadeEmEstoque = 3;
// //que eu quero comprar
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade Compra: {quantidadeCompra}");
// Console.WriteLine($"É possível fazer a venda? {possivelVenda}");

// if (quantidadeCompra == 0) {
//     Console.WriteLine("Venda Inválida");
// } 
// else if (possivelVenda) {
//     Console.WriteLine("Venda realizada");
// } 
// else {
//     Console.WriteLine("Desculpe, não temos no estoque");
// }









// string a = "15";
// int b = 0;

// int.TryParse(a, out b);
// Console.WriteLine(b);



//int a = Convert.ToInt32("5");
// int a = int.Parse("5");
// int inteiro = 5;
// string a = inteiro.ToString();

// Console.WriteLine(a);


// int a = 10;
// int b = 20;
// int c = a + b;

// Console.WriteLine(c);

// c += 5; 
// DateTime dataAtual = DateTime.Now;
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));

// string apresentacao = "Olá, seja bem vindo";
// int quantidade = 1;
// double altura = 1.80;
// decimal preco = 1.80M;
// bool condicao = true;

// Console.WriteLine("O valor da variável apresentação é: " + apresentacao);
// Console.WriteLine("O valor da variável quantidade é: " + quantidade);
// Console.WriteLine("O valor da variável altura é: " + altura.ToString("0.00"));
// Console.WriteLine("O valor da variável preço é: " + preco);
// Console.WriteLine("O valor da variável condição é: " + condicao);

// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Miguel";
// pessoa1.Idade = 18;
// pessoa1.Apresentar();