package _2_LV1Shop.Exceptions;

/**
 * Created by Simooo on 31.10.2015 ã..
 */
public class NoQuantityException extends Exception {
    public NoQuantityException(){
        super("There is no quantity of this stock");
    }
}
