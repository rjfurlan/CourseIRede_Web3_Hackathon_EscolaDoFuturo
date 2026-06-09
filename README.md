# ⚠ Disclaimer

## THE PROJECT IS PROVIDED "AS IS", USE AT YOUR OWN RISK
## O PROJETO É FORNECIDO "COMO ESTÁ", USE POR SUA CONTA E RISCO

This project was developed for educational purposes as part of the VR Metaverse course activity from the Web3 program taught by IRede, with the objective of demonstrating concepts learned during the course.

**Third-Party Assets:** Some elements of this project, including textures, 3D models, sounds and other assets, were obtained from third parties. Their respective authors, licenses, and source links are credited throughout this repository.  

[THIRD_PARTY_NOTICES.md](./THIRD_PARTY_NOTICES.md)  
[THIRD_PARTY_NOTICES.html](./THIRD_PARTY_NOTICES.html)
  
  

---
---
# Escola do Futuro
Autor: Ricardo Jorge Furlan  
Data: 09/06/2026  
Atividade: Hackathon  
Cursos: Meta verso - Web3 - IRede

---

## Links relevantes  

[Vídeo do Pitch do projeto]()   
[Vídeo com apresentação funcional do projeto](https://youtu.be/t6te20IFsSU)    
[Arquivo da apresentação do Pitch]()   
[Página de acesso ao aplicativo](
https://rjfurlan.github.io/CourseIRede_Web3_Hackathon_EscolaDoFuturo/)  
[Repositório do projeto](https://github.com/rjfurlan/CourseIRede_Web3_Hackathon_EscolaDoFuturo)

## Sobre o Projeto

Escola do Futuro é uma experiência educacional imersiva desenvolvida em Unity WebGL como parte do Hackathon do Curso Web3.

O projeto explora o uso de ambientes tridimensionais interativos para tornar o aprendizado mais envolvente e intuitivo. Em vez de consumir conteúdo apenas através de textos, vídeos ou apresentações tradicionais, o estudante pode explorar salas temáticas e interagir com elementos do ambiente para descobrir novos conteúdos.

A proposta busca demonstrar como tecnologias de ambientes virtuais e experiências imersivas podem ser utilizadas para complementar o processo educacional.

---

# Problema

Grande parte das experiências educacionais digitais atuais é baseada em conteúdos estáticos ou pouco interativos.

Isso pode gerar:

* baixo engajamento dos estudantes;
* dificuldade de manter a atenção;
* pouca exploração ativa do conteúdo;
* experiências de aprendizagem pouco memoráveis.

Além disso, conteúdos complexos muitas vezes são apresentados apenas através de textos ou vídeos, dificultando a contextualização visual dos temas estudados.

---

# Solução Proposta

A Escola do Futuro apresenta uma escola virtual composta por um ambiente central e salas temáticas interativas.

O estudante pode navegar livremente pelo ambiente e escolher quais temas deseja explorar.

Cada sala apresenta conteúdos específicos através de:

* objetos tridimensionais;
* elementos visuais;
* sons temáticos;
* painel interativo.

Essa abordagem transforma o aluno em participante ativo da experiência de aprendizagem.

---

# Experiência Criada

Ao iniciar a aplicação, o usuário é recebido no lobby principal da Escola do Futuro.

O lobby funciona como um hub central de navegação e contém três salas temáticas.

Cada sala possui identidade visual própria representada por cores específicas:

* Azul: Motores
* Vermelho: Corpo Humano
* Verde: Aeronaves

Ao entrar em uma sala, o estudante encontra:

* Um painel interativo com as atividades propostas;
* um pedestal a onde será mostrado o objeto a ser explorado.

Quando uma atividade é selecionada:

* o item escolhido é destacado visualmente;
* um objeto temático é exibido sobre um pedestal;
* um som característico é reproduzido.

O estudante pode retornar ao lobby a qualquer momento e explorar outras áreas da escola.

---

# Tecnologias Utilizadas

* Unity
* Unity WebGL
* C#
* TextMesh Pro
* GitHub
* GitHub Pages

---

# Estrutura do Projeto

O projeto é composto por quatro cenas:

## Lobby

Ambiente principal da aplicação.

Responsável pela navegação para as demais salas.

## Sala de Aeronaves

Conteúdo relacionado a diversos tipos de aeronaves.

## Sala do Corpo Humano

Conteúdo relacionado a partes do corpo humano.

## Sala de Moteres

Conteúdo relacionado à diversos tipos de motores.

---

# Controles

## Movimentação

Pressione o botão direito do mouse e mova o mouse para deslocar o personagem.

## Rotação

Pressione o botão do meio do mouse e mova o mouse para:

* girar o personagem para esquerda e direita;
* movimentar a visão para cima e para baixo.

## Interação

Posicione o cursor sobre uma atividade e clique com o botão esquerdo do mouse.

## Zoom

Utilize a roda de rolagem do mouse para ajustar o campo de visão da câmera.

## Navegação entre salas

Para entrar ou sair de uma sala, basta atravessar a porta correspondente.

---

# Como Executar

## Acesso Online

A aplicação pode ser acessada diretamente através do GitHub Pages.  
[Página de acesso ao aplicativo](
https://rjfurlan.github.io/CourseIRede_Web3_Hackathon_EscolaDoFuturo/)  

Basta abrir o endereço disponibilizado pelo projeto e clicar em "Iniciar Escola do Futuro".

---

## Execução Local

1. Clone o repositório:

```bash
git clone <URL_DO_REPOSITORIO>
```

2. Abra o projeto utilizando a versão do Unity 6.3 LTS (6000.3.13f1).

3. Mude para a cena inicial do projeto: Lobby

4. Faça o switch do profile para Web-Desktop-Release

5. Gere o novo Build ou rode direto da IDE.

---

# Público-Alvo

* estudantes do ensino médio;
* instituições de ensino;
* eventos educacionais;
* feiras de profissões;
* projetos de aprendizagem imersiva.

---

# Possíveis Evoluções Futuras

* novas salas temáticas;
* conteúdos educacionais adicionais;
* integração com inteligência artificial;
* trilhas de aprendizagem personalizadas;
* acompanhamento de progresso dos estudantes;
* suporte a dispositivos XR e realidade virtual.

---

# Licenças e Créditos

Este projeto utiliza alguns assets de terceiros.

Consulte o arquivo:

THIRD_PARTY_LICENSES.md

para obter informações detalhadas sobre licenças, autores e atribuições.

---

# Hackathon Web3

Projeto desenvolvido para demonstrar o potencial de ambientes imersivos na educação digital através de tecnologias Web3, ambientes 3D e experiências interativas.

Uma sugestão adicional: no topo do README coloque uma imagem (`screenshot`) do lobby da escola. Em projetos de Unity/WebGL isso costuma aumentar bastante a percepção de qualidade do repositório.

---

# Uso de Inteligência Artificial

Durante o desenvolvimento deste projeto foram utilizadas ferramentas de Inteligência Artificial como apoio ao processo de desenvolvimento.

A IA foi utilizada para:

- auxílio na redação e revisão de textos da documentação;
- esclarecimento de dúvidas relacionadas à configuração do ambiente de desenvolvimento;
- orientação sobre boas práticas de documentação de licenças de terceiros;
- consulta sobre funcionalidades, componentes e recursos disponíveis na Unity.

A concepção da solução, definição da arquitetura, implementação dos scripts, integração dos componentes, configuração do ambiente virtual, seleção dos assets, testes e validação do projeto foram realizados pelo autor.

As ferramentas de IA foram utilizadas como recurso de suporte técnico e documental, de forma semelhante à consulta de documentação, fóruns especializados e materiais de referência.
