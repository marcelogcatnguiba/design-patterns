﻿#region Bridge

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

// using DesignPatterns.Domain.PatternComportamental.Interpreter.ExemploEquipamento;

// var teste = new TestarEquipamentos();
// teste.TestaEquip();

#endregion

#region Flyweight

// using DesignPatterns.Domain.PatternsEstruturais.Flyweight;

// var client = new Cliente();
// client.ConsumirFlyweight();

#endregion

#region Template

// using DesignPatterns.Domain.PatternComportamental.Template;

// var client = new ClienteTemplate();
// var comando = args[0];

// switch(comando)
// {
//     case "xml":
//         client.ConsumirEndpointXML();
//         break;

//     case "json":
//         client.ConsumirEndpointJSON();
//         break;

//     default:
//         System.Console.WriteLine("Comando invalido !!");
//         break;
// }

#endregion

#region Facade
// using DesignPatterns.Domain.PatternsEstruturais.Facade;

// ClientFacade.ConsumirComplexidade();

#endregion

#region Command

// using DesignPatterns.Domain.PatternComportamental.Command;

// var client = new Client();

// client.FalarComandos();

#endregion

#region Visitor

// using DesignPatterns.Domain.PatternComportamental.Visitor;
// using DesignPatterns.Domain.PatternComportamental.Visitor.Produtos;

// List<ProdutoPerecivel> produtoPerecivels =
// [
//     new("Especiarias", 2500),
//     new("Poupas de frutas", 2000)
// ];

// List<ProdutoNaoPerecivel> produtoNaoPerecivels = 
// [
//     new("Antena WiFi", 500),
//     new("Perfume frances", 1000)
// ];

// Fiscal.CalcularImpostos(produtoPerecivels, produtoNaoPerecivels);

#endregion

#region Strategy

// using DesignPatterns.Domain.PatternComportamental.Strategy;

// RotinaTaxaServicos.ExecutarRotina();

#endregion

#region Chain

using System.Transactions;
using DesignPatterns.Domain.PatternComportamental.ChainOfResponsability;

// var sender = new Sender();

// sender.RealizarCheckout();

#endregion

#region Iterator

// using DesignPatterns.Domain.PatternComportamental.Iterator;

// Cliente.ConsumirEstrutura();

#endregion

#region Memento

// using DesignPatterns.Domain.PatternComportamental.Memento;

// Videocassete.ExecutarAcaoVideo();

#endregion

#region Mediator

using DesignPatterns.Domain.PatternComportamental.Mediator;

Chat.Conversar();

#endregion