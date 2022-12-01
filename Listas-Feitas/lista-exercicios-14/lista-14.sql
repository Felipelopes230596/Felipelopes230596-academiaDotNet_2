
--Crie o banco de dados empresa_db por meio do SQL Server Management Studio.

create database empresa_db

drop database empresa_db

--Nele, crie também as tabelas:

        --departamento(idDepartamento,nome,localizacao,orcamento)
       -- idDepartamento chave primária

        create table departamento(
        idDepartamento int not null identity,
        nome varchar (45) not null,
        localizacao varchar (35) not null,
        orcamento int not null,
        primary key (idDepartamento)
        ) 

        --empregado(idEmpregado,nome,idGerente,funcao,idDepartamento,dataAdmissao,salario,comissao)
        --idEmpregado chave primária 
        --idDepartamento referencia departamento 
        --idGerente referencia empregado

        create table empregado(
        idEmpregado int not null identity,
        nome varchar (45) not null,
        idGerente int,
        funcao varchar (20) not null,
        departamento_idDepartamento int not null,
        dataAdmissao date not null,
        salario int not null,
        comissao int,

        primary key (idEmpregado, departamento_idDepartamento),

        constraint idDepartamento
        FOREIGN KEY (departamento_idDepartamento)
        REFERENCES departamento (idDepartamento)
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,
        )

--Após, insere nas tabelas os seguintes valores:

--inserindo dados nas tabelas
INSERT INTO Departamento VALUES('Banco de Dados','Porto Alegre','2346');
INSERT INTO Departamento VALUES('Balconistas','Pelotas','10000');
INSERT INTO Departamento VALUES('Inteligência Artific','Pelotas','333');
INSERT INTO Departamento VALUES('Compiladores','Novo Hamburgo','5050');
INSERT INTO Departamento VALUES('Redes','Taquara','12122');

INSERT INTO Empregado VALUES('Mariewa',NULL,'Gerente','1','2000-04-05','2300','0');
INSERT INTO Empregado VALUES('Zico','1','Operário','1','1999-08-13','100','0');
INSERT INTO Empregado VALUES('Lula',NULL,'Presidente','5','1950-01-01','10000','0');
INSERT INTO Empregado VALUES('Luana Pyovany',NULL,'Gerente','2','1998-06-23','2300','0');
INSERT INTO Empregado VALUES('Vera Fixer','5','Balconista','2','1999-05-05','3300','0');
INSERT INTO Empregado VALUES('Daniela Schicarelli',NULL,'Gerente','3','1999-10-10','2300','0');
INSERT INTO Empregado VALUES('Luize Altenhofen',NULL,'Gerente','4','1999-04-26','2300','0');
INSERT INTO Empregado VALUES('Helo Pinheiro',NULL,'Gerente','5','1997-09-25','2300','0');
INSERT INTO Empregado VALUES('Pelé','1','Operário','1','2000-09-09','100',NULL);
INSERT INTO Empregado VALUES('Romário','1','Operário','5','2001-12-25','100','0');
INSERT INTO Empregado VALUES('Malu Mader','5','Balconista','2','2001-10-20','3400','0');
INSERT INTO Empregado VALUES('Antônio Fagundes','7','Vendedor','3','2002-12-22','5000','10');


--Finalmente, execute os comandos no shell do Management Studio:

-- Seleção de todos os campos (ou colunas) da tabela de Departamentos.
select *
from departamento;

            -- where
            --
            -- Operadores lógicos
            --
            -- operador significado
            -- =  igual a
            -- >  maior que
            -- >= maior que ou igual a
            -- <  menor que
            -- <= menor que ou igual a

select empregado.nome, empregado.dataAdmissao
from empregado
where empregado.salario >= 3300

select empregado.nome, empregado.funcao
from empregado
where empregado.funcao = 'vendedor'


-- Selecione todos os departamentos cujo orçamento mensal
--seja maior que 10000. Apresente o Nome de tal departamento
--e seu orçamento anual, que será obtido multiplicando-se o
--orçamento mensal por 12.

select departamento.nome, departamento.orcamento * 12 "Orçamento anual"
from departamento
where departamento.orcamento > 10000


-- Apresente a instrução anterior porém ao invés dos
--'feios' DepNome e DepOrca, os Títulos Departamento e Orçamento.

select departamento.nome "Departamento", departamento.orcamento * 12 "Orçamento"
from departamento
where departamento.orcamento > 10000


-- Apresente todos os cargos existentes na empresa,
-- porém omita eventuais duplicidades.

select distinct empregado.funcao
from empregado

-- Apresente os nomes e funções da cada funcionário contidos
--na tabela empregado, porém classificados alfabeticamente (A..Z)
--e depois alfabeticamente invertido (Z..A).

select distinct empregado.nome, empregado.funcao
from empregado
order by empregado.nome

select distinct empregado.nome, empregado.funcao
from empregado
order by empregado.nome desc

        -- Demais Operadores
        --
        --Operador                  significado
        --between  ...  and ...     entre dois valores ( inclusive )
        --in ( .... )               lista de valores
        --like                      com um padrao de caracteres
        --is null                   é um valor nulo


        -- Operadores Negativos
        --
        --operador               descrição
        --<>                     diferente
        --not nome_coluna =      diferente da coluna
        --not nome_coluna >      não maior que
        --not between            não entre dois valores informados
        --not in                 não existente numa dada lista de valores
        --not like               diferente do padrao de caracteres informado
        --is not null            não é um valor nulo

-- Selecione os Empregados cujos salários sejam
--menores que 1000 ou maiores que 3500.

select empregado.nome , empregado.salario
from empregado
where empregado.salario < 1000 or empregado.salario > 3500


-- Apresente todos os funcionários com salários
--entre 3400 e 4000 e que sejam balconistas.

select empregado.nome , empregado.salario
from empregado
where empregado.salario >= 3400 and empregado.salario <= 4000 and empregado.funcao = 'balconista'

    -- Operadores  'AND' (E) e  'OR' (OU).


-- Apresente todos os funcionários com salários
--entre 3400 e 4000 ou que sejam balconistas.

select empregado.nome , empregado.salario
from empregado
where empregado.salario >= 3400 and empregado.salario <= 4000 or empregado.funcao = 'balconista'

-- Apresente o nome de todos os empregados em letras minúsculas.

select lower(empregado.nome) 
from empregado

        --Funções de Caracteres
        --Lower - 		força caracteres maiúsculos aparecerem em minúsculos.
        --Upper - 		força caracteres minúsculos aparecerem em maiúsculos.
        --Concat(x,y)- 		concatena a string 'x' com a string 'y'.
        --Substring(x,y,str)- 	extrai um substring da string 'str', começando em 'x', e termina em 'y'.
        --To_Char(num)- 	converte um valor numérico para  uma string de caracteres.
        --To_Date(char,fmt)- 	converte uma string caracter em uma data.


-- Apresente o nome de todos os empregados (somente as 5 primeiras letras).

select substring(empregado.nome,1,5) 
from empregado

-- Apresente a Média, o Maior, o Menor e também a Somatória
--dos Salários pagos aos empregados.

select avg(empregado.salario) "Média salário",max(empregado.salario) "Maior salário",min(empregado.salario)"Menor salário", sum(empregado.salario) "Soma dos salários"   
from empregado

        -- Funções Agregadas (ou de Agrupamento)
        --
        --função        retorno
        --avg(n)        média do valor n, ignorando nulos
        --count(expr)   vezes que o número da expr avalia para algo nao nulo
        --max(expr)     maior valor da expr
        --min(expr)     menor valor da expr
        --sum(n)	       soma dos valores de n, ignorando nulos


-- Apresente a média de comissão pagos por departamento.

select avg(empregado.comissao)"Media comissão", empregado.departamento_idDepartamento "Departamento"
from empregado
group by empregado.departamento_idDepartamento


--  Retome o problema anterior, porém apresente resposta
--apenas para departamentos com mais de 2 empregados.

select avg(empregado.comissao)"Media comissão", empregado.departamento_idDepartamento "Departamento"
from empregado
group by empregado.departamento_idDepartamento
having count(empregado.departamento_idDepartamento) > 2


-- Listar Nomes de Empregados, Cargos e
--Nome do Departamento onde o empregado trabalha.

select empregado.nome, departamento.nome
from empregado, departamento
where empregado.departamento_idDepartamento = departamento.idDepartamento


--neste caso, o uso de ALIAS é desnecessário


-- Liste os Códigos de Cada Funcionário, seus Nomes, seus Cargos
--e o nome do Gerente ao qual este se relaciona.

-- neste caso, o uso de ALIAS é fundamental

select a.idEmpregado, a.nome, a.funcao, b.nome "Gerente"
from empregado a , empregado b
where a.idGerente = b.idEmpregado


-- execute e avalie os comandos
-- INSERT
INSERT INTO Departamento (idDepartamento, nome, localizacao, orcamento) VALUES ('70','PRODUCAO','RIO DE JANEIRO','1200');

-- UPDATE
UPDATE Empregado 
SET Empregado.salario = Empregado.salario* 1.2 
WHERE Empregado.salario< 1000;

-- DELETE
DELETE FROM Empregado
WHERE Empregado.salario > 5000;


-- Relacione todos os nomes de funcionários e seus respectivos
--cargos, desde que o orçamento do departamento seja igual a 10000.

select empregado.nome, empregado.funcao
from empregado
where 10000 in (select departamento.orcamento
				from departamento
				where empregado.departamento_idDepartamento = departamento.idDepartamento)

-- Relacione todos os departamentos que possuem
--empregados com remuneração maior que 3000.

select departamento.nome
from departamento
where exists (select *
		from empregado 
		where empregado.salario > 3000 and empregado.departamento_idDepartamento = departamento.idDepartamento )
