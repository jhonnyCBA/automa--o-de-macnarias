// Classe que representa a máquina agrícola inteligente
    public class MaquinaAgricolaInteligente
    {
        private Sensor _sensor;
        private List<string> _historicoAcoes;

        public MaquinaAgricolaInteligente()
        {
            _sensor = new Sensor();
            _historicoAcoes = new List<string>();
        }