namespace DesignPatterns.Domain.PatternComportamental.Command.Receivers
{
    public class LuzLuminariaReceiver
    {
        private bool _estaLigada = false;
        private int _intensidade = 100;
        private int _padraoAumentoIntensidade = 20;

        public string GetEstadoLuminaria() => _estaLigada ? "Ligada" : "Desligada";

        public void LigarLuz()
        {
            if(_estaLigada)
            {
                System.Console.WriteLine("Luz já esta ligada");
                return;
            }
            
            _estaLigada = !_estaLigada;
            System.Console.WriteLine($"A luz esta {GetEstadoLuminaria()}");
        }

        public void DesligarLuz()
        {
            if(_estaLigada)
            {
                _estaLigada = !_estaLigada;
                System.Console.WriteLine($"A luz esta {GetEstadoLuminaria()}");
                return;
            }
            
            System.Console.WriteLine("Já esta desligada");
        }

        public void AumentarIntensidade()
        {
            if(!_estaLigada)
            {
                System.Console.WriteLine("Ação não permitidade");
                return;
            }

            if(_intensidade >= 0 && _intensidade < 100)
            {
                _intensidade += _padraoAumentoIntensidade;
                System.Console.WriteLine($"Intensidade aumentada em {_padraoAumentoIntensidade}%");
                System.Console.WriteLine($"Intensidade esta em {_intensidade}%");
                return;
            }

            System.Console.WriteLine($"Intensidade já esta em {_intensidade}%");
        }

        public void DiminuirIntensidade()
        {
            if(!_estaLigada)
            {
                System.Console.WriteLine("Ação não permitidade");
                return;
            }
            
            if(_intensidade >= 0 && _intensidade <= 100)
            {
                _intensidade -= _padraoAumentoIntensidade;
                System.Console.WriteLine($"Intensidade diminuida em {_padraoAumentoIntensidade}%");
                System.Console.WriteLine($"Intensidade esta em {_intensidade}%");
                return;
            }

            
        }
    }   
}