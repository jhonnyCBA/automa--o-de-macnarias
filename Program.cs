class Program
    {
        static async Task Main(string[] args)
        {
            MaquinaAgricolaInteligente maquina = new MaquinaAgricolaInteligente();
            await maquina.ExecutarAutomacao();

            // Opcional: Exibir o histórico de ações ao encerrar o programa
            maquina.ExibirHistorico();
        }
    }
}
