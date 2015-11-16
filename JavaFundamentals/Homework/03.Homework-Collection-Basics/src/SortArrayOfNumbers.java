import java.lang.reflect.Array;
import java.util.Arrays;
import java.util.Scanner;

/**
 * Created by Borislav on 22/10/2015.
 */
public class SortArrayOfNumbers {
    public static void main(String[] args) {
        Scanner Console= new Scanner(System.in);
        int n = Integer.parseInt(Console.nextLine());
        int[] array = new int[n];
        String[] line=Console.nextLine().split(" ");

        for (int i = 0; i < n; i++) {
            array[i]=Integer.parseInt(line[i]);
        }

        Arrays.sort(array);

        for (int i = 0; i <array.length ; i++) {
            System.out.print(array[i]+" ");
        }


    }
}
