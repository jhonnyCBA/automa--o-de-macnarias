// Método para ajustar o nível de irrigação com base na umidade e na previsão do tempo
        public void AjustarIrrigacao()
        {
            double umidade = _sensor.ObterUmidadeSolo();
            string previsao = _sensor.PrevisaoTempo();
            string acao;

            if (umidade < 30 && previsao != "Chuvoso")
            {
                acao = "Irrigação ativada em nível alto.";
            }
            else if (umidade < 50 && previsao == "Ensolarado")
            {
                acao = "Irrigação ativada em nível médio.";
            }
            else
            {
                acao = "Irrigação desativada.";
            }
            
            Console.WriteLine(acao);
            _historicoAcoes.Add(acao);
        }
