// Método para ajustar a velocidade do trator com base em condições do terreno
        public void AjustarVelocidade()
        {
            double umidade = _sensor.ObterUmidadeSolo();
            string acao;

            if (umidade > 80)
            {
                acao = "Terreno muito molhado, reduzindo a velocidade.";
            }
            else if (umidade < 20)
            {
                acao = "Terreno seco, aumentando a velocidade.";
            }
            else
            {
                acao = "Velocidade normal.";
            }
            
            Console.WriteLine(acao);
            _historicoAcoes.Add(acao);
        }
