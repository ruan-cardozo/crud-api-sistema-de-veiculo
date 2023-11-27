## Trabalho de Testes unitário aplicando TDD em um sistema básico de veículos -> 
#### Para Faculdade -> Grupo: Ruan Cardozo, Thiago Saraiva, João David
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
