 // Método para exibir o histórico de ações realizadas pela máquina
        public void ExibirHistorico()
        {
            Console.WriteLine("Histórico de Ações:");
            foreach (var acao in _historicoAcoes)
            {
                Console.WriteLine(acao);
            }
        }
    }