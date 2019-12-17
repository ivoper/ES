insert into Promotor values ('Duarte Fabricio','Lisboa',987654321,123456789)
insert into Responsavel values ('Ivo Pedreira','ivopachorra@hotmail.com',123456789)
insert into Utilizador values ('tecnico','tecnico', 'pass123')
insert into Utilizador values ('gestor de financiamento','gestor', 'pass123')
insert into Utilizador values ('comissao de financiamento','comissao', 'pass123')
insert into Projeto values (100002019,'incentivo',1000,'descricao interessante','aberto',GETDATE(),1,1,123456789) 
insert into Projeto values (100012019,'incentivo',1000,'descricao interessante','analise_tecnica',GETDATE(),1,1,123456789) 
insert into Projeto values (100022019,'incentivo',1000,'descricao muito interessante','espera_despacho',GETDATE(),1,1,123456789) 
insert into Projeto values (100032019,'incentivo',1000,'descricao muito interessante','pagamento',GETDATE(),1,1,123456789)
insert into Projeto values (100042019,'bonificacao',1000,'descricao interessante','suspenso',GETDATE(),1,1,123456789)
insert into Projeto values (100052019,'incentivo',1000,'descricao muito interessante','arquivado',GETDATE(),1,1,123456789)
insert into Projeto values (100062019,'incentivo',1000,'descricao muito interessante','rejeitado',GETDATE(),1,1,123456789)
insert into Projeto values (100072019,'bonificacao',1000,'descricao interessante','fechado',GETDATE(),1,1,123456789)
insert into Projeto values (100082019,'incentivo',1000,'descricao muito interessante','espera_reforco',GETDATE(),1,1,123456789)
insert into Historico values(100042019, 'pagamento')
insert into Historico values(100082019, 'fechado')
insert into Despacho values('aprovado', 100, 100, GETDATE(), GETDATE(), 4)
insert into Despacho values('aprovado', 50, 20, '2019-10-10', GETDATE(), 4)

select * from Historico
select * from Despacho
select * from ParecerTecnico
select * from Responsavel
select * from Promotor
select * from Pagamento
select * from Projeto

/*
delete from Projeto
delete from Responsavel
delete from Promotor
*/