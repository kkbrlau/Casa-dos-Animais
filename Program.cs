using casa_dos_animais;

int opcao = 0;
List<AnimaisClasse> animaisLista = new List<AnimaisClasse>();
//Adicionando alguns animais na lista
animaisLista.Add(new AnimaisClasse
{
    AnimalSpecies = "Cachorro",
    AnimalID = 001,
    AnimalAge = "3 anos",
    AnimalPhysicalDescription = "Pelagem marrom, porte médio",
    AnimalPersonalityDescription = "Amigável e brincalhão",
    AnimalNickname = "Rex"
});

animaisLista.Add(new AnimaisClasse
{
    AnimalSpecies = "Gato",
    AnimalID = 002,
    AnimalAge = "2 anos",
    AnimalPhysicalDescription = "Pelagem preta, olhos verdes",
    AnimalPersonalityDescription = "Independente e curioso",
    AnimalNickname = "Mia"
});

animaisLista.Add(new AnimaisClasse
{
    AnimalSpecies = "Gato",
    AnimalID = 003,
    AnimalAge = "",
    AnimalPhysicalDescription = "",
    AnimalPersonalityDescription = "",
    AnimalNickname = ""

});

animaisLista.Add(new AnimaisClasse
{
    AnimalSpecies = "Cachorro",
    AnimalID = 004,
    AnimalAge = "",
    AnimalPhysicalDescription = "",
    AnimalPersonalityDescription = "",
    AnimalNickname = ""

});
while (opcao != 10)
{

    Console.WriteLine("Menu\n1 - Animais disponíveis\n2 - Adicionar novos animais\n3 - Remover animais\n4 - Verificar dados de idade e descrição física\n5 - Verificar dados de apelido e personalidade\n6 - Alterar a idade do animal\n7 - Alterar a descrição da personalidade do animal\n8 - Exibir todos os gatos\n9 - Exibir todos os cães\n10 - Sair do programa");
    Console.WriteLine("Informe a opcão desejada");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            foreach (var animal in animaisLista)
            {
                Console.WriteLine($"Espécie: {animal.AnimalSpecies}");
                Console.WriteLine($"ID: {animal.AnimalID}");
                Console.WriteLine($"Idade: {animal.AnimalAge}");
                Console.WriteLine($"Descrição Física: {animal.AnimalPhysicalDescription}");
                Console.WriteLine($"Descrição de Personalidade: {animal.AnimalPersonalityDescription}");
                Console.WriteLine($"Apelido: {animal.AnimalNickname}");
                Console.WriteLine();
            }
            break;

        case 2:
            int quantidadeDeAnimais;

            do
            {
                Console.WriteLine("Quantos animais você deseja adicionar");
                quantidadeDeAnimais = int.Parse(Console.ReadLine());

                if (quantidadeDeAnimais <= 0) Console.WriteLine("Digite uma quantidade válida");

                for (int i = 0; i < quantidadeDeAnimais; i++)
                {
                    Console.WriteLine("Infrmações\nDigite a espécie, o ID, a idade, a descrição física, a descrição de personalidade e o apelido");
                    animaisLista.Add(new AnimaisClasse
                    {
                        AnimalSpecies = Console.ReadLine(),
                        AnimalID = int.Parse(Console.ReadLine()),
                        AnimalAge = Console.ReadLine(),
                        AnimalPhysicalDescription = Console.ReadLine(),
                        AnimalPersonalityDescription = Console.ReadLine(),
                        AnimalNickname = Console.ReadLine()
                    });
                }
            } while (quantidadeDeAnimais <= 0);
            break;

        case 3:
            int auxiliar;
            string certeza;

            do
            {
                Console.WriteLine("Digite o ID do animal que você deseja remover: ");
                auxiliar = int.Parse(Console.ReadLine());
                Console.WriteLine("Você tem certeza? s -> sim e n -> não");
                certeza = Console.ReadLine().ToLower().Trim();

                if (certeza == "n")
                    Console.WriteLine($"Você digitou {certeza}");

                else
                {
                    bool animalEncontrado = false;
                    for (int i = 0; i < animaisLista.Count; i++)
                    {
                        if (animaisLista[i].AnimalID == auxiliar)
                        {
                            animaisLista.RemoveAt(i);
                            Console.WriteLine("Removendo...");
                            Console.WriteLine($"O animal com ID {auxiliar} foi removido com sucesso");
                            animalEncontrado = true;
                            break;
                        }
                    }

                    if (!animalEncontrado)
                    {
                        Console.WriteLine("ID não encontrado");
                    }
                }
            } while (certeza == "n");
            break;

        case 4:
            foreach (var animais in animaisLista)
            {
                if (animais.AnimalAge == "" && animais.AnimalPhysicalDescription == "")
                {
                    Console.WriteLine($"A idade e a descrição física do animal de ID {animais.AnimalID} estão vazias. Confira as informações do animal: ");
                    Console.WriteLine($"Espécie: {animais.AnimalSpecies}");
                    Console.WriteLine($"ID: {animais.AnimalID}");
                    Console.WriteLine($"Idade: {animais.AnimalAge}");
                    Console.WriteLine($"Descrição Física: {animais.AnimalPhysicalDescription}");
                    Console.WriteLine($"Descrição de Personalidade: {animais.AnimalPersonalityDescription}");
                    Console.WriteLine($"Apelido: {animais.AnimalNickname}");
                    Console.WriteLine();
                    Console.WriteLine("Por favor informar a idade e a descrição física: ");

                    animais.AnimalAge = Console.ReadLine();
                    animais.AnimalPhysicalDescription = Console.ReadLine();
                }

                else if (animais.AnimalAge == "")
                {
                    Console.WriteLine($"A idade do animal de ID {animais.AnimalID} está vazia. Confira as informações do animal: ");
                    Console.WriteLine($"Espécie: {animais.AnimalSpecies}");
                    Console.WriteLine($"ID: {animais.AnimalID}");
                    Console.WriteLine($"Idade: {animais.AnimalAge}");
                    Console.WriteLine($"Descrição Física: {animais.AnimalPhysicalDescription}");
                    Console.WriteLine($"Descrição de Personalidade: {animais.AnimalPersonalityDescription}");
                    Console.WriteLine($"Apelido: {animais.AnimalNickname}");
                    Console.WriteLine();
                    Console.WriteLine("Por favor informar a idade: ");

                    animais.AnimalAge = Console.ReadLine();
                }

                else if (animais.AnimalPhysicalDescription == "")
                {
                    Console.WriteLine($"A descrição física do animal de ID {animais.AnimalID} está vazia. Confira as informações do animal: ");
                    Console.WriteLine($"Espécie: {animais.AnimalSpecies}");
                    Console.WriteLine($"ID: {animais.AnimalID}");
                    Console.WriteLine($"Idade: {animais.AnimalAge}");
                    Console.WriteLine($"Descrição Física: {animais.AnimalPhysicalDescription}");
                    Console.WriteLine($"Descrição de Personalidade: {animais.AnimalPersonalityDescription}");
                    Console.WriteLine($"Apelido: {animais.AnimalNickname}");
                    Console.WriteLine();
                    Console.WriteLine("Por favor informar a descrição física: ");

                    animais.AnimalPhysicalDescription = Console.ReadLine();
                }

                else
                {
                    Console.WriteLine($"Os campos de idade e descrição física do animal com ID {animais.AnimalID} estão preenchidos");
                }
            }
            break;

        case 5:
            foreach (var animais in animaisLista)
            {
                if (animais.AnimalNickname == "" && animais.AnimalPersonalityDescription == "")
                {
                    Console.WriteLine($"O apelido e a descrição de personalidade do animal de ID {animais.AnimalID} estão vazios. Confira as informações do animal: ");
                    Console.WriteLine($"Espécie: {animais.AnimalSpecies}");
                    Console.WriteLine($"ID: {animais.AnimalID}");
                    Console.WriteLine($"Idade: {animais.AnimalAge}");
                    Console.WriteLine($"Descrição Física: {animais.AnimalPhysicalDescription}");
                    Console.WriteLine($"Descrição de Personalidade: {animais.AnimalPersonalityDescription}");
                    Console.WriteLine($"Apelido: {animais.AnimalNickname}");
                    Console.WriteLine();
                    Console.WriteLine("Por favor informar o apelido e a descrição de personalidade: ");

                    animais.AnimalNickname = Console.ReadLine();
                    animais.AnimalPersonalityDescription = Console.ReadLine();
                }

                else if (animais.AnimalNickname == "")
                {
                    Console.WriteLine($"O apelido do animal de ID {animais.AnimalID} está vazio. Confira as informações do animal: ");
                    Console.WriteLine($"Espécie: {animais.AnimalSpecies}");
                    Console.WriteLine($"ID: {animais.AnimalID}");
                    Console.WriteLine($"Idade: {animais.AnimalAge}");
                    Console.WriteLine($"Descrição Física: {animais.AnimalPhysicalDescription}");
                    Console.WriteLine($"Descrição de Personalidade: {animais.AnimalPersonalityDescription}");
                    Console.WriteLine($"Apelido: {animais.AnimalNickname}");
                    Console.WriteLine();
                    Console.WriteLine("Por favor informar o apelido: ");

                    animais.AnimalNickname = Console.ReadLine();
                }

                else if (animais.AnimalPersonalityDescription == "")
                {
                    Console.WriteLine($"A descrição de personalidade do animal de ID {animais.AnimalID} está vazia. Confira as informações do animal: ");
                    Console.WriteLine($"Espécie: {animais.AnimalSpecies}");
                    Console.WriteLine($"ID: {animais.AnimalID}");
                    Console.WriteLine($"Idade: {animais.AnimalAge}");
                    Console.WriteLine($"Descrição Física: {animais.AnimalPhysicalDescription}");
                    Console.WriteLine($"Descrição de Personalidade: {animais.AnimalPersonalityDescription}");
                    Console.WriteLine($"Apelido: {animais.AnimalNickname}");
                    Console.WriteLine();
                    Console.WriteLine("Por favor informar a descrição de personalidade: ");

                    animais.AnimalPersonalityDescription = Console.ReadLine();
                }

                else
                {
                    Console.WriteLine($"Os campos de idade e descrição física do animal com ID {animais.AnimalID} estão preenchidos");
                }
            }
            break;

        case 6:
            Console.WriteLine("Digite o id do animal: ");
            auxiliar = int.Parse(Console.ReadLine());

            foreach (var animal in animaisLista)
            {
                if (auxiliar == animal.AnimalID)
                {
                    Console.WriteLine($"Você selecionou o animal com ID {animal.AnimalID} para ter a idade alterada");

                    Console.WriteLine("Digite a nova idade do animal: ");
                    animal.AnimalAge = Console.ReadLine();
                }
                else Console.WriteLine("ID não encontrado");
            }
            break;

        case 7:
            Console.WriteLine("Digite o id do animal: ");
            auxiliar = int.Parse(Console.ReadLine());

            foreach (var animal in animaisLista)
            {
                if (auxiliar == animal.AnimalID)
                {
                    Console.WriteLine($"Você selecionou o animal com ID {animal.AnimalID} para ter a descrição de personalidade alterada");

                    Console.WriteLine("Digite a nova idescrição de personalidade do animal: ");
                    animal.AnimalPersonalityDescription = Console.ReadLine();
                }
                else Console.WriteLine("ID não encontrado");
            }
            break;

        case 8:
            Console.WriteLine("Informações dos gatos: ");

            foreach (var gatos in animaisLista)
            {
                gatos.AnimalSpecies = gatos.AnimalSpecies.ToLower();
                if (gatos.AnimalSpecies == "gato")
                {
                    Console.WriteLine($"Espécie: {gatos.AnimalSpecies}");
                    Console.WriteLine($"ID: {gatos.AnimalID}");
                    Console.WriteLine($"Idade: {gatos.AnimalAge}");
                    Console.WriteLine($"Descrição Física: {gatos.AnimalPhysicalDescription}");
                    Console.WriteLine($"Descrição de Personalidade: {gatos.AnimalPersonalityDescription}");
                    Console.WriteLine($"Apelido: {gatos.AnimalNickname}"); 
                    Console.WriteLine();
                }
            }
            break;

        case 9:
            Console.WriteLine("Informações dos cachorros: ");

            foreach (var caes in animaisLista)
            {
                caes.AnimalSpecies = caes.AnimalSpecies.ToLower().Trim();
                if (caes.AnimalSpecies == "cachorro")
                {
                    Console.WriteLine($"Espécie: {caes.AnimalSpecies}");
                    Console.WriteLine($"ID: {caes.AnimalID}");
                    Console.WriteLine($"Idade: {caes.AnimalAge}");
                    Console.WriteLine($"Descrição Física: {caes.AnimalPhysicalDescription}");
                    Console.WriteLine($"Descrição de Personalidade: {caes.AnimalPersonalityDescription}");
                    Console.WriteLine($"Apelido: {caes.AnimalNickname}");
                    Console.WriteLine();
                }
            }
            break;

        case 10:
            Console.WriteLine("Saindo...");
            break;

        default:
            Console.WriteLine("Digite uma opção válida");
            break;
    }
}