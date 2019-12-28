insert into Promotor values (987654321, 123456789, 'Duarte Fabricio','Lisboa');

insert into Responsavel values ('Ivo Pedreira', 'ivopachorra@hotmail.com', 123456789);

insert into Utilizador values ('tecnico', 'pass123');
insert into Utilizador values ('gestor', 'pass123');
insert into Utilizador values ('comissao', 'pass123');

insert into Tecnico values (1);
insert into GestorDeFinanciamento values (2);
insert into ComissaoDeFinanciamento values (3);

insert into Projeto values (100012019,'descricao interessante', GETDATE(), 1000, 1, 1, 1, 1); 
insert into Projeto values (100022019,'descricao interessante', GETDATE(), 1000, 2, 1, 1, 1); 
insert into Projeto values (100032019,'descricao interessante', GETDATE(), 1000, 3, 1, 1, 1); 
insert into Projeto values (100042019,'descricao interessante', GETDATE(), 1000, 4, 1, 1, 1); 
insert into Projeto values (100052019,'descricao interessante', GETDATE(), 1000, 5, 1, 1, 1); 
insert into Projeto values (100062019,'descricao interessante', GETDATE(), 1000, 6, 1, 1, 1); 
insert into Projeto values (100072019,'descricao interessante', GETDATE(), 1000, 7, 1, 1, 1); 
insert into Projeto values (100082019,'descricao interessante', GETDATE(), 1000, 8, 1, 1, 1); 
insert into Projeto values (100092019,'descricao interessante', GETDATE(), 1000, 9, 1, 1, 1); 

insert into Incentivo values (100012019); 
insert into Incentivo values (100022019);
insert into Incentivo values (100032019);
insert into Incentivo values (100042019);
insert into Bonificacao values (100052019); 
insert into Incentivo values (100062019);
insert into Incentivo values (100072019);
insert into Bonificacao values (100082019); 
insert into Incentivo values (100092019);

insert into Historico values(100042019, 4);
insert into Historico values(100082019, 8);

insert into Despacho values('aprovado', GETDATE(), 100042019);
insert into Despacho values('rejeitado', GETDATE(), 100082019);

insert into DespachoIncentivo values(1, 100, 100, '2020-10-10');
insert into DespachoBonificacao values(1, 10.0, 100, '2019-10-10');

select * from Historico
select * from Despacho
select * from ParecerTecnico
select * from Responsavel
select * from Promotor
select * from Pagamento
select * from Projeto
select * from EstadosTecnico
