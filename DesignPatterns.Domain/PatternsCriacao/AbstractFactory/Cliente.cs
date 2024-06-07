using DesignPatterns.Domain.PatternsCriacao.AbstractFactory.Enums;

namespace DesignPatterns.Domain.PatternsCriacao.AbstractFactory
{
    public class Cliente
    {
        public void ConsultarRotinaAluno()
        {
            IFactory? factory;

            var continuar = true;
            while (continuar)
            {
                System.Console.WriteLine("**********************************");
                System.Console.WriteLine("Selecione a rotina de treino: ");
                System.Console.WriteLine("1 - Segunda e Quinta-feira");
                System.Console.WriteLine("2 - Terca e Sexta-feira");
                System.Console.Write("3 - Quarta e Sabado:\t");
                var opt = int.Parse(Console.ReadLine()!);

                System.Console.WriteLine("**********************************");
                switch ((DiaDaSemana)opt)
                {
                    case DiaDaSemana.SegundaQuinta:
                        factory = new SegundaQuintaFactory();
                        break;
                    case DiaDaSemana.TercaSexta:
                        factory = new TercaSextaFactory();
                        break;
                    case DiaDaSemana.QuartaSabado:
                        factory = new QuartaSabadoFactory();
                        break;
                    default:
                        break;
                }
                System.Console.WriteLine("**********************************");
                System.Console.WriteLine("Deseja ver outra rotina ??");
                System.Console.Write("Sim[1] Nao[2]:\t");

                var resp = int.Parse(Console.ReadLine()!);
                if (resp == 2)
                {
                    continuar = false;
                }
            }

        }
    }
}