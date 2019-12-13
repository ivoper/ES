import java.util.Scanner;

/**
 * Created by k55 on 27-09-2019.
 */
public class Detector {

    public Evento detectar(){
        Scanner scan = new Scanner(System.in);
        String s = scan.next();
        if(s.equals("c")){
            return Evento.VALIDO;
        }
        if(s.equals("p")){
            return Evento.PASSAGEM;
        }
        if(s.equals("r")){
            return Evento.REINICIAR;
        }
        if(s.equals("t")){
            return Evento.TERMINAR;
        }
        if(s.equals("d")){
            return Evento.DIAGNOSTICO;
        }
        if(s.equals("n")){
            return Evento.NORMAL;
        }
        if(s.equals("l")){  //lock trinco
            return Evento.TRANCAR;
        }
        if(s.equals("u")){ //unlock trinco
            return Evento.DESTRANCAR;
        }
        return null;
    }

}
