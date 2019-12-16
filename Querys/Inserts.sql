insert into Promotor values ('Duarte Fabricio','Lisboa',987654321,123456789)
insert into Responsavel values ('Ivo Pedreira','ivopachorra@hotmail.com',123456789)
insert into Utilizador values ('tecnico','Bernardo Crosta', 'pass123')
insert into Utilizador values ('comissao de financiamento','Joe Mama', 'pass123')
insert into Projeto values (1,'incentivo',1000,'descricao interessante','aberto',GETDATE(),1,123456789,123456789) 
insert into Projeto values (2,'incentivo',1000,'descricao interessante','espera_despacho',GETDATE(),1,123456789,123456789) 
insert into Projeto values (3,'incentivo',1000,'descricao muito interessante','espera_despacho',GETDATE(),1,123456789,123456789) 

select * from Projeto
select * from Historico
select * from Despacho

delete from Despacho