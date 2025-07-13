# Projeto: Bloco de Notas com Login (EM ANDAMENTO)

<br/>

## Sobre o Projeto
Este é um projeto pessoal de um aplicativo para criar Anotações ou Tarefas, juntamente com um Login/Cadastro para cada usuário ter seu acesso. Estou desenvolvendo para aprender e praticar os seguintes conceitos:

- Criação de interfaces gráficas com Windows Forms;
- Validação de login e cadastro de usuários utilizando banco de dados;
- Integração com banco de dados usando o SQLite;
- Organização de notas e listas de tarefas (To-Do List);
- Desing UX/UI
- Uso de Rich Text Box para o usuário fazer formatação em textos
- E no futuro, estilização e funcionalidades extras na interface.

Apesar de ser um aplicativo simples, o planejei com o objetivo de aprender o máximo possível, combinando várias tecnologias e conceitos em um único projeto. 
O projeto está sendo feito no Visual Studio em linguagem C#.

<br/> <br/>

## O que já foi feito até o momento:
✅ Interface de login e cadastro integrada ao banco de dados (versão atual) <br/>
![telalogin1](https://github.com/user-attachments/assets/8944d187-d423-4086-96f6-43182f71071f)
![cadastro1](https://github.com/user-attachments/assets/f686fd94-c12f-44d1-b33b-f87e5ecdd316) <br/> <br/>

✅ Validação de login (verifica se o usuário existe no banco) e o cadastro salva os dados diretamente no banco de dados <br/>
✅ Notas e tarefas do usuário são armazenadas no banco de dados e exibidas quando ele acessa a opção correspondente no menu   <br/>
✅ Todas as opções na barra Menu funcionam corretamente <br/>
✅ O usuário agora tem acesso a seu perfil e pode alterar sua senha ou foto de perfil <br/>
✅ CRUD completo implementado <br/>
✅ Melhoria da Interface do aplicativo bloco de notas: 
* Bordas do Form arredondadas
* Menu deslizante
* Funcionalidade de seleção de tema pelo usuário
* O tema escolhido também é salvo no banco de dados de acordo com o ID de usuário, então o app sempre abre com o último tema que o usuário escolheu
* A foto do usuário aparece na barra Menu <br/>

✅ Edição avançada no bloco de notas com RichTextBox:
* Negrito, itálico e sublinhado aplicáveis ao texto selecionado
* Aumento e diminuição do tamanho da fonte
* Mudança de cor da fonte e marca-texto com escolha personalizada via paleta de cores
* Suporte ao atalho Ctrl+Z para desfazer alterações
* Interface intuitiva com botões funcionais simulando os recursos do Word
  <br/> 

---
## Video de demonstração:
https://github.com/user-attachments/assets/5c194b71-f063-45bc-86e6-308855cd1d54

---
<!-- resolução GIF 700 ou 800 -->
<br/> <br/>


## O que ainda será feito:
⭕ Coisas de segurança como: opção "esqueceu a senha?", limpeza da seção quando o usuário deslogar e validação de e-mail. <br/>
⭕ Com projeto pronto, gerar um .exe portátil para facilitar o uso sem necessidade de instalar dependências <br/>
