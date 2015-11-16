package _2_LV1Shop.Exceptions;

/**
 * Created by Simooo on 30.10.2015 ã..
 */
public class ProductExpiredException extends Exception {

    public ProductExpiredException(){
        super("The product has expired");
    }
}
