package algoritmedescarres;

import static java.lang.Math.*;
import java.util.*;

public class AlgoritmeDesCarres {

    public static void main(String[] args) {
        for (int i = 100; i < 400; i++) {
            for (int j = i; j < 400; j++) {
                double x = sqrt(i * j + 1);
                if (x == Math.floor(x)) {
                    for (int k = j; k < 500; k++) {
                        double y=sqrt(i*k+1);
                        double z=sqrt(j*k+1);
                        if(y == Math.floor(y) && z == Math.floor(z)){
                            System.out.println("Les 3 entiers sont:"+i+" "+j+" "+k);
                        }
                    }
                }
            }
        }
    }
}
