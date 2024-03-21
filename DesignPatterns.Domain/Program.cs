#region Bridge

// using DesignPatterns.Domain.PatternsEstruturais.Bridge;
// using DesignPatterns.Domain.PatternsEstruturais.Bridge.Abstracao;
// using DesignPatterns.Domain.PatternsEstruturais.Bridge.Implementacao;

// ClienteBridge client;
// Random random;

// while (true)
// {
//     client = new ClienteBridge();
//     random = new Random();

//     if (random.Next(2) == 1)
//         client.Material = new CanetaEsferografica();
//     else
//         client.Material = new PincelMarcador();

//     if (random.Next(1, 3) == 1)
//         client.Material.CorImplementacao = new Azul();
//     else if (random.Next(1, 3) == 2)
//         client.Material.CorImplementacao = new Preto();
//     else
//         client.Material.CorImplementacao = new Vermelho();

//     client.ConsultaCorEstoque();

//     System.Console.WriteLine("Pressione <Enter> para continuar ou qualquer outra teclar para sair ...");
//     ConsoleKeyInfo key = Console.ReadKey();

//     if (key.KeyChar != 13)
//         break;
// }

#endregion

#region  Interpreter
// using DesignPatterns.Domain.PatternComportamental.Interpreter.Jumanji;

// var popUp = new ApresentaPopUp();
// popUp.ApresentarHabilidades();

using DesignPatterns.Domain.PatternComportamental.Interpreter.ExemploEquipamento;

var teste = new TestarEquipamentos();
teste.TestaEquip();

#endregion
