## Trabalho de Testes unitário aplicando TDD em um sistema básico de veículos -> 
#### Para Faculdade -> Grupo: Ruan Diego Velloso Cardozo, Thiago de freitas Saraiva, João Antonio David
![image](https://github.com/ruan-cardozo/crud-api-sistema-de-veiculo/assets/110867639/51399a5a-6332-47d8-ad5c-cc40252232ef)
## Critérios de aceite
#### Cliente
* Id não pode ser negativo - Garante que o identificador único do cliente não seja um número negativo, mantendo consistência nos IDs.
* Deve criar um cliente - Assegura que o sistema seja capaz de criar um novo registro de cliente quando solicitado.
* Nome não pode ser nulo ou vazio - Requer que o campo de nome do cliente seja preenchido e não esteja vazio.
* CPF não pode ser nulo ou vazio - Exige que o número de CPF (Cadastro de Pessoas Físicas) seja fornecido e não esteja vazio.
* CPF deve conter 11 caracteres - Estabelece que o CPF deve ter exatamente 11 caracteres para ser considerado válido.
* CNH não pode ser nulo ou vazio - Requer que o número da CNH (Carteira Nacional de Habilitação) seja fornecido e não esteja vazio.
* CNH deve conter 11 caracteres - Determina que o número da CNH deve ter exatamente 11 caracteres para ser considerado válido.
* RG deve conter 9 caracteres - Estabelece que o número do RG (Registro Geral) deve ter exatamente 9 caracteres para ser considerado válido.
* Telefone deve conter 11 ou 10 caracteres - Exige que o número de telefone tenha 11 ou 10 caracteres, dependendo do formato utilizado no país/região.
* Telefone não pode ser nulo ou vazio - Requer que o campo de telefone seja preenchido e não esteja vazio.
* RG não pode ser nulo ou vazio - Exige que o número do RG seja fornecido e não esteja vazio.
#### Veículo
* Placa não pode ser nula nem vazia - Requer que o campo da placa do veículo seja preenchido e não esteja vazio.
* Placa deve conter 7 caracteres - Estabelece que a placa do veículo deve ter exatamente 7 caracteres para ser considerada válida.
* Ano de fabricação não pode exceder 1900 - Estabelece um limite para o ano de fabricação dos veículos, impedindo que seja menor que 1900, o que ajudaria a evitar datas inválidas
* Quilometragem não pode ser menor que 0 - Garante que a quilometragem registrada para o veículo não seja negativa, o que seria inconsistente
* Número do Chassi não pode ser nulo nem vazio - Requer que o número do Chassi do veículo seja fornecido e não esteja vazio.
* Número do Chassi deve conter 11 caracteres - Determina que o número do Chassi do veículo deve ter exatamente 11 caracteres para ser considerado válido.
* Marca não pode ser nula nem vazia - Exige que o campo da marca do veículo seja preenchido e não esteja vazio.
* Modelo não pode ser nulo ou vazio - Requer que o campo do modelo do veículo seja preenchido e não esteja vazio.
#### Manutenção
* Deve criar uma manutenção - Assegura que o sistema seja capaz de criar um registro para uma atividade de manutenção quando solicitado.
* Motivo não pode ser nulo ou vazio - Requer que o campo do motivo da manutenção seja preenchido e não esteja vazio.
* Valor não pode ser menor que 0 - Garante que o valor associado à manutenção não seja um número negativo, mantendo a integridade dos dados financeiros.
* ID_aluguel não pode ser menor que 0 - Se estiver relacionado a um aluguel, o ID associado a esse aluguel não deve ser um número negativo.
* ID não pode ser menor que 0 - O identificador único da manutenção não deve ser um número negativo.
* Motivo deve ter entre 5 e 50 caracteres - Estabelece que o motivo da manutenção deve ter um comprimento entre 5 e 50 caracteres para garantir uma descrição adequada, mas não excessivamente longa.
#### Aluguel
* Deve criar um aluguel - Garante que o sistema seja capaz de criar um registro para um novo aluguel quando solicitado.
* Data de devolução não pode ser menor que a data de retirada - Impede que a data de devolução seja anterior à data de retirada, garantindo que o aluguel tenha um intervalo de tempo válido.
* Valor previsto não pode ser negativo - Garante que o valor estimado do aluguel não seja um número negativo, mantendo a integridade dos dados financeiros.
* Valor real não pode ser negativo - Assegura que o valor real do aluguel (caso já tenha sido pago ou registrado) não seja um número negativo.
* Km de devolução não pode ser menor que a km de retirada, e não pode ser negativo - Previne que a quilometragem registrada na devolução seja menor do que a quilometragem registrada na retirada do veículo, e também garante que ambas as quilometragens sejam números não negativos.
* Quantidade de litros de devolução não pode ser menor que a quantidade de litros de retirada - Evita que a quantidade de combustível registrada na devolução seja menor do que a quantidade registrada na retirada do veículo.
