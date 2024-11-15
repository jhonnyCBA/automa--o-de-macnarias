// Método para detecção e resposta a obstáculos
        public void VerificarObstaculos()
        {
            bool obstaculo = _sensor.ObterDeteccaoObstaculo();
            string acao;

            if (obstaculo)
            {
                acao = "Obstáculo detectado! Parando a máquina.";
            }
            else
            {
                acao = "Sem obstáculos detectados.";
            }

            Console.WriteLine(acao);
            _historicoAcoes.Add(acao);
        }