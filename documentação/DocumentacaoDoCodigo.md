# Documentação - Sistema de Automação Inteligente para Maquinaria Agrícola

Este projeto em C# implementa um sistema de automação para maquinaria agrícola (por exemplo, um trator). A máquina ajusta automaticamente parâmetros como irrigação, velocidade, consumo de combustível, profundidade de plantio e responde à presença de obstáculos com base em dados simulados. Esse projeto visa simular o futuro da automação em equipamentos agrícolas, integrando conceitos de IoT e monitoramento inteligente.

## Estrutura do Projeto

### Classe `Sensor`

A classe `Sensor` é responsável por simular a coleta de dados do ambiente. Esses dados são utilizados pela classe `MaquinaAgricolaInteligente` para ajustar os parâmetros da máquina agrícola.

- **Métodos**:
  - `ObterUmidadeSolo()`: Retorna um valor aleatório entre 0% e 100% para simular a umidade do solo.
  - `PrevisaoTempo()`: Retorna uma condição climática simulada, podendo ser "Ensolarado", "Nublado" ou "Chuvoso".
  - `ObterNivelCombustivel()`: Simula o nível de combustível com um valor aleatório entre 0% e 100%.
  - `ObterDeteccaoObstaculo()`: Simula a detecção de um obstáculo com uma probabilidade de 10%.

### Classe `MaquinaAgricolaInteligente`

A `MaquinaAgricolaInteligente` é a principal classe do projeto, que gerencia as operações da máquina agrícola. Com base nos dados fornecidos pela classe `Sensor`, a máquina ajusta automaticamente suas operações.

- **Atributos**:
  - `_sensor`: Instância da classe `Sensor`, usada para obter os dados ambientais.
  - `_historicoAcoes`: Uma lista que armazena o histórico de ações executadas pela máquina para análise futura.

- **Métodos**:

  - `AjustarIrrigacao()`: Ajusta o nível de irrigação com base na umidade do solo e na previsão do tempo.
    - Ativa a irrigação em nível alto se a umidade do solo for inferior a 30% e a previsão não for "Chuvoso".
    - Ativa a irrigação em nível médio se a umidade for inferior a 50% e a previsão for "Ensolarado".
    - Desativa a irrigação em outros casos.

  - `AjustarVelocidade()`: Ajusta a velocidade da máquina com base na umidade do solo.
    - Reduz a velocidade se a umidade for superior a 80%, indicando um terreno muito molhado.
    - Aumenta a velocidade se a umidade for inferior a 20%, indicando um terreno seco.
    - Mantém a velocidade normal em outros casos.

  - `MonitorarCombustivel()`: Monitora o nível de combustível da máquina.
    - Emite um alerta se o nível de combustível for inferior a 20%.
    - Caso contrário, exibe o nível atual do combustível.

  - `VerificarObstaculos()`: Simula a detecção de obstáculos à frente da máquina.
    - Para a máquina caso um obstáculo seja detectado.
    - Indica que não há obstáculos em outros casos.

  - `AjustarProfundidadePlantio()`: Ajusta a profundidade de operação com base na umidade do solo, para otimizar o plantio de acordo com as condições do solo.
    - Ajusta para uma profundidade rasa se o solo estiver muito úmido (>70%).
    - Ajusta para uma profundidade profunda se o solo estiver seco (<30%).
    - Mantém uma profundidade média em outros casos.

  - `ExecutarAutomacao()`: Executa continuamente a automação, ajustando irrigação, velocidade, monitorando combustível, verificando obstáculos e ajustando a profundidade de plantio. É o método principal que roda em loop e atualiza os parâmetros da máquina a cada cinco segundos.

  - `ExibirHistorico()`: Exibe o histórico das ações realizadas pela máquina agrícola. Esse histórico é útil para análise futura e aprendizado de máquina.

### Classe `Program`

A classe `Program` é o ponto de entrada da aplicação. Ela inicializa a `MaquinaAgricolaInteligente` e executa o método `ExecutarAutomacao` de forma assíncrona, o que permite que a automação funcione continuamente.

- **Método `Main`**:
  - Cria uma instância de `MaquinaAgricolaInteligente`.
  - Chama `ExecutarAutomacao()` de forma assíncrona para iniciar a automação.
  - Opcionalmente, pode chamar `ExibirHistorico()` para exibir o histórico de ações ao encerrar o programa.

## Funcionalidades e Simulações

Este projeto demonstra um sistema agrícola inteligente que pode realizar as seguintes operações com base em dados simulados:

1. **Ajuste de Irrigação**: Configura automaticamente o nível de irrigação com base na umidade do solo e na previsão do tempo.
2. **Controle de Velocidade**: Ajusta a velocidade da máquina de acordo com a umidade do solo para otimizar o desempenho e evitar danos.
3. **Monitoramento de Combustível**: Verifica o nível de combustível e emite um alerta quando está baixo.
4. **Detecção de Obstáculos**: Simula um sistema de sensores para detectar obstáculos no caminho da máquina.
5. **Ajuste de Profundidade de Plantio**: Modifica a profundidade de plantio com base nas condições do solo.
6. **Registro Histórico**: Armazena um registro das ações executadas pela máquina, que pode ser utilizado para análises futuras.
