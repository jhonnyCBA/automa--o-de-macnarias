 // Método principal para rodar a automação
        public async Task ExecutarAutomacao()
        {
            while (true)
            {
                Console.WriteLine("Coletando dados e ajustando parâmetros...");
                AjustarIrrigacao();
                AjustarVelocidade();
                MonitorarCombustivel();
                VerificarObstaculos();
                AjustarProfundidadePlantio();
                Console.WriteLine("------");

                // Atualiza a cada 5 segundos
                await Task.Delay(5000);
            }
        }
