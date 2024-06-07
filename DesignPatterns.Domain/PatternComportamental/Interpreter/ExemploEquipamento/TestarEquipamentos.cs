using DesignPatterns.Domain.PatternComportamental.Interpreter.ExemploEquipamento.Armas;
using DesignPatterns.Domain.PatternComportamental.Interpreter.ExemploEquipamento.Prefixos;
using DesignPatterns.Domain.PatternComportamental.Interpreter.ExemploEquipamento.Sulfixos;

namespace DesignPatterns.Domain.PatternComportamental.Interpreter.ExemploEquipamento
{
    public class TestarEquipamentos
    {
        public void TestaEquip()
        {
            List<IPrefixo> prefixos = new(){
                new AumentarAtaque(10)

            };

            List<ISulfixo> sulfixos = new(){
                new VelocidadeDeAtaque(0.5M)
            };

            var espadaCurta = new EspadaCurta("Sabre", 10, 1.2M);
            var aplicaAfixos = new AplicaAfixos(prefixos, sulfixos);
            aplicaAfixos.CarregarAfixos(espadaCurta);
        }
    }
}