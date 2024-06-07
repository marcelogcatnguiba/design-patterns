using DesignPatterns.Domain.PatternComportamental.Interpreter.ExemploEquipamento.Armas;

namespace DesignPatterns.Domain.PatternComportamental.Interpreter.ExemploEquipamento.Sulfixos
{
    public class VelocidadeDeAtaque : ISulfixo
    {
        private decimal _valorAumento;

        public VelocidadeDeAtaque(decimal valorAumento)
        {
            _valorAumento = valorAumento;
        }

        public void CarregarAfixos(Espada espada)
        {
            espada.Afixo += $"\n[S] - Aumenta velocida de ataque em {_valorAumento}";
            espada.VelocidadeAtaque += _valorAumento;
        }
    }
}