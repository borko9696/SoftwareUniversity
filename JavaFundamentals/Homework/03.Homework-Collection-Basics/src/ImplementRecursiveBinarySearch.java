import java.util.Arrays;
import java.util.Scanner;

/**
 * Created by Borislav on 27/10/2015.
 */
public class ImplementRecursiveBinarySearch {
    public static void main(String[] args) {
        Scanner Console = new Scanner(System.in);
        int inputNum = Integer.parseInt(Console.nextLine());
        int[] numbers = Arrays.asList(Console.nextLine().split(" ")).stream().mapToInt(Integer::parseInt).toArray();

        boolean test = false;
        for (int i = 0; i < numbers.length; i++) {
            if (inputNum==numbers[i]){
                System.out.println(i);
                test=true;
                break;
            }
        }
        if (test==false) {
            System.out.println(-1);
        }
    }
}
