/**
 * Created by k55 on 27-09-2019.
 */
public class Torniquete {

    private Detector detector = new Detector();
    private Trinco trinco = new Trinco();
    private Sirene sirene = new Sirene();
    private MaquinaEstados maqEst = new MaquinaEstados();
    private boolean terminarProc = false;

    private void processar(Evento evento){
        Accao accao = maqEst.processar(evento);
        if(accao == null){
            return;
        }
        switch (accao){
            case BLOQUEAR:
                trinco.bloquear();
                break;
            case DESBLOQUEAR:
                trinco.desbloquear();
                break;
            case ATIVAR:
                sirene.ativar();
                break;
            case DESATIVAR:
                sirene.desativar();
                break;
            case TERMINAR:
                terminarProc = true;
                break;
        }
    }

    public void executar(){
        while (!terminarProc){
            processar(detector.detectar());
        }
    }
}