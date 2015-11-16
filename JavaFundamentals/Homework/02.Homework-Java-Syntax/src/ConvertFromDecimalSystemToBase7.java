import java.lang.reflect.Array;
import java.util.Scanner;

/**
 * Created by Borislav on 16/10/2015.
 */
public class ConvertFromDecimalSystemToBase7 {
    public static void main(String[] args) {
        Scanner Console=new Scanner(System.in);
        int num=Integer.parseInt(Console.nextLine());
        StringBuilder sb=new StringBuilder();

        while (num>0){
            int reminder=num%7;
            sb.insert(0,reminder);
            int nextNum=num/7;
            num=nextNum;
        }

        System.out.println(sb);
    }
}
