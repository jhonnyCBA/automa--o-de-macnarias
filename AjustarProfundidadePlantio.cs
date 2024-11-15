 // Método para ajustar a profundidade de plantio com base no tipo de solo (simulado com umidade)
        public void AjustarProfundidadePlantio()
        {
            double umidade = _sensor.ObterUmidadeSolo();
            string acao;

            if (umidade > 70)
            {
                acao = "Profundidade de plantio ajustada para rasa devido ao solo úmido.";
            }
            else if (umidade < 30)
            {
                acao = "Profundidade de plantio ajustada para profunda devido ao solo seco.";
            }
            else
            {
                acao = "Profundidade de plantio em nível médio.";
            }

            Console.WriteLine(acao);
            _historicoAcoes.Add(acao);
        }
