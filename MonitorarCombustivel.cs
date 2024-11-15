 // Método para monitorar e ajustar o uso do combustível
        public void MonitorarCombustivel()
        {
            double nivelCombustivel = _sensor.ObterNivelCombustivel();
            string acao;

            if (nivelCombustivel < 20)
            {
                acao = "Alerta: Nível de combustível baixo! Necessário reabastecimento.";
            }
            else
            {
                acao = $"Nível de combustível estável: {nivelCombustivel:F2}%";
            }

            Console.WriteLine(acao);
            _historicoAcoes.Add(acao);
        }