using System;
using System.Threading.Tasks;

namespace AgriculturaInteligente
{
    // Classe que simula a coleta de dados do sensor
    public class Sensor
    {
        public double ObterUmidadeSolo()
        {
            // Simulação de um valor de umidade do solo entre 0% e 100%
            return new Random().NextDouble() * 100;
        }

        public string PrevisaoTempo()
        {
            // Simulação da previsão do tempo (Ensolarado, Nublado, Chuvoso)
            string[] condicoes = { "Ensolarado", "Nublado", "Chuvoso" };
            return condicoes[new Random().Next(condicoes.Length)];
        }

        public double ObterNivelCombustivel()
        {
            // Simulação do nível de combustível, variando entre 0% e 100%
            return new Random().NextDouble() * 100;
        }

        public bool ObterDeteccaoObstaculo()
        {
            // Simulação de detecção de obstáculo (10% de chance de detectar)
            return new Random().Next(0, 10) < 1;
        }
    }