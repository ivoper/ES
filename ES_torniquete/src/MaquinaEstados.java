import com.google.common.collect.HashBasedTable;
import com.google.common.collect.Table;

import java.util.HashMap;
import java.util.Map;

/**
 * Created by k55 on 27-09-2019.
 */
public class MaquinaEstados {

    private Estado estado;
    private Table<Estado,Evento,Estado> tabelaDeTransicaoDeEstados = HashBasedTable.create();
    private Table<Estado,Evento,Accao> tabelaDeAccao = HashBasedTable.create();


    public MaquinaEstados(){

        estado = Estado.BLOQUEADO;

        tabelaDeTransicaoDeEstados.put(Estado.BLOQUEADO,Evento.VALIDO,Estado.DESBLOQUEADO);
        tabelaDeTransicaoDeEstados.put(Estado.BLOQUEADO,Evento.PASSAGEM,Estado.ALARME);
        tabelaDeTransicaoDeEstados.put(Estado.DESBLOQUEADO,Evento.PASSAGEM,Estado.BLOQUEADO);
        tabelaDeTransicaoDeEstados.put(Estado.ALARME,Evento.REINICIAR,Estado.BLOQUEADO);

        tabelaDeAccao.put(Estado.BLOQUEADO,Evento.VALIDO,Accao.DESBLOQUEAR);
        tabelaDeAccao.put(Estado.BLOQUEADO,Evento.PASSAGEM,Accao.ATIVAR);
        tabelaDeAccao.put(Estado.DESBLOQUEADO,Evento.PASSAGEM,Accao.BLOQUEAR);
        tabelaDeAccao.put(Estado.ALARME,Evento.REINICIAR,Accao.DESATIVAR);
    }

    public Accao processar(Evento evento){

        if(evento == Evento.TERMINAR){
            return Accao.TERMINAR;
        }
        Estado novoEstado = tabelaDeTransicaoDeEstados.get(estado,evento);
        if(novoEstado == null){
            return null;
        }
        Accao accao = tabelaDeAccao.get(estado,evento);
        estado = novoEstado;
        return accao;

    }

}
